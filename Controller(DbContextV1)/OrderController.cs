
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
        // PUT: Customer
        [HttpPut]
        [Route("(id)")]
        public async Task<ActionResult> UpdateOrder([FromRoute] string id, UpdateOrder updateOrder)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {
                order.Id = updateOrder.Id;
                order.DayOfWeek = updateOrder.DayOfWeek;
                order.DateTime = updateOrder.DateTime;
                order.Name = updateOrder.Name;
                order.CustomerId = updateOrder.Customers.Id;
                order.OrderLocationId = updateOrder.OrderLocations.Id;
                order.Products = updateOrder.Products.Select(updateProduct => new Product()
                {
                    Product_Info = updateProduct.Product_Info,
                    Name = updateProduct.Name,
                }).ToList();
                await _context.SaveChangesAsync();

                return Ok(order);
            }
            return NotFound();


        }



    }
    }

