
using LogisticApp.ControllerModelsCustomer;
using LogisticApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogisticApp.ModelsCustomer;
using System.Data.Entity;


namespace LogisticApp.Controller_DbContextV1_
{
    [ApiController]
    [Route("api/(OrderLocationController)")]
    public class OrderLocationController : Controller
    {
      
        

            private readonly LogisticDbContextV1 _context;

            public OrderLocationController(LogisticDbContextV1 context)
            
            {
                _context = context;
            }

        // GET: Orders
        [HttpGet]
            public async Task<ActionResult> GetOrderLocation()
            {
                return Ok(await _context.OrderLocations.ToListAsync());

            }
        // POST: Orders
        [HttpPost]
            public async Task<ActionResult> AddOrderLocation(AddOrderLocation addOrderLocation)
            {
                var orderlocation = new OrderLocation()
                {
                    Id = addOrderLocation.Id,
                   Name = addOrderLocation.Name,
                    Adress = addOrderLocation.Adress,
                    Orders = addOrderLocation.Orders.Select(addOrder => new Order()

                    {
                        Name = addOrder.Name,//la comanda ,tre de schimbat
                                           

                    }).ToList(),
                };

                await _context.OrderLocations.AddAsync(orderlocation);
                await _context.SaveChangesAsync();
                return Ok(orderlocation);



            }

        // PUT: Customer
        [HttpPut]
        [Route("(id)")]
        public async Task<ActionResult> UpdateOrderLocation([FromRoute] string id, UpdateOrderLocation updateOrderLocation)
        {
            var orderlocation = await _context.OrderLocations.FindAsync(id);
            if (orderlocation != null)
            {
                orderlocation.Id = updateOrderLocation.Id;
                orderlocation.Name = updateOrderLocation.Name;
                orderlocation.Adress = updateOrderLocation.Adress;
                orderlocation.Orders = updateOrderLocation.Orders.Select(updateOrder => new Order()
                
                {
                    Name=updateOrder.Name,
              
                }).ToList();
                await _context.SaveChangesAsync();

                return Ok(orderlocation);
            }
            return NotFound();


        }



    }
    }

