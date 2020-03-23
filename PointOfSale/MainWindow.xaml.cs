/*

* Author: Taylor Olson

* Class name: MainWindow.xaml.cs

* Purpose: The Main window xaml cs file used to hold the 3 buttons at the top

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

//This should be in ordercontrol oops
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializing values such as the data
        /// </summary>
        public MainWindow()
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
            this.DataContext = new Order();
            
        }
        /// <summary>
        /// Unused currently
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
