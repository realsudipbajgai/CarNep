using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.Data
{
    public class DBSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                if (!context.Brands.Any())
                {
                    context.AddRange(GetBrandsList());
                    context.SaveChanges();
                }
                if (!context.Categories.Any())
                {
                    context.AddRange(GetCategoriesList());
                    context.SaveChanges();
                }
                if (!context.Vehicles.Any())
                {
                    context.AddRange(GetVehiclesList());
                    context.SaveChanges();
                }
            }
        }
        public static List<Brand> GetBrandsList()
        {
            var brands = new List<Brand>
            {
                new Brand { Name = "Honda" },
                new Brand { Name = "Toyota" },
                new Brand { Name = "Tesla" },
                new Brand { Name = "Ford" },
                new Brand { Name = "Audi" },
                new Brand { Name = "Volkswagan" },
            };
            return brands;
        }
        public static List<Category> GetCategoriesList()
        {
            var categories = new List<Category>
            {
                new Category { Name = "Car" },
                new Category { Name = "Truck" },
                new Category { Name = "Van" },
                new Category { Name = "SUV" },
            };
            return categories;
        }
        public static List<Vehicle> GetVehiclesList()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle { Make = "123",BrandId = 1,CategoryId = 1,Model = "Corolla",Price = 12000,Image = "Chevrolet Impala.jpg"},
                new Vehicle { Make = "abcd",BrandId = 1,CategoryId = 2,Model = "ABCD",Price = 13000,Image = "BMW 3.jpg"},
                new Vehicle { Make = "123",BrandId = 2,CategoryId = 3,Model = "xyz",Price = 14000,Image = "BMW 3.jpg"},
                new Vehicle { Make = "1234",BrandId = 3,CategoryId = 4,Model = "hhh",Price = 15000,Image = "BMW 3.jpg"},
                new Vehicle { Make = "abcd",BrandId = 4,CategoryId = 3,Model = "Centric",Price = 11000,Image = "BMW 3.jpg"},
                new Vehicle { Make = "123",BrandId = 1,CategoryId = 4,Model = "xyz",Price = 20000,Image = "BMW 3.jpg"},
                new Vehicle { Make = "1234",BrandId = 4,CategoryId = 4,Model = "hhh",Price = 23000,Image = "BMW 3.jpg"},
            };
            return vehicles;
        }
    }
}
