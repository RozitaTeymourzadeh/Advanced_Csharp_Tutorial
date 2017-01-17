using System;
using System.Text;
using System.Text.RegularExpressions;
using Mod01Demo04.GreetingNamespace;



namespace Mod01Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            int I;
            I = 5;
            DateTime dt = DateTime.Now;
            DateTime dFuture = dt.AddDays(I);
            int J = I * 5;
            string S = "This is a string";
            J = J + 6;
            J += 6;
            J++;
            Console.WriteLine(I);
            Console.WriteLine(dt);
            Console.WriteLine(dFuture);
            Console.WriteLine(J);
            Console.WriteLine(S);
            #endregion
            #region Casting
            int c = 10;
            long h = c * 10;//Implicity casting
            c = (int)h;//Explicity casting
            string sDate = "01/01/2015";
            DateTime dt1 = DateTime.Parse(sDate);
            string result = dt1.ToString();
            Console.WriteLine(dt1);
            Console.WriteLine(result);
            #endregion
            #region DataManipulation
            string data = "First Number";
            data += "\n \r Second Number";
            data += @"\n Third Number \\...";
            Console.WriteLine(data);
            //same code in top and down, different way of implementation. 
            string data1;
            StringBuilder sb = new StringBuilder();
            sb.Append("\t First Number");
            sb.Append("\n \r Second Number");
            sb.Append("\n Third Number \\...");
            data1 = sb.ToString();
            Console.WriteLine(data1.ToUpper());

            string formatted = string.Format("Demo: {0} \n {1}",dt,data1);
            // Console.WriteLine(formatted);

            string Test_Text = "Hell0 W0rld!";
            string re = "\\d";
            var r = Regex.Match(Test_Text, re, RegexOptions.None);
            if(r.Success)
            {
                Console.WriteLine("Match");
            }
            #endregion
            #region  Conditional logic
            Console.WriteLine("Enter a number");
            String input = Console.ReadLine();
            int value = int.Parse(input);
            if (value == 10)
            {
                Console.WriteLine("The value is 10 (if)");
            }
            else if(value > 10)
            {
                Console.WriteLine("The value is Big (if)");
            }
            else
            {
                Console.WriteLine("The value is small (if)");
            }

            switch (value) { 
                case 9:
            Console.WriteLine("the entered value is 9 (switch)");
            break;
            case 10: 
            Console.WriteLine("the value is 10 (switch)");
            break;
            default:
            Console.WriteLine("the value is {0} (switch)\n", value);
            break;
            }
            #endregion
            #region iteration
            Console.WriteLine("Enter a number in iteration region");
            String input1 = Console.ReadLine();
            int value1 = int.Parse(input1);
            while (value1 != 10)
            {
                Console.WriteLine("Guess Again");
                input1 = Console.ReadLine();
                value1 = int.Parse(input1);
            }
            Console.WriteLine("This is correct No!(While)");


            do
            {
                Console.WriteLine("Guess Again");
                input1 = Console.ReadLine();
                value1 = int.Parse(input1);
            } while (value1 != 10);
                Console.WriteLine("This is correct No!(do-While)");

            for (int lcv=0; lcv<100; lcv++)
            {
                if(lcv == value1)
                {
                    Console.WriteLine("{0} is the value1",lcv);
                    break;
                }
                else
                {
                    Console.WriteLine("{0} is NOT the value1",lcv);
                }
            }


            #endregion
            #region String
            string[] names = new string[5];
            names[0] = "Bob0";
            names[1] = "Bob1";
            names[2] = "Bob2";
            names[3] = "Bob3";
            names[4] = "Bob4";

            string[,] locations = new string[2, 2];
            locations[0, 0] = "Africa";
            locations[0, 1] = "Asia";
            locations[1, 0] = "Europe";
            locations[1, 1] = "America";

            string[][] companies = new string[2][];
            companies[0] = new string[2];
            companies[1] = new string[3];

            companies[0][0] = "Company1_Bob";
            companies[0][1] = "Company1_Sue";
            companies[0][1] = "Company1_Sue";
            companies[1][0] = "Company2_Linda";
            companies[1][1] = "Company2_Ashely";
            companies[1][2] = "Company2_Ben";

            string[] employees = { "Pan", "Ann", "Roz", "Sue", "Ashley", "Ben"};

            foreach(string emp in employees)
            {
                Console.WriteLine(emp);
            }
            #endregion
            #region Referencing NameSpaces_nameSpace_Class/object_Method
            bool fileExit = System.IO.File.Exists(@"c:\Test.txt");
            DemoGreetingClass gr = new DemoGreetingClass();
            Console.WriteLine(gr.Greetingmethod());
            #endregion

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
