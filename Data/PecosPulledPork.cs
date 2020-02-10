using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// If the entree has bread
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// If the entree has pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Price of entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }
        /// <summary>
        /// Calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
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

                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}
