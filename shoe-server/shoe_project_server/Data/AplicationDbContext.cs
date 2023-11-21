using Microsoft.EntityFrameworkCore;
using shoe_project_server.Models;

namespace shoe_project_server.Data
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options){

        }
        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Favourite> favourites { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Producer> producers { get; set; }
        public DbSet<ProductDetail> productDetails { get; set; }
        public DbSet<ProductImage> productImages { get; set; }
        public DbSet<PurchaseHistory> purchaseHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseHistory>()
                .HasKey(ph => new { ph.orderId, ph.userId });
            modelBuilder.Entity<Favourite>()
              .HasKey(fa => new { fa.userId, fa.productId });

        }
    }
}
