/*

* Author: Taylor Olson

* Class name: IOrderItem.cs

* Purpose: The IOrderItem class file used to initalize the IOrderItem instance

*/
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// Variable for price
        /// </summary>
        public double Price { get; }
        /// <summary>
        /// Variable for special instructions
        /// </summary>
        public List<string> SpecialInstructions { get; }
        /// <summary>
        /// Variable for calories
        /// </summary>
        public uint Calories { get; }

    }
}