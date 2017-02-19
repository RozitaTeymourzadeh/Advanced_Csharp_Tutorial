using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04Demo01
{

    public static class Utilities// Allmembers of static class must be static type
    {
        private static Customer cust;

        public static ArrayList GetCustomers()
        {
            ArrayList customers = new ArrayList();
            customers.Add(new Customer("Rozita", CustomerStatusEnum.Gold, "roz@cust.com"));
            customers.Add(new Customer("Ann", CustomerStatusEnum.Silver, "Ann@cust.com"));
            customers.Add(new Customer("Pan", CustomerStatusEnum.Gold, "pan@cust.com"));
            customers.Add(new Customer("Eli", CustomerStatusEnum.Platinume, "Eli@cust.com"));
            return customers;
        }
        public static Customer GetCustomer(int ID)
        {
            //if (cust == null) { return 0; }
            if (ID == 5)
            {
                Customer cust = new Customer("Rozita", CustomerStatusEnum.Gold, "roz@cust.com");
            }
            else
            { 
                Customer cust = new Customer("Ann", CustomerStatusEnum.Silver, "Ann@cust.com");
            }
            return cust;
            Console.Write(ID);
            Console.ReadLine();

        }
    }
}
