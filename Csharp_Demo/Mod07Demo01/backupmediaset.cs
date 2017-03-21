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
    
    public partial class backupmediaset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public backupmediaset()
        {
            this.backupmediafamilies = new HashSet<backupmediafamily>();
            this.backupsets = new HashSet<backupset>();
        }
    
        public int media_set_id { get; set; }
        public Nullable<System.Guid> media_uuid { get; set; }
        public Nullable<byte> media_family_count { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string software_name { get; set; }
        public Nullable<int> software_vendor_id { get; set; }
        public Nullable<byte> MTF_major_version { get; set; }
        public Nullable<byte> mirror_count { get; set; }
        public Nullable<bool> is_password_protected { get; set; }
        public Nullable<bool> is_compressed { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<backupmediafamily> backupmediafamilies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<backupset> backupsets { get; set; }
    }
}
