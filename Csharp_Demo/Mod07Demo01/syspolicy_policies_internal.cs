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
    
    public partial class syspolicy_policies_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syspolicy_policies_internal()
        {
            this.syspolicy_system_health_state_internal = new HashSet<syspolicy_system_health_state_internal>();
            this.syspolicy_policy_execution_history_internal = new HashSet<syspolicy_policy_execution_history_internal>();
        }
    
        public int policy_id { get; set; }
        public string name { get; set; }
        public int condition_id { get; set; }
        public Nullable<int> root_condition_id { get; set; }
        public System.DateTime date_created { get; set; }
        public int execution_mode { get; set; }
        public Nullable<int> policy_category_id { get; set; }
        public Nullable<System.Guid> schedule_uid { get; set; }
        public string description { get; set; }
        public string help_text { get; set; }
        public string help_link { get; set; }
        public Nullable<int> object_set_id { get; set; }
        public bool is_enabled { get; set; }
        public Nullable<System.Guid> job_id { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> date_modified { get; set; }
        public bool is_system { get; set; }
    
        public virtual syspolicy_conditions_internal syspolicy_conditions_internal { get; set; }
        public virtual syspolicy_conditions_internal syspolicy_conditions_internal1 { get; set; }
        public virtual syspolicy_object_sets_internal syspolicy_object_sets_internal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_system_health_state_internal> syspolicy_system_health_state_internal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_policy_execution_history_internal> syspolicy_policy_execution_history_internal { get; set; }
        public virtual syspolicy_policy_categories_internal syspolicy_policy_categories_internal { get; set; }
    }
}
