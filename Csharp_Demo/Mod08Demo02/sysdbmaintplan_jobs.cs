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
    
    public partial class sysdbmaintplan_jobs
    {
        public System.Guid plan_id { get; set; }
        public System.Guid job_id { get; set; }
    
        public virtual sysdbmaintplan sysdbmaintplan { get; set; }
    }
}
