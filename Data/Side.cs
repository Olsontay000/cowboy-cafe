/*

* Author: Nathan Bean

* Edited by: Taylor Olson

* Class name: Side.cs

* Purpose: A class for a Side object and the default values

*/
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Tells if small is selected
        /// </summary>
        public abstract bool IsSmall { get; set; }
        /// <summary>
        /// Tells if medium is selected
        /// </summary>
        public abstract bool IsMedium { get; set; }
        /// <summary>
        /// Tells is large is selected
        /// </summary>
        public abstract bool IsLarge { get; set; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        public virtual List<string> SpecialInstructions { get; } = new List<string>();

    }
}
