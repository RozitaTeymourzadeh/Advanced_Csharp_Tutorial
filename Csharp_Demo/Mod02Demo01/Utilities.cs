using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod02Demo01
{
    public class Utilities// class
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> result = new List<Customer>();
            result.Add(new Customer { ID = 1, Name = "Bob", Email = "bob@cust.com", Status = CustomerStatusEnum.Gold });
            result.Add(new Customer { ID = 2, Name = "Ashley", Email = "ashley@cust.com", Status = CustomerStatusEnum.Gold });
            result.Add(new Customer { ID = 3, Name = "Ann", Email = "ann@cust.com", Status = CustomerStatusEnum.Platinum });
            result.Add(new Customer { ID = 4, Name = "Roz", Email = "Roz@cust.com", Status = CustomerStatusEnum.Gold});
            result.Add(new Customer { ID = 5, Name = "Pan", Email = "Pan@cust.com", Status = CustomerStatusEnum.Gold });
            return result;
        }
        //method overlap 1
        public Customer NewCustomer(int ID, string Name, CustomerStatusEnum Status , string Email = null)
        {
            Customer cust = new Customer();
            cust.ID = ID;
            cust.Name = Name;
            cust.Status = CustomerStatusEnum.Silver;
            cust.Email = (Email == null ? Name + "@cust.com" : Email);//optional parameter is defiened to be replaced with "method overlap 2"
            Debug.Print("New Customer ID" + ID);// This line of code helps to trace the code during execution.
            Trace.WriteLine("New Customer ID" + ID);//Alternatievely Trace can be used with more features
            Trace.TraceWarning("New Customer ID {0}", ID);
            CreateCounter();// Create performance counter in Performance monitor
            IncrementCounter();// It creates customer counter and increment counter
            return cust;
        }
        //method overlap 2
        public Customer NewCustomer(int ID, string Name)
        {
            return NewCustomer(ID, Name, CustomerStatusEnum.Gold, Name + "@cust.com");
        }
        public bool NewValidatedCustomer(int ID, string Name, out Customer cust, CustomerStatusEnum Status = CustomerStatusEnum.Gold, string Email = null)
        {
            if (ID != -1)
            {
                cust = new Customer();
                cust.ID = ID;
                cust.Name = Name;
                cust.Status = Status;
                cust.Email = (Email == null ? Name + "@cust.com" : Email);//optional parameter is defiened to be replaced with "method overlap 2"
                return true;
            }
            else
            {
                cust = null;
                return false;
            }
        }
        public void CreateCounter()
        {
            if (!PerformanceCounterCategory.Exists("A Demo Counter"))
            {
                CounterCreationDataCollection counters = new CounterCreationDataCollection();
                CounterCreationData totalorders = new CounterCreationData();
                totalorders.CounterName = "Customers";
                totalorders.CounterHelp = "Total number of customers created";
                totalorders.CounterType = PerformanceCounterType.NumberOfItems32;
                counters.Add(totalorders);
                PerformanceCounterCategory.Create("A Demo Counter", "A custom category for demonstration", PerformanceCounterCategoryType.SingleInstance, counters);
            }
        }
        public void IncrementCounter()
        {
            PerformanceCounter counterOrders = new PerformanceCounter("A Demo Counter", "Customers", false);
            counterOrders.Increment();
        }

    }
}