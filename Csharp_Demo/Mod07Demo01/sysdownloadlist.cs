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
    
    public partial class sysdownloadlist
    {
        public int instance_id { get; set; }
        public string source_server { get; set; }
        public byte operation_code { get; set; }
        public byte object_type { get; set; }
        public System.Guid object_id { get; set; }
        public string target_server { get; set; }
        public string error_message { get; set; }
        public System.DateTime date_posted { get; set; }
        public Nullable<System.DateTime> date_downloaded { get; set; }
        public byte status { get; set; }
        public string deleted_object_name { get; set; }
    }
}