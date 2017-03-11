using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod05Demo01
{
    public class Customer:Person
    {
        public CustomerStatusEnum Status { get; set; }
        public override string Details()
       /* Method must have return, virtual type is to be able to overwrite by class that is inheritted to this base class*/
        {
            return string.Format("Person {0}\n{1}\n{2}\n{3}\n{4}", ID, Name, Status,Email,Notes);
        }
    }
    public class Prospect:Person
    {
        public string PostalCode { get; set; }
        public override string Details()
        {
            return "Prospect" + base.Details() + "\n" + PostalCode;

        }
    }
    public enum CustomerStatusEnum
    {
        Gold,
        Silver,
        Platinum
    }
}
