using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04Demo01
{
    public class Customer
    {
        public Customer()
        {
            // default Custome constructor
        }

        public Customer(int ID, string Name, CustomerStatusEnum Status, string Email)// constructor: to connect property to method parameter, constructor return Customer and there is no int or void etc
        {
            this.ID = ID;
            this.Name = Name;
            this.Status = Status;
            this.Email = (Email==null? Name+"@cust.com":Email);
        }
        public Customer(int ID, string Name)// constructor: to connect property to method parameter
        {
            this.ID = ID;
            this.Name = Name;
            this.Status = CustomerStatusEnum.Gold;
            this.Email = Name + "@cust.com";
        }

        public int ID { get; set; } // property
        public string Name { get; set; }
        public CustomerStatusEnum Status { get; set; }
        public string Email { get; set; }

        public string Details()// Method must have return
        {
            return string.Format("{0}\n{1}\n{2}\n{3}", ID, Name, Status, Email);
        }
    }

    public enum CustomerStatusEnum
    {
        Gold,
        Silver,
        Platinume
    }
}
