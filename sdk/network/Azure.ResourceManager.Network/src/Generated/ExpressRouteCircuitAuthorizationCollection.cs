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
    /// <summary> A class representing collection of ExpressRouteCircuitAuthorization and their operations over its parent. </summary>
    public partial class ExpressRouteCircuitAuthorizationCollection : ArmCollection, IEnumerable<ExpressRouteCircuitAuthorization>, IAsyncEnumerable<ExpressRouteCircuitAuthorization>
    {
        private readonly ClientDiagnostics _expressRouteCircuitAuthorizationClientDiagnostics;
        private readonly ExpressRouteCircuitAuthorizationsRestOperations _expressRouteCircuitAuthorizationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitAuthorizationCollection"/> class for mocking. </summary>
        protected ExpressRouteCircuitAuthorizationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitAuthorizationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteCircuitAuthorizationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteCircuitAuthorizationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteCircuitAuthorization.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ExpressRouteCircuitAuthorization.ResourceType, out string expressRouteCircuitAuthorizationApiVersion);
            _expressRouteCircuitAuthorizationRestClient = new ExpressRouteCircuitAuthorizationsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, expressRouteCircuitAuthorizationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRouteCircuit.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRouteCircuit.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an authorization in the specified express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}
        /// Operation Id: ExpressRouteCircuitAuthorizations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="authorizationParameters"> Parameters supplied to the create or update express route circuit authorization operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> or <paramref name="authorizationParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteCircuitAuthorization>> CreateOrUpdateAsync(WaitUntil waitUntil, string authorizationName, ExpressRouteCircuitAuthorizationData authorizationParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));
            Argument.AssertNotNull(authorizationParameters, nameof(authorizationParameters));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitAuthorizationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, authorizationParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCircuitAuthorization>(new ExpressRouteCircuitAuthorizationOperationSource(Client), _expressRouteCircuitAuthorizationClientDiagnostics, Pipeline, _expressRouteCircuitAuthorizationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, authorizationParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an authorization in the specified express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}
        /// Operation Id: ExpressRouteCircuitAuthorizations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="authorizationParameters"> Parameters supplied to the create or update express route circuit authorization operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> or <paramref name="authorizationParameters"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCircuitAuthorization> CreateOrUpdate(WaitUntil waitUntil, string authorizationName, ExpressRouteCircuitAuthorizationData authorizationParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));
            Argument.AssertNotNull(authorizationParameters, nameof(authorizationParameters));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitAuthorizationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, authorizationParameters, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCircuitAuthorization>(new ExpressRouteCircuitAuthorizationOperationSource(Client), _expressRouteCircuitAuthorizationClientDiagnostics, Pipeline, _expressRouteCircuitAuthorizationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, authorizationParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified authorization from the specified express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}
        /// Operation Id: ExpressRouteCircuitAuthorizations_Get
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteCircuitAuthorization>> GetAsync(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitAuthorizationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitAuthorization(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified authorization from the specified express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}
        /// Operation Id: ExpressRouteCircuitAuthorizations_Get
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuitAuthorization> Get(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitAuthorizationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitAuthorization(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all authorizations in an express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations
        /// Operation Id: ExpressRouteCircuitAuthorizations_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCircuitAuthorization" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteCircuitAuthorization> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteCircuitAuthorization>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCircuitAuthorizationRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitAuthorization(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRouteCircuitAuthorization>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCircuitAuthorizationRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitAuthorization(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all authorizations in an express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations
        /// Operation Id: ExpressRouteCircuitAuthorizations_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCircuitAuthorization" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteCircuitAuthorization> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteCircuitAuthorization> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCircuitAuthorizationRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitAuthorization(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRouteCircuitAuthorization> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCircuitAuthorizationRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitAuthorization(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}
        /// Operation Id: ExpressRouteCircuitAuthorizations_Get
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(authorizationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}
        /// Operation Id: ExpressRouteCircuitAuthorizations_Get
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(authorizationName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}
        /// Operation Id: ExpressRouteCircuitAuthorizations_Get
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteCircuitAuthorization>> GetIfExistsAsync(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitAuthorizationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ExpressRouteCircuitAuthorization>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitAuthorization(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/authorizations/{authorizationName}
        /// Operation Id: ExpressRouteCircuitAuthorizations_Get
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuitAuthorization> GetIfExists(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteCircuitAuthorizationClientDiagnostics.CreateScope("ExpressRouteCircuitAuthorizationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitAuthorizationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ExpressRouteCircuitAuthorization>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitAuthorization(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteCircuitAuthorization> IEnumerable<ExpressRouteCircuitAuthorization>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteCircuitAuthorization> IAsyncEnumerable<ExpressRouteCircuitAuthorization>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
