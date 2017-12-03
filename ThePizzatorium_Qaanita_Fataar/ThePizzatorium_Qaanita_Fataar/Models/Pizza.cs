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
        public List<Ingredient> Ingredients { get; set; }
        public double Price { get; set; }

    }

    public enum PizzaSize
    {
        Small,
        Medium,
        Large
    }
}