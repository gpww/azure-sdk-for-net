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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualHubResource" /> and their operations.
    /// Each <see cref="VirtualHubResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="VirtualHubCollection" /> instance call the GetVirtualHubs method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class VirtualHubCollection : ArmCollection, IEnumerable<VirtualHubResource>, IAsyncEnumerable<VirtualHubResource>
    {
        private readonly ClientDiagnostics _virtualHubClientDiagnostics;
        private readonly VirtualHubsRestOperations _virtualHubRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualHubCollection"/> class for mocking. </summary>
        protected VirtualHubCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualHubCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualHubCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualHubClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualHubResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualHubResource.ResourceType, out string virtualHubApiVersion);
            _virtualHubRestClient = new VirtualHubsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualHubApiVersion);
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
        /// Creates a VirtualHub resource if it doesn't exist else updates the existing VirtualHub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="data"> Parameters supplied to create or update VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualHubResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualHubName, VirtualHubData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualHubName, nameof(virtualHubName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualHubRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VirtualHubResource>(new VirtualHubOperationSource(Client), _virtualHubClientDiagnostics, Pipeline, _virtualHubRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a VirtualHub resource if it doesn't exist else updates the existing VirtualHub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="data"> Parameters supplied to create or update VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualHubResource> CreateOrUpdate(WaitUntil waitUntil, string virtualHubName, VirtualHubData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualHubName, nameof(virtualHubName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualHubRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, data, cancellationToken);
                var operation = new NetworkArmOperation<VirtualHubResource>(new VirtualHubOperationSource(Client), _virtualHubClientDiagnostics, Pipeline, _virtualHubRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a VirtualHub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> is null. </exception>
        public virtual async Task<Response<VirtualHubResource>> GetAsync(string virtualHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualHubName, nameof(virtualHubName));

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a VirtualHub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> is null. </exception>
        public virtual Response<VirtualHubResource> Get(string virtualHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualHubName, nameof(virtualHubName));

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the VirtualHubs in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubs_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualHubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualHubResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualHubRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualHubRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualHubResource(Client, VirtualHubData.DeserializeVirtualHubData(e)), _virtualHubClientDiagnostics, Pipeline, "VirtualHubCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the VirtualHubs in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubs_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualHubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualHubResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualHubRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualHubRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualHubResource(Client, VirtualHubData.DeserializeVirtualHubData(e)), _virtualHubClientDiagnostics, Pipeline, "VirtualHubCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualHubName, nameof(virtualHubName));

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualHubName, nameof(virtualHubName));

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualHubResource> IEnumerable<VirtualHubResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualHubResource> IAsyncEnumerable<VirtualHubResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
