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
    
    public partial class sysmail_profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysmail_profile()
        {
            this.sysmail_principalprofile = new HashSet<sysmail_principalprofile>();
        }
    
        public int profile_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public System.DateTime last_mod_datetime { get; set; }
        public string last_mod_user { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmail_principalprofile> sysmail_principalprofile { get; set; }
    }
}
