﻿using Microsoft.EntityFrameworkCore;
using MVVM_Shop.SqlTables;

namespace MVVM_Shop
{
    public class SqlDb : DbContext
    {
        public SqlDb(DbContextOptions<SqlDb> options)
            : base(options)
        {
        }

        public DbSet<Suplier> Supliers { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Suplier>().ToTable("Supliers");
            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategories");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Cart>().ToTable("Carts");
        }
    }
}
