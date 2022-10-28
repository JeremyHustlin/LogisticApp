using LogisticApp.ControllerModelsForWarder;
using LogisticApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogisticApp.ModelsForWarder;
using System.Data.Entity;

namespace LogisticApp.APIController
{
    [ApiController]
    [Route("api/(DriverController)")]
    public class DriverController : Controller
    {

        private readonly LogisticDbContextV3 _context;

        public DriverController(LogisticDbContextV3 context)
        {
            _context = context;
        }

        // GET: Driver
        [HttpGet]
        public async Task<ActionResult> GetDriver()
        {
            return Ok(await _context.Drivers.ToListAsync());

        }
        // POST: Driver
        [HttpPost]
        public async Task<ActionResult> AddDriver(AddDriver addDriver)
        {
            var driver = new Driver()
            {
                Id = addDriver.Id,
                PhoneNumber=addDriver.PhoneNumber,
                Free_or_Busy = addDriver.Free_or_Busy,
                DayOfWeek = addDriver.DayOfWeek,
                Hour= addDriver.Hour,
                VehicleLocations = addDriver.VehicleLocations.Select(addVehicleLocations => new VehicleLocation()

                {
                    Id = addVehicleLocations.Id,
                    Location_Name = addVehicleLocations.Location_Name,
                    Hour= addVehicleLocations.Hour,
                }).ToList(),
                Vehicles = addDriver.Vehicles.Select(addVehicle => new Vehicle()

                {
                    Id = addVehicle.Id,
                    Name = addVehicle.Name,
                    Type = addVehicle.Type,
                }).ToList(),
            };

            await _context.Drivers.AddAsync(driver);
            await _context.SaveChangesAsync();
            return Ok(driver);



        }
        [HttpPut]
        [Route("(id)")]
        public async Task<ActionResult> UpdateDriver([FromRoute] string id, UpdateDriver updateDriver)
        {
            var driver= await _context.Drivers.FindAsync(id);

            if (driver != null)
            {
                driver.Id = updateDriver.Id;
                driver.PhoneNumber = updateDriver.PhoneNumber;
                driver.Free_or_Busy = updateDriver.Free_or_Busy;
                driver.DayOfWeek = updateDriver.DayOfWeek;
                driver.Hour = updateDriver.Hour;
                driver.VehicleLocations = updateDriver.VehicleLocations.Select(updateVehicleLocation => new VehicleLocation()

                {
                    Id = updateVehicleLocation.Id,
                    Location_Name = updateVehicleLocation.Location_Name,
                    Hour = updateVehicleLocation.Hour,
                }).ToList();
                driver.Vehicles = updateDriver.Vehicles.Select(updateVehicle => new Vehicle()

                {
                    Id = updateVehicle.Id,
                    Name = updateVehicle.Name,
                    Type = updateVehicle.Type,
                }).ToList();

                await _context.SaveChangesAsync();
                return Ok(driver);
            }
            return NotFound();
             

        }
    }
}
