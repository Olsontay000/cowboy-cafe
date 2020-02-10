/*

* Author: Taylor Olson

* Class name: TexasTripleBurger.cs

* Purpose: The attributes for the menu item "Texas Triple Burger"

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger : Entree
    {
        
        /// <summary>
        /// If the Texas Triple Burger is served with bun
        /// </summary>
        public override bool Bun { get; set; } = true;
        /// <summary>
        /// If the Texas Triple Burger is served with ketchup
        /// </summary>
        public override bool Ketchup { get; set; } = true;
        /// <summary>
        /// If the Texas Triple Burger is served with mustard
        /// </summary>
        public override bool Mustard { get; set; } = true;
        /// <summary>
        /// If the Texas Triple Burger is served with pickle
        /// </summary>
        public override bool Pickle { get; set; } = true;
        /// <summary>
        /// If the Texas Triple Burger is served with cheese
        /// </summary>
        public override bool Cheese { get; set; } = true;
        /// <summary>
        /// If the Texas Triple Burger is served with tomato
        /// </summary>
        public override bool Tomato { get; set; } = true;
        /// <summary>
        /// If the Texas Triple Burger is served with lettuce
        /// </summary>
        public override bool Lettuce { get; set; } = true;
        /// <summary>
        /// If the Texas Triple Burger is served with mayo
        /// </summary>
        public override bool Mayo { get; set; } = true;
        /// <summary>
        /// If the Texas Triple Burger is served with bacon
        /// </summary>
        public override bool Bacon { get; set; } = true;
        /// <summary>
        /// If the Texas Triple Burger is served with egg
        /// </summary>
        public override bool Egg { get; set; } = true;
        /// <summary>
        /// The price of the Texas Triple Burger
        /// </summary>
        public override double Price
        {
            get { return 6.45; }
        }
        /// <summary>
        /// The calories within the Texas Triple Burger
        /// </summary>
        public override uint Calories
        {
            get { return 698; }
        }
        /// <summary>
        /// The special instructions for the Texas Triple Burger
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
                if (!Tomato) { instructions.Add("hold tomato"); }
                if (!Lettuce) { instructions.Add("hold lettuce"); }
                if (!Mayo) { instructions.Add("hold mayo"); }
                if (!Bacon) { instructions.Add("hold bacon"); }
                if (!Egg) { instructions.Add("hold egg"); }

                return instructions;
            }

        }
        


    }
}
