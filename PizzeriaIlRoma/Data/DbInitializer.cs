using PizzeriaIlRoma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaIlRoma.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Pizzas.Any())
            {
                return; // Db is already seeded
            }

            var ingredients = new Ingredient[]
            {
                new Ingredient {Name = "Tomato sauce"},
                new Ingredient {Name = "Cheese"},
                new Ingredient {Name = "Pepperoni"},
                new Ingredient {Name = "Ham"},
                new Ingredient {Name = "Pineapple"},
                new Ingredient {Name = "Mushrooms"},
                new Ingredient {Name = "Tuna"}
            };
            foreach (Ingredient i in ingredients)
            {
                context.Ingredients.Add(i);
            }
            context.SaveChanges();

            var pizzas = new Pizza[]
            {
                new Pizza{Name = "Margherita", Description = "Pizza with tomato and cheese", Price = 10.00M},
                new Pizza{Name = "Funghi", Description = "Pizza with mushrooms", Price = 11.00M},
                new Pizza{Name = "Mista", Description = "Pizza with cheese, ham, salami and mushrooms", Price = 11.00M},
                new Pizza{Name = "Hawaii", Description = "Pizza with cheese, ham, pineapple", Price = 13.00M},
                new Pizza{Name = "Pepperoni", Description = "Pizza with cheese and pepperoni", Price = 12.00M}

            };

            foreach(Pizza p in pizzas)
            {
                context.Add(p);
            }
            context.SaveChanges();
        }
    }
}
