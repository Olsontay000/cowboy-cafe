/*

* Author: Taylor Olson

* Class name: IOrderItem.cs

* Purpose: The IOrderItem class file used to initalize the IOrderItem instance

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

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
   
    }
}