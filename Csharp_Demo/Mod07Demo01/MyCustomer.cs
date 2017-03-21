using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod07Demo01
{
    public partial class syspolicy_policy_categories_internal// will put as partial to add to auto generated customer class
    {
        public CustomerStatusEnum Status
        {
            get
            {
                return (CustomerStatusEnum)dbpolicy_category_id;
            }
            set
            {
                dbpolicy_category_id = (int)value;
            }
        }
        public string Details
        {
            get
            {
                return string.Format("Customer {0}\n{1}\n{2}", mandate_database_subscriptions, Status, name);// these variables are taken from syspolicy_policy_categories_internal class on server
            }
        }
    }
}
