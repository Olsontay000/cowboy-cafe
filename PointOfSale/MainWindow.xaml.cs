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
        }
    }
}
