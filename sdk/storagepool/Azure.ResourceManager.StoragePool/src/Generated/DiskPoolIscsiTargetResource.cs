// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    /// <summary>
    /// A Class representing a DiskPoolIscsiTarget along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DiskPoolIscsiTargetResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDiskPoolIscsiTargetResource method.
    /// Otherwise you can get one from its parent resource <see cref="DiskPoolResource"/> using the GetDiskPoolIscsiTarget method.
    /// </summary>
    public partial class DiskPoolIscsiTargetResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DiskPoolIscsiTargetResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="diskPoolName"> The diskPoolName. </param>
        /// <param name="iscsiTargetName"> The iscsiTargetName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string diskPoolName, string iscsiTargetName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _diskPoolIscsiTargetIscsiTargetsClientDiagnostics;
        private readonly IscsiTargetsRestOperations _diskPoolIscsiTargetIscsiTargetsRestClient;
        private readonly DiskPoolIscsiTargetData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StoragePool/diskPools/iscsiTargets";

        /// <summary> Initializes a new instance of the <see cref="DiskPoolIscsiTargetResource"/> class for mocking. </summary>
        protected DiskPoolIscsiTargetResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiskPoolIscsiTargetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DiskPoolIscsiTargetResource(ArmClient client, DiskPoolIscsiTargetData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DiskPoolIscsiTargetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DiskPoolIscsiTargetResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diskPoolIscsiTargetIscsiTargetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StoragePool", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string diskPoolIscsiTargetIscsiTargetsApiVersion);
            _diskPoolIscsiTargetIscsiTargetsRestClient = new IscsiTargetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, diskPoolIscsiTargetIscsiTargetsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DiskPoolIscsiTargetData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get an iSCSI Target.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DiskPoolIscsiTargetResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetResource.Get");
            scope.Start();
            try
            {
                var response = await _diskPoolIscsiTargetIscsiTargetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskPoolIscsiTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an iSCSI Target.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DiskPoolIscsiTargetResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetResource.Get");
            scope.Start();
            try
            {
                var response = _diskPoolIscsiTargetIscsiTargetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskPoolIscsiTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete an iSCSI Target.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetResource.Delete");
            scope.Start();
            try
            {
                var response = await _diskPoolIscsiTargetIscsiTargetsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new StoragePoolArmOperation(_diskPoolIscsiTargetIscsiTargetsClientDiagnostics, Pipeline, _diskPoolIscsiTargetIscsiTargetsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete an iSCSI Target.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetResource.Delete");
            scope.Start();
            try
            {
                var response = _diskPoolIscsiTargetIscsiTargetsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new StoragePoolArmOperation(_diskPoolIscsiTargetIscsiTargetsClientDiagnostics, Pipeline, _diskPoolIscsiTargetIscsiTargetsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update an iSCSI Target.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Request payload for iSCSI Target update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<DiskPoolIscsiTargetResource>> UpdateAsync(WaitUntil waitUntil, DiskPoolIscsiTargetPatch patch, CancellationToken cancellationToken = default)
        {
            if (patch == null)
            {
                throw new ArgumentNullException(nameof(patch));
            }

            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetResource.Update");
            scope.Start();
            try
            {
                var response = await _diskPoolIscsiTargetIscsiTargetsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new StoragePoolArmOperation<DiskPoolIscsiTargetResource>(new DiskPoolIscsiTargetOperationSource(Client), _diskPoolIscsiTargetIscsiTargetsClientDiagnostics, Pipeline, _diskPoolIscsiTargetIscsiTargetsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Update an iSCSI Target.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IscsiTargets_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPoolIscsiTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Request payload for iSCSI Target update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<DiskPoolIscsiTargetResource> Update(WaitUntil waitUntil, DiskPoolIscsiTargetPatch patch, CancellationToken cancellationToken = default)
        {
            if (patch == null)
            {
                throw new ArgumentNullException(nameof(patch));
            }

            using var scope = _diskPoolIscsiTargetIscsiTargetsClientDiagnostics.CreateScope("DiskPoolIscsiTargetResource.Update");
            scope.Start();
            try
            {
                var response = _diskPoolIscsiTargetIscsiTargetsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new StoragePoolArmOperation<DiskPoolIscsiTargetResource>(new DiskPoolIscsiTargetOperationSource(Client), _diskPoolIscsiTargetIscsiTargetsClientDiagnostics, Pipeline, _diskPoolIscsiTargetIscsiTargetsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
