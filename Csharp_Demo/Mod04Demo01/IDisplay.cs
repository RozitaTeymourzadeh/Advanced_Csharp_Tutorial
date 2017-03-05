using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod05Demo01
{
    public interface IDisplay// means all classes inherite to this interface must have ID, Name and details
    {
        int ID { get; set; }
        string Name { get; set; }
        string Details();
    }
}
