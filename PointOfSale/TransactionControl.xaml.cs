using System.Windows;
using System.Windows.Controls;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl()
        {
            InitializeComponent();
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            this.DataContext = new MenuItemSelectionControl();
            //this.DataContext = new Order();
        }

        private void OnCashClick(object sender, RoutedEventArgs e)
        {

        }

        private void OnCreditClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
