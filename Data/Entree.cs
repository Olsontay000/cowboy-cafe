/*

* Author: Taylor Olson

* Class name: Entree.cs

* Purpose: The entree class object that holds default values and allows the values to be overriden within the specific entrees

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An abstract base class representing an entree
    /// </summary>
    public abstract class Entree : IOrderItem
    {


        /// <summary>
        /// Gets the default value for "Bread", can be set
        /// </summary>
        public virtual bool Bread { get; set; } = true;
        /// <summary>
        /// Gets the default value for "Pickle", can be set
        /// </summary>
        public virtual bool Pickle { get; set; } = true;
        /// <summary>
        /// Gets the default value for "Bun", can be set
        /// </summary>
        public virtual bool Bun { get; set; } = true;
        /// <summary>
        /// Gets the default value for "Ketchup", can be set
        /// </summary>
        public virtual bool Ketchup { get; set; } = true;
        /// <summary>
        /// Gets the default value for "Mustward", can be set
        /// </summary>
        public virtual bool Mustard { get; set; } = true;
        /// <summary>
        /// Gets the default value for "Cheese", can be set
        /// </summary>
        public virtual bool Cheese { get; set; } = true;
        /// <summary>
        /// Gets the default value for "Tomato", can be set
        /// </summary>
        public virtual bool Tomato { get; set; } = true;
        /// <summary>
        /// Gets the default value for "Lettuce", can be set
        /// </summary>
        public virtual bool Lettuce { get; set; } = true;
        /// <summary>
        /// Gets the default value for "Mayo", can be set
        /// </summary>
        public virtual bool Mayo { get; set; } = true;
        /// <summary>
        /// Gets the default value for "Bacon", can be set
        /// </summary>
        public virtual bool Bacon { get; set; } = true;
        /// <summary>
        /// Gets the default value for "Egg", can be set
        /// </summary>
        public virtual bool Egg { get; set; } = true;
        /// <summary>
        /// Gets the default value for "Sour Cream", can be set
        /// </summary>
        public virtual bool SourCream { get; set; } = true;
        /// <summary>
        /// Gets the default value for "Green Onions", can be set
        /// </summary>
        public virtual bool GreenOnions { get; set; } = true;
        /// <summary>
        /// Gets the default value for "Tortilla Strips", can be set
        /// </summary>
        public virtual bool TortillaStrips { get; set; } = true;
     

        /// <summary>
        /// The price attribute of the entree, set in the specific class
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// The calories attribute of the entree, set in the specific class
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// The special instructions for a given entree, defined in speicfic class using virtual values from above
        /// </summary>
        public abstract IEnumerable<string> SpecialInstructions { get; }
        


    }
}
