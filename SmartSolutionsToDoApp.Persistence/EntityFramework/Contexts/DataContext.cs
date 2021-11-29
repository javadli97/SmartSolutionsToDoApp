using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartSolutionsToDoApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartSolutionsToDoApp.Persistence.EntityFramework.Contexts
{
    public class DataContext : IdentityDbContext<AppUser,Role,int>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<UsersTasks> UsersTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          
            foreach (var property in builder.Model.GetEntityTypes()
               .SelectMany(t => t.GetProperties())
               .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {

                property.SetPrecision(18);
                property.SetScale(2);
            }

            builder.SeedData();


            base.OnModelCreating(builder);


            //builder.Entity<UserEntity>()
            //        .HasIndex(u => u.Pin)
            //        .IsUnique();

        }
    }
}
