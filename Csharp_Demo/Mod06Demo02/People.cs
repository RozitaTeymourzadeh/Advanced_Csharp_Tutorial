using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod06Demo02
{
    [Serializable]// all classes had to be marked as serializable the same way!
    public class People:List<Person>
    {
    }
}
