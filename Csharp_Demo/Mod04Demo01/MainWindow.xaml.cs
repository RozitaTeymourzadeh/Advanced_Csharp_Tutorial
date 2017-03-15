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

namespace Mod06Demo02
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

        private void customerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(customerList.SelectedItem == null) return;
            IDisplay current = customerList.SelectedItem as IDisplay;//ListBox
            /*Option 1 using IDisplay*/
            if (current != null)
            {
                details.Text = current.Details();
            }
            /*Option 2 */
            //Customer cust = current as Customer; // "as" cast the current to customer type and return null if the object is not customer
            //if (cust != null)
            //{
            //    details.Text = cust.Details();
            //}
            //else
            //{
            //    Prospect prosp = current as Prospect;
            //    if(prosp != null)
            //    {
            //        details.Text = prosp.Details();
            //    }
            //}
            // details.Text = current.Details();//ToolBox
        }

        private void constructors_Click(object sender, RoutedEventArgs e)
        {
            customerList.Items.Add(new Customer(100,"Rozita"));
            customerList.Items.Add(new Customer("Anita", CustomerStatusEnum.Platinume, "ann@cust.com"));
            customerList.Items.Add(new Customer(100,"Rozita"));
        }
 

        private void statics_Click(object sender, RoutedEventArgs e)
        {
            foreach (object cust in Utilities.GetCustomers())// since cust could be "customer" or "prospect" we put object
            {
                customerList.Items.Add(cust);
            }
        }
    }
}
