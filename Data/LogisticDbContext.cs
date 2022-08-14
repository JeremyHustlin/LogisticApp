using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using LogisticApp.ModelsCustomer;
using LogisticApp.ModelsDelivers;
using LogisticApp.ModelsForWarder;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace LogisticApp.Data
{



    public class LogisticDbContextV1 : DbContext

    {
        public LogisticDbContextV1(DbContextOptions<LogisticDbContextV1> options) : base(options)
        {
            //
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLocation> OrderLocations { get; set; }
        public DbSet<Product> Products { get; set; }

    }

    public class LogisticDbContextV2 : DbContext

    {
        public LogisticDbContextV2(DbContextOptions<LogisticDbContextV2> options) : base(options)
        {
            //
        }

        public DbSet<Delivers> Delivers { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Transportation> Transportations { get; set; }
    }

    public class LogisticDbContextV3 : IdentityDbContext<Driver>

    {
        public LogisticDbContextV3(DbContextOptions<LogisticDbContextV3> options) : base(options)
        {
            //
        }


        public DbSet<Driver> Drivers { get; set; }
    }
    public class LogisticDbContextV4 : DbContext

    { 
                
         public LogisticDbContextV4(DbContextOptions<LogisticDbContextV4> options) : base(options)
                    {
                        //
                    }

             public DbSet<ForWarder> ForWarders { get; set; }
             public DbSet<Schedule> Schedules { get; set; }
             public DbSet<Vehicle> Vehicles { get; set; }
             public DbSet<VehicleLocation> VehiclesLocations { get; set; }

    }
}


/* protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
     modelBuilder
         .Entity<Customer>()
         .HasOne(e => e.Orders)
         .WithOne(e => e.Id)
         .OnDelete(DeleteBehavior.ClientCascade);
 }
{
 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
     modelBuilder.Entity<Customer>()
         .HasOne(i => i.Orders)
         .WithMany(c => c.Id)
         .IsRequired()
         .OnDelete(DeleteBehavior.Cascade);
*/


/*protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
     modelBuilder.Entity<Customer>()
     .HasOne<Order>(e => e.Orders)
     .WithMany(d => d.Customers)
     .HasForeignKey(e => e.OrderId)
     .IsRequired(true)
     .OnDelete(DeleteBehavior.Cascade);

     base.OnModelCreating(modelBuilder);
 }*/
