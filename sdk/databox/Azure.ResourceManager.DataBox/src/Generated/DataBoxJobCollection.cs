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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataBox
{
    /// <summary>
    /// A class representing a collection of <see cref="DataBoxJobResource"/> and their operations.
    /// Each <see cref="DataBoxJobResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DataBoxJobCollection"/> instance call the GetDataBoxJobs method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DataBoxJobCollection : ArmCollection, IEnumerable<DataBoxJobResource>, IAsyncEnumerable<DataBoxJobResource>
    {
        private readonly ClientDiagnostics _dataBoxJobJobsClientDiagnostics;
        private readonly JobsRestOperations _dataBoxJobJobsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataBoxJobCollection"/> class for mocking. </summary>
        protected DataBoxJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataBoxJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataBoxJobJobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBox", DataBoxJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataBoxJobResource.ResourceType, out string dataBoxJobJobsApiVersion);
            _dataBoxJobJobsRestClient = new JobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataBoxJobJobsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new job with the specified parameters. Existing job cannot be updated with this API and should instead be updated with the Update job API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="data"> Job details from request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataBoxJobResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string jobName, DataBoxJobData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxJobJobsClientDiagnostics.CreateScope("DataBoxJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataBoxJobJobsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, jobName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxArmOperation<DataBoxJobResource>(new DataBoxJobOperationSource(Client), _dataBoxJobJobsClientDiagnostics, Pipeline, _dataBoxJobJobsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, jobName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new job with the specified parameters. Existing job cannot be updated with this API and should instead be updated with the Update job API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="data"> Job details from request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataBoxJobResource> CreateOrUpdate(WaitUntil waitUntil, string jobName, DataBoxJobData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxJobJobsClientDiagnostics.CreateScope("DataBoxJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataBoxJobJobsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, jobName, data, cancellationToken);
                var operation = new DataBoxArmOperation<DataBoxJobResource>(new DataBoxJobOperationSource(Client), _dataBoxJobJobsClientDiagnostics, Pipeline, _dataBoxJobJobsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, jobName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets information about the specified job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="expand"> $expand is supported on details parameter for job, which provides details on the job stages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<DataBoxJobResource>> GetAsync(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _dataBoxJobJobsClientDiagnostics.CreateScope("DataBoxJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataBoxJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, jobName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="expand"> $expand is supported on details parameter for job, which provides details on the job stages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<DataBoxJobResource> Get(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _dataBoxJobJobsClientDiagnostics.CreateScope("DataBoxJobCollection.Get");
            scope.Start();
            try
            {
                var response = _dataBoxJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, jobName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the jobs available under the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> $skipToken is supported on Get list of jobs, which provides the next page in the list of jobs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataBoxJobResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataBoxJobResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataBoxJobJobsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataBoxJobJobsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataBoxJobResource(Client, DataBoxJobData.DeserializeDataBoxJobData(e)), _dataBoxJobJobsClientDiagnostics, Pipeline, "DataBoxJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the jobs available under the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> $skipToken is supported on Get list of jobs, which provides the next page in the list of jobs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataBoxJobResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataBoxJobResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataBoxJobJobsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataBoxJobJobsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataBoxJobResource(Client, DataBoxJobData.DeserializeDataBoxJobData(e)), _dataBoxJobJobsClientDiagnostics, Pipeline, "DataBoxJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="expand"> $expand is supported on details parameter for job, which provides details on the job stages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _dataBoxJobJobsClientDiagnostics.CreateScope("DataBoxJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataBoxJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, jobName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="expand"> $expand is supported on details parameter for job, which provides details on the job stages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _dataBoxJobJobsClientDiagnostics.CreateScope("DataBoxJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataBoxJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, jobName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="expand"> $expand is supported on details parameter for job, which provides details on the job stages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataBoxJobResource>> GetIfExistsAsync(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _dataBoxJobJobsClientDiagnostics.CreateScope("DataBoxJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataBoxJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, jobName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataBoxJobResource>(response.GetRawResponse());
                return Response.FromValue(new DataBoxJobResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="expand"> $expand is supported on details parameter for job, which provides details on the job stages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual NullableResponse<DataBoxJobResource> GetIfExists(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _dataBoxJobJobsClientDiagnostics.CreateScope("DataBoxJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataBoxJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, jobName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataBoxJobResource>(response.GetRawResponse());
                return Response.FromValue(new DataBoxJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataBoxJobResource> IEnumerable<DataBoxJobResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataBoxJobResource> IAsyncEnumerable<DataBoxJobResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
