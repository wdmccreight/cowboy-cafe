using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink
    /// </summary>
    public class TexasTea : Drink
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
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
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
                        return Sweet? (uint) 10 : 5;
                    case Size.Medium:
                        return Sweet? (uint) 22 : 11;
                    case Size.Large:
                        return Sweet? (uint) 36 : 18;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// If drink has ice
        /// </summary>
        public override bool Ice { get; set; } = true;

        /// <summary>
        /// If drink has lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// If drink is sweet
        /// </summary>
        public bool Sweet { get; set; } = true;

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
        /// The string representation of this Texas Tea
        /// </summary>
        /// <returns>String describing Texas Tea</returns>
        public override string ToString()
        {
            if(Sweet)
            {
                return Size + " Texas Sweet Tea";
            }
            return Size + " Texas Plain Tea";
        }
    }
}
