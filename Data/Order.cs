using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private List<IOrderItem> items = new List<IOrderItem>();

        public static uint OrderNumber { get; set;} = 0;

        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); }  }

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

        public void Add(IOrderItem item) 
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
