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
    
    public partial class backupfile
    {
        public int backup_set_id { get; set; }
        public Nullable<byte> first_family_number { get; set; }
        public Nullable<short> first_media_number { get; set; }
        public string filegroup_name { get; set; }
        public Nullable<int> page_size { get; set; }
        public decimal file_number { get; set; }
        public Nullable<decimal> backed_up_page_count { get; set; }
        public string file_type { get; set; }
        public Nullable<decimal> source_file_block_size { get; set; }
        public Nullable<decimal> file_size { get; set; }
        public string logical_name { get; set; }
        public string physical_drive { get; set; }
        public string physical_name { get; set; }
        public Nullable<byte> state { get; set; }
        public string state_desc { get; set; }
        public Nullable<decimal> create_lsn { get; set; }
        public Nullable<decimal> drop_lsn { get; set; }
        public Nullable<System.Guid> file_guid { get; set; }
        public Nullable<decimal> read_only_lsn { get; set; }
        public Nullable<decimal> read_write_lsn { get; set; }
        public Nullable<decimal> differential_base_lsn { get; set; }
        public Nullable<System.Guid> differential_base_guid { get; set; }
        public Nullable<decimal> backup_size { get; set; }
        public Nullable<System.Guid> filegroup_guid { get; set; }
        public Nullable<bool> is_readonly { get; set; }
        public Nullable<bool> is_present { get; set; }
    
        public virtual backupset backupset { get; set; }
    }
}
