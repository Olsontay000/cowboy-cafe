/*

* Author: Taylor Olson

* Class name: ChiliCheeseFries.cs

* Purpose: The attributes for the side item "Chili Cheese Fries"

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class representing a Chili Cheese Fries side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// Set value for calories of Chili Cheese Fries depending on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Set value for price of Chili Cheese Fries depending on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string of the menu item, Chili Cheese Fries</returns>
        public override string ToString()
        {
            return "Chili Cheese Fries";
        }
    }
}
