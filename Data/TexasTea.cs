/*

* Author: Taylor Olson

* Class name: TexasTea.cs

* Purpose: The attributes for the menu item "Texas Tea"

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink, inheriting the "Drink.cs" base class
    /// </summary>
    public class TexasTea : Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool lemon = false;
        private bool ice = true;
        private bool sweet = true; //to be used when tracking calories
        private Size size = Size.Small;

        /// <summary>
        /// Constructor for size that also updates INotifyProperty
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsSmall"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsMedium"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsLarge"));
            }
        }
        /// <summary>
        /// Constructor if the size small is selected
        /// </summary>
        public bool IsSmall
        {
            get
            {
                return Size == Size.Small;
            }
            set
            {
                Size = Size.Small;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        /// <summary>
        /// Constructor is the size medium is selected
        /// </summary>
        public bool IsMedium
        {
            get
            {
                return Size == Size.Medium;
            }
            set
            {
                Size = Size.Medium;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        /// <summary>
        /// Constructor if the size large is selected
        /// </summary>
        public bool IsLarge
        {
            get
            {
                return Size == Size.Large;
            }
            set
            {
                Size = Size.Large;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// The price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// The calories of the tea, sweetner halfs the calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        if (!Sweet) { return 18; }
                        return 36;
                    case Size.Medium:
                        if (!Sweet) { return 11; }
                        return 22;
                    case Size.Small:
                        if (!Sweet) { return 5; }
                        return 10;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// If the tea contains sweetner, default is true
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// If the tea contains lemon, default is false
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// If the tea contains ice, default is true
        /// </summary>
        public override bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sweet) { instructions.Add("Unsweetened"); }
                if (!Ice) { instructions.Add("Hold Ice"); }
                if (Lemon) { instructions.Add("Add Lemon"); }
                return instructions;
            }
        }
        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string of the menu item, Texas Tea</returns>
        public override string ToString()
        {
            if(Sweet)
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Texas Sweet Tea";
                    case Size.Medium:
                        return "Medium Texas Sweet Tea";
                    case Size.Small:
                        return "Small Texas Sweet Tea";
                    default:
                        return "Unknown selection";
                }
            }
            else
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Texas Plain Tea";
                    case Size.Medium:
                        return "Medium Texas Plain Tea";
                    case Size.Small:
                        return "Small Texas Plain Tea";
                    default:
                        return "Unknown selection";
                }
            }
        }

    }
}
