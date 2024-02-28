using Microsoft.EntityFrameworkCore;
using TCT.Models;

namespace TayCT.Models;

public class TayCTContext: DbContext
{
    public TayCTContext(DbContextOptions<TayCTContext> options)
        : base(options)
    {
        
    }
    
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<ClientCompany> ClientCompanies { get; set; }
    public DbSet<Booking> Bookings { get; set; }
}