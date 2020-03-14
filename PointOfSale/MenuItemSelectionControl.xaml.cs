/*

* Author: Taylor Olson

* Class name: MenuItemSelectionControl.xaml.cs

* Purpose: The menu item selection control xaml cs files used to handle all eventhandlers and check their validity

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
using CowboyCafe.Data;
using PointOfSale.CustomizationScreens;
using PointOfSale.CustomizationStreams;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for clicking the Trail Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new TrailBurger();
                    var screen = new TrailBurgerCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Cowpoke Chili button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new CowpokeChili();
                    var screen = new CowpokeChiliCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Angry Chicken button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new AngryChicken();
                    var screen = new AngryChickenCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Rustler's Ribs button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new RustlersRibs());
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Peco's Pulled Pork button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new PecosPulledPork();
                    var screen = new PecosPulledPorkCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Dakota Double Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new DakotaDoubleBurger();
                    var screen = new DakotaDoubleBurgerCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Texas Triple Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new TexasTripleBurger();
                    var screen = new TexasTripleBurgerCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Baked Beans button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new BakedBeans();
                    var screen = new BakedBeansCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Chili Cheese Fries button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new ChiliCheeseFries();
                    var screen = new ChiliCheeseFriesCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Corn Dodgers button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new CornDodgers();
                    var screen = new CornDodgersCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Pan De Campo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPandeCampo_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new PanDeCampo();
                    var screen = new PanDeCampoCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Jerked Soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new JerkedSoda();
                    var screen = new JerkedSodaCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Texas Tea button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new TexasTea();
                    var screen = new TexasTeaCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Cowboy Coffee button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new CowboyCoffee();
                    var screen = new CowboyCoffeeCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
        /// <summary>
        /// Event handler for clicking the Water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            var orderConrol = this.FindAncestor<MainWindow>(); //Change to order control oops
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new Water();
                    var screen = new WaterCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderConrol?.SwapScreen(screen);
                }
            }
        }
    }
}
