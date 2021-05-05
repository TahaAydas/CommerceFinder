using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CommerceFinder.Entities;

namespace CommerceFinder.DataAccess
{
    public class ProductDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=TAHAAYDAS;Database=CommerceDb;Trusted_Connection=True;");
        }

        public DbSet<Products> Products{ get; set; }
    }
}
