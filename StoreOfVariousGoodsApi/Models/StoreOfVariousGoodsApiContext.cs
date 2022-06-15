using Microsoft.EntityFrameworkCore;

namespace StoreOfVariousGoodsApi.Models;

public class StoreOfVariousGoodsApiContext : DbContext
{
    public StoreOfVariousGoodsApiContext(DbContextOptions<StoreOfVariousGoodsApiContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    } 

    public DbSet<Buyer> Buyers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProvidedProduct> ProvidedProducts { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleData> SalesDates { get; set; }
    public DbSet<SalesPoint> SalesPoints { get; set; }
}