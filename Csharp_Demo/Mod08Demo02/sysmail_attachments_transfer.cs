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
    
    public partial class sysmail_attachments_transfer
    {
        public int transfer_id { get; set; }
        public System.Guid uid { get; set; }
        public string filename { get; set; }
        public int filesize { get; set; }
        public byte[] attachment { get; set; }
        public System.DateTime create_date { get; set; }
    }
}
