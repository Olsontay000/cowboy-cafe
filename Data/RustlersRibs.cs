/*

* Author: Taylor Olson

* Class name: RustlersRibs.cs

* Purpose: The attributes for the menu item "Rustler's Ribs"

*/
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the Rustler's Ribs
        /// </summary>
        public override double Price
        {
            get { return 7.50; }
        }
        /// <summary>
        /// The calories within the Rustler's Ribs
        /// </summary>
        public override uint Calories
        {
            get { return 894; }
        }
        /// <summary>
        /// Special instructions for Rustler's Ribs (There are none)
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }

        }
        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string of the menu item, Rustler's Ribs</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
