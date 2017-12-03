using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ThePizzatorium_Qaanita_Fataar.Models
{
    public class PizzatoriumDB : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Pizza> PredefinedPizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        private static PizzatoriumDB DBData = new PizzatoriumDB();

        public static PizzatoriumDB Data
        {
            get { return DBData; }
        }
    }
}