using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds
{
    class Menu
    {
        public Drinks Drink { get; set; }

        public Fries Fries { get; set; }

        public Burger Burger { get; set; }



        public Menu(Drinks drink, Fries fries, Burger burger)
        {
            Drink = drink;
            Fries = fries;
            Burger = burger;
        }

        public int GetTotalPrice()
        {
            return Drink.Price + Fries.Price + Burger.Price;
        }

        public override string ToString()
        {
            return $"{Drink}, {Fries}, {Burger}";
        }
    }
}
