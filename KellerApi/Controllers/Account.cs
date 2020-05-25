using KellerApi.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

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
        public IActionResult Register([FromBody] KellerApi.Data.Entities.Account account)
        {
            if (ModelState.IsValid)
            {
                account.Token = Guid.NewGuid().ToString();
            }
            return Ok(account);


        }
    }
}
