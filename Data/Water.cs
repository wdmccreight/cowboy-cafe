using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Water drink
    /// </summary>
    public class Water : Drink
    {
        
        /// <summary>
        /// Get price of drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// Get calories of drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// If drink has ice
        /// </summary>
        public override bool Ice { get; set; } = true;

        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Get special instructions of drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("hold ice");
                if (Lemon) instructions.Add("add lemon");

                return instructions;
            }
        }

        /// <summary>
        /// The string representation of this Water
        /// </summary>
        /// <returns>String describing Water</returns>
        public override string ToString()
        {
            return Size + " Water";
        }
    }
}
