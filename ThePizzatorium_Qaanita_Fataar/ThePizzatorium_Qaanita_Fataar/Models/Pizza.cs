using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThePizzatorium_Qaanita_Fataar.Models
{
    public class Pizza
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        public string Ingredients { get; set; } = "";
        public double Price { get; set; }

        public static Pizza GetPizza(int _ID)
        {
            return PizzatoriumDB.PizzaData.Pizzas.Single(p => _ID == p.ID);
        }

        public void AddIngredient(Ingredient ing)
        {
            Ingredients += ing.ID + ",";
        }

    }

    public enum PizzaSize
    {
        Small,
        Medium,
        Large
    }
}