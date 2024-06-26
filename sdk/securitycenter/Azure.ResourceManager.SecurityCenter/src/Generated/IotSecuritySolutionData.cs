// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the IotSecuritySolution data model.
    /// IoT Security solution configuration and resource information.
    /// </summary>
    public partial class IotSecuritySolutionData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionData"/>. </summary>
        /// <param name="location"> The location. </param>
        public IotSecuritySolutionData(AzureLocation location) : base(location)
        {
            Export = new ChangeTrackingList<IotSecuritySolutionExportOption>();
            DisabledDataSources = new ChangeTrackingList<IotSecuritySolutionDataSource>();
            IotHubs = new ChangeTrackingList<string>();
            AutoDiscoveredResources = new ChangeTrackingList<string>();
            RecommendationsConfiguration = new ChangeTrackingList<RecommendationConfigurationProperties>();
            AdditionalWorkspaces = new ChangeTrackingList<AdditionalWorkspacesProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="workspace"> Workspace resource ID. </param>
        /// <param name="displayName"> Resource display name. </param>
        /// <param name="status"> Status of the IoT Security solution. </param>
        /// <param name="export"> List of additional options for exporting to workspace data. </param>
        /// <param name="disabledDataSources"> Disabled data sources. Disabling these data sources compromises the system. </param>
        /// <param name="iotHubs"> IoT Hub resource IDs. </param>
        /// <param name="userDefinedResources"> Properties of the IoT Security solution's user defined resources. </param>
        /// <param name="autoDiscoveredResources"> List of resources that were automatically discovered as relevant to the security solution. </param>
        /// <param name="recommendationsConfiguration"> List of the configuration status for each recommendation type. </param>
        /// <param name="unmaskedIPLoggingStatus"> Unmasked IP address logging status. </param>
        /// <param name="additionalWorkspaces"> List of additional workspaces. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotSecuritySolutionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string workspace, string displayName, SecuritySolutionStatus? status, IList<IotSecuritySolutionExportOption> export, IList<IotSecuritySolutionDataSource> disabledDataSources, IList<string> iotHubs, UserDefinedResourcesProperties userDefinedResources, IReadOnlyList<string> autoDiscoveredResources, IList<RecommendationConfigurationProperties> recommendationsConfiguration, UnmaskedIPLoggingStatus? unmaskedIPLoggingStatus, IList<AdditionalWorkspacesProperties> additionalWorkspaces, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Workspace = workspace;
            DisplayName = displayName;
            Status = status;
            Export = export;
            DisabledDataSources = disabledDataSources;
            IotHubs = iotHubs;
            UserDefinedResources = userDefinedResources;
            AutoDiscoveredResources = autoDiscoveredResources;
            RecommendationsConfiguration = recommendationsConfiguration;
            UnmaskedIPLoggingStatus = unmaskedIPLoggingStatus;
            AdditionalWorkspaces = additionalWorkspaces;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionData"/> for deserialization. </summary>
        internal IotSecuritySolutionData()
        {
        }

        /// <summary> Workspace resource ID. </summary>
        public string Workspace { get; set; }
        /// <summary> Resource display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Status of the IoT Security solution. </summary>
        public SecuritySolutionStatus? Status { get; set; }
        /// <summary> List of additional options for exporting to workspace data. </summary>
        public IList<IotSecuritySolutionExportOption> Export { get; }
        /// <summary> Disabled data sources. Disabling these data sources compromises the system. </summary>
        public IList<IotSecuritySolutionDataSource> DisabledDataSources { get; }
        /// <summary> IoT Hub resource IDs. </summary>
        public IList<string> IotHubs { get; }
        /// <summary> Properties of the IoT Security solution's user defined resources. </summary>
        public UserDefinedResourcesProperties UserDefinedResources { get; set; }
        /// <summary> List of resources that were automatically discovered as relevant to the security solution. </summary>
        public IReadOnlyList<string> AutoDiscoveredResources { get; }
        /// <summary> List of the configuration status for each recommendation type. </summary>
        public IList<RecommendationConfigurationProperties> RecommendationsConfiguration { get; }
        /// <summary> Unmasked IP address logging status. </summary>
        public UnmaskedIPLoggingStatus? UnmaskedIPLoggingStatus { get; set; }
        /// <summary> List of additional workspaces. </summary>
        public IList<AdditionalWorkspacesProperties> AdditionalWorkspaces { get; }
    }
}
