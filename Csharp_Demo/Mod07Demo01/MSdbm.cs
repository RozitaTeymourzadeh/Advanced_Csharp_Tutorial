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
    
    public partial class MSdbm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSdbm()
        {
            this.MSdbms_datatype = new HashSet<MSdbms_datatype>();
            this.MSdbms_map = new HashSet<MSdbms_map>();
            this.MSdbms_map1 = new HashSet<MSdbms_map>();
        }
    
        public int dbms_id { get; set; }
        public string dbms { get; set; }
        public string version { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSdbms_datatype> MSdbms_datatype { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSdbms_map> MSdbms_map { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSdbms_map> MSdbms_map1 { get; set; }
    }
}
