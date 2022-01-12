#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
    public class MVCContext : DbContext
    {
        public MVCContext (DbContextOptions<MVCContext> options)
            : base(options)
        {
        }

        public DbSet<MVC.Models.Category> Category { get; set; }

        public DbSet<MVC.Models.Product> Product { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* modelBuilder.Entity<Product>()
                 .HasMany(b => b.Categories)
                 .WithOne()
                 ;

             modelBuilder.Entity<Product>()
                 .Navigation(b => b.Categories)
                 .UsePropertyAccessMode(PropertyAccessMode.Property);*/

            modelBuilder.Entity<Product>(entity =>
            {
                modelBuilder.Entity<Product>().ToTable("Products");
                modelBuilder.Entity<Product>().HasKey(c => c.p_Id);
                modelBuilder.Entity<Product>().Ignore(c => c.Categories);
                //.HasName("PK_Commodity");
            });


        }
        
    }
}
