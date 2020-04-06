/*

* Author: Taylor Olson

* Class name: OrderControl.xaml.cs

* Purpose: The CS file for our orden control UI, used for event handling

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Initializing values such as the data
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();

            var data = new Order();

            this.DataContext = data;
        }
        /// <summary>
        /// Clears the order instance and creates a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
        /// <summary>
        /// Clears the order instance and creates a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {

            //this.EntireGrid.Children = new TransactionControl();
            //TransactionControl transControl = new TransactionControl();
            //this.Visibility = Visibility.Hidden;
            //transControl.Show();
            ItemSelection.Visibility = System.Windows.Visibility.Hidden;
            CancelOrder.Visibility = System.Windows.Visibility.Hidden;
            CompleteOrder.Visibility = System.Windows.Visibility.Hidden;
            OrderList.Visibility = System.Windows.Visibility.Hidden;
            Container.Child = new TransactionControl();
            //this.DataContext = new Order();
            //TransactionControl transcontrol = new TransactionControl();
            //transcontrol.Content = null;
            //EntireGrid.Children.Remove(OrderSummaryControl);
            //EntireGrid.Children.Add(transcontrol.FullGrid);

        }
        /// <summary>
        /// Swaps to menu item selection cotrols
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }
        /// <summary>
        /// Swaps the screen with the item customization screen
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }

    }
}
