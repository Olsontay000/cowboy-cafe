using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Dakota Dobule Burger entree
    /// </summary>
    public class DakotaDoubleBurger
    {
        /// <summary>
        /// If the Dakota Double Burger is served with bun
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// If the Dakota Double Burger is served with ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// If the Dakota Double Burger is served with mustard
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// If the Dakota Double Burger is served with pickle
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// If the Dakota Double Burger is served with cheese
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// If the Dakota Double Burger is served with tomato
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// If the Dakota Double Burger is served with lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// If the Dakota Double Burger is served with mayo
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// The price of the Dakota Double Burger
        /// </summary>
        public double Price
        {
            get { return 5.20; }
        }
        /// <summary>
        /// The calories within the Dakota Double Burger
        /// </summary>
        public uint Calories
        {
            get { return 464; }
        }
        /// <summary>
        /// The special instructions for the Dakota Double Burger
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
                if (!Tomato) { instructions.Add("hold tomato"); }
                if (!Lettuce) { instructions.Add("hold lettuce"); }
                if (!Mayo) { instructions.Add("hold mayo"); }

                return instructions;
            }

        }
    }
}
