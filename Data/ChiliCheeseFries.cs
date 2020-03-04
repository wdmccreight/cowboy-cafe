using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side, IOrderItem
    {
        /// <summary>
        /// Get calories of the side 
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// Get price of the side
        /// </summary>
        public override double Price 
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// Get special instructions of side
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// The string representation of this Chili Cheese Fry
        /// </summary>
        /// <returns>String describing Chili Cheese Fries</returns>
        public override string ToString()
        {
            return Size + " Chili Cheese Fries";
        }
    }
}
