/*Mod08: Referencing a WCF Data Source and Retrieving and Modifying Data*/
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
using S = Mod08Demo03.DSCustomers;// DSCustomers is Data Service namespace that is generated using the following steps
/*this is Wb Data Service item*/
/*After modify this file follow the following steps:*/
/*1. Right click on Referrence*/
/*2. Select Add Service Reference */
/*3. put your service local host address http://localhost:50267/Customers.svc/ and press go to find server "Customer management here"* /
 /*4. Name it as DSCustomer to generate namespace of customer and EDM */
namespace Mod08Demo03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void get_data_Click(object sender, RoutedEventArgs e)
        {
            var context = new S.CustomerManagementEntities(new Uri("http://localhost:50267/Customers.svc/"));
            customerList.ItemsSource = context.Customers.ToList();
        }

        private void customerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void query_data_Click(object sender, RoutedEventArgs e)
        {
            var context = new S.CustomerManagementEntities(new Uri("http://localhost:50267/Customers.svc/"));
            customerList.ItemsSource = context.Customers.where(c=>c.Status ==1).OrderBy(c => c.name).ToList();
        }

        private void update_data_Click(object sender, RoutedEventArgs e)
        {
            var context = new S.CustomerManagementEntities(new Uri("http://localhost:50267/Customers.svc/"));
            var newcust = new S.Customer { Name = "Service Customer", Stats = 1, Email = "sc@cust.com" };
            context.AddToCustomers(newcust);
            context.SaveChanges();
            customerList.ItemsSource = context.Customers.ToList();
        }
    }
}
