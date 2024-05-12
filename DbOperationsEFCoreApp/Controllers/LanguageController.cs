using DbOperationsEFCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsEFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public LanguageController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLanguages() 
        {
            //var result = await this.appDbContext.Languages.ToListAsync();
            var result = await (from Languages in appDbContext.Languages
                          select Languages).ToListAsync();
            return Ok(result);
        }
    }
}
