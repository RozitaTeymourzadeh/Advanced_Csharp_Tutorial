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
    
    public partial class sysutility_ucp_dacs_stub
    {
        public int dac_id { get; set; }
        public string physical_server_name { get; set; }
        public string server_instance_name { get; set; }
        public string dac_name { get; set; }
        public Nullable<System.DateTime> dac_deploy_date { get; set; }
        public string dac_description { get; set; }
        public string urn { get; set; }
        public string powershell_path { get; set; }
        public Nullable<System.DateTimeOffset> processing_time { get; set; }
        public Nullable<System.DateTimeOffset> batch_time { get; set; }
        public Nullable<float> dac_percent_total_cpu_utilization { get; set; }
    }
}
