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

namespace Mod09Demo01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Customer fc = Utilities.GetCustomers().First() as Customer;
            customerInfo.DataContext = fc;
        }


        //private void reload_click(object sender, RoutedEventArgs e)
        //{
        //    action.Text = "Reloaded";
        //}

        //private void save_click(object sender, RoutedEventArgs e)
        //{
        //    action.Text = "Saved";
        //}

        //private void cancel_Click(object sender, RoutedEventArgs e)
        //{
        //    action.Text = "Cancelled";
        //}

        /*Add bubling handler*/
        private void StackPanel_click(object sender, RoutedEventArgs e)
        {
            Button button = e.OriginalSource as Button;
            if (button != null)
            {
                action.Text = button.Content.ToString();
            }
        }

        private void StatusControl_SelectionChanged(object sender, EventArgs e)
        {
            action.Text = status.Status.ToString();
        }
    }
}
