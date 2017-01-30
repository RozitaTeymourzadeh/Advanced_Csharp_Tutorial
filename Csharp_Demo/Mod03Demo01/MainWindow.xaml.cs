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
            Customer current = (Customer)CustomerList.SelectedItem;
            details.Text= current.Details();
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
            var util = new Utilities();
            var customers = util.GetCustomers();
            foreach (Customer cust in customers)
            {
                CustomerList.Items.Add(cust);
            }
        }
    }
}
