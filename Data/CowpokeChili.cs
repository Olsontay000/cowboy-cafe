﻿/*

* Author: Nathan Bean

* Edited by: Taylor Olson

* Class name: CowpokeChili.cs

* Purpose: The attributes for the menu item "Cowpoke Chili"

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class CowpokeChili : Entree, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private bool cheese = true;
        /// <summary>
        /// If the chili is topped with cheese
        /// </summary>
        public override bool Cheese
        {
            get { return cheese; }
            set 
            { 
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool sourCream = true;
        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public override bool SourCream
        {
            get { return sourCream; }
            set 
            { 
                sourCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SourCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool greenOnions = true;
        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public override bool GreenOnions
        {
            get { return greenOnions; }
            set 
            { 
                greenOnions = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GreenOnions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool tortillaStrips = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public override bool TortillaStrips
        {
            get { return tortillaStrips; }
            set 
            {
                tortillaStrips = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TortillaStrips"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        
        }

        /// <summary>
        /// The price of the chili
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.10;
            }
        }

        /// <summary>
        /// The calories of the chili
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 171;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!sourCream) instructions.Add("hold sour cream");
                if (!greenOnions) instructions.Add("hold green onions");
                if (!tortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;
            }
        }
        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string of the menu item, Cowpoke Chili</returns>
        public override string ToString()
        {
            return "Cowpoke Chili";
        }
    }
}

