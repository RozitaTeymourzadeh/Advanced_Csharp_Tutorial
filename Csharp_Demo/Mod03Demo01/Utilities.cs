using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod03Demo01
{
    public class Utilities
    {
        public ArrayList GetCustomers()// Array Collection type
        {
            ArrayList customers = new ArrayList();
            customers.Add(new Customer (1,"Bob",CustomerStatusEnum.Gold,"bob@cust.com"));
            customers.Add(new Customer(2, "Roz", CustomerStatusEnum.Gold, "roz@cust.com"));
            customers.Add(new Customer(3, "Ann", CustomerStatusEnum.Silver, "ann@cust.com"));
            customers.Add(new Customer(4, "Pan", CustomerStatusEnum.Platinum, "pan@cust.com"));
            return customers;
        }

        public Hashtable GetCustomers2()
        {
            Hashtable customers = new Hashtable();
            customers.Add("Roz", new Customer(1, "Rozita", CustomerStatusEnum.Silver, "roz@cust.com"));
            customers.Add("Ann", new Customer(2, "Anita", CustomerStatusEnum.Silver, "ann@cust.com"));
            customers.Add("Eli", new Customer(3, "Eliza", CustomerStatusEnum.Silver, "roz@cust.com"));
            customers.Add("Pan", new Customer(4, "Pantea", CustomerStatusEnum.Silver, "pan@cust.com"));
            return customers;
        }
    }
}
