// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Analysis.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Analysis
{
    /// <summary>
    /// A class representing the AnalysisServer data model.
    /// Represents an instance of an Analysis Services resource.
    /// </summary>
    public partial class AnalysisServerData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of AnalysisServerData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="analysisSku"> The SKU of the Analysis Services resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisSku"/> is null. </exception>
        public AnalysisServerData(AzureLocation location, AnalysisResourceSku analysisSku) : base(location)
        {
            Argument.AssertNotNull(analysisSku, nameof(analysisSku));

            AnalysisSku = analysisSku;
        }

        /// <summary> Initializes a new instance of AnalysisServerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="asAdministrators"> A collection of AS server administrators. </param>
        /// <param name="backupBlobContainerUri"> The SAS container URI to the backup container. </param>
        /// <param name="gatewayDetails"> The gateway details configured for the AS server. </param>
        /// <param name="iPv4FirewallSettings"> The firewall settings for the AS server. </param>
        /// <param name="queryPoolConnectionMode"> How the read-write server's participation in the query pool is controlled.&lt;br/&gt;It can have the following values: &lt;ul&gt;&lt;li&gt;readOnly - indicates that the read-write server is intended not to participate in query operations&lt;/li&gt;&lt;li&gt;all - indicates that the read-write server can participate in query operations&lt;/li&gt;&lt;/ul&gt;Specifying readOnly when capacity is 1 results in error. </param>
        /// <param name="managedMode"> The managed mode of the server (0 = not managed, 1 = managed). </param>
        /// <param name="serverMonitorMode"> The server monitor mode for AS server. </param>
        /// <param name="state"> The current state of Analysis Services resource. The state is to indicate more states outside of resource provisioning. </param>
        /// <param name="provisioningState"> The current deployment state of Analysis Services resource. The provisioningState is to indicate states for resource provisioning. </param>
        /// <param name="serverFullName"> The full name of the Analysis Services resource. </param>
        /// <param name="analysisServerSku"> The SKU of the Analysis Services resource. </param>
        /// <param name="analysisSku"> The SKU of the Analysis Services resource. </param>
        internal AnalysisServerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ServerAdministrators asAdministrators, Uri backupBlobContainerUri, AnalysisGatewayDetails gatewayDetails, AnalysisIPv4FirewallSettings iPv4FirewallSettings, AnalysisConnectionMode? queryPoolConnectionMode, AnalysisManagedMode? managedMode, ServerMonitorMode? serverMonitorMode, AnalysisState? state, AnalysisProvisioningState? provisioningState, string serverFullName, AnalysisResourceSku analysisServerSku, AnalysisResourceSku analysisSku) : base(id, name, resourceType, systemData, tags, location)
        {
            AsAdministrators = asAdministrators;
            BackupBlobContainerUri = backupBlobContainerUri;
            GatewayDetails = gatewayDetails;
            IPv4FirewallSettings = iPv4FirewallSettings;
            QueryPoolConnectionMode = queryPoolConnectionMode;
            ManagedMode = managedMode;
            ServerMonitorMode = serverMonitorMode;
            State = state;
            ProvisioningState = provisioningState;
            ServerFullName = serverFullName;
            AnalysisServerSku = analysisServerSku;
            AnalysisSku = analysisSku;
        }

        /// <summary> A collection of AS server administrators. </summary>
        internal ServerAdministrators AsAdministrators { get; set; }
        /// <summary> An array of administrator user identities. </summary>
        public IList<string> AsAdministratorIdentities
        {
            get
            {
                if (AsAdministrators is null)
                    AsAdministrators = new ServerAdministrators();
                return AsAdministrators.AsAdministratorIdentities;
            }
        }

        /// <summary> The SAS container URI to the backup container. </summary>
        public Uri BackupBlobContainerUri { get; set; }
        /// <summary> The gateway details configured for the AS server. </summary>
        public AnalysisGatewayDetails GatewayDetails { get; set; }
        /// <summary> The firewall settings for the AS server. </summary>
        public AnalysisIPv4FirewallSettings IPv4FirewallSettings { get; set; }
        /// <summary> How the read-write server's participation in the query pool is controlled.&lt;br/&gt;It can have the following values: &lt;ul&gt;&lt;li&gt;readOnly - indicates that the read-write server is intended not to participate in query operations&lt;/li&gt;&lt;li&gt;all - indicates that the read-write server can participate in query operations&lt;/li&gt;&lt;/ul&gt;Specifying readOnly when capacity is 1 results in error. </summary>
        public AnalysisConnectionMode? QueryPoolConnectionMode { get; set; }
        /// <summary> The managed mode of the server (0 = not managed, 1 = managed). </summary>
        public AnalysisManagedMode? ManagedMode { get; set; }
        /// <summary> The server monitor mode for AS server. </summary>
        public ServerMonitorMode? ServerMonitorMode { get; set; }
        /// <summary> The current state of Analysis Services resource. The state is to indicate more states outside of resource provisioning. </summary>
        public AnalysisState? State { get; }
        /// <summary> The current deployment state of Analysis Services resource. The provisioningState is to indicate states for resource provisioning. </summary>
        public AnalysisProvisioningState? ProvisioningState { get; }
        /// <summary> The full name of the Analysis Services resource. </summary>
        public string ServerFullName { get; }
        /// <summary> The SKU of the Analysis Services resource. </summary>
        public AnalysisResourceSku AnalysisServerSku { get; set; }
        /// <summary> The SKU of the Analysis Services resource. </summary>
        public AnalysisResourceSku AnalysisSku { get; set; }
    }
}
