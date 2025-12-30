    using Microsoft.EntityFrameworkCore;
using SabzMarket.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.DAL
{
    public class SabzMarketDbContext : DbContext
    {
        public SabzMarketDbContext(DbContextOptions<SabzMarketDbContext> options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<FeaturedSeller> FeaturedSellers {  get; set; }
        public DbSet<CartItem> CartItems { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>()
                .HasData(
                new Categorie { Id = 1, Name = "کود های شیمیایی" },
                new Categorie { Id = 2, Name = "کود های آلی " },
                new Categorie { Id = 3, Name = "کودهای بیولوژیک" },
                new Categorie { Id = 4, Name = "حشره کش ها " },
                new Categorie { Id = 5, Name = "علف کش ها" },
                new Categorie { Id = 6, Name = "سموم معدنی " },
                new Categorie { Id = 7, Name = "سموم آلی " }
                );
            modelBuilder.Entity<Seller>()
                .HasOne(s => s.User)
                .WithOne(u => u.Seller)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Farmer>()
                .HasOne(f => f.User)
                .WithOne(u => u.Farmer)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Chat>()
                .HasOne(c => c.FromUser)
                .WithMany()
                .HasForeignKey(c => c.FromUserId)
                .OnDelete(DeleteBehavior.Restrict);
             
            modelBuilder.Entity<Chat>()
                .HasOne(c => c.ToUser)
                .WithMany()
                .HasForeignKey(c => c.ToUserId)
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<FeaturedSeller>()
                .HasIndex(x => x.SellerId)
                .IsUnique();
        }
    }
}
