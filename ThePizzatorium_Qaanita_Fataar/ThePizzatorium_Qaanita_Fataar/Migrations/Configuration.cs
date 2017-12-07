namespace ThePizzatorium_Qaanita_Fataar.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ThePizzatorium_Qaanita_Fataar.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ThePizzatorium_Qaanita_Fataar.Models.PizzatoriumDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ThePizzatorium_Qaanita_Fataar.Models.PizzatoriumDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Users.AddOrUpdate(u => u.ID,

            new Models.User
            {
                ID = 1,
                Name = "Admin",
                Username = "Admin",
                Email = "admin@admin.com",
                Password = "p@ssw0rd",
                IsAdmin = true

            });

            context.Ingredients.AddOrUpdate(i => i.ID,
            new Ingredient { ID = 1, Name = "Tomato Base", Price = 11.00},
            new Ingredient { ID = 2, Name = "BBQ Base", Price = 11.00 },
            new Ingredient { ID = 3, Name = "Chutney Base",  Price = 11.00},
            new Ingredient { ID = 4, Name = "Szechuan Sauce",  Price = 18.00},
            new Ingredient { ID = 5, Name = "BBQ Sauce",  Price = 9.00},
            new Ingredient { ID = 6, Name = "Mayonnaise",  Price = 9.00},
            new Ingredient { ID = 7, Name = "Sweet & Sour Sauce",  Price = 9.00},
            new Ingredient { ID = 8, Name = "Chicken",  Price = 12.00},
            new Ingredient { ID = 9, Name = "Beef",  Price = 12.00},
            new Ingredient { ID = 10, Name = "Rib",  Price = 12.00},
            new Ingredient { ID = 11, Name = "Anchovies",  Price = 12.00},
            new Ingredient { ID = 12, Name = "Pepperoni",  Price = 12.00},
            new Ingredient { ID = 13, Name = "Macon",  Price = 12.00},
            new Ingredient { ID = 14, Name = "Bacon",  Price = 12.00},
            new Ingredient { ID = 15, Name = "Banana",  Price = 11.00},
            new Ingredient { ID = 16, Name = "Pineapple",  Price = 11.00},
            new Ingredient { ID = 17, Name = "Ham",  Price = 12.00},
            new Ingredient { ID = 18, Name = "Mozzerella Cheese",  Price = 10.00},
            new Ingredient { ID = 19, Name = "Cheddar Cheese",  Price = 10.00},
            new Ingredient { ID = 20, Name = "Feta Cheese",  Price = 10.00},
            new Ingredient { ID = 21, Name = "Fried Chips",  Price = 12.00},
            new Ingredient { ID = 22, Name = "Egg",  Price = 12.00 },
            new Ingredient { ID = 23, Name = "Olives", Price = 15.00 }
           );


        }
    }
}
