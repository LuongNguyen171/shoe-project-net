using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using shoe_project_server.Data.Seeder;
using shoe_project_server.Models;

namespace shoe_project_server.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){

        }
        /*public DbSet<User> users { get; set; }*/
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

            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();


            /*  modelBuilder.Entity<ApplicationUser>()
             .HasIndex(u => u.Email)
             .IsUnique();*/


            base.OnModelCreating(modelBuilder);

        }
    }
}
