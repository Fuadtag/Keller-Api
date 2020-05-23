using System.Collections.Generic;
using System.Threading.Tasks;
using KellerApi.Data;
using KellerApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KellerApi.Controllers
{
    [Route("api/pages")]
    [ApiController]
    public class PagesController : ControllerBase
    {
        private readonly KellerDbContext context;
        public PagesController(KellerDbContext _context)
        {
            context = _context;
        }
        [HttpGet]
        [Route("faqs")]
        public async Task<IActionResult> FaqAsync()
        {
            List<Question> questions = await context.Questions.ToListAsync();
            return Ok(questions);
        }
    }
}