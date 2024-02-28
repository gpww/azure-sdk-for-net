// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmPeeringModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.CdnPeeringPrefix"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="prefix"> The prefix. </param>
        /// <param name="azureRegion"> The Azure region. </param>
        /// <param name="azureService"> The Azure service. </param>
        /// <param name="isPrimaryRegion"> The flag that indicates whether or not this is the primary region. </param>
        /// <param name="bgpCommunity"> The BGP Community. </param>
        /// <returns> A new <see cref="Models.CdnPeeringPrefix"/> instance for mocking. </returns>
        public static CdnPeeringPrefix CdnPeeringPrefix(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string prefix = null, AzureLocation? azureRegion = null, string azureService = null, bool? isPrimaryRegion = null, string bgpCommunity = null)
        {
            return new CdnPeeringPrefix(
                id,
                name,
                resourceType,
                systemData,
                prefix,
                azureRegion,
                azureService,
                isPrimaryRegion,
                bgpCommunity,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Peering.PeeringData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU that defines the tier and kind of the peering. </param>
        /// <param name="kind"> The kind of the peering. </param>
        /// <param name="direct"> The properties that define a direct peering. </param>
        /// <param name="exchange"> The properties that define an exchange peering. </param>
        /// <param name="peeringLocation"> The location of the peering. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <returns> A new <see cref="Peering.PeeringData"/> instance for mocking. </returns>
        public static PeeringData PeeringData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, PeeringSku sku = null, PeeringKind kind = default, DirectPeeringProperties direct = null, ExchangePeeringProperties exchange = null, string peeringLocation = null, PeeringProvisioningState? provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new PeeringData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                sku,
                kind,
                direct,
                exchange,
                peeringLocation,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PeeringSku"/>. </summary>
        /// <param name="name"> The name of the peering SKU. </param>
        /// <param name="tier"> The tier of the peering SKU. </param>
        /// <param name="family"> The family of the peering SKU. </param>
        /// <param name="size"> The size of the peering SKU. </param>
        /// <returns> A new <see cref="Models.PeeringSku"/> instance for mocking. </returns>
        public static PeeringSku PeeringSku(string name = null, PeeringTier? tier = null, PeeringFamily? family = null, PeeringSize? size = null)
        {
            return new PeeringSku(name, tier, family, size, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DirectPeeringProperties"/>. </summary>
        /// <param name="connections"> The set of connections that constitute a direct peering. </param>
        /// <param name="useForPeeringService"> The flag that indicates whether or not the peering is used for peering service. </param>
        /// <param name="peerAsnId"> The reference of the peer ASN. </param>
        /// <param name="directPeeringType"> The type of direct peering. </param>
        /// <returns> A new <see cref="Models.DirectPeeringProperties"/> instance for mocking. </returns>
        public static DirectPeeringProperties DirectPeeringProperties(IEnumerable<PeeringDirectConnection> connections = null, bool? useForPeeringService = null, ResourceIdentifier peerAsnId = null, DirectPeeringType? directPeeringType = null)
        {
            connections ??= new List<PeeringDirectConnection>();

            return new DirectPeeringProperties(connections?.ToList(), useForPeeringService, peerAsnId != null ? ResourceManagerModelFactory.WritableSubResource(peerAsnId) : null, directPeeringType, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PeeringDirectConnection"/>. </summary>
        /// <param name="bandwidthInMbps"> The bandwidth of the connection. </param>
        /// <param name="provisionedBandwidthInMbps"> The bandwidth that is actually provisioned. </param>
        /// <param name="sessionAddressProvider"> The field indicating if Microsoft provides session ip addresses. </param>
        /// <param name="useForPeeringService"> The flag that indicates whether or not the connection is used for peering service. </param>
        /// <param name="microsoftTrackingId"> The ID used within Microsoft's peering provisioning system to track the connection. </param>
        /// <param name="peeringDBFacilityId"> The PeeringDB.com ID of the facility at which the connection has to be set up. </param>
        /// <param name="connectionState"> The state of the connection. </param>
        /// <param name="bgpSession"> The BGP session associated with the connection. </param>
        /// <param name="connectionIdentifier"> The unique identifier (GUID) for the connection. </param>
        /// <param name="errorMessage"> The error message related to the connection state, if any. </param>
        /// <returns> A new <see cref="Models.PeeringDirectConnection"/> instance for mocking. </returns>
        public static PeeringDirectConnection PeeringDirectConnection(int? bandwidthInMbps = null, int? provisionedBandwidthInMbps = null, PeeringSessionAddressProvider? sessionAddressProvider = null, bool? useForPeeringService = null, string microsoftTrackingId = null, int? peeringDBFacilityId = null, PeeringConnectionState? connectionState = null, PeeringBgpSession bgpSession = null, string connectionIdentifier = null, string errorMessage = null)
        {
            return new PeeringDirectConnection(
                bandwidthInMbps,
                provisionedBandwidthInMbps,
                sessionAddressProvider,
                useForPeeringService,
                microsoftTrackingId,
                peeringDBFacilityId,
                connectionState,
                bgpSession,
                connectionIdentifier,
                errorMessage,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PeeringBgpSession"/>. </summary>
        /// <param name="sessionPrefixV4"> The IPv4 prefix that contains both ends' IPv4 addresses. </param>
        /// <param name="sessionPrefixV6"> The IPv6 prefix that contains both ends' IPv6 addresses. </param>
        /// <param name="microsoftSessionIPv4Address"> The IPv4 session address on Microsoft's end. </param>
        /// <param name="microsoftSessionIPv6Address"> The IPv6 session address on Microsoft's end. </param>
        /// <param name="peerSessionIPv4Address"> The IPv4 session address on peer's end. </param>
        /// <param name="peerSessionIPv6Address"> The IPv6 session address on peer's end. </param>
        /// <param name="sessionStateV4"> The state of the IPv4 session. </param>
        /// <param name="sessionStateV6"> The state of the IPv6 session. </param>
        /// <param name="maxPrefixesAdvertisedV4"> The maximum number of prefixes advertised over the IPv4 session. </param>
        /// <param name="maxPrefixesAdvertisedV6"> The maximum number of prefixes advertised over the IPv6 session. </param>
        /// <param name="md5AuthenticationKey"> The MD5 authentication key of the session. </param>
        /// <returns> A new <see cref="Models.PeeringBgpSession"/> instance for mocking. </returns>
        public static PeeringBgpSession PeeringBgpSession(string sessionPrefixV4 = null, string sessionPrefixV6 = null, IPAddress microsoftSessionIPv4Address = null, IPAddress microsoftSessionIPv6Address = null, IPAddress peerSessionIPv4Address = null, IPAddress peerSessionIPv6Address = null, PeeringSessionStateV4? sessionStateV4 = null, PeeringSessionStateV6? sessionStateV6 = null, int? maxPrefixesAdvertisedV4 = null, int? maxPrefixesAdvertisedV6 = null, string md5AuthenticationKey = null)
        {
            return new PeeringBgpSession(
                sessionPrefixV4,
                sessionPrefixV6,
                microsoftSessionIPv4Address,
                microsoftSessionIPv6Address,
                peerSessionIPv4Address,
                peerSessionIPv6Address,
                sessionStateV4,
                sessionStateV6,
                maxPrefixesAdvertisedV4,
                maxPrefixesAdvertisedV6,
                md5AuthenticationKey,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PeeringExchangeConnection"/>. </summary>
        /// <param name="peeringDBFacilityId"> The PeeringDB.com ID of the facility at which the connection has to be set up. </param>
        /// <param name="connectionState"> The state of the connection. </param>
        /// <param name="bgpSession"> The BGP session associated with the connection. </param>
        /// <param name="connectionIdentifier"> The unique identifier (GUID) for the connection. </param>
        /// <param name="errorMessage"> The error message related to the connection state, if any. </param>
        /// <returns> A new <see cref="Models.PeeringExchangeConnection"/> instance for mocking. </returns>
        public static PeeringExchangeConnection PeeringExchangeConnection(int? peeringDBFacilityId = null, PeeringConnectionState? connectionState = null, PeeringBgpSession bgpSession = null, Guid? connectionIdentifier = null, string errorMessage = null)
        {
            return new PeeringExchangeConnection(
                peeringDBFacilityId,
                connectionState,
                bgpSession,
                connectionIdentifier,
                errorMessage,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LookingGlassOutput"/>. </summary>
        /// <param name="command"> Invoked command. </param>
        /// <param name="output"> Output of the command. </param>
        /// <returns> A new <see cref="Models.LookingGlassOutput"/> instance for mocking. </returns>
        public static LookingGlassOutput LookingGlassOutput(LookingGlassCommand? command = null, string output = null)
        {
            return new LookingGlassOutput(command, output, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Peering.PeerAsnData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="peerAsn"> The Autonomous System Number (ASN) of the peer. </param>
        /// <param name="peerContactDetail"> The contact details of the peer. </param>
        /// <param name="peerName"> The name of the peer. </param>
        /// <param name="validationState"> The validation state of the ASN associated with the peer. </param>
        /// <param name="errorMessage"> The error message for the validation state. </param>
        /// <returns> A new <see cref="Peering.PeerAsnData"/> instance for mocking. </returns>
        public static PeerAsnData PeerAsnData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, int? peerAsn = null, IEnumerable<PeerAsnContactDetail> peerContactDetail = null, string peerName = null, PeerAsnValidationState? validationState = null, string errorMessage = null)
        {
            peerContactDetail ??= new List<PeerAsnContactDetail>();

            return new PeerAsnData(
                id,
                name,
                resourceType,
                systemData,
                peerAsn,
                peerContactDetail?.ToList(),
                peerName,
                validationState,
                errorMessage,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PeeringLocation"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of peering that the peering location supports. </param>
        /// <param name="direct"> The properties that define a direct peering location. </param>
        /// <param name="exchangePeeringFacilities"> The properties that define an exchange peering location. </param>
        /// <param name="peeringLocationValue"> The name of the peering location. </param>
        /// <param name="country"> The country in which the peering location exists. </param>
        /// <param name="azureRegion"> The Azure region associated with the peering location. </param>
        /// <returns> A new <see cref="Models.PeeringLocation"/> instance for mocking. </returns>
        public static PeeringLocation PeeringLocation(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PeeringKind? kind = null, DirectPeeringLocationProperties direct = null, IEnumerable<ExchangePeeringFacility> exchangePeeringFacilities = null, string peeringLocationValue = null, string country = null, AzureLocation? azureRegion = null)
        {
            exchangePeeringFacilities ??= new List<ExchangePeeringFacility>();

            return new PeeringLocation(
                id,
                name,
                resourceType,
                systemData,
                kind,
                direct,
                exchangePeeringFacilities != null ? new PeeringLocationPropertiesExchange(exchangePeeringFacilities?.ToList(), serializedAdditionalRawData: null) : null,
                peeringLocationValue,
                country,
                azureRegion,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Peering.PeeringRegisteredAsnData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="asn"> The customer's ASN from which traffic originates. </param>
        /// <param name="peeringServicePrefixKey"> The peering service prefix key that is to be shared with the customer. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <returns> A new <see cref="Peering.PeeringRegisteredAsnData"/> instance for mocking. </returns>
        public static PeeringRegisteredAsnData PeeringRegisteredAsnData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, int? asn = null, string peeringServicePrefixKey = null, PeeringProvisioningState? provisioningState = null)
        {
            return new PeeringRegisteredAsnData(
                id,
                name,
                resourceType,
                systemData,
                asn,
                peeringServicePrefixKey,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Peering.PeeringRegisteredPrefixData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="prefix"> The customer's prefix from which traffic originates. </param>
        /// <param name="prefixValidationState"> The prefix validation state. </param>
        /// <param name="peeringServicePrefixKey"> The peering service prefix key that is to be shared with the customer. </param>
        /// <param name="errorMessage"> The error message associated with the validation state, if any. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <returns> A new <see cref="Peering.PeeringRegisteredPrefixData"/> instance for mocking. </returns>
        public static PeeringRegisteredPrefixData PeeringRegisteredPrefixData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string prefix = null, PeeringPrefixValidationState? prefixValidationState = null, string peeringServicePrefixKey = null, string errorMessage = null, PeeringProvisioningState? provisioningState = null)
        {
            return new PeeringRegisteredPrefixData(
                id,
                name,
                resourceType,
                systemData,
                prefix,
                prefixValidationState,
                peeringServicePrefixKey,
                errorMessage,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PeeringReceivedRoute"/>. </summary>
        /// <param name="prefix"> The prefix. </param>
        /// <param name="nextHop"> The next hop for the prefix. </param>
        /// <param name="asPath"> The AS path for the prefix. </param>
        /// <param name="originAsValidationState"> The origin AS change information for the prefix. </param>
        /// <param name="rpkiValidationState"> The RPKI validation state for the prefix and origin AS that's listed in the AS path. </param>
        /// <param name="trustAnchor"> The authority which holds the Route Origin Authorization record for the prefix, if any. </param>
        /// <param name="receivedTimestamp"> The received timestamp associated with the prefix. </param>
        /// <returns> A new <see cref="Models.PeeringReceivedRoute"/> instance for mocking. </returns>
        public static PeeringReceivedRoute PeeringReceivedRoute(string prefix = null, string nextHop = null, string asPath = null, string originAsValidationState = null, string rpkiValidationState = null, string trustAnchor = null, string receivedTimestamp = null)
        {
            return new PeeringReceivedRoute(
                prefix,
                nextHop,
                asPath,
                originAsValidationState,
                rpkiValidationState,
                trustAnchor,
                receivedTimestamp,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Peering.ConnectionMonitorTestData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sourceAgent"> The Connection Monitor test source agent. </param>
        /// <param name="destination"> The Connection Monitor test destination. </param>
        /// <param name="destinationPort"> The Connection Monitor test destination port. </param>
        /// <param name="testFrequencyInSec"> The Connection Monitor test frequency in seconds. </param>
        /// <param name="isTestSuccessful"> The flag that indicates if the Connection Monitor test is successful or not. </param>
        /// <param name="path"> The path representing the Connection Monitor test. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <returns> A new <see cref="Peering.ConnectionMonitorTestData"/> instance for mocking. </returns>
        public static ConnectionMonitorTestData ConnectionMonitorTestData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string sourceAgent = null, string destination = null, int? destinationPort = null, int? testFrequencyInSec = null, bool? isTestSuccessful = null, IEnumerable<string> path = null, PeeringProvisioningState? provisioningState = null)
        {
            path ??= new List<string>();

            return new ConnectionMonitorTestData(
                id,
                name,
                resourceType,
                systemData,
                sourceAgent,
                destination,
                destinationPort,
                testFrequencyInSec,
                isTestSuccessful,
                path?.ToList(),
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PeeringServiceCountry"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <returns> A new <see cref="Models.PeeringServiceCountry"/> instance for mocking. </returns>
        public static PeeringServiceCountry PeeringServiceCountry(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null)
        {
            return new PeeringServiceCountry(id, name, resourceType, systemData, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PeeringServiceLocation"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="country"> Country of the customer. </param>
        /// <param name="state"> State of the customer. </param>
        /// <param name="azureRegion"> Azure region for the location. </param>
        /// <returns> A new <see cref="Models.PeeringServiceLocation"/> instance for mocking. </returns>
        public static PeeringServiceLocation PeeringServiceLocation(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string country = null, string state = null, AzureLocation? azureRegion = null)
        {
            return new PeeringServiceLocation(
                id,
                name,
                resourceType,
                systemData,
                country,
                state,
                azureRegion,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Peering.PeeringServicePrefixData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="prefix"> The prefix from which your traffic originates. </param>
        /// <param name="prefixValidationState"> The prefix validation state. </param>
        /// <param name="learnedType"> The prefix learned type. </param>
        /// <param name="errorMessage"> The error message for validation state. </param>
        /// <param name="events"> The list of events for peering service prefix. </param>
        /// <param name="peeringServicePrefixKey"> The peering service prefix key. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <returns> A new <see cref="Peering.PeeringServicePrefixData"/> instance for mocking. </returns>
        public static PeeringServicePrefixData PeeringServicePrefixData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string prefix = null, PeeringPrefixValidationState? prefixValidationState = null, PeeringLearnedType? learnedType = null, string errorMessage = null, IEnumerable<PeeringServicePrefixEvent> events = null, string peeringServicePrefixKey = null, PeeringProvisioningState? provisioningState = null)
        {
            events ??= new List<PeeringServicePrefixEvent>();

            return new PeeringServicePrefixData(
                id,
                name,
                resourceType,
                systemData,
                prefix,
                prefixValidationState,
                learnedType,
                errorMessage,
                events?.ToList(),
                peeringServicePrefixKey,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PeeringServicePrefixEvent"/>. </summary>
        /// <param name="eventTimestamp"> The timestamp of the event associated with a prefix. </param>
        /// <param name="eventType"> The type of the event associated with a prefix. </param>
        /// <param name="eventSummary"> The summary of the event associated with a prefix. </param>
        /// <param name="eventLevel"> The level of the event associated with a prefix. </param>
        /// <param name="eventDescription"> The description of the event associated with a prefix. </param>
        /// <returns> A new <see cref="Models.PeeringServicePrefixEvent"/> instance for mocking. </returns>
        public static PeeringServicePrefixEvent PeeringServicePrefixEvent(DateTimeOffset? eventTimestamp = null, string eventType = null, string eventSummary = null, string eventLevel = null, string eventDescription = null)
        {
            return new PeeringServicePrefixEvent(
                eventTimestamp,
                eventType,
                eventSummary,
                eventLevel,
                eventDescription,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PeeringServiceProvider"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="serviceProviderName"> The name of the service provider. </param>
        /// <param name="peeringLocations"> The list of locations at which the service provider peers with Microsoft. </param>
        /// <returns> A new <see cref="Models.PeeringServiceProvider"/> instance for mocking. </returns>
        public static PeeringServiceProvider PeeringServiceProvider(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string serviceProviderName = null, IEnumerable<string> peeringLocations = null)
        {
            peeringLocations ??= new List<string>();

            return new PeeringServiceProvider(
                id,
                name,
                resourceType,
                systemData,
                serviceProviderName,
                peeringLocations?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Peering.PeeringServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="skuName"> The SKU that defines the type of the peering service. </param>
        /// <param name="peeringServiceLocation"> The location (state/province) of the customer. </param>
        /// <param name="peeringServiceProvider"> The name of the service provider. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="providerPrimaryPeeringLocation"> The primary peering (Microsoft/service provider) location to be used for customer traffic. </param>
        /// <param name="providerBackupPeeringLocation"> The backup peering (Microsoft/service provider) location to be used for customer traffic. </param>
        /// <param name="logAnalyticsWorkspaceProperties"> The Log Analytics Workspace Properties. </param>
        /// <returns> A new <see cref="Peering.PeeringServiceData"/> instance for mocking. </returns>
        public static PeeringServiceData PeeringServiceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string skuName = null, string peeringServiceLocation = null, string peeringServiceProvider = null, PeeringProvisioningState? provisioningState = null, string providerPrimaryPeeringLocation = null, string providerBackupPeeringLocation = null, PeeringLogAnalyticsWorkspaceProperties logAnalyticsWorkspaceProperties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new PeeringServiceData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                skuName != null ? new PeeringServiceSku(skuName, serializedAdditionalRawData: null) : null,
                peeringServiceLocation,
                peeringServiceProvider,
                provisioningState,
                providerPrimaryPeeringLocation,
                providerBackupPeeringLocation,
                logAnalyticsWorkspaceProperties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PeeringLogAnalyticsWorkspaceProperties"/>. </summary>
        /// <param name="workspaceId"> The Workspace ID. </param>
        /// <param name="key"> The Workspace Key. </param>
        /// <param name="connectedAgents"> The list of connected agents. </param>
        /// <returns> A new <see cref="Models.PeeringLogAnalyticsWorkspaceProperties"/> instance for mocking. </returns>
        public static PeeringLogAnalyticsWorkspaceProperties PeeringLogAnalyticsWorkspaceProperties(string workspaceId = null, string key = null, IEnumerable<string> connectedAgents = null)
        {
            connectedAgents ??= new List<string>();

            return new PeeringLogAnalyticsWorkspaceProperties(workspaceId, key, connectedAgents?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.RoutingPreferenceUnbilledPrefix"/>. </summary>
        /// <param name="prefix"> The prefix. </param>
        /// <param name="azureRegion"> The Azure region. </param>
        /// <param name="peerAsn"> The peer ASN. </param>
        /// <returns> A new <see cref="Models.RoutingPreferenceUnbilledPrefix"/> instance for mocking. </returns>
        public static RoutingPreferenceUnbilledPrefix RoutingPreferenceUnbilledPrefix(string prefix = null, AzureLocation? azureRegion = null, int? peerAsn = null)
        {
            return new RoutingPreferenceUnbilledPrefix(prefix, azureRegion, peerAsn, serializedAdditionalRawData: null);
        }
    }
}
