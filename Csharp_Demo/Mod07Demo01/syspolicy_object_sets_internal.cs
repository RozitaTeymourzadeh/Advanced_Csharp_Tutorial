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
    
    public partial class syspolicy_object_sets_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syspolicy_object_sets_internal()
        {
            this.syspolicy_policies_internal = new HashSet<syspolicy_policies_internal>();
            this.syspolicy_target_sets_internal = new HashSet<syspolicy_target_sets_internal>();
        }
    
        public int object_set_id { get; set; }
        public string object_set_name { get; set; }
        public Nullable<int> facet_id { get; set; }
        public bool is_system { get; set; }
    
        public virtual syspolicy_management_facets syspolicy_management_facets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_policies_internal> syspolicy_policies_internal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_target_sets_internal> syspolicy_target_sets_internal { get; set; }
    }
}
