using LogisticApp.ControllerModelsForWarder;
using LogisticApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogisticApp.ModelsForWarder;
using System.Data.Entity;

namespace LogisticApp.APIController
{
    [ApiController]
    [Route("api/(VehicleLocationController)")]
    public class VehicleLocationController : Controller
    {

        private readonly LogisticDbContextV4 _context;

        public VehicleLocationController(LogisticDbContextV4 context)
        {
            _context = context;
        }

        // GET: VehicleLocation
        [HttpGet]
        public async Task<ActionResult> GetVehicleLocation()
        {
            return Ok(await _context.VehicleLocations.ToListAsync());

        }
        // POST: VehicleLocation
        [HttpPost]
        public async Task<ActionResult> AddVehicleLocation(AddVehicleLocation addVehicleLocation)
        {
            var vehiclelocation = new VehicleLocation()
            {
                Id = addVehicleLocation.Id,
                Location_Name = addVehicleLocation.Location_Name,
                Hour = addVehicleLocation.Hour,
            };


            await _context.VehicleLocations.AddAsync(vehiclelocation);
            await _context.SaveChangesAsync();
            return Ok(vehiclelocation);



        }
    }
}