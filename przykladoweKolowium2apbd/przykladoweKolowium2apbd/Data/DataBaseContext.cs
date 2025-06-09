using Microsoft.EntityFrameworkCore;
using przykladoweKolowium2apbd.Models;

namespace przykladoweKolowium2apbd.Data;

public class DataBaseContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<ProductOrder> ProductOrders { get; set; }


    protected DataBaseContext()
    {
        
    }
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
    
}