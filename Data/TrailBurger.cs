﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trail Burger entree
    /// </summary>
    public class Trailburger
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
        /// Price of entree
        /// </summary>
        public double Price
        {
            get
            {
                return 4.50;
            }
        }
        /// <summary>
        /// Calories of the entree
        /// </summary>
        public uint Calories
        {
            get
            {
                return 288;
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

                if (!Bun) instructions.Add("hold bun");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");

                return instructions;
            }
        }
    }
}