using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public Size Size 
        {
            get 
            {
                return size;
            }
            set 
            {
                size = value;
                NotifyOfPropertyChange(new List<string>() { "Size", "Price", "Calories" });
            } 
        }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        protected void NotifyOfPropertyChange(List<string> propertiesChanged)
        {
            foreach (string property in propertiesChanged)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
