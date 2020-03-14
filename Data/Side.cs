/*

* Author: Nathan Bean

* Edited by: Taylor Olson

* Class name: Side.cs

* Purpose: A class for a Side object and the default values

*/
using System;
using System.Collections.Generic;
using System.Text;

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

        public abstract bool IsSmall { get; set; }

        public abstract bool IsMedium { get; set; }

        public abstract bool IsLarge { get; set; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        public virtual List<string> SpecialInstructions { get; } = new List<string>();

    }
}
