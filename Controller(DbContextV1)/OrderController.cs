
using LogisticApp.ControllerModelsCustomer;
using LogisticApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogisticApp.ModelsCustomer;
using System.Data.Entity;


namespace LogisticApp.Controller_DbContextV1_
{
    [ApiController]
    [Route("api/(OrderController)")]
    public class OrderController : Controller
    {
      
        

            private readonly LogisticDbContextV1 _context;

            public OrderController(LogisticDbContextV1 context)
            
            {
                _context = context;
            }

        // GET: Orders
        [HttpGet]
            public async Task<ActionResult> GetOrder()
            {
                return Ok(await _context.Orders.ToListAsync());

            }
        // POST: Orders
        [HttpPost]
            public async Task<ActionResult> AddOrder(AddOrder addOrder)
            {
                var order = new Order()
                {
                    Id = addOrder.Id,
                   Name = addOrder.Name,
                    DateTime = addOrder.DateTime,
                    DayOfWeek = addOrder.DayOfWeek,
                    CustomerId=addOrder.Customers.Id,
                    OrderLocationId=addOrder.OrderLocations.Id,
                    Products = addOrder.Products.Select(addProducts => new Product()

                    {
                        Name = addProducts.Name,
                        Product_Info=addProducts.Product_Info,

                    }).ToList(),
                };

                await _context.Orders.AddAsync(order);
                await _context.SaveChangesAsync();
                return Ok(order);



            }



        }
    }

