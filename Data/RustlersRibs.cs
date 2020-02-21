using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// Price of entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }
        /// <summary>
        /// Calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// List of Special Instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// The string representation of this Rustlers Ribs
        /// </summary>
        /// <returns>String describing Rustlers Ribs</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
