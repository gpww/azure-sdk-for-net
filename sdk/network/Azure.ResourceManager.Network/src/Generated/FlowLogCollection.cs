// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of FlowLog and their operations over its parent. </summary>
    public partial class FlowLogCollection : ArmCollection, IEnumerable<FlowLog>, IAsyncEnumerable<FlowLog>
    {
        private readonly ClientDiagnostics _flowLogClientDiagnostics;
        private readonly FlowLogsRestOperations _flowLogRestClient;

        /// <summary> Initializes a new instance of the <see cref="FlowLogCollection"/> class for mocking. </summary>
        protected FlowLogCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FlowLogCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FlowLogCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _flowLogClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", FlowLog.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(FlowLog.ResourceType, out string flowLogApiVersion);
            _flowLogRestClient = new FlowLogsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, flowLogApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkWatcher.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkWatcher.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a flow log for the specified network security group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="flowLogName"> The name of the flow log. </param>
        /// <param name="parameters"> Parameters that define the create or update flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<FlowLog>> CreateOrUpdateAsync(WaitUntil waitUntil, string flowLogName, FlowLogData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _flowLogRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<FlowLog>(new FlowLogOperationSource(Client), _flowLogClientDiagnostics, Pipeline, _flowLogRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a flow log for the specified network security group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="flowLogName"> The name of the flow log. </param>
        /// <param name="parameters"> Parameters that define the create or update flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<FlowLog> CreateOrUpdate(WaitUntil waitUntil, string flowLogName, FlowLogData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _flowLogRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<FlowLog>(new FlowLogOperationSource(Client), _flowLogClientDiagnostics, Pipeline, _flowLogRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a flow log resource by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_Get
        /// </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual async Task<Response<FlowLog>> GetAsync(string flowLogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.Get");
            scope.Start();
            try
            {
                var response = await _flowLogRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FlowLog(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a flow log resource by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_Get
        /// </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual Response<FlowLog> Get(string flowLogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.Get");
            scope.Start();
            try
            {
                var response = _flowLogRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FlowLog(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all flow log resources for the specified Network Watcher.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs
        /// Operation Id: FlowLogs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FlowLog" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FlowLog> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FlowLog>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _flowLogRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FlowLog(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FlowLog>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _flowLogRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FlowLog(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all flow log resources for the specified Network Watcher.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs
        /// Operation Id: FlowLogs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FlowLog" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FlowLog> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FlowLog> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _flowLogRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FlowLog(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FlowLog> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _flowLogRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FlowLog(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_Get
        /// </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string flowLogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(flowLogName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_Get
        /// </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual Response<bool> Exists(string flowLogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(flowLogName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_Get
        /// </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual async Task<Response<FlowLog>> GetIfExistsAsync(string flowLogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _flowLogRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<FlowLog>(null, response.GetRawResponse());
                return Response.FromValue(new FlowLog(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_Get
        /// </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual Response<FlowLog> GetIfExists(string flowLogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _flowLogRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<FlowLog>(null, response.GetRawResponse());
                return Response.FromValue(new FlowLog(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FlowLog> IEnumerable<FlowLog>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FlowLog> IAsyncEnumerable<FlowLog>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
