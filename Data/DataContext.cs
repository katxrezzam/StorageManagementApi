using Microsoft.EntityFrameworkCore;

namespace storageApi;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
    public DbSet<DeliveryDetail> DeliveryDetails { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Provider> Providers { get; set; }
    public DbSet<Transfer> Transfers { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Transfer>()
            .HasOne(t => t.Origin)
            .WithMany(w => w.Origins)
            .HasForeignKey(t => t.OriginId)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<Transfer>()
            .HasOne(t => t.Destiny)
            .WithMany(w => w.Destinies)
            .HasForeignKey(t => t.DestinyId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
