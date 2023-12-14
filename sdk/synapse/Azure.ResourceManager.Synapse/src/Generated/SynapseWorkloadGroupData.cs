// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseWorkloadGroup data model.
    /// Workload group operations for a sql pool
    /// </summary>
    public partial class SynapseWorkloadGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SynapseWorkloadGroupData"/>. </summary>
        public SynapseWorkloadGroupData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseWorkloadGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="minResourcePercent"> The workload group minimum percentage resource. </param>
        /// <param name="maxResourcePercent"> The workload group cap percentage resource. </param>
        /// <param name="minResourcePercentPerRequest"> The workload group request minimum grant percentage. </param>
        /// <param name="maxResourcePercentPerRequest"> The workload group request maximum grant percentage. </param>
        /// <param name="importance"> The workload group importance level. </param>
        /// <param name="queryExecutionTimeout"> The workload group query execution timeout. </param>
        internal SynapseWorkloadGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? minResourcePercent, int? maxResourcePercent, double? minResourcePercentPerRequest, double? maxResourcePercentPerRequest, string importance, int? queryExecutionTimeout) : base(id, name, resourceType, systemData)
        {
            MinResourcePercent = minResourcePercent;
            MaxResourcePercent = maxResourcePercent;
            MinResourcePercentPerRequest = minResourcePercentPerRequest;
            MaxResourcePercentPerRequest = maxResourcePercentPerRequest;
            Importance = importance;
            QueryExecutionTimeout = queryExecutionTimeout;
        }

        /// <summary> The workload group minimum percentage resource. </summary>
        public int? MinResourcePercent { get; set; }
        /// <summary> The workload group cap percentage resource. </summary>
        public int? MaxResourcePercent { get; set; }
        /// <summary> The workload group request minimum grant percentage. </summary>
        public double? MinResourcePercentPerRequest { get; set; }
        /// <summary> The workload group request maximum grant percentage. </summary>
        public double? MaxResourcePercentPerRequest { get; set; }
        /// <summary> The workload group importance level. </summary>
        public string Importance { get; set; }
        /// <summary> The workload group query execution timeout. </summary>
        public int? QueryExecutionTimeout { get; set; }
    }
}
