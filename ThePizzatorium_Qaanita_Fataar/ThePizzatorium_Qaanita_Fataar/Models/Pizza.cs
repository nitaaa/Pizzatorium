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
        public string PizzaIngredients { get; set; } = "";
        public double Price { get; set; }

        public List<int> Ingredients
        {
            get
            {
                if (this.PizzaIngredients == "")
                    return new List<int> { };
                List<string> _list = this.PizzaIngredients.Split(',').ToList();
                if (_list.Count > 0)
                {
                    return _list.Select(i => Convert.ToInt32(i)).ToList();
                }
                return new List<int> { };

            }
            set
            {
                this.PizzaIngredients = value.Select(i => i.ToString()).Aggregate((i, j) => i + ',' + j);
            }
        }

    }
}