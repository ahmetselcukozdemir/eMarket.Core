using System;
using System.Collections.Generic;
using System.Text;
using eMarket.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace eMarket.Core.Data.Concrete.EfCore
{
   public class eMarketContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                //@"Server=DESKTOP-EU8IQQD\AHMET;Database=eStoreAppDB;Trusted_Connection=True");
                @"Server=DESKTOP-EU8IQQD\AHMET;Database=eMarket;Trusted_Connection=True");

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFavorite> ProductFavorites { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ApplicationForm> ApplicationForms { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Message> Messages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
