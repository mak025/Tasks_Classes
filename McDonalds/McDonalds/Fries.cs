using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds
{

    /// <summary>
    /// Creating an enum to hold the values for sizes and prices of fries
    /// </summary>
    public enum FriesSize { Medium = 24, Large = 33, XLarge = 50 }

    /// <summary>
    /// Creating the Fries class
    /// </summary>
    public class Fries
    {
        /// <summary>
        /// Gets or sets the size of the fries.
        /// </summary>
        public FriesSize Size { get; set; }

        /// <summary>
        /// Gets or sets the price of the fries, based on their size.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fries"/> class.
        /// </summary>
        /// <param name="size">The size of the fries.</param>
        public Fries(FriesSize size)
        {
            Size = size;
            Price = (int)size;
        }

        /// <summary>
        /// Returns a string that represents the fries' details.
        /// </summary>
        /// <returns>A string containing the fries' size and price.</returns>
        public override string ToString()
        {
            return $"Fries ({Size}) - {Price} kr.";
        }
    }
}
