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
    
    public partial class sysmaintplan_logdetail
    {
        public System.Guid task_detail_id { get; set; }
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string line3 { get; set; }
        public string line4 { get; set; }
        public string line5 { get; set; }
        public string server_name { get; set; }
        public Nullable<System.DateTime> start_time { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public Nullable<int> error_number { get; set; }
        public string error_message { get; set; }
        public string command { get; set; }
        public Nullable<bool> succeeded { get; set; }
    
        public virtual sysmaintplan_log sysmaintplan_log { get; set; }
    }
}
