//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mod07Demo01
{
    using System;
    using System.Collections.Generic;
    
    public partial class syspolicy_policy_execution_history_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syspolicy_policy_execution_history_internal()
        {
            this.syspolicy_policy_execution_history_details_internal = new HashSet<syspolicy_policy_execution_history_details_internal>();
        }
    
        public long history_id { get; set; }
        public int policy_id { get; set; }
        public System.DateTime start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public bool result { get; set; }
        public bool is_full_run { get; set; }
        public string exception_message { get; set; }
        public string exception { get; set; }
    
        public virtual syspolicy_policies_internal syspolicy_policies_internal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_policy_execution_history_details_internal> syspolicy_policy_execution_history_details_internal { get; set; }
    }
}
