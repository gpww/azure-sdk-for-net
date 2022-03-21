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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> A class representing collection of ConfigurationStore and their operations over its parent. </summary>
    public partial class ConfigurationStoreCollection : ArmCollection, IEnumerable<ConfigurationStore>, IAsyncEnumerable<ConfigurationStore>
    {
        private readonly ClientDiagnostics _configurationStoreClientDiagnostics;
        private readonly ConfigurationStoresRestOperations _configurationStoreRestClient;

        /// <summary> Initializes a new instance of the <see cref="ConfigurationStoreCollection"/> class for mocking. </summary>
        protected ConfigurationStoreCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConfigurationStoreCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ConfigurationStoreCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _configurationStoreClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", ConfigurationStore.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ConfigurationStore.ResourceType, out string configurationStoreApiVersion);
            _configurationStoreRestClient = new ConfigurationStoresRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, configurationStoreApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a configuration store with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="configStoreCreationParameters"> The parameters for creating a configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> or <paramref name="configStoreCreationParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ConfigurationStore>> CreateOrUpdateAsync(WaitUntil waitUntil, string configStoreName, ConfigurationStoreData configStoreCreationParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));
            Argument.AssertNotNull(configStoreCreationParameters, nameof(configStoreCreationParameters));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _configurationStoreRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, configStoreCreationParameters, cancellationToken).ConfigureAwait(false);
                var operation = new AppConfigurationArmOperation<ConfigurationStore>(new ConfigurationStoreOperationSource(Client), _configurationStoreClientDiagnostics, Pipeline, _configurationStoreRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, configStoreCreationParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a configuration store with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="configStoreCreationParameters"> The parameters for creating a configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> or <paramref name="configStoreCreationParameters"/> is null. </exception>
        public virtual ArmOperation<ConfigurationStore> CreateOrUpdate(WaitUntil waitUntil, string configStoreName, ConfigurationStoreData configStoreCreationParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));
            Argument.AssertNotNull(configStoreCreationParameters, nameof(configStoreCreationParameters));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _configurationStoreRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, configStoreCreationParameters, cancellationToken);
                var operation = new AppConfigurationArmOperation<ConfigurationStore>(new ConfigurationStoreOperationSource(Client), _configurationStoreClientDiagnostics, Pipeline, _configurationStoreRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, configStoreCreationParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the properties of the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual async Task<Response<ConfigurationStore>> GetAsync(string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.Get");
            scope.Start();
            try
            {
                var response = await _configurationStoreRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfigurationStore(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<ConfigurationStore> Get(string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.Get");
            scope.Start();
            try
            {
                var response = _configurationStoreRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfigurationStore(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the configuration stores for a given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores
        /// Operation Id: ConfigurationStores_ListByResourceGroup
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfigurationStore" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConfigurationStore> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ConfigurationStore>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _configurationStoreRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationStore(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ConfigurationStore>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _configurationStoreRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationStore(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists the configuration stores for a given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores
        /// Operation Id: ConfigurationStores_ListByResourceGroup
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfigurationStore" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConfigurationStore> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<ConfigurationStore> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _configurationStoreRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationStore(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ConfigurationStore> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _configurationStoreRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationStore(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(configStoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<bool> Exists(string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(configStoreName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual async Task<Response<ConfigurationStore>> GetIfExistsAsync(string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _configurationStoreRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ConfigurationStore>(null, response.GetRawResponse());
                return Response.FromValue(new ConfigurationStore(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<ConfigurationStore> GetIfExists(string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _configurationStoreRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ConfigurationStore>(null, response.GetRawResponse());
                return Response.FromValue(new ConfigurationStore(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ConfigurationStore> IEnumerable<ConfigurationStore>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ConfigurationStore> IAsyncEnumerable<ConfigurationStore>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
