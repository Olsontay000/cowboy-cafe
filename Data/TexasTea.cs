/*

* Author: Taylor Olson

* Class name: TexasTea.cs

* Purpose: The attributes for the menu item "Texas Tea"

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink, inheriting the "Drink.cs" base class
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// The price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// The calories of the tea, sweetner halfs the calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        if (!Sweet) { return 18; }
                        return 36;
                    case Size.Medium:
                        if (!Sweet) { return 11; }
                        return 22;
                    case Size.Small:
                        if (!Sweet) { return 5; }
                        return 10;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// If the tea contains sweetner, default is true
        /// </summary>
        public bool Sweet { get; set; } = true;
        /// <summary>
        /// If the tea contains lemon, default is false
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// Special instructions for the preparation of the tea
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
        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string of the menu item, Texas Tea</returns>
        public override string ToString()
        {
            return "Texas Tea";
        }

    }
}
