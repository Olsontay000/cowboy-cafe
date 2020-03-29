/*

* Author: Taylor Olson

* Class name: PanDeCampo.cs

* Purpose: The attributes for the menu item "Pan de Campo"

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class representing a Pan De Campo side
    /// </summary>
    public class PanDeCampo : Side, INotifyPropertyChanged
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
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
        /// Set value for calories of Pan de Campo depending on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Set value for price of Pan de Campo depending on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
            //set
            //{
                //price = value;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            //}
        }
        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string of the menu item, Pan De Campo</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Large:
                    return "Large Pan de Campo";
                case Size.Medium:
                    return "Medium Pan de Campo";
                case Size.Small:
                    return "Small Pan de Campo";
                default:
                    return "Unknown selection";
            }
        }
    }
}
