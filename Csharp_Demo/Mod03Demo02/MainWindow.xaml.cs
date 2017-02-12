using Mod03Demo01;
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

namespace Mod03Demo02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Customer customer = new Customer(2, "Bob", CustomerStatusEnum.Gold, "bob@cust.com");
        public MainWindow()
        {
            InitializeComponent();
            customer.NameChanged += Customer_NameChanged;// Subscribe to event
            activity.Items.Add("Started with " + customer.Name);
        }

        private void Customer_NameChanged(object sender, EventArgs e)// Subscribe to event
        {
            activity.Items.Add("Name Changed " + customer.Name);
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            customer.Name = customerName.Text; 
        }

        private void customerName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void activity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
