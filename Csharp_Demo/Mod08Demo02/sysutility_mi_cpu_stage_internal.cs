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
    
    public partial class sysutility_mi_cpu_stage_internal
    {
        public int num_processors { get; set; }
        public string cpu_name { get; set; }
        public string cpu_caption { get; set; }
        public decimal cpu_family_id { get; set; }
        public decimal cpu_architecture_id { get; set; }
        public decimal cpu_max_clock_speed { get; set; }
        public decimal cpu_clock_speed { get; set; }
        public decimal l2_cache_size { get; set; }
        public decimal l3_cache_size { get; set; }
        public decimal instance_processor_usage_start_ticks { get; set; }
        public decimal instance_collect_time_start_ticks { get; set; }
        public decimal computer_processor_idle_start_ticks { get; set; }
        public decimal computer_collect_time_start_ticks { get; set; }
        public decimal instance_processor_usage_end_ticks { get; set; }
        public decimal instance_collect_time_end_ticks { get; set; }
        public decimal computer_processor_idle_end_ticks { get; set; }
        public decimal computer_collect_time_end_ticks { get; set; }
        public string server_instance_name { get; set; }
        public string virtual_server_name { get; set; }
        public string physical_server_name { get; set; }
        public Nullable<float> instance_processor_usage_percentage { get; set; }
        public Nullable<float> computer_processor_usage_percentage { get; set; }
    }
}
