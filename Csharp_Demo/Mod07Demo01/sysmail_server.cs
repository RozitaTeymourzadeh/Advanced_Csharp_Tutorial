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
    
    public partial class sysmail_server
    {
        public int account_id { get; set; }
        public string servertype { get; set; }
        public string servername { get; set; }
        public int port { get; set; }
        public string username { get; set; }
        public Nullable<int> credential_id { get; set; }
        public bool use_default_credentials { get; set; }
        public bool enable_ssl { get; set; }
        public int flags { get; set; }
        public Nullable<int> timeout { get; set; }
        public System.DateTime last_mod_datetime { get; set; }
        public string last_mod_user { get; set; }
    
        public virtual sysmail_account sysmail_account { get; set; }
        public virtual sysmail_servertype sysmail_servertype { get; set; }
    }
}
