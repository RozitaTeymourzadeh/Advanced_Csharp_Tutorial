//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mod08Demo02
{
    using System;
    using System.Collections.Generic;
    
    public partial class sysmanagement_shared_registered_servers_internal
    {
        public int server_id { get; set; }
        public Nullable<int> server_group_id { get; set; }
        public string name { get; set; }
        public string server_name { get; set; }
        public string description { get; set; }
        public int server_type { get; set; }
    
        public virtual sysmanagement_shared_server_groups_internal sysmanagement_shared_server_groups_internal { get; set; }
    }
}
