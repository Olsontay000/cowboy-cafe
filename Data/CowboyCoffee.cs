/*

* Author: Taylor Olson

* Class name: CowboyCoffee.cs

* Purpose: The attributes for the menu item "Cowboy Coffee"

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee drink, inheriting the "Drink.cs" base class
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// The price of the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return 0.60;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// The calories of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// If the coffee contains ice, default is false
        /// </summary>
        public override bool Ice {get; set;} = false;
        /// <summary>
        /// If the coffee is decaf, no default
        /// </summary>
        public bool Decaf { get; set; }
        /// <summary>
        /// If the coffee has room for cream, default is false
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// Special instructions for the preparation of the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) { instructions.Add("Add Ice"); }
                if(RoomForCream) { instructions.Add("Room for Cream"); }
                return instructions;
            }
        }

    }
}
