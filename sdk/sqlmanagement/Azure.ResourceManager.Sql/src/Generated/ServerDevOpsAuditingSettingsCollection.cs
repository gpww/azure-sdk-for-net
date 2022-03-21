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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerDevOpsAuditingSettings and their operations over its parent. </summary>
    public partial class ServerDevOpsAuditingSettingsCollection : ArmCollection, IEnumerable<ServerDevOpsAuditingSettings>, IAsyncEnumerable<ServerDevOpsAuditingSettings>
    {
        private readonly ClientDiagnostics _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics;
        private readonly ServerDevOpsAuditSettingsRestOperations _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerDevOpsAuditingSettingsCollection"/> class for mocking. </summary>
        protected ServerDevOpsAuditingSettingsCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerDevOpsAuditingSettingsCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerDevOpsAuditingSettingsCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerDevOpsAuditingSettings.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ServerDevOpsAuditingSettings.ResourceType, out string serverDevOpsAuditingSettingsServerDevOpsAuditSettingsApiVersion);
            _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient = new ServerDevOpsAuditSettingsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverDevOpsAuditingSettingsServerDevOpsAuditSettingsApiVersion);
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
        /// Creates or updates a server&apos;s DevOps audit settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="parameters"> Properties of DevOps audit settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerDevOpsAuditingSettings>> CreateOrUpdateAsync(WaitUntil waitUntil, string devOpsAuditingSettingsName, ServerDevOpsAuditingSettingsData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ServerDevOpsAuditingSettings>(new ServerDevOpsAuditingSettingsOperationSource(Client), _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics, Pipeline, _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a server&apos;s DevOps audit settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="parameters"> Properties of DevOps audit settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ServerDevOpsAuditingSettings> CreateOrUpdate(WaitUntil waitUntil, string devOpsAuditingSettingsName, ServerDevOpsAuditingSettingsData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ServerDevOpsAuditingSettings>(new ServerDevOpsAuditingSettingsOperationSource(Client), _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics, Pipeline, _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a server&apos;s DevOps audit settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_Get
        /// </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual async Task<Response<ServerDevOpsAuditingSettings>> GetAsync(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDevOpsAuditingSettings(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server&apos;s DevOps audit settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_Get
        /// </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual Response<ServerDevOpsAuditingSettings> Get(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDevOpsAuditingSettings(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists DevOps audit settings of a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings
        /// Operation Id: ServerDevOpsAuditSettings_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerDevOpsAuditingSettings" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerDevOpsAuditingSettings> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerDevOpsAuditingSettings>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettings(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerDevOpsAuditingSettings>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettings(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists DevOps audit settings of a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings
        /// Operation Id: ServerDevOpsAuditSettings_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerDevOpsAuditingSettings" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerDevOpsAuditingSettings> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerDevOpsAuditingSettings> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettings(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerDevOpsAuditingSettings> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettings(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_Get
        /// </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(devOpsAuditingSettingsName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_Get
        /// </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual Response<bool> Exists(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(devOpsAuditingSettingsName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_Get
        /// </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual async Task<Response<ServerDevOpsAuditingSettings>> GetIfExistsAsync(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerDevOpsAuditingSettings>(null, response.GetRawResponse());
                return Response.FromValue(new ServerDevOpsAuditingSettings(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_Get
        /// </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual Response<ServerDevOpsAuditingSettings> GetIfExists(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerDevOpsAuditingSettings>(null, response.GetRawResponse());
                return Response.FromValue(new ServerDevOpsAuditingSettings(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerDevOpsAuditingSettings> IEnumerable<ServerDevOpsAuditingSettings>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerDevOpsAuditingSettings> IAsyncEnumerable<ServerDevOpsAuditingSettings>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
