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
    
    public partial class log_shipping_monitor_secondary
    {
        public string secondary_server { get; set; }
        public string secondary_database { get; set; }
        public System.Guid secondary_id { get; set; }
        public string primary_server { get; set; }
        public string primary_database { get; set; }
        public int restore_threshold { get; set; }
        public int threshold_alert { get; set; }
        public bool threshold_alert_enabled { get; set; }
        public string last_copied_file { get; set; }
        public Nullable<System.DateTime> last_copied_date { get; set; }
        public Nullable<System.DateTime> last_copied_date_utc { get; set; }
        public string last_restored_file { get; set; }
        public Nullable<System.DateTime> last_restored_date { get; set; }
        public Nullable<System.DateTime> last_restored_date_utc { get; set; }
        public Nullable<int> last_restored_latency { get; set; }
        public int history_retention_period { get; set; }
    }
}
