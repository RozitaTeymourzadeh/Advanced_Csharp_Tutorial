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
    
    public partial class sysdbmaintplan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysdbmaintplan()
        {
            this.sysdbmaintplan_jobs = new HashSet<sysdbmaintplan_jobs>();
            this.sysdbmaintplan_databases = new HashSet<sysdbmaintplan_databases>();
        }
    
        public System.Guid plan_id { get; set; }
        public string plan_name { get; set; }
        public System.DateTime date_created { get; set; }
        public string owner { get; set; }
        public int max_history_rows { get; set; }
        public string remote_history_server { get; set; }
        public int max_remote_history_rows { get; set; }
        public Nullable<int> user_defined_1 { get; set; }
        public string user_defined_2 { get; set; }
        public Nullable<System.DateTime> user_defined_3 { get; set; }
        public Nullable<System.Guid> user_defined_4 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysdbmaintplan_jobs> sysdbmaintplan_jobs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysdbmaintplan_databases> sysdbmaintplan_databases { get; set; }
    }
}
