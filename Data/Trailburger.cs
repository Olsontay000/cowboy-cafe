using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class representing the Trail Burger entree 
    /// </summary>
    public class TrailBurger
    {
        /// <summary>
        /// If the Trail Burger is served with bun
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// If the Trail Burger is served with ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// If the Trail Burger is served with mustard
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// If the Trail Burger is served with pickle
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// If the Trail Burger is served with cheese
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// The price of the Trail Burger
        /// </summary>
        public double Price
        {
            get { return 4.50; }
        }
        /// <summary>
        /// The calories within the Trail Burger
        /// </summary>
        public uint Calories
        {
            get { return 288; }
        }
        /// <summary>
        /// The special instructions for the Trail Burger
        /// </summary>
        public List<string> SpecialInstructions
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
    }
}
