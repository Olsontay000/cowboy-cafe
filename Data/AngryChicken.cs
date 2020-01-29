using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing an AngryChicken entree
    /// </summary>
    public class AngryChicken
    {
        private bool bread = true;
        /// <summary>
        /// If the AngryChicken is served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }
        /// <summary>
        /// If the AngryChicken is served with pickle
        /// </summary>
        public bool Pickle { get; set; } = true; //auto property declaration (short-hand)
        /// <summary>
        /// The price of the AngryChicken
        /// </summary>
        public double Price
        {
            get { return 5.99; }
        }
        /// <summary>
        /// The calories within the AngryChicken
        /// </summary>
        public uint Calories
        {
            get { return 190; }
        }
        /// <summary>
        /// The special instructions for the AngryChicken
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!bread) { instructions.Add("hold bread"); }
                if(!Pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }

        }
    }
}
