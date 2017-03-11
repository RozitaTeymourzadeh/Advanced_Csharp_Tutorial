using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod05Demo01
{

    public static class Utilities// All members of static class must be static type
    {

        public static List<Person> GetCustomers()// Generic List  
        {
            var customers = new List<Person>();// Generic collection List  
            customers.Add(new Customer { Name = "Rozita", Status = CustomerStatusEnum.Gold, Email = "roz@cust.com"});
            customers.Add(new Customer { Name = "Ann", Status = CustomerStatusEnum.Gold, Email = "Ann@cust.com" });
            customers.Add(new Customer { Name = "Pan", Status = CustomerStatusEnum.Gold, Email = "Pan@cust.com" });

            customers.Add(new Prospect { Name = "Vali", PostalCode = "123", Email = "vali@pros.com" });
            customers.Add(new Prospect { Name = "Mama", PostalCode = "223", Email = "mama@pros.com" });
            customers.Add(new Prospect { Name = "Papa", PostalCode = "1223", Email = "papa@pros.com" });
            customers.Sort();// To sort customer in List
            return customers;
            
        }
        public static string TitleCase(this string input) // we use "this" to tell to compiler about this extension method means object.extension method()
        {
            string[] words = input.Split(' ');
            for (int lcv = 0; lcv < words.Length; lcv++)
            {
                words[lcv] = words[lcv].Substring(0, 1).ToUpper() + words[lcv].Substring(1).ToLower();
            }
            return string.Join(" ", words);
        } 

    }
}
