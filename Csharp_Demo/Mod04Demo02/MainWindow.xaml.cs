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

namespace Mod04Demo02//value Reference
{
    class Program
    {
        static void main(string[] args)
        {
            SimpleClass c1 = new SimpleClass() { Payload = "Class 1" };
            SimpleStruct s1 = new SimpleStruct() { Payload = "Struct 1" };
            SimpleClass c2 = c1;
            SimpleStruct s2 = s1;
            c2.Payload = "Class 2";
            s2.Payload = "Struct 2";

            Console.Write("Class:\n\t {0}\n{1}\n\t Struct{0}\n{1}\n", c1.Payload, c2.Payload, s1.Payload, s2.Payload);
            Console.ReadLine();
        }
    }
    public class SimpleClass
    {
        public string Payload { get; set; }
    }
    public struct SimpleStruct
    {
        public string Payload { get; set; }
    }
}
