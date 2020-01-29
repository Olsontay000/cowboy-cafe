using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs
    {
        /// <summary>
        /// The price of the Rustler's Ribs
        /// </summary>
        public double Price
        {
            get { return 7.50; }
        }
        /// <summary>
        /// The calories within the Rustler's Ribs
        /// </summary>
        public uint Calories
        {
            get { return 894; }
        }
        /// <summary>
        /// Special instructions for Rustler's Ribs (There are none)
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }

        }
    }
}
