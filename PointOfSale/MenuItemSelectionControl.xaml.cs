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
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new TrailBurger());
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
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new CowpokeChili());
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
            if (DataContext is CowboyCafe.Data.Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new AngryChicken());
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
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new PecosPulledPork());
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
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new DakotaDoubleBurger());
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
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new TexasTripleBurger());
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
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new BakedBeans());
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
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new ChiliCheeseFries());
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
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new CornDodgers());
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
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new PanDeCampo());
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
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new JerkedSoda());
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
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new TexasTea());
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
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new CowboyCoffee());
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
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Add(new Water());
                }
            }
        }
    }
}
