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
    
    public partial class syspolicy_policy_execution_history_details_internal
    {
        public long detail_id { get; set; }
        public long history_id { get; set; }
        public string target_query_expression { get; set; }
        public string target_query_expression_with_id { get; set; }
        public System.DateTime execution_date { get; set; }
        public bool result { get; set; }
        public string result_detail { get; set; }
        public string exception_message { get; set; }
        public string exception { get; set; }
    
        public virtual syspolicy_policy_execution_history_internal syspolicy_policy_execution_history_internal { get; set; }
    }
}
