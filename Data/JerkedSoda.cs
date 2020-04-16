/*

* Author: Taylor Olson

* Class name: JerkedSoda.cs

* Purpose: The attributes for the menu item "Jerked Soda"

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda drink, inheriting the "Drink.cs" base class
    /// </summary>
    public class JerkedSoda : Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool ice = true;
        private Size size = Size.Small;
        private SodaFlavor flavor = SodaFlavor.CreamSoda;

        /// <summary>
        /// Constructor for ice
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
        /// The price of the soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// The calories of the soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// Determines what flavor the soda should be, no default
        /// </summary>
        public SodaFlavor Flavor
        {
            get
            {
                return this.flavor;
            }
            set
            {
                this.flavor = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SodaFlavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsBirchBeer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsCreamSoda"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsOrangeSoda"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRootBeer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsSarsparilla"));
            }
        }

        /// <summary>
        /// Constructor if Birch Beer is selected
        /// </summary>
        public bool IsBirchBeer
        {
            get
            {
                return Flavor == SodaFlavor.BirchBeer;
            }
            set
            {
                Flavor = SodaFlavor.BirchBeer;
            }
        }
        /// <summary>
        /// Constructor if cream soda is selected
        /// </summary>
        public bool IsCreamSoda
        {
            get
            {
                return Flavor == SodaFlavor.CreamSoda;
            }
            set
            {
                Flavor = SodaFlavor.CreamSoda;
            }
        }
        /// <summary>
        /// Constructor if orange soda is selected
        /// </summary>
        public bool IsOrangeSoda
        {
            get
            {
                return Flavor == SodaFlavor.OrangeSoda;
            }
            set
            {
                Flavor = SodaFlavor.OrangeSoda;
            }
        }
        /// <summary>
        /// Constructor if root beer is selected
        /// </summary>
        public bool IsRootBeer
        {
            get
            {
                return Flavor == SodaFlavor.RootBeer;
            }
            set
            {
                Flavor = SodaFlavor.RootBeer;
            }
        }
        /// <summary>
        /// Constructor if sarsparilla is selected
        /// </summary>
        public bool IsSarsparilla
        {
            get
            {
                return Flavor == SodaFlavor.Sarsparilla;
            }
            set
            {
                Flavor = SodaFlavor.Sarsparilla;
            }
        }

        /// <summary>
        /// Special instructions to prepare the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) { instructions.Add("Hold Ice"); }
                return instructions;
            }
        }
        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The string of the menu item, Jerked Soda</returns>
        public override string ToString()
        {
            if (Flavor == SodaFlavor.BirchBeer)
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Birch Beer Jerked Soda";
                    case Size.Medium:
                        return "Medium Birch Beer Jerked Soda";
                    case Size.Small:
                        return "Small Birch Beer Jerked Soda";
                    default:
                        return "Unknown selection";
                }

            }
            else if (Flavor == SodaFlavor.CreamSoda)
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Cream Soda Jerked Soda";
                    case Size.Medium:
                        return "Medium Cream Soda Jerked Soda";
                    case Size.Small:
                        return "Small Cream Soda Jerked Soda";
                    default:
                        return "Unknown selection";
                }
            }
            else if (Flavor == SodaFlavor.OrangeSoda)
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Orange Soda Jerked Soda";
                    case Size.Medium:
                        return "Medium Orange Soda Jerked Soda";
                    case Size.Small:
                        return "Small Orange Soda Jerked Soda";
                    default:
                        return "Unknown selection";
                }
            }
            else if (Flavor == SodaFlavor.RootBeer)
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Root Beer Jerked Soda";
                    case Size.Medium:
                        return "Medium Root Beer Jerked Soda";
                    case Size.Small:
                        return "Small Root Beer Jerked Soda";
                    default:
                        return "Unknown selection";
                }
            }
            else if (Flavor == SodaFlavor.Sarsparilla)
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Sarsparilla Jerked Soda";
                    case Size.Medium:
                        return "Medium Sarsparilla Jerked Soda";
                    case Size.Small:
                        return "Small Sarsparilla Jerked Soda";
                    default:
                        return "Unknown selection";
                }
            }
            else
            {
                return "Unknown Flavor";
            }
        }
    }
}
