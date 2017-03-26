using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Runtime.Serialization.Json;
/*Module 8: Lesson 1 Accessing Data Across the web */
namespace Mod08Demo01
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
            var uri = "http://localhost:3549/api/customers";
            var request = WebRequest.Create(uri) as HttpWebRequest;
            request.Method = "GET";
            request.ContentType = "application/json";
            var response = request.GetResponse() as HttpWebResponse;
            var formatter = new DataContractJsonSerializer(typeof(Customers));
            using (var stream = response.GetResponseStream())// We using "using" to make sure close the stream. 
            {
                var customers = formatter.ReadObject(stream) as Customers;
                customerList.ItemsSource = customers;
            }
        }

        private void customerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Customer current = customerList.SelectedItem as Customer;
            if (current != null)
            {
                details.Text = current.Details();
            }
        }
    }
}
