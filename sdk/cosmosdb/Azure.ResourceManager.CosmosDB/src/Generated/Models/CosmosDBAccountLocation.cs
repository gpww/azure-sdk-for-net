// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> A region in which the Azure Cosmos DB database account is deployed. </summary>
    public partial class CosmosDBAccountLocation
    {
        /// <summary> Initializes a new instance of CosmosDBAccountLocation. </summary>
        public CosmosDBAccountLocation()
        {
        }

        /// <summary> Initializes a new instance of CosmosDBAccountLocation. </summary>
        /// <param name="id"> The unique identifier of the region within the database account. Example: &lt;accountName&gt;-&lt;locationName&gt;. </param>
        /// <param name="locationName"> The name of the region. </param>
        /// <param name="documentEndpoint"> The connection endpoint for the specific region. Example: https://&lt;accountName&gt;-&lt;locationName&gt;.documents.azure.com:443/. </param>
        /// <param name="provisioningState"> The status of the Cosmos DB account at the time the operation was called. The status can be one of following. 'Creating' – the Cosmos DB account is being created. When an account is in Creating state, only properties that are specified as input for the Create Cosmos DB account operation are returned. 'Succeeded' – the Cosmos DB account is active for use. 'Updating' – the Cosmos DB account is being updated. 'Deleting' – the Cosmos DB account is being deleted. 'Failed' – the Cosmos DB account failed creation. 'DeletionFailed' – the Cosmos DB account deletion failed. </param>
        /// <param name="failoverPriority"> The failover priority of the region. A failover priority of 0 indicates a write region. The maximum value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the regions in which the database account exists. </param>
        /// <param name="isZoneRedundant"> Flag to indicate whether or not this region is an AvailabilityZone region. </param>
        internal CosmosDBAccountLocation(string id, AzureLocation? locationName, string documentEndpoint, string provisioningState, int? failoverPriority, bool? isZoneRedundant)
        {
            Id = id;
            LocationName = locationName;
            DocumentEndpoint = documentEndpoint;
            ProvisioningState = provisioningState;
            FailoverPriority = failoverPriority;
            IsZoneRedundant = isZoneRedundant;
        }

        /// <summary> The unique identifier of the region within the database account. Example: &lt;accountName&gt;-&lt;locationName&gt;. </summary>
        public string Id { get; }
        /// <summary> The name of the region. </summary>
        public AzureLocation? LocationName { get; set; }
        /// <summary> The connection endpoint for the specific region. Example: https://&lt;accountName&gt;-&lt;locationName&gt;.documents.azure.com:443/. </summary>
        public string DocumentEndpoint { get; }
        /// <summary> The status of the Cosmos DB account at the time the operation was called. The status can be one of following. 'Creating' – the Cosmos DB account is being created. When an account is in Creating state, only properties that are specified as input for the Create Cosmos DB account operation are returned. 'Succeeded' – the Cosmos DB account is active for use. 'Updating' – the Cosmos DB account is being updated. 'Deleting' – the Cosmos DB account is being deleted. 'Failed' – the Cosmos DB account failed creation. 'DeletionFailed' – the Cosmos DB account deletion failed. </summary>
        public string ProvisioningState { get; }
        /// <summary> The failover priority of the region. A failover priority of 0 indicates a write region. The maximum value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the regions in which the database account exists. </summary>
        public int? FailoverPriority { get; set; }
        /// <summary> Flag to indicate whether or not this region is an AvailabilityZone region. </summary>
        public bool? IsZoneRedundant { get; set; }
    }
}
