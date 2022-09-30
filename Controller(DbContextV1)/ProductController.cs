
using LogisticApp.ControllerModelsCustomer;
using LogisticApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogisticApp.ModelsCustomer;
using System.Data.Entity;


namespace LogisticApp.Controller_DbContextV1_
{
    [ApiController]
    [Route("api/(ProductController)")]
    public class ProductController : Controller
    {
      
        

            private readonly LogisticDbContextV1 _context;

            public ProductController(LogisticDbContextV1 context)
            
            {
                _context = context;
            }

        // GET: Product
        [HttpGet]
            public async Task<ActionResult> GetProduct()
            {
                return Ok(await _context.Products.ToListAsync());

            }
        // POST: Product
        [HttpPost]
            public async Task<ActionResult> AddProduct(AddProduct addProduct)
            {
                var product = new Product()
                {
                    Id = addProduct.Id,
                   Name = addProduct.Name,
                   Product_Info = addProduct.Product_Info,
                    Orders = addProduct.Orders.Select(addOrder => new Order()

                    {
                        Name = addOrder.Name,//la comanda tre de schimbat
                       CustomerId= addOrder.Customers.Id,

                    }).ToList(),
                };

                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
                return Ok(product);



            }



        }
    }

