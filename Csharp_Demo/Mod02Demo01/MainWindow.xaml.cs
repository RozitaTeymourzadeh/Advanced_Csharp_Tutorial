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

namespace Mod02Demo01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Utilities utils = new Utilities();
           // customerList.ItemSourse = utils.GetCustomer();
            // To generate custom exception
            var ex = new NullReferenceException("The Name parameter is Null");
            //throw ex;
        }
        private void customerList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Customer current = customerList.SelectedItem as Customer;
            displayCustomer(current);
        }
        private void displayCustomer(Customer customer)
        {
            details.Text = string.Format("{0}\n{1}\n{2}", customer.Name, customer.Status, customer.Email);
        }
        private void overloaded_Click_1(object sender, RoutedEventArgs e)
        {
            Utilities util = new Utilities();
            Customer c1 = util.NewCustomer(10, "Customer 1");
            Customer c2 = util.NewCustomer(11, "Customer 2", CustomerStatusEnum.Gold, "another@email.com");
            customerList.Items.Add(c1);
            customerList.Items.Add(c2);
        }

        private void optional_Click_1(object sender, RoutedEventArgs e)
        {
            Utilities util = new Utilities();
            Customer c1 = util.NewCustomer(10, "Customer 3");
            Customer c2 = util.NewCustomer(11, "Customer 4", CustomerStatusEnum.Gold);
            customerList.Items.Add(c1);
            customerList.Items.Add(c2);
        }

        private void named_Click_1(object sender, RoutedEventArgs e)
        {
            Utilities util = new Utilities();
            Customer c1 = util.NewCustomer(ID: 20, Name: "Named1", Status: CustomerStatusEnum.Platinum);
            Customer c2 = util.NewCustomer(ID: 20, Name: "Named1"); // named parameter helps to assign the values regardless to their position
            customerList.Items.Add(c1);
            customerList.Items.Add(c2);
        }

        private void output_Click_1(object sender, RoutedEventArgs e)
        {
            Utilities util = new Utilities();
            Customer c1;
            Customer c2;
            if (util.NewValidatedCustomer(1, "Bob", out c1))
            {
                customerList.Items.Add(c1);
            }
            if (util.NewValidatedCustomer(-1, "Sue", out c2))
            {
                customerList.Items.Add(c2);
            }
            else
            {
                MessageBox.Show("Invalid customer");
            }
        }
    }
}
