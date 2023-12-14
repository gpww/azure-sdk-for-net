// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataLakeAnalytics.Models;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary>
    /// A class representing a collection of <see cref="DataLakeAnalyticsStorageAccountInformationResource"/> and their operations.
    /// Each <see cref="DataLakeAnalyticsStorageAccountInformationResource"/> in the collection will belong to the same instance of <see cref="DataLakeAnalyticsAccountResource"/>.
    /// To get a <see cref="DataLakeAnalyticsStorageAccountInformationCollection"/> instance call the GetDataLakeAnalyticsStorageAccountInformation method from an instance of <see cref="DataLakeAnalyticsAccountResource"/>.
    /// </summary>
    public partial class DataLakeAnalyticsStorageAccountInformationCollection : ArmCollection, IEnumerable<DataLakeAnalyticsStorageAccountInformationResource>, IAsyncEnumerable<DataLakeAnalyticsStorageAccountInformationResource>
    {
        private readonly ClientDiagnostics _dataLakeAnalyticsStorageAccountInformationStorageAccountsClientDiagnostics;
        private readonly StorageAccountsRestOperations _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsStorageAccountInformationCollection"/> class for mocking. </summary>
        protected DataLakeAnalyticsStorageAccountInformationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsStorageAccountInformationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataLakeAnalyticsStorageAccountInformationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataLakeAnalyticsStorageAccountInformationStorageAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeAnalytics", DataLakeAnalyticsStorageAccountInformationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataLakeAnalyticsStorageAccountInformationResource.ResourceType, out string dataLakeAnalyticsStorageAccountInformationStorageAccountsApiVersion);
            _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient = new StorageAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataLakeAnalyticsStorageAccountInformationStorageAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataLakeAnalyticsAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataLakeAnalyticsAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates the specified Data Lake Analytics account to add an Azure Storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Add</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageAccountName"> The name of the Azure Storage account to add. </param>
        /// <param name="content"> The parameters containing the access key and optional suffix for the Azure Storage Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation> CreateOrUpdateAsync(WaitUntil waitUntil, string storageAccountName, DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeAnalyticsStorageAccountInformationStorageAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsStorageAccountInformationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient.AddAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, content, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeAnalyticsArmOperation(response);
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
        /// Updates the specified Data Lake Analytics account to add an Azure Storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Add</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageAccountName"> The name of the Azure Storage account to add. </param>
        /// <param name="content"> The parameters containing the access key and optional suffix for the Azure Storage Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation CreateOrUpdate(WaitUntil waitUntil, string storageAccountName, DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeAnalyticsStorageAccountInformationStorageAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsStorageAccountInformationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient.Add(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, content, cancellationToken);
                var operation = new DataLakeAnalyticsArmOperation(response);
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
        /// Gets the specified Azure Storage account linked to the given Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageAccountName"> The name of the Azure Storage account for which to retrieve the details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual async Task<Response<DataLakeAnalyticsStorageAccountInformationResource>> GetAsync(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _dataLakeAnalyticsStorageAccountInformationStorageAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsStorageAccountInformationCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsStorageAccountInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Azure Storage account linked to the given Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageAccountName"> The name of the Azure Storage account for which to retrieve the details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual Response<DataLakeAnalyticsStorageAccountInformationResource> Get(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _dataLakeAnalyticsStorageAccountInformationStorageAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsStorageAccountInformationCollection.Get");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsStorageAccountInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the first page of Azure Storage accounts, if any, linked to the specified Data Lake Analytics account. The response includes a link to the next page, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeAnalyticsStorageAccountInformationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataLakeAnalyticsStorageAccountInformationResource> GetAllAsync(DataLakeAnalyticsStorageAccountInformationCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new DataLakeAnalyticsStorageAccountInformationCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataLakeAnalyticsStorageAccountInformationResource(Client, DataLakeAnalyticsStorageAccountInformationData.DeserializeDataLakeAnalyticsStorageAccountInformationData(e)), _dataLakeAnalyticsStorageAccountInformationStorageAccountsClientDiagnostics, Pipeline, "DataLakeAnalyticsStorageAccountInformationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the first page of Azure Storage accounts, if any, linked to the specified Data Lake Analytics account. The response includes a link to the next page, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeAnalyticsStorageAccountInformationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataLakeAnalyticsStorageAccountInformationResource> GetAll(DataLakeAnalyticsStorageAccountInformationCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new DataLakeAnalyticsStorageAccountInformationCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataLakeAnalyticsStorageAccountInformationResource(Client, DataLakeAnalyticsStorageAccountInformationData.DeserializeDataLakeAnalyticsStorageAccountInformationData(e)), _dataLakeAnalyticsStorageAccountInformationStorageAccountsClientDiagnostics, Pipeline, "DataLakeAnalyticsStorageAccountInformationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageAccountName"> The name of the Azure Storage account for which to retrieve the details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _dataLakeAnalyticsStorageAccountInformationStorageAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsStorageAccountInformationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageAccountName"> The name of the Azure Storage account for which to retrieve the details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _dataLakeAnalyticsStorageAccountInformationStorageAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsStorageAccountInformationCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageAccountName"> The name of the Azure Storage account for which to retrieve the details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataLakeAnalyticsStorageAccountInformationResource>> GetIfExistsAsync(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _dataLakeAnalyticsStorageAccountInformationStorageAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsStorageAccountInformationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataLakeAnalyticsStorageAccountInformationResource>(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsStorageAccountInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageAccountName"> The name of the Azure Storage account for which to retrieve the details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual NullableResponse<DataLakeAnalyticsStorageAccountInformationResource> GetIfExists(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _dataLakeAnalyticsStorageAccountInformationStorageAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsStorageAccountInformationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsStorageAccountInformationStorageAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataLakeAnalyticsStorageAccountInformationResource>(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsStorageAccountInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataLakeAnalyticsStorageAccountInformationResource> IEnumerable<DataLakeAnalyticsStorageAccountInformationResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<DataLakeAnalyticsStorageAccountInformationResource> IAsyncEnumerable<DataLakeAnalyticsStorageAccountInformationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
