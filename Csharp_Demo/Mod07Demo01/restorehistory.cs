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
    
    public partial class restorehistory
    {
        public int restore_history_id { get; set; }
        public Nullable<System.DateTime> restore_date { get; set; }
        public string destination_database_name { get; set; }
        public string user_name { get; set; }
        public int backup_set_id { get; set; }
        public string restore_type { get; set; }
        public Nullable<bool> replace { get; set; }
        public Nullable<bool> recovery { get; set; }
        public Nullable<bool> restart { get; set; }
        public Nullable<System.DateTime> stop_at { get; set; }
        public Nullable<byte> device_count { get; set; }
        public string stop_at_mark_name { get; set; }
        public Nullable<bool> stop_before { get; set; }
    
        public virtual backupset backupset { get; set; }
        public virtual restorefile restorefile { get; set; }
        public virtual restorefilegroup restorefilegroup { get; set; }
    }
}