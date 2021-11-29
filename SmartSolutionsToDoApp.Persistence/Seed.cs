using Microsoft.EntityFrameworkCore;
using SmartSolutionsToDoApp.Domain;

namespace SmartSolutionsToDoApp.Persistence
{
    public static class Seed
    {

        public static void SeedData(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin", NormalizedName = "ADMIN", Description = "Organization administrator" },
                new Role { Id = 2, Name = "User", NormalizedName = "USER", Description = "Organization user" }
           );


        }


    }
}
