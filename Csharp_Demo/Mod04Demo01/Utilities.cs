using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod06Demo02
{

    public static class Utilities// Allmembers of static class must be static type
    {
        private static Customer cust;

        // public static ArrayList GetCustomers()// collection Array List 
        public static List<IDisplay> GetCustomers()// Generic List  

        {
            //ArrayList customers = new ArrayList();// collection Array List 
            var customers = new List<IDisplay>();// Generic collection List  
            customers.Add(new Customer("Rozita", CustomerStatusEnum.Gold, "roz@cust.com"));
            customers.Add(new Customer("Ann", CustomerStatusEnum.Silver, "Ann@cust.com"));
            customers.Add(new Customer("Pan", CustomerStatusEnum.Gold, "pan@cust.com"));
            customers.Add(new Customer("Eli", CustomerStatusEnum.Platinume, "Eli@cust.com"));
            customers.Add(new Prospect { Name = "Vali", PostalCode = "123", Email = "vali@pros.com" });
            customers.Add(new Prospect { Name = "Mama", PostalCode = "223", Email = "mama@pros.com" });
            customers.Add(new Prospect { Name = "Papa", PostalCode = "1223", Email = "papa@pros.com" });
            customers.Sort();
            return customers;
        }
        public static Customer GetCustomers(int ID)
        {
            var custs = GetCustomers().Cast<Customer>();
            return custs.First(c => c.ID == ID);
        }
    }
}
