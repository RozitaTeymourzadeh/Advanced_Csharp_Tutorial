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

namespace Mod04Demo01
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
            if(customerList.SelectedItem == null) { return; }
            Customer current = (Customer)customerList.SelectedItem;//ListBox
            details.Text = current.Details();//ToolBox
        }

        private void constructors_Click(object sender, RoutedEventArgs e)
        {
            customerList.Items.Add(new Customer(100,"Rozita"));
            customerList.Items.Add(new Customer("Anita", CustomerStatusEnum.Platinume, "ann@cust.com"));
            customerList.Items.Add(new Customer(100,"Rozita"));
        }
 

        private void statics_Click(object sender, RoutedEventArgs e)
        {
            foreach (Customer cust in Utilities.GetCustomers())
            {
                customerList.Items.Add(cust);
            }
        }
    }
}
