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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedDiskResource" /> and their operations.
    /// Each <see cref="ManagedDiskResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ManagedDiskCollection" /> instance call the GetManagedDisks method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ManagedDiskCollection : ArmCollection, IEnumerable<ManagedDiskResource>, IAsyncEnumerable<ManagedDiskResource>
    {
        private readonly ClientDiagnostics _managedDiskDisksClientDiagnostics;
        private readonly DisksRestOperations _managedDiskDisksRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedDiskCollection"/> class for mocking. </summary>
        protected ManagedDiskCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedDiskCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedDiskCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedDiskDisksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ManagedDiskResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedDiskResource.ResourceType, out string managedDiskDisksApiVersion);
            _managedDiskDisksRestClient = new DisksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedDiskDisksApiVersion);
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
        /// Creates or updates a disk.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="data"> Disk object supplied in the body of the Put disk operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedDiskResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string diskName, ManagedDiskData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedDiskDisksClientDiagnostics.CreateScope("ManagedDiskCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedDiskDisksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, diskName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<ManagedDiskResource>(new ManagedDiskOperationSource(Client), _managedDiskDisksClientDiagnostics, Pipeline, _managedDiskDisksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a disk.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="data"> Disk object supplied in the body of the Put disk operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedDiskResource> CreateOrUpdate(WaitUntil waitUntil, string diskName, ManagedDiskData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedDiskDisksClientDiagnostics.CreateScope("ManagedDiskCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedDiskDisksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, diskName, data, cancellationToken);
                var operation = new ComputeArmOperation<ManagedDiskResource>(new ManagedDiskOperationSource(Client), _managedDiskDisksClientDiagnostics, Pipeline, _managedDiskDisksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets information about a disk.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        public virtual async Task<Response<ManagedDiskResource>> GetAsync(string diskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));

            using var scope = _managedDiskDisksClientDiagnostics.CreateScope("ManagedDiskCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedDiskDisksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDiskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a disk.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        public virtual Response<ManagedDiskResource> Get(string diskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));

            using var scope = _managedDiskDisksClientDiagnostics.CreateScope("ManagedDiskCollection.Get");
            scope.Start();
            try
            {
                var response = _managedDiskDisksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDiskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the disks under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedDiskResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedDiskResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedDiskDisksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedDiskDisksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagedDiskResource(Client, ManagedDiskData.DeserializeManagedDiskData(e)), _managedDiskDisksClientDiagnostics, Pipeline, "ManagedDiskCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the disks under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedDiskResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedDiskResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedDiskDisksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedDiskDisksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagedDiskResource(Client, ManagedDiskData.DeserializeManagedDiskData(e)), _managedDiskDisksClientDiagnostics, Pipeline, "ManagedDiskCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string diskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));

            using var scope = _managedDiskDisksClientDiagnostics.CreateScope("ManagedDiskCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedDiskDisksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        public virtual Response<bool> Exists(string diskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));

            using var scope = _managedDiskDisksClientDiagnostics.CreateScope("ManagedDiskCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedDiskDisksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        public virtual async Task<NullableResponse<ManagedDiskResource>> GetIfExistsAsync(string diskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));

            using var scope = _managedDiskDisksClientDiagnostics.CreateScope("ManagedDiskCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedDiskDisksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ManagedDiskResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedDiskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        public virtual NullableResponse<ManagedDiskResource> GetIfExists(string diskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));

            using var scope = _managedDiskDisksClientDiagnostics.CreateScope("ManagedDiskCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedDiskDisksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ManagedDiskResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedDiskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedDiskResource> IEnumerable<ManagedDiskResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedDiskResource> IAsyncEnumerable<ManagedDiskResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
