// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a ManagedInstanceDatabaseSchemaTable along with the instance operations that can be performed on it. </summary>
    public partial class ManagedInstanceDatabaseSchemaTable : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedInstanceDatabaseSchemaTable"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics;
        private readonly ManagedDatabaseTablesRestOperations _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient;
        private readonly DatabaseTableData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTable"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseSchemaTable()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedInstanceDatabaseSchemaTable"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchemaTable(ArmClient client, DatabaseTableData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTable"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchemaTable(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string managedInstanceDatabaseSchemaTableManagedDatabaseTablesApiVersion);
            _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient = new ManagedDatabaseTablesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedInstanceDatabaseSchemaTableManagedDatabaseTablesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/schemas/tables";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseTableData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ManagedInstanceDatabaseSchemaTableColumns in the ManagedInstanceDatabaseSchemaTableColumn. </summary>
        /// <returns> An object representing collection of ManagedInstanceDatabaseSchemaTableColumns and their operations over a ManagedInstanceDatabaseSchemaTableColumn. </returns>
        public virtual ManagedInstanceDatabaseSchemaTableColumnCollection GetManagedInstanceDatabaseSchemaTableColumns()
        {
            return GetCachedClient(Client => new ManagedInstanceDatabaseSchemaTableColumnCollection(Client, Id));
        }

        /// <summary>
        /// Get managed database column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: ManagedDatabaseColumns_Get
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public virtual async Task<Response<ManagedInstanceDatabaseSchemaTableColumn>> GetManagedInstanceDatabaseSchemaTableColumnAsync(string columnName, CancellationToken cancellationToken = default)
        {
            return await GetManagedInstanceDatabaseSchemaTableColumns().GetAsync(columnName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get managed database column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: ManagedDatabaseColumns_Get
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public virtual Response<ManagedInstanceDatabaseSchemaTableColumn> GetManagedInstanceDatabaseSchemaTableColumn(string columnName, CancellationToken cancellationToken = default)
        {
            return GetManagedInstanceDatabaseSchemaTableColumns().Get(columnName, cancellationToken);
        }

        /// <summary>
        /// Get managed database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceDatabaseSchemaTable>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTable.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get managed database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDatabaseSchemaTable> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTable.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseSchemaTableManagedDatabaseTablesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
