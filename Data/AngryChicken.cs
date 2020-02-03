﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken
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
        public double Price
        {
            get
            {
                return 5.99;
            }
        }
        /// <summary>
        /// Calories of the entree
        /// </summary>
        public uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// List of Special Instructions
        /// </summary>
        public List<string> SpecialInstructions
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