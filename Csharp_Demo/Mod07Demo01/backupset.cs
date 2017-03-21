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
    
    public partial class backupset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public backupset()
        {
            this.backupfiles = new HashSet<backupfile>();
            this.backupfilegroups = new HashSet<backupfilegroup>();
            this.restorehistories = new HashSet<restorehistory>();
        }
    
        public int backup_set_id { get; set; }
        public System.Guid backup_set_uuid { get; set; }
        public int media_set_id { get; set; }
        public Nullable<byte> first_family_number { get; set; }
        public Nullable<short> first_media_number { get; set; }
        public Nullable<byte> last_family_number { get; set; }
        public Nullable<short> last_media_number { get; set; }
        public Nullable<byte> catalog_family_number { get; set; }
        public Nullable<short> catalog_media_number { get; set; }
        public Nullable<int> position { get; set; }
        public Nullable<System.DateTime> expiration_date { get; set; }
        public Nullable<int> software_vendor_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string user_name { get; set; }
        public Nullable<byte> software_major_version { get; set; }
        public Nullable<byte> software_minor_version { get; set; }
        public Nullable<short> software_build_version { get; set; }
        public Nullable<short> time_zone { get; set; }
        public Nullable<byte> mtf_minor_version { get; set; }
        public Nullable<decimal> first_lsn { get; set; }
        public Nullable<decimal> last_lsn { get; set; }
        public Nullable<decimal> checkpoint_lsn { get; set; }
        public Nullable<decimal> database_backup_lsn { get; set; }
        public Nullable<System.DateTime> database_creation_date { get; set; }
        public Nullable<System.DateTime> backup_start_date { get; set; }
        public Nullable<System.DateTime> backup_finish_date { get; set; }
        public string type { get; set; }
        public Nullable<short> sort_order { get; set; }
        public Nullable<short> code_page { get; set; }
        public Nullable<byte> compatibility_level { get; set; }
        public Nullable<int> database_version { get; set; }
        public Nullable<decimal> backup_size { get; set; }
        public string database_name { get; set; }
        public string server_name { get; set; }
        public string machine_name { get; set; }
        public Nullable<int> flags { get; set; }
        public Nullable<int> unicode_locale { get; set; }
        public Nullable<int> unicode_compare_style { get; set; }
        public string collation_name { get; set; }
        public Nullable<bool> is_password_protected { get; set; }
        public string recovery_model { get; set; }
        public Nullable<bool> has_bulk_logged_data { get; set; }
        public Nullable<bool> is_snapshot { get; set; }
        public Nullable<bool> is_readonly { get; set; }
        public Nullable<bool> is_single_user { get; set; }
        public Nullable<bool> has_backup_checksums { get; set; }
        public Nullable<bool> is_damaged { get; set; }
        public Nullable<bool> begins_log_chain { get; set; }
        public Nullable<bool> has_incomplete_metadata { get; set; }
        public Nullable<bool> is_force_offline { get; set; }
        public Nullable<bool> is_copy_only { get; set; }
        public Nullable<System.Guid> first_recovery_fork_guid { get; set; }
        public Nullable<System.Guid> last_recovery_fork_guid { get; set; }
        public Nullable<decimal> fork_point_lsn { get; set; }
        public Nullable<System.Guid> database_guid { get; set; }
        public Nullable<System.Guid> family_guid { get; set; }
        public Nullable<decimal> differential_base_lsn { get; set; }
        public Nullable<System.Guid> differential_base_guid { get; set; }
        public Nullable<decimal> compressed_backup_size { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<backupfile> backupfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<backupfilegroup> backupfilegroups { get; set; }
        public virtual backupmediaset backupmediaset { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<restorehistory> restorehistories { get; set; }
    }
}
