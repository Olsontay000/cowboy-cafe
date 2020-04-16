/*

* Author: Taylor Olson

* Class name: PecosPulledPork.cs

* Purpose: The attributes for the menu item "Pecos Pulled Pork"

*/
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool bread = true;
        private bool pickle = true;
        /// <summary>
        /// If the Pecos Pulled Pork is served with bread
        /// </summary>
        public override bool Bread
        {
            get { return bread; }
            set
            {
                bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// If the Pecos Pulled Pork is served with pickle
        /// </summary>
        public override bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
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
        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string of the menu item, Peco's Pulled Pork</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
