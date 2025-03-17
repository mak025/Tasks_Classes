using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speedtest
{
    public class Pizza
    {
        //instance variables
        string _Name; //what is this persons name?
        string _Topping1; //is this person male or female?
        string _Topping2; //how old is this person?
        int _Price; //what is the persons profession?
        string _Size; //what is the person studying or educated in?

        //constructor
        public Pizza(string name, string topping1, string topping2, string size, int price)
        {
            //properties
            _Name = name;
            _Topping1 = topping1;
            _Topping2 = topping2;
            _Price = price;
            _Size = size;
        }

        public override string ToString()
        {
            return $"This Pizza is called {_Name}, has the toppings:" +
                $" {_Topping1} & {_Topping2} " +
                $"has the size {_Size} and costs {_Price}$.";
        }

    }



}
