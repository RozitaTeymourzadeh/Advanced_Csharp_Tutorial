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
    
    public partial class syscollector_tsql_query_collector
    {
        public System.Guid collection_set_uid { get; set; }
        public int collection_set_id { get; set; }
        public int collection_item_id { get; set; }
        public System.Guid collection_package_id { get; set; }
        public System.Guid upload_package_id { get; set; }
    
        public virtual syscollector_collection_items_internal syscollector_collection_items_internal { get; set; }
    }
}
