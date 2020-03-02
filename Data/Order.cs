using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        private static uint lastOrderNumber = 0;

        private List<IOrderItem> items;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach(IOrderItem item in items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }


        public IEnumerable<IOrderItem> Items
        {
            get
            {
                return items.ToArray();
            }
        }
        public uint OrderNumber
        {
            get
           {
                return lastOrderNumber + 1;
           }
        }

        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
