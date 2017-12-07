using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThePizzatorium_Qaanita_Fataar.Models
{
    public class Ingredient
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public PizzaSize Size { get; set; }

        public static List<Ingredient> Get(string stringIDs)
        {
            string[] _Ids = stringIDs.Split(',');
            List<int> IDs = new List<int>();
            foreach (string s in _Ids)
            {
                IDs.Add(int.Parse(s));
            }
            return PizzatoriumDB.PizzaData.Ingredients.Where(i => IDs.Contains(i.ID)).ToList();
        }

        public static List<Ingredient> Get(params int[] IDs)
        {
            return PizzatoriumDB.PizzaData.Ingredients.Where(i => IDs.Contains(i.ID)).ToList();
        }

        public static List<Ingredient> Get(List<int> IDs)
        {
            return PizzatoriumDB.PizzaData.Ingredients.Where(i => IDs.Contains(i.ID)).ToList();
        }


    }

    

    public enum PizzaSize
    {
        Small,
        Medium,
        Large
    }
}