using Microsoft.EntityFrameworkCore;
using Excercise3.Models;

namespace Excercise3.Core
{
    public class ExcerciseDbContext(DbContextOptions<ExcerciseDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products => Set<Product>();

        public void Seed()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1, Name = "Belgian Fries",
                    Description = "Crispy golden fries served with a variety of sauces.",
                    Price = 3.50m, Category = "Fries"
                },
                new Product
                {
                    Id = 2, Name = "Frikandel", Description = "A popular Belgian sausage, deep-fried to perfection.",
                    Price = 2.00m, Category = "Snacks"
                },
                new Product
                {
                    Id = 3, Name = "Bitterballen",
                    Description = "Deep-fried meatballs, crunchy on the outside and soft inside.", Price = 4.00m,
                    Category = "Snacks"
                },
                new Product
                {
                    Id = 4, Name = "Cheese Croquettes", Description = "Delicious croquettes filled with melted cheese.",
                    Price = 3.00m, Category = "Snacks"
                },
                new Product
                {
                    Id = 5, Name = "Chicken Nuggets",
                    Description = "Crispy chicken nuggets served with a dipping sauce.",
                    Price = 3.00m, Category = "Snacks"
                },
                new Product
                {
                    Id = 6, Name = "Mayonnaise", Description = "Classic Belgian mayonnaise, perfect for dipping fries.",
                    Price = 0.50m, Category = "Sauces"
                },
                new Product
                {
                    Id = 7, Name = "Andalouse Sauce",
                    Description = "A spicy and tangy sauce, great with fries and snacks.",
                    Price = 0.50m, Category = "Sauces"
                },
                new Product
                {
                    Id = 8, Name = "Curry Ketchup", Description = "A sweet and spicy ketchup with a hint of curry.",
                    Price = 0.50m, Category = "Sauces"
                }
            };

            Products.AddRange(products);

            SaveChanges();
        }
    }
}