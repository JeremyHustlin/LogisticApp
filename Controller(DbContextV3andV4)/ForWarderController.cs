using Microsoft.AspNetCore.Mvc;
using LogisticApp.ControllerModelsForWarder;
using LogisticApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogisticApp.ModelsForWarder;
using LogisticApp.ControllerModelsCustomer;
using LogisticApp.ModelsCustomer;
using System.Data.Entity;

namespace LogisticApp.APIController
{
    [ApiController]
    [Route("api/(ForWarderController)")]
    public class ForWarderController : Controller
    {

        private readonly LogisticDbContextV4 _context;

        public ForWarderController(LogisticDbContextV4 context)
        {
            _context = context;
        }

        // GET: ForWarder
        [HttpGet]
        public async Task<ActionResult> GetForWarder()
        {
            return Ok(await _context.ForWarders.ToListAsync());

        }
        // POST: ForWarder
        [HttpPost]
        public async Task<ActionResult> AddForWarder(AddForWarder addForWarder)
        {
            var forwarder = new ForWarder()
            {
                Id = addForWarder.Id,
                Company_Name = addForWarder.Company_Name,
                Call_Centre_Phone = addForWarder.Call_Centre_Phone,
                SchedulesId= addForWarder.Schedules.Id,
                Vehicles = addForWarder.Vehicles.Select(addOrder => new Vehicle()

                {
                    Id = addOrder.Id,
                    Name = addOrder.Name,
                    Type = addOrder.Type,
                }).ToList(),
                Drivers = addForWarder.Drivers.Select(addDriver => new Driver()
                {
                    Id = addDriver.Id,
                    UserName = addDriver.UserName,
                    PhoneNumber = addDriver.PhoneNumber,
                }).ToList(),
            };
            await _context.ForWarders.AddAsync(forwarder);
            await _context.SaveChangesAsync();
            return Ok(forwarder);

        }
    }
}














