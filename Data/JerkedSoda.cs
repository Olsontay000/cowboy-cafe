/*

* Author: Taylor Olson

* Class name: JerkedSoda.cs

* Purpose: The attributes for the menu item "Jerked Soda"

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda drink, inheriting the "Drink.cs" base class
    /// </summary>
    public class JerkedSoda : Drink
    {
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
        public SodaFlavor Flavor { get; set; }
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
