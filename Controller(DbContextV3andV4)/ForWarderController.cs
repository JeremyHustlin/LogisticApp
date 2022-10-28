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


        [HttpPut]
        [Route("(id)")]
        public async Task<ActionResult> UpdateForWarder([FromRoute] string id, UpdateForWarder updateForWarder)
        {
            var forwarder = await _context.ForWarders.FindAsync(id);
            if (forwarder != null)
            {
                forwarder.Id = updateForWarder.Id;
                forwarder.Call_Centre_Phone = updateForWarder.Call_Centre_Phone;
                forwarder.Company_Name = updateForWarder.Company_Name;
                forwarder.SchedulesId = updateForWarder.Schedules.Id;
                forwarder.Vehicles = updateForWarder.Vehicles.Select(updateOrder => new Vehicle()

                {
                    Id = updateOrder.Id,
                    Name = updateOrder.Name,
                    Type = updateOrder.Type,
                }).ToList();
                forwarder.Drivers = updateForWarder.Drivers.Select(updateDriver => new Driver()
                {
                    Id = updateDriver.Id,
                    UserName = updateDriver.UserName,
                    PhoneNumber = updateDriver.PhoneNumber,
                }).ToList();

                await _context.SaveChangesAsync();
                return Ok(forwarder);

            }
            return NotFound();
        }
    }
}














