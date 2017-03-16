using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod06Demo03
{
    class Program
    {
        private const string binFile = @"C:\tmp\stream.bin";
        private const string textFile = @"C:\tmp\stream.txt";
        static void Main(string[] args)
        {
            writeDataBinary();
            readDataBinary();
            writeDataText();
            readDataText();
            Console.ReadLine();
        }

        private static void writeDataBinary()
        {
            string s = "This is a string";
            int i = 5;
            DateTime dt = DateTime.Now;
            var stream = new FileStream(binFile, FileMode.Create, FileAccess.Write);
            var wr = new BinaryWriter(stream);
            wr.Write(s);
            wr.Write(i);
            wr.Write(dt.ToBinary());// To write in Binary format
            stream.Close();
        }
        private static void readDataBinary()
        {
            string s;
            int  i;
            DateTime dt;// for Binary Format only
            var stream = new FileStream(binFile, FileMode.Open, FileAccess.Read);
            var rdr = new BinaryReader(stream);// for Binary Format only
            s = rdr.ReadString();// for Binary Format only
            i = rdr.ReadInt32(); // for Binary Format only
            dt = DateTime.FromBinary(rdr.ReadInt64());// for Binary Format only
            stream.Close();
            Console.Write("String:{0}\nInteger: {1}\nDate: {2}", s, i, dt);
        }
        private static void writeDataText()
        {
            string s = "This is a string";
            int i = 5;
            DateTime dt = DateTime.Now;
            using (var stream = new FileStream(binFile, FileMode.Create, FileAccess.Write))
            {
                var wr = new StreamWriter(stream);
                wr.Write(string.Format("{0:0000}", s.Length));
                wr.Write(s);
                wr.Write(string.Format("{0:0000}", i));
                wr.Write(dt.ToShortDateString());// To write in text format
                wr.Flush(); // To write in text format
                //stream.Close();

            }

        }
        private static void readDataText()
        {
            string s;
            int length, i;
            char[] buffer = new char[1024];
            var stream = new FileStream(binFile, FileMode.Open, FileAccess.Read);
            var rdr = new StreamReader(stream);
            rdr.Read(buffer, 0, 4);// Read from index 0 to 4 in buffer
            length = int.Parse(getString(buffer, 4));
            rdr.Read(buffer, 0, length);
            s = getString(buffer, length);
            rdr.Read(buffer, 0, 4);
            i = int.Parse(getString(buffer, 4));
            stream.Close();
            Console.Write("String:{0}\nInteger: {1}\nDate: {2}", s, i);

        }

        private static string getString(char[] buffer, int v)
        {
            throw new NotImplementedException();
        }
    }
}
