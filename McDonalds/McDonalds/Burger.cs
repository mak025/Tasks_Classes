using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds
{
    /// <summary>
    /// Creating an enum to hold the values for the available burgers
    /// </summary>
    public enum BurgerType { Cheeseburger = 55, Hamburger = 50, BaconCheeseBurger = 65 }
    /// <summary>
    /// Creating the Burger class
    /// </summary>
    public class Burger
    {
        /// <summary>
        /// Gets or sets the type of burger
        /// </summary>
        public BurgerType Name { get; set; }

        /// <summary>
        /// Gets or sets the price of the burger.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Burger"/> class.
        /// </summary>
        /// <param name="name">The name of the burger.</param>
        /// <param name="price">The price of the burger.</param>
        public Burger(BurgerType name)
        {
            Name = name;
            Price = (int)name;
        }

        /// <summary>
        /// Returns a string that represents the burger's details.
        /// </summary>
        /// <returns>A string containing the burger's name and price.</returns>
        public override string ToString()
        {
            return $"{Name} - {Price} kr.";
        }
    }
}
