/*

* Author: Taylor Olson

* Class name: OrderSummaryControl.xaml.cs

* Purpose: OrderSummaryControl used to hold the space for the menuitemselection buttons

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PointOfSale.ExtensionMethods;
using CowboyCafe.Data;
using PointOfSale.CustomizationScreens;
using PointOfSale.CustomizationStreams;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        /// <summary>
        /// Initializes
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The event handler when an item inside of the listbox is clicked to change the screen
        /// </summary>
        /// <param name="sender">Object clicked</param>
        /// <param name="e">Event args</param>
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(List.SelectedItem == null)
            {
                return;
            }

            if (List.SelectedItem.ToString().Contains("Angry Chicken"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new AngryChickenCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }

            else if (List.SelectedItem.ToString().Contains("Cowpoke Chili"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new CowpokeChiliCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }

            else if (List.SelectedItem.ToString().Contains("Trail Burger"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new TrailBurgerCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }

            else if (List.SelectedItem.ToString().Contains("Pecos Pulled Pork"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }

            else if (List.SelectedItem.ToString().Contains("Dakota Double Burger"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new DakotaDoubleBurgerCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }

            else if (List.SelectedItem.ToString().Contains("Texas Triple Burger"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new TexasTripleBurgerCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }

            else if (List.SelectedItem.ToString().Contains("Baked Beans"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new BakedBeansCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }

            else if (List.SelectedItem.ToString().Contains("Chili Cheese Fries"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new ChiliCheeseFriesCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }

            else if (List.SelectedItem.ToString().Contains("Corn Dodgers"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new CornDodgersCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }

            else if (List.SelectedItem.ToString().Contains("Pan de Campo"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new PanDeCampoCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }

            else if (List.SelectedItem.ToString().Contains("Jerked Soda"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new JerkedSodaCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }

            else if (List.SelectedItem.ToString().Contains("Texas Sweet Tea") | List.SelectedItem.ToString().Contains("Texas Plain Tea"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new TexasTeaCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }

            else if (List.SelectedItem.ToString().Contains("Cowboy Coffee"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new CowboyCoffeeCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }

            else if (List.SelectedItem.ToString().Contains("Water"))
            {
                var orderControl = this.FindAncestor<MainWindow>();
                var screen = new WaterCustomization();
                screen.DataContext = List.SelectedItem;
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// The event handler for the click of the remove button
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">Event args</param>
        private void OnRemoveItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var Button = sender as Button;
                var Item = Button.DataContext as IOrderItem;
                order.Remove(Item);
            }
            return;
        }
    }
}
