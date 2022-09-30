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
    [Route("api/(ScheduleController)")]
    public class ScheduleController : Controller
    {

        private readonly LogisticDbContextV4 _context;

        public ScheduleController(LogisticDbContextV4 context)
        {
            _context = context;
        }

        // GET: Schedule
        [HttpGet]
        public async Task<ActionResult> GetSchedule()
        {
            return Ok(await _context.Schedules.ToListAsync());

        }
        // POST: Schedule
        [HttpPost]
        public async Task<ActionResult> AddSchedule(AddSchedule addSchedule)
        {
            var schedule = new Schedule()
            {
                Id = addSchedule.Id,
                DriverId = addSchedule.Driver.Id,
                OrderLocationId = addSchedule.OrderLocation.Id,
            };









            await _context.Schedules.AddAsync(schedule);
            await _context.SaveChangesAsync();
            return Ok(schedule);

        }
    }
}