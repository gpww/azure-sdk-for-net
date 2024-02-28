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

namespace Azure.ResourceManager.SqlVirtualMachine
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlVmResource"/> and their operations.
    /// Each <see cref="SqlVmResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="SqlVmCollection"/> instance call the GetSqlVms method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class SqlVmCollection : ArmCollection, IEnumerable<SqlVmResource>, IAsyncEnumerable<SqlVmResource>
    {
        private readonly ClientDiagnostics _sqlVmSqlVirtualMachinesClientDiagnostics;
        private readonly SqlVirtualMachinesRestOperations _sqlVmSqlVirtualMachinesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlVmCollection"/> class for mocking. </summary>
        protected SqlVmCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlVmCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlVmCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlVmSqlVirtualMachinesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SqlVirtualMachine", SqlVmResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlVmResource.ResourceType, out string sqlVmSqlVirtualMachinesApiVersion);
            _sqlVmSqlVirtualMachinesRestClient = new SqlVirtualMachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlVmSqlVirtualMachinesApiVersion);
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
        /// Creates or updates a SQL virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sqlVmName"> Name of the SQL virtual machine. </param>
        /// <param name="data"> The SQL virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlVmResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sqlVmName, SqlVmData data, CancellationToken cancellationToken = default)
        {
            if (sqlVmName == null)
            {
                throw new ArgumentNullException(nameof(sqlVmName));
            }
            if (sqlVmName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sqlVmName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _sqlVmSqlVirtualMachinesClientDiagnostics.CreateScope("SqlVmCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlVmSqlVirtualMachinesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVmName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlVirtualMachineArmOperation<SqlVmResource>(new SqlVmOperationSource(Client), _sqlVmSqlVirtualMachinesClientDiagnostics, Pipeline, _sqlVmSqlVirtualMachinesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, sqlVmName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a SQL virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sqlVmName"> Name of the SQL virtual machine. </param>
        /// <param name="data"> The SQL virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlVmResource> CreateOrUpdate(WaitUntil waitUntil, string sqlVmName, SqlVmData data, CancellationToken cancellationToken = default)
        {
            if (sqlVmName == null)
            {
                throw new ArgumentNullException(nameof(sqlVmName));
            }
            if (sqlVmName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sqlVmName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _sqlVmSqlVirtualMachinesClientDiagnostics.CreateScope("SqlVmCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlVmSqlVirtualMachinesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, sqlVmName, data, cancellationToken);
                var operation = new SqlVirtualMachineArmOperation<SqlVmResource>(new SqlVmOperationSource(Client), _sqlVmSqlVirtualMachinesClientDiagnostics, Pipeline, _sqlVmSqlVirtualMachinesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, sqlVmName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a SQL virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmName"> Name of the SQL virtual machine. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmName"/> is null. </exception>
        public virtual async Task<Response<SqlVmResource>> GetAsync(string sqlVmName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (sqlVmName == null)
            {
                throw new ArgumentNullException(nameof(sqlVmName));
            }
            if (sqlVmName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sqlVmName));
            }

            using var scope = _sqlVmSqlVirtualMachinesClientDiagnostics.CreateScope("SqlVmCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlVmSqlVirtualMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVmName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlVmResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a SQL virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmName"> Name of the SQL virtual machine. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmName"/> is null. </exception>
        public virtual Response<SqlVmResource> Get(string sqlVmName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (sqlVmName == null)
            {
                throw new ArgumentNullException(nameof(sqlVmName));
            }
            if (sqlVmName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sqlVmName));
            }

            using var scope = _sqlVmSqlVirtualMachinesClientDiagnostics.CreateScope("SqlVmCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlVmSqlVirtualMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sqlVmName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlVmResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all SQL virtual machines in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlVmResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlVmResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlVmSqlVirtualMachinesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlVmSqlVirtualMachinesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlVmResource(Client, SqlVmData.DeserializeSqlVmData(e)), _sqlVmSqlVirtualMachinesClientDiagnostics, Pipeline, "SqlVmCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all SQL virtual machines in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlVmResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlVmResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlVmSqlVirtualMachinesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlVmSqlVirtualMachinesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlVmResource(Client, SqlVmData.DeserializeSqlVmData(e)), _sqlVmSqlVirtualMachinesClientDiagnostics, Pipeline, "SqlVmCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmName"> Name of the SQL virtual machine. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sqlVmName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (sqlVmName == null)
            {
                throw new ArgumentNullException(nameof(sqlVmName));
            }
            if (sqlVmName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sqlVmName));
            }

            using var scope = _sqlVmSqlVirtualMachinesClientDiagnostics.CreateScope("SqlVmCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlVmSqlVirtualMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVmName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmName"> Name of the SQL virtual machine. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmName"/> is null. </exception>
        public virtual Response<bool> Exists(string sqlVmName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (sqlVmName == null)
            {
                throw new ArgumentNullException(nameof(sqlVmName));
            }
            if (sqlVmName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sqlVmName));
            }

            using var scope = _sqlVmSqlVirtualMachinesClientDiagnostics.CreateScope("SqlVmCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlVmSqlVirtualMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sqlVmName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmName"> Name of the SQL virtual machine. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlVmResource>> GetIfExistsAsync(string sqlVmName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (sqlVmName == null)
            {
                throw new ArgumentNullException(nameof(sqlVmName));
            }
            if (sqlVmName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sqlVmName));
            }

            using var scope = _sqlVmSqlVirtualMachinesClientDiagnostics.CreateScope("SqlVmCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlVmSqlVirtualMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVmName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlVmResource>(response.GetRawResponse());
                return Response.FromValue(new SqlVmResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmName"> Name of the SQL virtual machine. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmName"/> is null. </exception>
        public virtual NullableResponse<SqlVmResource> GetIfExists(string sqlVmName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (sqlVmName == null)
            {
                throw new ArgumentNullException(nameof(sqlVmName));
            }
            if (sqlVmName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sqlVmName));
            }

            using var scope = _sqlVmSqlVirtualMachinesClientDiagnostics.CreateScope("SqlVmCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlVmSqlVirtualMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sqlVmName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlVmResource>(response.GetRawResponse());
                return Response.FromValue(new SqlVmResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlVmResource> IEnumerable<SqlVmResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlVmResource> IAsyncEnumerable<SqlVmResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
