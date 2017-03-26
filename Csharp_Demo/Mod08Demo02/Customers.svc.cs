//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace Mod08Demo02
{
    public class Customers : DataService<msdbEntities/* TODO: put your data source class name here, Add EDM server name that we add before here is "msdbEntities"*/ >
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            // config.SetEntitySetAccessRule("MyEntityset", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            // config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);
            config.SetServiceActionAccessRule("GetCustomersByStatus", ServiceActionRights.Invoke);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }
        [WebGet]
        public IQueryable<syspolicy_policy_categories_internal> GetCustomersByStatus(int Status) /*Add one of table in EDM here:syspolicy_policy_categories_internal*/
        {
            return from c in this.CurrentDataSource.syspolicy_policy_categories_internal
                   where c.policy_category_id == Status
                   select c;
        }
    }
}
