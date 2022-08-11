using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using LogisticApp.ModelsCustomer;
using LogisticApp.ModelsDelivers;
using LogisticApp.ModelsForWarder;

namespace LogisticApp.Data
{
    public class LogisticDbContext: IdentityDbContext<Driver>

    {
            public LogisticDbContext(DbContextOptions<LogisticDbContext> options) : base(options)
            {
                //
            }



        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLocation> OrderLocations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Delivers> Delivers { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Transportation> Transportations { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<ForWarder> ForWarders { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleLocation> VehiclesLocations { get; set; }


    }
}

