using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
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
    /// Add soap as reference assembly to the project. 
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string binFile = @"C:\tmp\people.bin";
        private const string xmlFile = @"C:\tmp\people.xml";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            customerList.ItemsSource = Utilities.GetCustomers();
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            //var formatter = new BinaryFormatter();// for serializing in binary format 
            var formatter = new SoapFormatter();// for serializing in xml format 
            var stream = File.OpenRead(xmlFile);// the file is opened in Load status
            People people = formatter.Deserialize(stream) as People;
            stream.Close();
            customerList.ItemsSource = people;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            People people = customerList.ItemsSource as People;
            if (people == null) { return; }
           //var formatter = new BinaryFormatter();// for serializing in binary format 
            var formatter = new SoapFormatter();// for serializing in xml format 
            var stream = File.Create(xmlFile); // the file is created in Save status
            formatter.Serialize(stream, people);// take people object and save in stream seialization
            stream.Close();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void customerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (customerList.SelectedItem == null) return;
            Person current = customerList.SelectedItem as Person;
            if (current != null)
            {
                details.Text = current.Details();
            }
        }
    }
}
