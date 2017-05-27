using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*This model should be run using start without debugging (Ctrl+F5)*/
namespace Mod10Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            var da = new DemoAsync();
            da.SlowMethod("Sample");// simple example 
            Task t1 = new Task(new Action(da.SlowAction));//call Action Task
            Task T2 = new Task(delegate { da.SlowMethod("Called from delegate"); });
            Task t3 = new Task(() => { da.SlowMethod("Lambda call"); });
            t1.Start();
            T2.Start();
            t3.Start();
            Console.WriteLine("Done");
            Console.ReadLine();
            #endregion
            /*Linking Task*/
            #region
            Task<string> t4 = new Task<String>(() =>
            {
                Thread.Sleep(1500);
                return "Task 4 complete";
            });
            Task t5 = t4.ContinueWith((input) =>
            {
                Console.WriteLine(input.Result);
                Console.WriteLine("Task 5 Completed");
            });// t4 is input for t5
            Task t6 = t5.ContinueWith((input) =>
           {
               Console.WriteLine("Task 6");
           });
            t4.Start();
            #endregion
            /*Handling Task Exception*/
            #region
            Task<string> t7 = new Task<String>(() =>
            {
                Thread.Sleep(1500);
                return "Task 7 complete";
            });
            Task t8 = new Task((input) =>
            {
                Console.WriteLine(input);
                Console.WriteLine("Task 8 Completed");
            },"Task 2 input");
            Task t9 = new Task(() =>
            {
                Console.WriteLine("Task 9");
                throw new Exception("bad logic");
            });
            try
            {
                t7.Start();
                t8.Start();
                t9.Start();
                Task.WaitAll(t7, t8, t9);
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("Exception:" + e.Message);
                }
            }
            Console.WriteLine(t7.Result);
            Console.WriteLine("Done");
            Console.ReadLine();
            #endregion

        }
        class DemoAsync
        {
            internal void SlowAction()
            {
                SlowMethod("Called from Action");
            }
            internal void SlowMethod(string Payload)
            {
                Thread.Sleep(2000); //2 Second
                Console.WriteLine("{0}:\t{1}", DateTime.Now.ToLongTimeString(), Payload);
            }
        }
    }
}
