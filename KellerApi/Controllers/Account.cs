using KellerApi.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace KellerApi.Controllers
{
    [Route("api/account")]
    [ApiController]
    [Produces("application/json")]
    public class Account : ControllerBase
    {
        private readonly KellerDbContext _context;
        public Account(KellerDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("register")]
        [AllowAnonymous]
        public IActionResult Register([FromBody][Bind("Username, Email, Password")] Data.Entities.Account account)
        {
            
            if (ModelState.IsValid)
            {
                PasswordHasher<Data.Entities.Account> hasher = new PasswordHasher<Data.Entities.Account>(
                    new OptionsWrapper<PasswordHasherOptions>(
                        new PasswordHasherOptions()
                        {
                            CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV3
                        }
                        ));
                account.Password = hasher.HashPassword(account, account.Password);
                account.Token = Guid.NewGuid().ToString();
                _context.Accounts.Add(account);
                _context.SaveChanges();
                return Ok(account);
            }
            return BadRequest();


        }
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody][Bind(include:"Email, Password")] Data.Entities.Account account)
        {
            PasswordHasher<Data.Entities.Account> hasher = new PasswordHasher<Data.Entities.Account>(
                    new OptionsWrapper<PasswordHasherOptions>(
                        new PasswordHasherOptions()
                        {
                            CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV3
                        }
                        ));
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var user = _context.Accounts.FirstOrDefault(a => a.Email == account.Email);
            if (user == null)
            {
                return NotFound();
            };
            var result = hasher.VerifyHashedPassword(user, user.Password, account.Password);
            if (result == PasswordVerificationResult.Success)
            {
                return Ok(user);
            }

            return Ok(account);
        }
    }
}
