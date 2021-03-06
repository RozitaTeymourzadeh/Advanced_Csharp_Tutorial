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
    
    public partial class sysmail_mailitems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysmail_mailitems()
        {
            this.sysmail_send_retries = new HashSet<sysmail_send_retries>();
            this.sysmail_attachments = new HashSet<sysmail_attachments>();
        }
    
        public int mailitem_id { get; set; }
        public int profile_id { get; set; }
        public string recipients { get; set; }
        public string copy_recipients { get; set; }
        public string blind_copy_recipients { get; set; }
        public string subject { get; set; }
        public string from_address { get; set; }
        public string reply_to { get; set; }
        public string body { get; set; }
        public string body_format { get; set; }
        public string importance { get; set; }
        public string sensitivity { get; set; }
        public string file_attachments { get; set; }
        public string attachment_encoding { get; set; }
        public string query { get; set; }
        public string execute_query_database { get; set; }
        public Nullable<bool> attach_query_result_as_file { get; set; }
        public Nullable<bool> query_result_header { get; set; }
        public Nullable<int> query_result_width { get; set; }
        public string query_result_separator { get; set; }
        public Nullable<bool> exclude_query_output { get; set; }
        public Nullable<bool> append_query_error { get; set; }
        public System.DateTime send_request_date { get; set; }
        public string send_request_user { get; set; }
        public Nullable<int> sent_account_id { get; set; }
        public Nullable<byte> sent_status { get; set; }
        public Nullable<System.DateTime> sent_date { get; set; }
        public System.DateTime last_mod_date { get; set; }
        public string last_mod_user { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmail_send_retries> sysmail_send_retries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmail_attachments> sysmail_attachments { get; set; }
    }
}
