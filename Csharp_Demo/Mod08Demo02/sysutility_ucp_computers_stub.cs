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
    
    public partial class sysutility_ucp_computers_stub
    {
        public int id { get; set; }
        public string virtual_server_name { get; set; }
        public string physical_server_name { get; set; }
        public Nullable<int> is_clustered_server { get; set; }
        public Nullable<int> num_processors { get; set; }
        public string cpu_name { get; set; }
        public string cpu_caption { get; set; }
        public string cpu_family { get; set; }
        public string cpu_architecture { get; set; }
        public Nullable<decimal> cpu_max_clock_speed { get; set; }
        public Nullable<decimal> cpu_clock_speed { get; set; }
        public Nullable<decimal> l2_cache_size { get; set; }
        public Nullable<decimal> l3_cache_size { get; set; }
        public string urn { get; set; }
        public string powershell_path { get; set; }
        public Nullable<System.DateTimeOffset> processing_time { get; set; }
        public Nullable<System.DateTimeOffset> batch_time { get; set; }
        public Nullable<float> percent_total_cpu_utilization { get; set; }
    }
}
