﻿using LogisticApp.ControllerModelsDelivers;
using LogisticApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogisticApp.ModelsDelivers;
using System.Data.Entity;

namespace LogisticApp.APIController
{
    [ApiController]
    [Route("api/(DeliversController)")]
    public class DeliversController : Controller
    {

        private readonly LogisticDbContextV2 _context;

        public DeliversController(LogisticDbContextV2 context)
        {
            _context = context;
        }

        // GET: Delivers
        [HttpGet]
        public async Task<ActionResult> GetDelivers()
        {
            return Ok(await _context.Delivers.ToListAsync());

        }
        // POST: Delivers
        [HttpPost]
        public async Task<ActionResult> AddDelivers(AddDelivers addDelivers)
        {
            var deliver = new Delivers()
            {
                Id = addDelivers.Id,
                Name = addDelivers.Name,
                TransportationId = addDelivers.Transportations.Id,

            };

            await _context.Delivers.AddAsync(deliver);
            await _context.SaveChangesAsync();
            return Ok(deliver);



        }

        [HttpPut]
        [Route("(id)")]
        public async Task<ActionResult> UpdateDelivers([FromRoute] string id, UpdateDelivers updateDelivers)
        {
            var deliver = await _context.Delivers.FindAsync(id);

            if (deliver != null)
            {
                deliver.Name = updateDelivers.Name;
                deliver.Id = updateDelivers.Id;
                deliver.TransportationId = updateDelivers.Transportations.Id;
                await _context.SaveChangesAsync();
                return Ok(deliver);
            }

            return NotFound();
        }


        
    }
}
