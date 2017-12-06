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
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        //public static List<Pizza> Pizzas { get; set; }

        private static PizzatoriumDB DBData = new PizzatoriumDB();

        public static PizzatoriumDB PizzaData
        {
            get { return DBData; }
        }
    }

    //A nice way to add pizzas to the cart, 
    //but because the formative only wants the user to order one pizza, 
    //there is no need for it
    //public class SessionCart
    //{
    //    public User User { get; set; }
    //    public List<Pizza> Pizzas { get; set; }

    //    public SessionCart()
    //    {
    //        this.Pizzas = new List<Pizza>();
    //    }



    //    public int Count
    //    {
    //        get
    //        {
    //            int items = 0;
    //            items += this.Pizzas.Count;

    //            return items;
    //        }

    //    }

    //    public void AddPizza(int _ID)
    //    {
    //        this.Pizzas.Add(PizzatoriumDB.Pizzas.Single(p => p.ID == _ID));
    //    }

    //    public void AddPizzas(int[] _IDs)
    //    {
    //        this.Pizzas.AddRange(PizzatoriumDB.Pizzas.Where(p => _IDs.Contains(p.ID)));
    //    }



    //    public void AddPizza(Pizza pizza)
    //    {
    //        this.Pizzas.Add(pizza);
    //    }



    //    public void AddPizza(List<Pizza> pizzas)
    //    {
    //        this.Pizzas.AddRange(pizzas);
    //    }


    //    public void RemovePizza(int Index)
    //    {
    //        this.Pizzas.RemoveAt(Index);
    //    }

    //    public void RemovePizza(int[] Indexes)
    //    {
    //        List<Pizza> RemoveList = new List<Pizza>();
    //        foreach (int index in Indexes)
    //        {
    //            RemoveList.Add(this.Pizzas[index]);
    //        }

    //        this.Pizzas.RemoveAll(p => RemoveList.Contains(p));
    //    }
    //}
}