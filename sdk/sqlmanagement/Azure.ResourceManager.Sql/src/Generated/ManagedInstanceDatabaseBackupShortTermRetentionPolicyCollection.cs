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
    /// <summary> A class representing collection of ManagedInstanceDatabaseBackupShortTermRetentionPolicy and their operations over its parent. </summary>
    public partial class ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection : ArmCollection, IEnumerable<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>, IAsyncEnumerable<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>
    {
        private readonly ClientDiagnostics _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics;
        private readonly ManagedBackupShortTermRetentionPoliciesRestOperations _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstanceDatabaseBackupShortTermRetentionPolicy.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ManagedInstanceDatabaseBackupShortTermRetentionPolicy.ResourceType, out string managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesApiVersion);
            _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient = new ManagedBackupShortTermRetentionPoliciesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedDatabase.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates a managed database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The policy name. Should always be &quot;default&quot;. </param>
        /// <param name="parameters"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>> CreateOrUpdateAsync(WaitUntil waitUntil, ManagedShortTermRetentionPolicyName policyName, ManagedBackupShortTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>(new ManagedInstanceDatabaseBackupShortTermRetentionPolicyOperationSource(Client), _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Updates a managed database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The policy name. Should always be &quot;default&quot;. </param>
        /// <param name="parameters"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> CreateOrUpdate(WaitUntil waitUntil, ManagedShortTermRetentionPolicyName policyName, ManagedBackupShortTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>(new ManagedInstanceDatabaseBackupShortTermRetentionPolicyOperationSource(Client), _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a managed database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>> GetAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> Get(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed database&apos;s short term retention policy list.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceDatabaseBackupShortTermRetentionPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a managed database&apos;s short term retention policy list.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceDatabaseBackupShortTermRetentionPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(policyName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>> GetIfExistsAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> GetIfExists(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> IEnumerable<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> IAsyncEnumerable<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
