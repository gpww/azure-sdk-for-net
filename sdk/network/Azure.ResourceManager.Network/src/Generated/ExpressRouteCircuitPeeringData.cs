// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the ExpressRouteCircuitPeering data model.
    /// Peering in an ExpressRouteCircuit resource.
    /// </summary>
    public partial class ExpressRouteCircuitPeeringData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitPeeringData"/>. </summary>
        public ExpressRouteCircuitPeeringData()
        {
            Connections = new ChangeTrackingList<ExpressRouteCircuitConnectionData>();
            PeeredConnections = new ChangeTrackingList<PeerExpressRouteCircuitConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitPeeringData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="peeringType"> The peering type. </param>
        /// <param name="state"> The peering state. </param>
        /// <param name="azureASN"> The Azure ASN. </param>
        /// <param name="peerASN"> The peer ASN. </param>
        /// <param name="primaryPeerAddressPrefix"> The primary address prefix. </param>
        /// <param name="secondaryPeerAddressPrefix"> The secondary address prefix. </param>
        /// <param name="primaryAzurePort"> The primary port. </param>
        /// <param name="secondaryAzurePort"> The secondary port. </param>
        /// <param name="sharedKey"> The shared key. </param>
        /// <param name="vlanId"> The VLAN ID. </param>
        /// <param name="microsoftPeeringConfig"> The Microsoft peering configuration. </param>
        /// <param name="stats"> The peering stats of express route circuit. </param>
        /// <param name="provisioningState"> The provisioning state of the express route circuit peering resource. </param>
        /// <param name="gatewayManagerETag"> The GatewayManager Etag. </param>
        /// <param name="lastModifiedBy"> Who was the last to modify the peering. </param>
        /// <param name="routeFilter"> The reference to the RouteFilter resource. </param>
        /// <param name="ipv6PeeringConfig"> The IPv6 peering configuration. </param>
        /// <param name="expressRouteConnection"> The ExpressRoute connection. </param>
        /// <param name="connections"> The list of circuit connections associated with Azure Private Peering for this circuit. </param>
        /// <param name="peeredConnections"> The list of peered circuit connections associated with Azure Private Peering for this circuit. </param>
        internal ExpressRouteCircuitPeeringData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, ExpressRoutePeeringType? peeringType, ExpressRoutePeeringState? state, int? azureASN, long? peerASN, string primaryPeerAddressPrefix, string secondaryPeerAddressPrefix, string primaryAzurePort, string secondaryAzurePort, string sharedKey, int? vlanId, ExpressRouteCircuitPeeringConfig microsoftPeeringConfig, ExpressRouteCircuitStats stats, NetworkProvisioningState? provisioningState, string gatewayManagerETag, string lastModifiedBy, WritableSubResource routeFilter, IPv6ExpressRouteCircuitPeeringConfig ipv6PeeringConfig, SubResource expressRouteConnection, IList<ExpressRouteCircuitConnectionData> connections, IReadOnlyList<PeerExpressRouteCircuitConnectionData> peeredConnections) : base(id, name, resourceType)
        {
            ETag = etag;
            PeeringType = peeringType;
            State = state;
            AzureASN = azureASN;
            PeerASN = peerASN;
            PrimaryPeerAddressPrefix = primaryPeerAddressPrefix;
            SecondaryPeerAddressPrefix = secondaryPeerAddressPrefix;
            PrimaryAzurePort = primaryAzurePort;
            SecondaryAzurePort = secondaryAzurePort;
            SharedKey = sharedKey;
            VlanId = vlanId;
            MicrosoftPeeringConfig = microsoftPeeringConfig;
            Stats = stats;
            ProvisioningState = provisioningState;
            GatewayManagerETag = gatewayManagerETag;
            LastModifiedBy = lastModifiedBy;
            RouteFilter = routeFilter;
            IPv6PeeringConfig = ipv6PeeringConfig;
            ExpressRouteConnection = expressRouteConnection;
            Connections = connections;
            PeeredConnections = peeredConnections;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The peering type. </summary>
        public ExpressRoutePeeringType? PeeringType { get; set; }
        /// <summary> The peering state. </summary>
        public ExpressRoutePeeringState? State { get; set; }
        /// <summary> The Azure ASN. </summary>
        public int? AzureASN { get; set; }
        /// <summary> The peer ASN. </summary>
        public long? PeerASN { get; set; }
        /// <summary> The primary address prefix. </summary>
        public string PrimaryPeerAddressPrefix { get; set; }
        /// <summary> The secondary address prefix. </summary>
        public string SecondaryPeerAddressPrefix { get; set; }
        /// <summary> The primary port. </summary>
        public string PrimaryAzurePort { get; set; }
        /// <summary> The secondary port. </summary>
        public string SecondaryAzurePort { get; set; }
        /// <summary> The shared key. </summary>
        public string SharedKey { get; set; }
        /// <summary> The VLAN ID. </summary>
        public int? VlanId { get; set; }
        /// <summary> The Microsoft peering configuration. </summary>
        public ExpressRouteCircuitPeeringConfig MicrosoftPeeringConfig { get; set; }
        /// <summary> The peering stats of express route circuit. </summary>
        public ExpressRouteCircuitStats Stats { get; set; }
        /// <summary> The provisioning state of the express route circuit peering resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The GatewayManager Etag. </summary>
        public string GatewayManagerETag { get; set; }
        /// <summary> Who was the last to modify the peering. </summary>
        public string LastModifiedBy { get; }
        /// <summary> The reference to the RouteFilter resource. </summary>
        internal WritableSubResource RouteFilter { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier RouteFilterId
        {
            get => RouteFilter is null ? default : RouteFilter.Id;
            set
            {
                if (RouteFilter is null)
                    RouteFilter = new WritableSubResource();
                RouteFilter.Id = value;
            }
        }

        /// <summary> The IPv6 peering configuration. </summary>
        public IPv6ExpressRouteCircuitPeeringConfig IPv6PeeringConfig { get; set; }
        /// <summary> The ExpressRoute connection. </summary>
        internal SubResource ExpressRouteConnection { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier ExpressRouteConnectionId
        {
            get => ExpressRouteConnection is null ? default : ExpressRouteConnection.Id;
        }

        /// <summary> The list of circuit connections associated with Azure Private Peering for this circuit. </summary>
        public IList<ExpressRouteCircuitConnectionData> Connections { get; }
        /// <summary> The list of peered circuit connections associated with Azure Private Peering for this circuit. </summary>
        public IReadOnlyList<PeerExpressRouteCircuitConnectionData> PeeredConnections { get; }
    }
}
