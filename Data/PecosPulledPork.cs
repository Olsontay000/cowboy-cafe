/*

* Author: Taylor Olson

* Class name: PecosPulledPork.cs

* Purpose: The attributes for the menu item "Pecos Pulled Pork"

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// If the Pecos Pulled Pork is served with bread
        /// </summary>
        public override bool Bread { get; set; } = true;
        /// <summary>
        /// If the Pecos Pulled Pork is served with pickle
        /// </summary>
        public override bool Pickle { get; set; } = true;
        /// <summary>
        /// The price of the Pecos Pulled Pork
        /// </summary>
        public override double Price
        {
            get { return 5.88; }
        }
        /// <summary>
        /// The calories within the Pecos Pulled Pork
        /// </summary>
        public override uint Calories
        {
            get { return 528; }
        }
        /// <summary>
        /// The special instructions for the Pecos Pulled Pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bread) { instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }

        }
    }
}
