/*

* Author: Taylor Olson

* Class name: Drink.cs

* Purpose: The drink class object that holds default values and allows the values to be overriden within the specific drinks

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An abstract base class representing a drink
    /// </summary>
    public abstract class Drink
    {
        public Size Size { get; set; } = Size.Small;
        /// <summary>
        /// The price attribute of the drink, set in the specific class
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// The calories attribute of the drink, set in the specific class
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Gets the default value for "Ice", can be set
        /// </summary>
        public virtual bool Ice { get; set; } = true;
        
        /// <summary>
        /// The special instructions for a given entree, defined in speicfic class using virtual values from above
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }





    }
}
