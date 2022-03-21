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

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary> A class representing collection of SessionHost and their operations over its parent. </summary>
    public partial class SessionHostCollection : ArmCollection, IEnumerable<SessionHost>, IAsyncEnumerable<SessionHost>
    {
        private readonly ClientDiagnostics _sessionHostClientDiagnostics;
        private readonly SessionHostsRestOperations _sessionHostRestClient;

        /// <summary> Initializes a new instance of the <see cref="SessionHostCollection"/> class for mocking. </summary>
        protected SessionHostCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SessionHostCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SessionHostCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sessionHostClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", SessionHost.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SessionHost.ResourceType, out string sessionHostApiVersion);
            _sessionHostRestClient = new SessionHostsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sessionHostApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HostPool.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HostPool.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a session host.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}
        /// Operation Id: SessionHosts_Get
        /// </summary>
        /// <param name="sessionHostName"> The name of the session host within the specified host pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionHostName"/> is null. </exception>
        public virtual async Task<Response<SessionHost>> GetAsync(string sessionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sessionHostName, nameof(sessionHostName));

            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.Get");
            scope.Start();
            try
            {
                var response = await _sessionHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionHostName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SessionHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a session host.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}
        /// Operation Id: SessionHosts_Get
        /// </summary>
        /// <param name="sessionHostName"> The name of the session host within the specified host pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionHostName"/> is null. </exception>
        public virtual Response<SessionHost> Get(string sessionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sessionHostName, nameof(sessionHostName));

            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.Get");
            scope.Start();
            try
            {
                var response = _sessionHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionHostName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SessionHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List sessionHosts.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts
        /// Operation Id: SessionHosts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SessionHost" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SessionHost> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SessionHost>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sessionHostRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SessionHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SessionHost>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sessionHostRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SessionHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List sessionHosts.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts
        /// Operation Id: SessionHosts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SessionHost" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SessionHost> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SessionHost> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sessionHostRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SessionHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SessionHost> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sessionHostRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SessionHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}
        /// Operation Id: SessionHosts_Get
        /// </summary>
        /// <param name="sessionHostName"> The name of the session host within the specified host pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionHostName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sessionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sessionHostName, nameof(sessionHostName));

            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(sessionHostName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}
        /// Operation Id: SessionHosts_Get
        /// </summary>
        /// <param name="sessionHostName"> The name of the session host within the specified host pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionHostName"/> is null. </exception>
        public virtual Response<bool> Exists(string sessionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sessionHostName, nameof(sessionHostName));

            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(sessionHostName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}
        /// Operation Id: SessionHosts_Get
        /// </summary>
        /// <param name="sessionHostName"> The name of the session host within the specified host pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionHostName"/> is null. </exception>
        public virtual async Task<Response<SessionHost>> GetIfExistsAsync(string sessionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sessionHostName, nameof(sessionHostName));

            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sessionHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionHostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SessionHost>(null, response.GetRawResponse());
                return Response.FromValue(new SessionHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}
        /// Operation Id: SessionHosts_Get
        /// </summary>
        /// <param name="sessionHostName"> The name of the session host within the specified host pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionHostName"/> is null. </exception>
        public virtual Response<SessionHost> GetIfExists(string sessionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sessionHostName, nameof(sessionHostName));

            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sessionHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionHostName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SessionHost>(null, response.GetRawResponse());
                return Response.FromValue(new SessionHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SessionHost> IEnumerable<SessionHost>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SessionHost> IAsyncEnumerable<SessionHost>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
