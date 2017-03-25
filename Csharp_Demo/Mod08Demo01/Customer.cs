using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod08Demo01
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CustomerStatusEnum Status { get; set; }
        public string Email { get; set; }
        public string Details()
        {
            return string.Format("Customer {0}\n{1}\n{2}\n{3}", ID, Name, Status,Email);
        }
    }
    public enum CustomerStatusEnum
    {
        Gold,
        Silver,
        Platinum
    }
}
