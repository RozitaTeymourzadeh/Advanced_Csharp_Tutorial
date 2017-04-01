using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09Demo01
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CustomerStatusEnum Status { get; set; }
        public string Email { get; set; }
    }

    public enum CustomerStatusEnum
    {
        Silver,
        Gold,
        Platinum
    }
}
