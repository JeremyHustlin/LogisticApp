using LogisticApp.ControllerModelsDelivers;
using LogisticApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogisticApp.ModelsDelivers;
using System.Data.Entity;

namespace LogisticApp.APIController
{
    [ApiController]
    [Route("api/(TransportationController)")]
    public class TransportationController : Controller
    {

        private readonly LogisticDbContextV2 _context;

        public TransportationController(LogisticDbContextV2 context)
        {
            _context = context;
        }

        // GET: Transportation
        [HttpGet]
        public async Task<ActionResult> GetTransportation()
        {
            return Ok(await _context.Transportations.ToListAsync());

        }
        // POST: Transportation
        [HttpPost]
        public async Task<ActionResult> AddTransportation(AddTransportation addTransportation)
        {
            var transportation = new Transportation()
            {
                Id = addTransportation.Id,
                Distance = addTransportation.Distance,
                PriceId = addTransportation.Prices.Id,


            };

            await _context.Transportations.AddAsync(transportation);
            await _context.SaveChangesAsync();
            return Ok(transportation);



        }
        [HttpPut]
        [Route("(id)")]
        public async Task<ActionResult> UpdateTransportation([FromRoute] string id, UpdateTransportation updateTransportation)
        {
            var transportation = await _context.Transportations.FindAsync(id);

            if (transportation != null)
            {
                transportation.Id = updateTransportation.Id;
                transportation.Distance = updateTransportation.Distance;
                transportation.PriceId = updateTransportation.Prices.Id;
                await _context.SaveChangesAsync();
                return Ok(transportation);
            }

            return NotFound();
        }
    }
}
