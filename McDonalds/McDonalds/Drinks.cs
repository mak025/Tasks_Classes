using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds
{
    /// <summary>
    /// Creating an enum to hold the values for drink sizes and their prices
    /// </summary>
    public enum DrinkSize { Small = 13, Medium = 25, Large = 35 }

    /// <summary>
    /// Creating the Drinks Class
    /// </summary>
    public class Drinks
    {
        /// <summary>
        /// Gets or sets the name of the drink (e.g., Cola, Fanta).
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the size of the drink.
        /// </summary>
        public DrinkSize Size { get; set; }
        /// <summary>
        /// Gets or sets the price of the drink, based on its size.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Drink"/> class.
        /// </summary>
        /// <param name="name">The name of the drink.</param>
        /// <param name="size">The size of the drink.</param>
        public Drinks(string name, DrinkSize size)
        {
            Name = name;
            Size = size;
            Price = (int)size; // Price is directly tied to the enum value
        }

        /// <summary>
        /// Returns a string that represents the drink's details.
        /// </summary>
        /// <returns>A string containing the drink's name, size, and price.</returns>
        public override string ToString()
        {
            return $"{Name} ({Size}) - {Price} kr."; // Example: "Cola (Large) - 35 kr."
        }
    }

}
