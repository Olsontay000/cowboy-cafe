using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
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
        public bool Sweet { get; set; } = true;
        public bool Lemon { get; set; } = false;
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) { instructions.Add("Hold Ice"); }
                if (Lemon) { instructions.Add("Add Lemon"); }
                return instructions;
            }
        }


    }
}
