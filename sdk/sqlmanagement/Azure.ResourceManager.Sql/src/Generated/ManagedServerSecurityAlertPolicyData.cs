// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ManagedServerSecurityAlertPolicy data model. </summary>
    public partial class ManagedServerSecurityAlertPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagedServerSecurityAlertPolicyData. </summary>
        public ManagedServerSecurityAlertPolicyData()
        {
            DisabledAlerts = new ChangeTrackingList<string>();
            EmailAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ManagedServerSecurityAlertPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"> Specifies the state of the policy, whether it is enabled or disabled or a policy has not been applied yet on the specific database. </param>
        /// <param name="disabledAlerts"> Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly, Data_Exfiltration, Unsafe_Action, Brute_Force. </param>
        /// <param name="emailAddresses"> Specifies an array of e-mail addresses to which the alert is sent. </param>
        /// <param name="emailAccountAdmins"> Specifies that the alert is sent to the account administrators. </param>
        /// <param name="storageEndpoint"> Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. </param>
        /// <param name="storageAccountAccessKey"> Specifies the identifier key of the Threat Detection audit storage account. </param>
        /// <param name="retentionDays"> Specifies the number of days to keep in the Threat Detection audit logs. </param>
        /// <param name="creationTime"> Specifies the UTC creation time of the policy. </param>
        internal ManagedServerSecurityAlertPolicyData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, SecurityAlertsPolicyState? state, IList<string> disabledAlerts, IList<string> emailAddresses, bool? emailAccountAdmins, string storageEndpoint, string storageAccountAccessKey, int? retentionDays, DateTimeOffset? creationTime) : base(id, name, type, systemData)
        {
            State = state;
            DisabledAlerts = disabledAlerts;
            EmailAddresses = emailAddresses;
            EmailAccountAdmins = emailAccountAdmins;
            StorageEndpoint = storageEndpoint;
            StorageAccountAccessKey = storageAccountAccessKey;
            RetentionDays = retentionDays;
            CreationTime = creationTime;
        }

        /// <summary> Specifies the state of the policy, whether it is enabled or disabled or a policy has not been applied yet on the specific database. </summary>
        public SecurityAlertsPolicyState? State { get; set; }
        /// <summary> Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly, Data_Exfiltration, Unsafe_Action, Brute_Force. </summary>
        public IList<string> DisabledAlerts { get; }
        /// <summary> Specifies an array of e-mail addresses to which the alert is sent. </summary>
        public IList<string> EmailAddresses { get; }
        /// <summary> Specifies that the alert is sent to the account administrators. </summary>
        public bool? EmailAccountAdmins { get; set; }
        /// <summary> Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. </summary>
        public string StorageEndpoint { get; set; }
        /// <summary> Specifies the identifier key of the Threat Detection audit storage account. </summary>
        public string StorageAccountAccessKey { get; set; }
        /// <summary> Specifies the number of days to keep in the Threat Detection audit logs. </summary>
        public int? RetentionDays { get; set; }
        /// <summary> Specifies the UTC creation time of the policy. </summary>
        public DateTimeOffset? CreationTime { get; }
    }
}
