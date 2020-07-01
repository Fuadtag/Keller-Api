using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KellerApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KellerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class Company : ControllerBase
    {
        private readonly KellerDbContext _context;
        public Company(KellerDbContext context)
        {
            _context = context;
        }
        [Route("list")]
        [HttpGet]
        public IActionResult List()
        {
            var model = _context.Companies.Include(c => c.Jobs).ToList();
            if (model.Count != 0)
            {
                return Ok(model);
            };
            return NotFound();
        }
        [Route("detail/{id}")]
        [HttpGet]
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var model = _context.Companies.Include(c=> c.Jobs).FirstOrDefault(c => c.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }
    }
}
