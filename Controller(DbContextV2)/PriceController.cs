using LogisticApp.ControllerModelsDelivers;
using LogisticApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogisticApp.ModelsDelivers;
using System.Data.Entity;

namespace LogisticApp.APIController
{
    [ApiController]
    [Route("api/(PriceController)")]
    public class PriceController : Controller
    {

        private readonly LogisticDbContextV2 _context;

        public PriceController(LogisticDbContextV2 context)
        {
            _context = context;
        }

        // GET: Price
        [HttpGet]
        public async Task<ActionResult> GetPrice()
        {
            return Ok(await _context.Prices.ToListAsync());

        }
        // POST: Price
        [HttpPost]
        public async Task<ActionResult> AddPrice(AddPrice addPrice)
        {
            var price = new Price()
            {
                Id = addPrice.Id,
                Suma = addPrice.Suma,

            };

            await _context.Prices.AddAsync(price);
            await _context.SaveChangesAsync();
            return Ok(price);



        }

        [HttpPut]
        [Route("(id)")]
        public async Task<ActionResult> UpdatePrice([FromRoute] string id, UpdatePrice updatePrice)
        {
            var price = await _context.Prices.FindAsync(id);

            if (price != null)
            {
                price.Id = updatePrice.Id;
                price.Suma = updatePrice.Suma;
                await _context.SaveChangesAsync();
                return Ok(price);
            }

            return NotFound();
        }
    }
}
