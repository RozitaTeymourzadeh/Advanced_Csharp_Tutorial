using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace Mod06Demo01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string textFile = @"C:\tmp\text.txt";
        private string linesFile = @"C:\tmp\lines.txt";
        ObservableCollection<String> items = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            display.ItemsSource = items;
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            items.Add(textBox.Text);// Add(Destination, Source)
            textBox.Text = "";
            textBox.Focus();

        }

        private void SAVE_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(textFile,textBox.Text); 
        }

        private void LOAD_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = File.ReadAllText(textFile);
        }

        private void SAVE_ALL_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllLines(linesFile, items);
        }

        private void LOAD_ALL_Click(object sender, RoutedEventArgs e)
        {
            items.Clear();
            string[] itemsFromFile = File.ReadAllLines(linesFile);
            foreach (string item in itemsFromFile)
            {
                items.Add(item);
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
