using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the CowboyCoffee drink
    /// </summary>
    public class CowboyCoffee : Drink
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
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
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
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// If drink has ice
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// If drink is decaf
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// If drink has room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Get special instructions of drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("add ice");
                if (RoomForCream) instructions.Add("room for cream");

                return instructions;
            }
        }

        /// <summary>
        /// The string representation of this Cowboy Coffee
        /// </summary>
        /// <returns>String describing Cowboy Coffee</returns>
        public override string ToString()
        {
            if(Decaf)
            {
                return Size + " Decaf Cowboy Coffee";
            }
            return Size + " Cowboy Coffee";
        }
    }
}
