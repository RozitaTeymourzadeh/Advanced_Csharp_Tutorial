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
/*This project is built using Data Model Entity connection using SQL server. It is geneeted by add -> new Item -> ADO.NetEntity Data Model -> EF Designer and connect (localdb)\v11.0 to masterdb model*/
namespace Mod07Demo01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        msdbEntities context = new msdbEntities();// This line will be added to get access to context pin ao msdbEntity database
        public MainWindow()
        {
            InitializeComponent();
            customerList.ItemsSource = context.syspolicy_policy_categories_internal.ToList(); // context.xxx is lazy loading in otder to force to load we will add .ToList method
        }

        private void customerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            syspolicy_policy_categories_internal current = customerList.SelectedItem as syspolicy_policy_categories_internal;
            details.Text = (current != null ? current.Details : "");
        }

        private void get_data_Click(object sender, RoutedEventArgs e)
        {

        }

        private void read_and_modify_Click(object sender, RoutedEventArgs e)
        {
            syspolicy_policy_categories_internal bob = context.syspolicy_policy_categories_internal.Last(c => c.name == "Availibility database warnings");
            bob.Status = CustomerStatusEnum.Platinum;
            context.syspolicy_policy_categories_internal.Add(new syspolicy_policy_categories_internal { name = "Test", Status = CustomerStatusEnum.Gold });
            context.SaveChanges();
            customerList.ItemsSource = context.syspolicy_policy_categories_internal.ToList();

        }

        private void query_data_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            //var customers = from c in context.syspolicy_policy_categories_internal
            //                where c.Status == CustomerStatusEnum.Platinum
            //                orderby c.name
            //                select c;
            //customerList.ItemsSource = customers.ToList();
            /*this extension method is replacement of above line*/
            customerList.ItemsSource = context.syspolicy_policy_categories_internal.Where(c => c.dbpolicy_category_id == 1).OrderBy(c => c.name).ToList();
            var stats = from c in context.syspolicy_policy_categories_internal
                        group c by c.dbpolicy_category_id into s
                        select new { status = (CustomerStatusEnum)s.Key, CustCount = s.Count() };
            foreach(var stat in stats)
            {
                sb.AppendFormat("{0} - {1}\n", stat.status, stat.CustCount);
            }
            details.Text = sb.ToString();
        }
    }
}
;