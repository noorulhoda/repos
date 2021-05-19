using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class NoSuchItemException : Exception { }

    public class Item 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }


    public class ShoppingCart
    {
        Dictionary<Item, int> cart;

        public Dictionary<Item, int> Cart
        {
            get
            {
                return cart;
            }
        }

       
        public ShoppingCart()
        {
            cart = new Dictionary<Item, int>();
            
        }

        public string AddItems(Item anItem, int quantity)
        {
            if (quantity < 0)
                throw new ArgumentOutOfRangeException();
            if (Cart.Keys.Contains(anItem))
            {
                Cart[anItem] += quantity;
                return "Updated";
            }
            else
            {
                Cart.Add(anItem, quantity);
                return "Added";
            }

        }

       

        public int ItemsCount
        {
            get 
            {
                return cart.Values.Sum();
            }
        }



        public int getAvg(int f, int s, int th)
        {
            return (f + s + th) / 3;

        }
      public int getAge(DateTime d)
        {
            return
                 DateTime.Now.Year - d.Year;
        }


    }
}
