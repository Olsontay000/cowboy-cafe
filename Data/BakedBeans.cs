﻿/*

* Author: Taylor Olson

* Class name: BakedBeans.cs

* Purpose: The attributes for the side item "Baked Beans"

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class representing a Baked Beans side
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// Set value for calories of Baked Beans depending on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Set value for price of Baked Beans depending on size
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
        }
    }
}