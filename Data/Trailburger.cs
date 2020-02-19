/*

* Author: Taylor Olson

* Class name: TrailBurger.cs

* Purpose: The attributes for the menu item "Trail Burger"

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class representing the Trail Burger entree 
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// If the Trail Burger is served with bun
        /// </summary>
        public override bool Bun { get; set; } = true;
        /// <summary>
        /// If the Trail Burger is served with ketchup
        /// </summary>
        public override bool Ketchup { get; set; } = true;
        /// <summary>
        /// If the Trail Burger is served with mustard
        /// </summary>
        public override bool Mustard { get; set; } = true;
        /// <summary>
        /// If the Trail Burger is served with pickle
        /// </summary>
        public override bool Pickle { get; set; } = true;
        /// <summary>
        /// If the Trail Burger is served with cheese
        /// </summary>
        public override bool Cheese { get; set; } = true;
        /// <summary>
        /// The price of the Trail Burger
        /// </summary>
        public override double Price
        {
            get { return 4.50; }
        }
        /// <summary>
        /// The calories within the Trail Burger
        /// </summary>
        public override uint Calories
        {
            get { return 288; }
        }
        /// <summary>
        /// The special instructions for the Trail Burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bun) { instructions.Add("hold bun"); }
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if (!Mustard) { instructions.Add("hold mustard"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Cheese) { instructions.Add("hold cheese"); }

                return instructions;
            }

        }

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string of the menu item, Trail Burger</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
