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
    
    public partial class sysdbmaintplan_history
    {
        public int sequence_id { get; set; }
        public System.Guid plan_id { get; set; }
        public string plan_name { get; set; }
        public string database_name { get; set; }
        public string server_name { get; set; }
        public string activity { get; set; }
        public bool succeeded { get; set; }
        public System.DateTime end_time { get; set; }
        public Nullable<int> duration { get; set; }
        public Nullable<System.DateTime> start_time { get; set; }
        public int error_number { get; set; }
        public string message { get; set; }
    }
}
