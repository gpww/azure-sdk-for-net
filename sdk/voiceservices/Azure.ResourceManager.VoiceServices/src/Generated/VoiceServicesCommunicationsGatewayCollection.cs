// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.VoiceServices
{
    /// <summary>
    /// A class representing a collection of <see cref="VoiceServicesCommunicationsGatewayResource" /> and their operations.
    /// Each <see cref="VoiceServicesCommunicationsGatewayResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="VoiceServicesCommunicationsGatewayCollection" /> instance call the GetVoiceServicesCommunicationsGateways method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class VoiceServicesCommunicationsGatewayCollection : ArmCollection, IEnumerable<VoiceServicesCommunicationsGatewayResource>, IAsyncEnumerable<VoiceServicesCommunicationsGatewayResource>
    {
        private readonly ClientDiagnostics _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics;
        private readonly CommunicationsGatewaysRestOperations _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient;

        /// <summary> Initializes a new instance of the <see cref="VoiceServicesCommunicationsGatewayCollection"/> class for mocking. </summary>
        protected VoiceServicesCommunicationsGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VoiceServicesCommunicationsGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VoiceServicesCommunicationsGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.VoiceServices", VoiceServicesCommunicationsGatewayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VoiceServicesCommunicationsGatewayResource.ResourceType, out string voiceServicesCommunicationsGatewayCommunicationsGatewaysApiVersion);
            _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient = new CommunicationsGatewaysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, voiceServicesCommunicationsGatewayCommunicationsGatewaysApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a CommunicationsGateway
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="communicationsGatewayName"> Unique identifier for this deployment. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationsGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationsGatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VoiceServicesCommunicationsGatewayResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string communicationsGatewayName, VoiceServicesCommunicationsGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationsGatewayName, nameof(communicationsGatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics.CreateScope("VoiceServicesCommunicationsGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, communicationsGatewayName, data, cancellationToken).ConfigureAwait(false);
                var operation = new VoiceServicesArmOperation<VoiceServicesCommunicationsGatewayResource>(new VoiceServicesCommunicationsGatewayOperationSource(Client), _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics, Pipeline, _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, communicationsGatewayName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a CommunicationsGateway
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="communicationsGatewayName"> Unique identifier for this deployment. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationsGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationsGatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VoiceServicesCommunicationsGatewayResource> CreateOrUpdate(WaitUntil waitUntil, string communicationsGatewayName, VoiceServicesCommunicationsGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationsGatewayName, nameof(communicationsGatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics.CreateScope("VoiceServicesCommunicationsGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, communicationsGatewayName, data, cancellationToken);
                var operation = new VoiceServicesArmOperation<VoiceServicesCommunicationsGatewayResource>(new VoiceServicesCommunicationsGatewayOperationSource(Client), _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics, Pipeline, _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, communicationsGatewayName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a CommunicationsGateway
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationsGatewayName"> Unique identifier for this deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationsGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationsGatewayName"/> is null. </exception>
        public virtual async Task<Response<VoiceServicesCommunicationsGatewayResource>> GetAsync(string communicationsGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationsGatewayName, nameof(communicationsGatewayName));

            using var scope = _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics.CreateScope("VoiceServicesCommunicationsGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, communicationsGatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VoiceServicesCommunicationsGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a CommunicationsGateway
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationsGatewayName"> Unique identifier for this deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationsGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationsGatewayName"/> is null. </exception>
        public virtual Response<VoiceServicesCommunicationsGatewayResource> Get(string communicationsGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationsGatewayName, nameof(communicationsGatewayName));

            using var scope = _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics.CreateScope("VoiceServicesCommunicationsGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, communicationsGatewayName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VoiceServicesCommunicationsGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List CommunicationsGateway resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VoiceServicesCommunicationsGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VoiceServicesCommunicationsGatewayResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VoiceServicesCommunicationsGatewayResource(Client, VoiceServicesCommunicationsGatewayData.DeserializeVoiceServicesCommunicationsGatewayData(e)), _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics, Pipeline, "VoiceServicesCommunicationsGatewayCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List CommunicationsGateway resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VoiceServicesCommunicationsGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VoiceServicesCommunicationsGatewayResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VoiceServicesCommunicationsGatewayResource(Client, VoiceServicesCommunicationsGatewayData.DeserializeVoiceServicesCommunicationsGatewayData(e)), _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics, Pipeline, "VoiceServicesCommunicationsGatewayCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationsGatewayName"> Unique identifier for this deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationsGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationsGatewayName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string communicationsGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationsGatewayName, nameof(communicationsGatewayName));

            using var scope = _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics.CreateScope("VoiceServicesCommunicationsGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, communicationsGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationsGatewayName"> Unique identifier for this deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationsGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationsGatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string communicationsGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationsGatewayName, nameof(communicationsGatewayName));

            using var scope = _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics.CreateScope("VoiceServicesCommunicationsGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, communicationsGatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VoiceServicesCommunicationsGatewayResource> IEnumerable<VoiceServicesCommunicationsGatewayResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VoiceServicesCommunicationsGatewayResource> IAsyncEnumerable<VoiceServicesCommunicationsGatewayResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
