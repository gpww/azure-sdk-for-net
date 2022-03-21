// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    internal partial class SubscriptionExtensionClient : ArmResource
    {
        private ClientDiagnostics _databaseAccountClientDiagnostics;
        private DatabaseAccountsRestOperations _databaseAccountRestClient;
        private ClientDiagnostics _restorableDatabaseAccountClientDiagnostics;
        private RestorableDatabaseAccountsRestOperations _restorableDatabaseAccountRestClient;
        private ClientDiagnostics _clusterResourceCassandraClustersClientDiagnostics;
        private CassandraClustersRestOperations _clusterResourceCassandraClustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class for mocking. </summary>
        protected SubscriptionExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DatabaseAccountClientDiagnostics => _databaseAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CosmosDB", DatabaseAccount.ResourceType.Namespace, DiagnosticOptions);
        private DatabaseAccountsRestOperations DatabaseAccountRestClient => _databaseAccountRestClient ??= new DatabaseAccountsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(DatabaseAccount.ResourceType));
        private ClientDiagnostics RestorableDatabaseAccountClientDiagnostics => _restorableDatabaseAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CosmosDB", RestorableDatabaseAccount.ResourceType.Namespace, DiagnosticOptions);
        private RestorableDatabaseAccountsRestOperations RestorableDatabaseAccountRestClient => _restorableDatabaseAccountRestClient ??= new RestorableDatabaseAccountsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(RestorableDatabaseAccount.ResourceType));
        private ClientDiagnostics ClusterResourceCassandraClustersClientDiagnostics => _clusterResourceCassandraClustersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ClusterResource.ResourceType.Namespace, DiagnosticOptions);
        private CassandraClustersRestOperations ClusterResourceCassandraClustersRestClient => _clusterResourceCassandraClustersRestClient ??= new CassandraClustersRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(ClusterResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of CosmosDBLocations in the CosmosDBLocation. </summary>
        /// <returns> An object representing collection of CosmosDBLocations and their operations over a CosmosDBLocation. </returns>
        public virtual CosmosDBLocationCollection GetCosmosDBLocations()
        {
            return GetCachedClient(Client => new CosmosDBLocationCollection(Client, Id));
        }

        /// <summary>
        /// Lists all the Azure Cosmos DB database accounts available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/databaseAccounts
        /// Operation Id: DatabaseAccounts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatabaseAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatabaseAccount> GetDatabaseAccountsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DatabaseAccount>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DatabaseAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDatabaseAccounts");
                scope.Start();
                try
                {
                    var response = await DatabaseAccountRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DatabaseAccount(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists all the Azure Cosmos DB database accounts available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/databaseAccounts
        /// Operation Id: DatabaseAccounts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatabaseAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatabaseAccount> GetDatabaseAccounts(CancellationToken cancellationToken = default)
        {
            Page<DatabaseAccount> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DatabaseAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDatabaseAccounts");
                scope.Start();
                try
                {
                    var response = DatabaseAccountRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DatabaseAccount(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists all the restorable Azure Cosmos DB database accounts available under the subscription. This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/restorableDatabaseAccounts
        /// Operation Id: RestorableDatabaseAccounts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableDatabaseAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableDatabaseAccount> GetRestorableDatabaseAccountsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorableDatabaseAccount>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = RestorableDatabaseAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetRestorableDatabaseAccounts");
                scope.Start();
                try
                {
                    var response = await RestorableDatabaseAccountRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDatabaseAccount(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists all the restorable Azure Cosmos DB database accounts available under the subscription. This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/restorableDatabaseAccounts
        /// Operation Id: RestorableDatabaseAccounts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableDatabaseAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableDatabaseAccount> GetRestorableDatabaseAccounts(CancellationToken cancellationToken = default)
        {
            Page<RestorableDatabaseAccount> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = RestorableDatabaseAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetRestorableDatabaseAccounts");
                scope.Start();
                try
                {
                    var response = RestorableDatabaseAccountRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDatabaseAccount(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List all managed Cassandra clusters in this subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/cassandraClusters
        /// Operation Id: CassandraClusters_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterResource> GetClusterResourcesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ClusterResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ClusterResourceCassandraClustersClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetClusterResources");
                scope.Start();
                try
                {
                    var response = await ClusterResourceCassandraClustersRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ClusterResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List all managed Cassandra clusters in this subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/cassandraClusters
        /// Operation Id: CassandraClusters_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterResource> GetClusterResources(CancellationToken cancellationToken = default)
        {
            Page<ClusterResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ClusterResourceCassandraClustersClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetClusterResources");
                scope.Start();
                try
                {
                    var response = ClusterResourceCassandraClustersRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ClusterResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
