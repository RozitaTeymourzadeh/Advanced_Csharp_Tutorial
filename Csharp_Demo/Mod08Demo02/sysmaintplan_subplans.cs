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
    
    public partial class sysmaintplan_subplans
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysmaintplan_subplans()
        {
            this.sysmaintplan_log = new HashSet<sysmaintplan_log>();
        }
    
        public System.Guid subplan_id { get; set; }
        public string subplan_name { get; set; }
        public string subplan_description { get; set; }
        public System.Guid plan_id { get; set; }
        public System.Guid job_id { get; set; }
        public Nullable<System.Guid> msx_job_id { get; set; }
        public Nullable<int> schedule_id { get; set; }
        public bool msx_plan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmaintplan_log> sysmaintplan_log { get; set; }
        public virtual sysschedule sysschedule { get; set; }
    }
}
