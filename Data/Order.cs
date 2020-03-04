using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Event for when the Orders properties change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// List of Items in the order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// The unique order number
        /// </summary>
        public static uint OrderNumber { get; set;} = 0;

        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); }  }

        /// <summary>
        /// The Order Subtotal
        /// </summary>
        public double Subtotal 
        {
            get
            {
                double total = 0;
                foreach (IOrderItem item in items)
                {
                    total += item.Price;
                }

                return total;
            }
        }

        /// <summary>
        /// Add new Item to the order
        /// </summary>
        /// <param name="item">Item to Add</param>
        public void Add(IOrderItem item) 
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Remove an Item from the order
        /// </summary>
        /// <param name="item">Item to Remove</param>
        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
