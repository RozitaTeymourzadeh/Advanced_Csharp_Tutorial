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

namespace Mod03Demo01 // Suould be the same Name with Customer namespace, so it can be used in this file. 
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int nextID = 1;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CustomerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CustomerList.SelectedItem == null)// to fix null reference bug
            {
                return;
            }
            Customer current = (Customer)CustomerList.SelectedItem;
            /*To show Hash Table */
            var util = new Utilities();
            var customers = util.GetCustomers2();
            if (customers[current.Name] == null)// to fix null reference bug
            {
                return;
            }
            Customer cust = (Customer)customers[current.Name];//a way to access hash table collection key

            details.Text= cust.Details();
        }
        private void Struct_Click_1(object sender, RoutedEventArgs e)
        {
            /* the lines commented to implement it using constructor */
            //Customer cust = new Customer();// needs to be changed from "Customer cust;" to "Customer cust = new Customer();" because Name from struct Field concerted to Struct 
            //cust.ID = nextID++;
            //cust.Name = customerName.Text;
            //cust.Status = CustomerStatusEnum.Gold;
            //cust.Email = cust.Name + "@cust.com";
            //CustomerList.Items.Add(cust);

            CustomerList.Items.Add(new Customer(nextID++, customerName.Text + "@cust.com", CustomerStatusEnum.Gold, customerName.Text));// constructor
        }

        private void collection_Click(object sender, RoutedEventArgs e)
        {
            /*To show  customer in array list collection*/
            //var util = new Utilities();
            //var customers = util.GetCustomers();
            //foreach (Customer cust in customers)
            //{
            //    CustomerList.Items.Add(cust);
            //}
            /*To show  customer in Hash Table collection*/
            var util = new Utilities();
            var customers = util.GetCustomers2();
            foreach (Customer cust in customers.Values)
            {
                CustomerList.Items.Add(cust);
            }
        }

        private void query_Click(object sender, RoutedEventArgs e)
        {
            var utils = new Utilities();
            CustomerList.Items.Clear();
            var customers = utils.GetCustomers();
            var gold = from Customer c in customers
                       where c.Status == CustomerStatusEnum.Silver
                       orderby c.Name
                       select c;
            foreach(var customer in gold)
            {
                CustomerList.Items.Add(customer);
            }

        }
    }
}
