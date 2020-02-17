/*

* Author: Taylor Olson

* Class name: Water.cs

* Purpose: The attributes for the menu item "Water"

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Water drink, inheriting the "Drink.cs" base class
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// The price of water, $0.12 for all sizes
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    default:
                        return 0.12;
                }
            }
        }
        /// <summary>
        /// There are no calories for water in any size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    default:
                        return 0;
                }
            }
        }
        /// <summary>
        /// If the water has a lemon in it, default is false
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// Special instructions for the preparation of the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) { instructions.Add("Hold Ice"); }
                if (Lemon) { instructions.Add("Add Lemon"); }
                return instructions;
            }
        }

    }
}
