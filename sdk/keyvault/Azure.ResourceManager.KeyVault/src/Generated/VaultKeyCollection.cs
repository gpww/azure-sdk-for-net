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
using Azure.ResourceManager.KeyVault.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing collection of VaultKey and their operations over its parent. </summary>
    public partial class VaultKeyCollection : ArmCollection, IEnumerable<VaultKey>, IAsyncEnumerable<VaultKey>
    {
        private readonly ClientDiagnostics _vaultKeyKeysClientDiagnostics;
        private readonly KeysRestOperations _vaultKeyKeysRestClient;

        /// <summary> Initializes a new instance of the <see cref="VaultKeyCollection"/> class for mocking. </summary>
        protected VaultKeyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VaultKeyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VaultKeyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vaultKeyKeysClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.KeyVault", VaultKey.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(VaultKey.ResourceType, out string vaultKeyKeysApiVersion);
            _vaultKeyKeysRestClient = new KeysRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, vaultKeyKeysApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Vault.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Vault.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates the first version of a new key if it does not exist. If it already exists, then the existing key is returned without any write operations being performed. This API does not create subsequent versions, and does not update existing keys.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// Operation Id: Keys_CreateIfNotExist
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyName"> The name of the key to be created. </param>
        /// <param name="parameters"> The parameters used to create the specified key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<VaultKey>> CreateOrUpdateAsync(WaitUntil waitUntil, string keyName, KeyCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vaultKeyKeysRestClient.CreateIfNotExistAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new KeyVaultArmOperation<VaultKey>(Response.FromValue(new VaultKey(Client, response), response.GetRawResponse()));
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
        /// Creates the first version of a new key if it does not exist. If it already exists, then the existing key is returned without any write operations being performed. This API does not create subsequent versions, and does not update existing keys.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// Operation Id: Keys_CreateIfNotExist
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyName"> The name of the key to be created. </param>
        /// <param name="parameters"> The parameters used to create the specified key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<VaultKey> CreateOrUpdate(WaitUntil waitUntil, string keyName, KeyCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vaultKeyKeysRestClient.CreateIfNotExist(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, parameters, cancellationToken);
                var operation = new KeyVaultArmOperation<VaultKey>(Response.FromValue(new VaultKey(Client, response), response.GetRawResponse()));
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
        /// Gets the current version of the specified key from the specified key vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// Operation Id: Keys_Get
        /// </summary>
        /// <param name="keyName"> The name of the key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual async Task<Response<VaultKey>> GetAsync(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKeyCollection.Get");
            scope.Start();
            try
            {
                var response = await _vaultKeyKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VaultKey(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the current version of the specified key from the specified key vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// Operation Id: Keys_Get
        /// </summary>
        /// <param name="keyName"> The name of the key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual Response<VaultKey> Get(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKeyCollection.Get");
            scope.Start();
            try
            {
                var response = _vaultKeyKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VaultKey(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the keys in the specified key vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys
        /// Operation Id: Keys_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VaultKey" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VaultKey> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VaultKey>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKeyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vaultKeyKeysRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultKey(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VaultKey>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKeyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vaultKeyKeysRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultKey(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists the keys in the specified key vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys
        /// Operation Id: Keys_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VaultKey" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VaultKey> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VaultKey> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKeyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vaultKeyKeysRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultKey(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VaultKey> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKeyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vaultKeyKeysRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultKey(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// Operation Id: Keys_Get
        /// </summary>
        /// <param name="keyName"> The name of the key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(keyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// Operation Id: Keys_Get
        /// </summary>
        /// <param name="keyName"> The name of the key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual Response<bool> Exists(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(keyName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// Operation Id: Keys_Get
        /// </summary>
        /// <param name="keyName"> The name of the key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual async Task<Response<VaultKey>> GetIfExistsAsync(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKeyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vaultKeyKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VaultKey>(null, response.GetRawResponse());
                return Response.FromValue(new VaultKey(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// Operation Id: Keys_Get
        /// </summary>
        /// <param name="keyName"> The name of the key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual Response<VaultKey> GetIfExists(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKeyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vaultKeyKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VaultKey>(null, response.GetRawResponse());
                return Response.FromValue(new VaultKey(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VaultKey> IEnumerable<VaultKey>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VaultKey> IAsyncEnumerable<VaultKey>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
