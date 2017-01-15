﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
