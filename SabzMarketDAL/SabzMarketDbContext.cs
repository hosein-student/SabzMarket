using SabzMarketDAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SabzMarketDAL
{
    public class SabzMarketDbContext : DbContext
    {
        public SabzMarketDbContext() : base("Data Source=.;Initial Catalog=SabzMarketEfDb;Integrated Security=True;Encrypt=False")
        {
            //Environment.GetEnvironmentVariable("SabzCS", EnvironmentVariableTarget.Machine)
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Farmer> Farmers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seller>()
                .HasRequired(s => s.User)
                .WithOptional(u => u.Seller)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Farmer>()
                .HasRequired(s => s.User)
                .WithOptional(u => u.Farmer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .HasRequired(s => s.Product)
                .WithMany(u => u.OrderDetails)
                .HasForeignKey(s => s.ProductId)
                .WillCascadeOnDelete(false);
        }

    }
}
