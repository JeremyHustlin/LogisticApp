using LogisticApp.ControllerModelsCustomer;
using LogisticApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogisticApp.ModelsCustomer;
using System.Data.Entity;
using LinqKit.Core; 

namespace LogisticApp.APIController
{
    [ApiController]
    [Route("api/(CustomerController)")]
    public class CustomerController : Controller
    {

        private readonly LogisticDbContextV1 _context;

        public CustomerController(LogisticDbContextV1 context)
        {
            _context = context;
        }

        // GET: Customers
        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            return Ok(await _context.Customers.ToListAsync());

        }
        //GET:Customer
        [HttpGet]
        [Route("(id)")]
        public async Task<IActionResult> GetCustomer([FromRoute] string id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }
        // POST: Customers
        [HttpPost]
        public async Task<IActionResult> AddCustomer(AddCustomer addCustomer)
        {
            var customer = new Customer()
            {
                Id = addCustomer.Id,
                Company_Name = addCustomer.Company_Name,
                CallCentrePhone = addCustomer.CallCentrePhone,
                Orders = addCustomer.Orders.Select(addOrder => new Order()

                {
                    Id = addOrder.Id,
                    Name = addOrder.Name,
                }).ToList(),
            };

            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return Ok(customer);



        }
        // PUT: Customer
        [HttpPut]
        [Route("(id)")]
        public async Task<IActionResult> UpdateCustomer([FromRoute] string id, UpdateCustomer updateCustomer)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                customer.Id = updateCustomer.Id;
                customer.Company_Name = updateCustomer.Company_Name;
                customer.CallCentrePhone = updateCustomer.CallCentrePhone;
                customer.Orders = updateCustomer.Orders.Select(updateOrder => new Order()
                {
                    Id = updateOrder.Id,
                    Name = updateOrder.Name,
                }).ToList();
                await _context.SaveChangesAsync();

                return Ok(customer);
            }
            return NotFound();


        }
        [HttpDelete]
        [Route("(id)")]
        public async Task<IActionResult> DeleteCustomer([FromRoute] string id)
        
        {
            var customer= await _context.Customers.FindAsync(id);

            if(customer != null)
            {
                _context.Remove(customer);
                await _context.SaveChangesAsync();
                return Ok(customer);


            }

            return NotFound();

        }
       
    }
}



    
    /* public IActionResult GetCustomer()
     {
         return Ok(_context.Customers.ToList());
     }
}*/


/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LogisticApp.Data;
using LogisticApp.ModelsCustomer;

namespace LogisticApp.ControllerCustomer
{
    [ApiController]


    public class CustomersController : Controller
    {
        private readonly LogisticDbContextV1 _context;

        public CustomersController(LogisticDbContextV1 context)
        {
            _context = context;
        }

        // GET: Customers
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return _context.Customers != null ?
                        View(await _context.Customers.ToListAsync()) :
                        Problem("Entity set 'LogisticDbContextV1.Customers'  is null.");
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Company_Name,CallCentrePhone")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Company_Name,CallCentrePhone")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Customers == null)
            {
                return Problem("Entity set 'LogisticDbContextV1.Customers'  is null.");
            }
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(string id)
        {
            return (_context.Customers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
*/