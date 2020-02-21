using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger : Entree
    {
        /// <summary>
        /// If entree has Bun.
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// If entree has Ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// If entree has Mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// If entree has Pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If entree has Cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// If entree has Tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// If entree has Lecttuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// If entree has Mayo
        /// </summary>
        public bool Mayo { get; set; } = true;


        /// <summary>
        /// If entree has Bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// If entree has Egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Price of entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }
        /// <summary>
        /// Calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
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

                if (!Bun) instructions.Add("hold bun");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");
                if (!Bacon) instructions.Add("hold bacon");
                if (!Egg) instructions.Add("hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// The string representation of this Texas Triple Burger
        /// </summary>
        /// <returns>String describing Texas Triple Burger</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
