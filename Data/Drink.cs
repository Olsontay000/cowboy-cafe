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
    public abstract class Drink
    {
        public Size Size { get; set; } = Size.Small;
        public abstract double Price { get; }
        public abstract uint Calories { get; }
        public virtual bool Ice { get; set; } = true;
        
        /// <summary>
        /// The special instructions for a given entree, defined in speicfic class using virtual values from above
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }





    }
}
