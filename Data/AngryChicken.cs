/*

* Author: Taylor Olson

* Class name: AngryChicken.cs

* Purpose: The attributes for the menu item "Angry Chicken"

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing an AngryChicken entree
    /// </summary>
    public class AngryChicken : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool bread = true;

        private bool pickle = true;
        /// <summary>
        /// If the AngryChicken is served with bread
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
        /// If the AngryChicken is served with pickle
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
        /// The price of the AngryChicken
        /// </summary>
        public override double Price
        {
            get { return 5.99; }
        }
        /// <summary>
        /// The calories within the AngryChicken
        /// </summary>
        public override uint Calories
        {
            get { return 190; }
        }
        /// <summary>
        /// The special instructions for the AngryChicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bread) { instructions.Add("hold bread"); }
                if(!Pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }

        }
        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string of the menu item, Angry Chicken</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }

    }
}
