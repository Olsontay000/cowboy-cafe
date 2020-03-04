/*

* Author: Taylor Olson

* Class name: Order.cs

* Purpose: The order class used to initialize and update lists of IOrderItems

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// The private static variable to keep track of the order number within the class
        /// </summary>
        private static uint lastOrderNumber = 1;
        /// <summary>
        /// creates a new list of IOrderItem for use within the class
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// The property changed event handler for the inotify property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// subtotal getter that takes all items and adds their prices together
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// Because List<T> don't update the inotify, we must make the items list an array
        /// </summary>
        public IEnumerable<IOrderItem> Items
        {
            get
            {
                return items.ToArray();
            }
        }
        /// <summary>
        /// Increments the order number whenever a new order() is made
        /// </summary>
        public uint OrderNumber
        {
            get
            {
                return lastOrderNumber++;
            }
        }
        /// <summary>
        /// The method that adds for the binding data and updates the items and subtotals
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);

            if (item is INotifyPropertyChanged pcitem) // Don't leave in
            {
                pcitem.PropertyChanged += OnItemChanged;
                //item.PropertyChanged += OnItemChanged; //Implement on every single item and IOrder Item
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
        /// <summary>
        /// The method that removes from the list for the binding data and updates the items and subtotals
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);

            if (item is INotifyPropertyChanged pcitem) // Don't leave in
            {
                pcitem.PropertyChanged -= OnItemChanged;
                //item.PropertyChanged -= OnItemChanged; //Implement on every single item and IOrder Item
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}
