using DbOperationsEFCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsEFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public CurrencyController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCurrencies() 
        {
            //var result = await this.appDbContext.Currencies.ToListAsync();
            var result = await (from currencies in appDbContext.Currencies
                         select currencies).ToListAsync();
            return Ok(result);
        }
    }
}
