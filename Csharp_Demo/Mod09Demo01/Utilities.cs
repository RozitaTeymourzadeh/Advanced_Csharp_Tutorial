using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mod09Demo01.StatusControl;

namespace Mod09Demo01
{

    public static class Utilities// All members of static class must be static type
    {

        public static List<Customer> GetCustomers()// Generic List  
        {
            var customers = new List<Customer>();// Generic collection List  
            customers.Add(new Customer { Name = "Rozita", Status = CustomerStatusEnum.Platinum, Email = "roz@cust.com"});
            customers.Add(new Customer { Name = "Ann", Status = CustomerStatusEnum.Gold, Email = "Ann@cust.com" });
            customers.Add(new Customer { Name = "Pan", Status = CustomerStatusEnum.Gold, Email = "Pan@cust.com" });

            return customers;     
        }

    }
}
