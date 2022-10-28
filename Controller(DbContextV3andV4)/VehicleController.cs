using LogisticApp.ControllerModelsForWarder;
using LogisticApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogisticApp.ModelsForWarder;
using System.Data.Entity;

namespace LogisticApp.APIController
{
    [ApiController]
    [Route("api/(VehicleController)")]
    public class VehicleController : Controller
    {

        private readonly LogisticDbContextV4 _context;

        public VehicleController(LogisticDbContextV4 context)
        {
            _context = context;
        }

        // GET: Vehicle
        [HttpGet]
        public async Task<ActionResult> GetVehicle()
        {
            return Ok(await _context.Vehicles.ToListAsync());

        }
        // POST: Vehicle
        [HttpPost]
        public async Task<ActionResult> AddVehicle(AddVehicle addVehicle)
        {
            var vehicle = new Vehicle()
            {
                Id = addVehicle.Id,
                Name = addVehicle.Name,
                Type = addVehicle.Type,
            };
            

            await _context.Vehicles.AddAsync(vehicle);
            await _context.SaveChangesAsync();
            return Ok(vehicle);



        }

        [HttpPut]
        [Route("(id)")]
        public async Task<ActionResult> UpdateVehicle([FromRoute] string id, UpdateVehicle updateVehicle)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle != null)
            {
                vehicle.Id = updateVehicle.Id;
                vehicle.Name = updateVehicle.Name;
                vehicle.Type = updateVehicle.Type;

                await _context.SaveChangesAsync();
                return Ok(vehicle);

            }
            return NotFound();
        }
    }
}