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
    
    public partial class syspolicy_management_facets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syspolicy_management_facets()
        {
            this.syspolicy_conditions_internal = new HashSet<syspolicy_conditions_internal>();
            this.syspolicy_facet_events = new HashSet<syspolicy_facet_events>();
            this.syspolicy_object_sets_internal = new HashSet<syspolicy_object_sets_internal>();
        }
    
        public int management_facet_id { get; set; }
        public string name { get; set; }
        public int execution_mode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_conditions_internal> syspolicy_conditions_internal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_facet_events> syspolicy_facet_events { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_object_sets_internal> syspolicy_object_sets_internal { get; set; }
    }
}
