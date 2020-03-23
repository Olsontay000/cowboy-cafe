/*

* Author: Taylor Olson

* Class name: ChiliCheeseFries.cs

* Purpose: The attributes for the side item "Chili Cheese Fries"

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class representing a Chili Cheese Fries side
    /// </summary>
    public class ChiliCheeseFries : Side, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
        public override bool IsSmall
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
        public override bool IsMedium
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
        public override bool IsLarge
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
        /// Set value for calories of Chili Cheese Fries depending on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Set value for price of Chili Cheese Fries depending on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
          
        }
        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string of the menu item, Chili Cheese Fries</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Large:
                    return "Large Chili Cheese Fries";
                case Size.Medium:
                    return "Medium Chili Cheese Fries";
                case Size.Small:
                    return "Small Chili Cheese Fries";
                default:
                    return "Unknown selection";
            }
        }
    }
}
