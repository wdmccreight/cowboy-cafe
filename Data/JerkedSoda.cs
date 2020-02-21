using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda drink
    /// </summary>
    public class JerkedSoda : Drink
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
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
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
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
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
        /// Flavor of drink
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// Get special instructions of drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("hold ice");


                return instructions;
            }
        }

        /// <summary>
        /// The string representation of this Jerked Soda
        /// </summary>
        /// <returns>String describing Jerked Soda</returns>
        public override string ToString()
        {
            switch(Flavor)
            {
                case SodaFlavor.BirchBeer:
                    return Size + " Birch Beer Jerked Soda";
                case SodaFlavor.CreamSoda:
                    return Size + " Cream Soda Jerked Soda";
                case SodaFlavor.OrangeSoda:
                    return Size + " Orange Soda Jerked Soda";
                case SodaFlavor.RootBeer:
                    return Size + " Root Beer Jerked Soda";
                case SodaFlavor.Sarsparilla:
                    return Size + " Sarsparilla Jerked Soda";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
