﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class msdbEntities : DbContext
    {
        public msdbEntities()
            : base("name=msdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<backupfile> backupfiles { get; set; }
        public virtual DbSet<backupfilegroup> backupfilegroups { get; set; }
        public virtual DbSet<backupmediafamily> backupmediafamilies { get; set; }
        public virtual DbSet<backupmediaset> backupmediasets { get; set; }
        public virtual DbSet<backupset> backupsets { get; set; }
        public virtual DbSet<log_shipping_monitor_alert> log_shipping_monitor_alert { get; set; }
        public virtual DbSet<log_shipping_monitor_primary> log_shipping_monitor_primary { get; set; }
        public virtual DbSet<log_shipping_monitor_secondary> log_shipping_monitor_secondary { get; set; }
        public virtual DbSet<log_shipping_primaries> log_shipping_primaries { get; set; }
        public virtual DbSet<log_shipping_primary_databases> log_shipping_primary_databases { get; set; }
        public virtual DbSet<log_shipping_primary_secondaries> log_shipping_primary_secondaries { get; set; }
        public virtual DbSet<log_shipping_secondary> log_shipping_secondary { get; set; }
        public virtual DbSet<log_shipping_secondary_databases> log_shipping_secondary_databases { get; set; }
        public virtual DbSet<MSdbm> MSdbms { get; set; }
        public virtual DbSet<MSdbms_datatype> MSdbms_datatype { get; set; }
        public virtual DbSet<MSdbms_datatype_mapping> MSdbms_datatype_mapping { get; set; }
        public virtual DbSet<MSdbms_map> MSdbms_map { get; set; }
        public virtual DbSet<restorehistory> restorehistories { get; set; }
        public virtual DbSet<syscachedcredential> syscachedcredentials { get; set; }
        public virtual DbSet<syscollector_blobs_internal> syscollector_blobs_internal { get; set; }
        public virtual DbSet<syscollector_collection_items_internal> syscollector_collection_items_internal { get; set; }
        public virtual DbSet<syscollector_collection_sets_internal> syscollector_collection_sets_internal { get; set; }
        public virtual DbSet<syscollector_collector_types_internal> syscollector_collector_types_internal { get; set; }
        public virtual DbSet<syscollector_config_store_internal> syscollector_config_store_internal { get; set; }
        public virtual DbSet<syscollector_execution_log_internal> syscollector_execution_log_internal { get; set; }
        public virtual DbSet<syscollector_execution_stats_internal> syscollector_execution_stats_internal { get; set; }
        public virtual DbSet<sysdac_history_internal> sysdac_history_internal { get; set; }
        public virtual DbSet<sysdac_instances_internal> sysdac_instances_internal { get; set; }
        public virtual DbSet<sysdbmaintplan> sysdbmaintplans { get; set; }
        public virtual DbSet<sysjobstepslog> sysjobstepslogs { get; set; }
        public virtual DbSet<sysmail_account> sysmail_account { get; set; }
        public virtual DbSet<sysmail_attachments_transfer> sysmail_attachments_transfer { get; set; }
        public virtual DbSet<sysmail_configuration> sysmail_configuration { get; set; }
        public virtual DbSet<sysmail_log> sysmail_log { get; set; }
        public virtual DbSet<sysmail_mailitems> sysmail_mailitems { get; set; }
        public virtual DbSet<sysmail_principalprofile> sysmail_principalprofile { get; set; }
        public virtual DbSet<sysmail_profile> sysmail_profile { get; set; }
        public virtual DbSet<sysmail_profileaccount> sysmail_profileaccount { get; set; }
        public virtual DbSet<sysmail_query_transfer> sysmail_query_transfer { get; set; }
        public virtual DbSet<sysmail_send_retries> sysmail_send_retries { get; set; }
        public virtual DbSet<sysmail_server> sysmail_server { get; set; }
        public virtual DbSet<sysmail_servertype> sysmail_servertype { get; set; }
        public virtual DbSet<sysmaintplan_log> sysmaintplan_log { get; set; }
        public virtual DbSet<sysmaintplan_subplans> sysmaintplan_subplans { get; set; }
        public virtual DbSet<sysmanagement_shared_registered_servers_internal> sysmanagement_shared_registered_servers_internal { get; set; }
        public virtual DbSet<sysmanagement_shared_server_groups_internal> sysmanagement_shared_server_groups_internal { get; set; }
        public virtual DbSet<syspolicy_conditions_internal> syspolicy_conditions_internal { get; set; }
        public virtual DbSet<syspolicy_configuration_internal> syspolicy_configuration_internal { get; set; }
        public virtual DbSet<syspolicy_management_facets> syspolicy_management_facets { get; set; }
        public virtual DbSet<syspolicy_object_sets_internal> syspolicy_object_sets_internal { get; set; }
        public virtual DbSet<syspolicy_policies_internal> syspolicy_policies_internal { get; set; }
        public virtual DbSet<syspolicy_policy_categories_internal> syspolicy_policy_categories_internal { get; set; }
        public virtual DbSet<syspolicy_policy_category_subscriptions_internal> syspolicy_policy_category_subscriptions_internal { get; set; }
        public virtual DbSet<syspolicy_policy_execution_history_details_internal> syspolicy_policy_execution_history_details_internal { get; set; }
        public virtual DbSet<syspolicy_policy_execution_history_internal> syspolicy_policy_execution_history_internal { get; set; }
        public virtual DbSet<syspolicy_system_health_state_internal> syspolicy_system_health_state_internal { get; set; }
        public virtual DbSet<syspolicy_target_set_levels_internal> syspolicy_target_set_levels_internal { get; set; }
        public virtual DbSet<syspolicy_target_sets_internal> syspolicy_target_sets_internal { get; set; }
        public virtual DbSet<sysschedule> sysschedules { get; set; }
        public virtual DbSet<syssession> syssessions { get; set; }
        public virtual DbSet<sysssislog> sysssislogs { get; set; }
        public virtual DbSet<sysssispackagefolder> sysssispackagefolders { get; set; }
        public virtual DbSet<sysssispackage> sysssispackages { get; set; }
        public virtual DbSet<sysutility_mi_configuration_internal> sysutility_mi_configuration_internal { get; set; }
        public virtual DbSet<sysutility_mi_dac_execution_statistics_internal> sysutility_mi_dac_execution_statistics_internal { get; set; }
        public virtual DbSet<sysutility_mi_session_statistics_internal> sysutility_mi_session_statistics_internal { get; set; }
        public virtual DbSet<sysutility_mi_smo_objects_to_collect_internal> sysutility_mi_smo_objects_to_collect_internal { get; set; }
        public virtual DbSet<sysutility_mi_smo_properties_to_collect_internal> sysutility_mi_smo_properties_to_collect_internal { get; set; }
        public virtual DbSet<sysutility_ucp_computer_cpu_health_internal> sysutility_ucp_computer_cpu_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_configuration_internal> sysutility_ucp_configuration_internal { get; set; }
        public virtual DbSet<sysutility_ucp_dac_file_space_health_internal> sysutility_ucp_dac_file_space_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_dac_health_internal> sysutility_ucp_dac_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_filegroups_with_policy_violations_internal> sysutility_ucp_filegroups_with_policy_violations_internal { get; set; }
        public virtual DbSet<sysutility_ucp_health_policies_internal> sysutility_ucp_health_policies_internal { get; set; }
        public virtual DbSet<sysutility_ucp_managed_instances_internal> sysutility_ucp_managed_instances_internal { get; set; }
        public virtual DbSet<sysutility_ucp_mi_database_health_internal> sysutility_ucp_mi_database_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_mi_file_space_health_internal> sysutility_ucp_mi_file_space_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_mi_health_internal> sysutility_ucp_mi_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_mi_volume_space_health_internal> sysutility_ucp_mi_volume_space_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_policy_check_conditions_internal> sysutility_ucp_policy_check_conditions_internal { get; set; }
        public virtual DbSet<sysutility_ucp_policy_target_conditions_internal> sysutility_ucp_policy_target_conditions_internal { get; set; }
        public virtual DbSet<sysutility_ucp_policy_violations_internal> sysutility_ucp_policy_violations_internal { get; set; }
        public virtual DbSet<sysutility_ucp_processing_state_internal> sysutility_ucp_processing_state_internal { get; set; }
        public virtual DbSet<sysutility_ucp_supported_object_types_internal> sysutility_ucp_supported_object_types_internal { get; set; }
        public virtual DbSet<log_shipping_monitor_error_detail> log_shipping_monitor_error_detail { get; set; }
        public virtual DbSet<log_shipping_monitor_history_detail> log_shipping_monitor_history_detail { get; set; }
        public virtual DbSet<log_shipping_secondaries> log_shipping_secondaries { get; set; }
        public virtual DbSet<logmarkhistory> logmarkhistories { get; set; }
        public virtual DbSet<msdb_version> msdb_version { get; set; }
        public virtual DbSet<restorefile> restorefiles { get; set; }
        public virtual DbSet<restorefilegroup> restorefilegroups { get; set; }
        public virtual DbSet<sqlagent_info> sqlagent_info { get; set; }
        public virtual DbSet<suspect_pages> suspect_pages { get; set; }
        public virtual DbSet<sysalert> sysalerts { get; set; }
        public virtual DbSet<syscategory> syscategories { get; set; }
        public virtual DbSet<syscollector_tsql_query_collector> syscollector_tsql_query_collector { get; set; }
        public virtual DbSet<sysdbmaintplan_databases> sysdbmaintplan_databases { get; set; }
        public virtual DbSet<sysdbmaintplan_history> sysdbmaintplan_history { get; set; }
        public virtual DbSet<sysdbmaintplan_jobs> sysdbmaintplan_jobs { get; set; }
        public virtual DbSet<sysdownloadlist> sysdownloadlists { get; set; }
        public virtual DbSet<sysjobactivity> sysjobactivities { get; set; }
        public virtual DbSet<sysjobhistory> sysjobhistories { get; set; }
        public virtual DbSet<sysjob> sysjobs { get; set; }
        public virtual DbSet<sysjobschedule> sysjobschedules { get; set; }
        public virtual DbSet<sysjobserver> sysjobservers { get; set; }
        public virtual DbSet<sysjobstep> sysjobsteps { get; set; }
        public virtual DbSet<sysmail_attachments> sysmail_attachments { get; set; }
        public virtual DbSet<sysmaintplan_logdetail> sysmaintplan_logdetail { get; set; }
        public virtual DbSet<sysnotification> sysnotifications { get; set; }
        public virtual DbSet<sysoperator> sysoperators { get; set; }
        public virtual DbSet<sysoriginatingserver> sysoriginatingservers { get; set; }
        public virtual DbSet<syspolicy_facet_events> syspolicy_facet_events { get; set; }
        public virtual DbSet<sysproxy> sysproxies { get; set; }
        public virtual DbSet<sysproxylogin> sysproxylogins { get; set; }
        public virtual DbSet<sysproxysubsystem> sysproxysubsystems { get; set; }
        public virtual DbSet<syssubsystem> syssubsystems { get; set; }
        public virtual DbSet<systargetservergroupmember> systargetservergroupmembers { get; set; }
        public virtual DbSet<systargetservergroup> systargetservergroups { get; set; }
        public virtual DbSet<systargetserver> systargetservers { get; set; }
        public virtual DbSet<systaskid> systaskids { get; set; }
        public virtual DbSet<sysutility_mi_cpu_stage_internal> sysutility_mi_cpu_stage_internal { get; set; }
        public virtual DbSet<sysutility_mi_smo_stage_internal> sysutility_mi_smo_stage_internal { get; set; }
        public virtual DbSet<sysutility_mi_volumes_stage_internal> sysutility_mi_volumes_stage_internal { get; set; }
        public virtual DbSet<sysutility_ucp_aggregated_dac_health_internal> sysutility_ucp_aggregated_dac_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_aggregated_mi_health_internal> sysutility_ucp_aggregated_mi_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_computers_stub> sysutility_ucp_computers_stub { get; set; }
        public virtual DbSet<sysutility_ucp_cpu_utilization_stub> sysutility_ucp_cpu_utilization_stub { get; set; }
        public virtual DbSet<sysutility_ucp_dacs_stub> sysutility_ucp_dacs_stub { get; set; }
        public virtual DbSet<sysutility_ucp_databases_stub> sysutility_ucp_databases_stub { get; set; }
        public virtual DbSet<sysutility_ucp_datafiles_stub> sysutility_ucp_datafiles_stub { get; set; }
        public virtual DbSet<sysutility_ucp_filegroups_stub> sysutility_ucp_filegroups_stub { get; set; }
        public virtual DbSet<sysutility_ucp_logfiles_stub> sysutility_ucp_logfiles_stub { get; set; }
        public virtual DbSet<sysutility_ucp_space_utilization_stub> sysutility_ucp_space_utilization_stub { get; set; }
        public virtual DbSet<sysutility_ucp_volumes_stub> sysutility_ucp_volumes_stub { get; set; }
    }
}