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
    
    public partial class sysoperator
    {
        public int id { get; set; }
        public string name { get; set; }
        public byte enabled { get; set; }
        public string email_address { get; set; }
        public int last_email_date { get; set; }
        public int last_email_time { get; set; }
        public string pager_address { get; set; }
        public int last_pager_date { get; set; }
        public int last_pager_time { get; set; }
        public int weekday_pager_start_time { get; set; }
        public int weekday_pager_end_time { get; set; }
        public int saturday_pager_start_time { get; set; }
        public int saturday_pager_end_time { get; set; }
        public int sunday_pager_start_time { get; set; }
        public int sunday_pager_end_time { get; set; }
        public byte pager_days { get; set; }
        public string netsend_address { get; set; }
        public int last_netsend_date { get; set; }
        public int last_netsend_time { get; set; }
        public int category_id { get; set; }
    }
}
