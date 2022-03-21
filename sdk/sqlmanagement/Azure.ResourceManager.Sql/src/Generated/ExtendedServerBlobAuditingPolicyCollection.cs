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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ExtendedServerBlobAuditingPolicy and their operations over its parent. </summary>
    public partial class ExtendedServerBlobAuditingPolicyCollection : ArmCollection, IEnumerable<ExtendedServerBlobAuditingPolicy>, IAsyncEnumerable<ExtendedServerBlobAuditingPolicy>
    {
        private readonly ClientDiagnostics _extendedServerBlobAuditingPolicyClientDiagnostics;
        private readonly ExtendedServerBlobAuditingPoliciesRestOperations _extendedServerBlobAuditingPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExtendedServerBlobAuditingPolicyCollection"/> class for mocking. </summary>
        protected ExtendedServerBlobAuditingPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExtendedServerBlobAuditingPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExtendedServerBlobAuditingPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _extendedServerBlobAuditingPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ExtendedServerBlobAuditingPolicy.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ExtendedServerBlobAuditingPolicy.ResourceType, out string extendedServerBlobAuditingPolicyApiVersion);
            _extendedServerBlobAuditingPolicyRestClient = new ExtendedServerBlobAuditingPoliciesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, extendedServerBlobAuditingPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an extended server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ExtendedServerBlobAuditingPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="parameters"> Properties of extended blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ExtendedServerBlobAuditingPolicy>> CreateOrUpdateAsync(WaitUntil waitUntil, BlobAuditingPolicyName blobAuditingPolicyName, ExtendedServerBlobAuditingPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _extendedServerBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedServerBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _extendedServerBlobAuditingPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ExtendedServerBlobAuditingPolicy>(new ExtendedServerBlobAuditingPolicyOperationSource(Client), _extendedServerBlobAuditingPolicyClientDiagnostics, Pipeline, _extendedServerBlobAuditingPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an extended server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ExtendedServerBlobAuditingPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="parameters"> Properties of extended blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ExtendedServerBlobAuditingPolicy> CreateOrUpdate(WaitUntil waitUntil, BlobAuditingPolicyName blobAuditingPolicyName, ExtendedServerBlobAuditingPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _extendedServerBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedServerBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _extendedServerBlobAuditingPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ExtendedServerBlobAuditingPolicy>(new ExtendedServerBlobAuditingPolicyOperationSource(Client), _extendedServerBlobAuditingPolicyClientDiagnostics, Pipeline, _extendedServerBlobAuditingPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an extended server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ExtendedServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExtendedServerBlobAuditingPolicy>> GetAsync(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _extendedServerBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedServerBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _extendedServerBlobAuditingPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExtendedServerBlobAuditingPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an extended server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ExtendedServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExtendedServerBlobAuditingPolicy> Get(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _extendedServerBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedServerBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _extendedServerBlobAuditingPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExtendedServerBlobAuditingPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists extended auditing settings of a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/extendedAuditingSettings
        /// Operation Id: ExtendedServerBlobAuditingPolicies_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExtendedServerBlobAuditingPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExtendedServerBlobAuditingPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExtendedServerBlobAuditingPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _extendedServerBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _extendedServerBlobAuditingPolicyRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExtendedServerBlobAuditingPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExtendedServerBlobAuditingPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _extendedServerBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _extendedServerBlobAuditingPolicyRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExtendedServerBlobAuditingPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists extended auditing settings of a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/extendedAuditingSettings
        /// Operation Id: ExtendedServerBlobAuditingPolicies_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExtendedServerBlobAuditingPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExtendedServerBlobAuditingPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExtendedServerBlobAuditingPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _extendedServerBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _extendedServerBlobAuditingPolicyRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExtendedServerBlobAuditingPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExtendedServerBlobAuditingPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _extendedServerBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _extendedServerBlobAuditingPolicyRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExtendedServerBlobAuditingPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ExtendedServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _extendedServerBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedServerBlobAuditingPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(blobAuditingPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ExtendedServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _extendedServerBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedServerBlobAuditingPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(blobAuditingPolicyName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ExtendedServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExtendedServerBlobAuditingPolicy>> GetIfExistsAsync(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _extendedServerBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedServerBlobAuditingPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _extendedServerBlobAuditingPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ExtendedServerBlobAuditingPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ExtendedServerBlobAuditingPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ExtendedServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExtendedServerBlobAuditingPolicy> GetIfExists(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _extendedServerBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedServerBlobAuditingPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _extendedServerBlobAuditingPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ExtendedServerBlobAuditingPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ExtendedServerBlobAuditingPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExtendedServerBlobAuditingPolicy> IEnumerable<ExtendedServerBlobAuditingPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExtendedServerBlobAuditingPolicy> IAsyncEnumerable<ExtendedServerBlobAuditingPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
