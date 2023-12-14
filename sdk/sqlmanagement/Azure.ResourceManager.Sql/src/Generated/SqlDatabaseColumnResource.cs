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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlDatabaseColumn along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SqlDatabaseColumnResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSqlDatabaseColumnResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlDatabaseTableResource"/> using the GetSqlDatabaseColumn method.
    /// </summary>
    public partial class SqlDatabaseColumnResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlDatabaseColumnResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="databaseName"> The databaseName. </param>
        /// <param name="schemaName"> The schemaName. </param>
        /// <param name="tableName"> The tableName. </param>
        /// <param name="columnName"> The columnName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlDatabaseColumnDatabaseColumnsClientDiagnostics;
        private readonly DatabaseColumnsRestOperations _sqlDatabaseColumnDatabaseColumnsRestClient;
        private readonly ClientDiagnostics _sqlDatabaseSensitivityLabelSensitivityLabelsClientDiagnostics;
        private readonly SensitivityLabelsRestOperations _sqlDatabaseSensitivityLabelSensitivityLabelsRestClient;
        private readonly DatabaseColumnData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/schemas/tables/columns";

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseColumnResource"/> class for mocking. </summary>
        protected SqlDatabaseColumnResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseColumnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlDatabaseColumnResource(ArmClient client, DatabaseColumnData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseColumnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlDatabaseColumnResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlDatabaseColumnDatabaseColumnsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlDatabaseColumnDatabaseColumnsApiVersion);
            _sqlDatabaseColumnDatabaseColumnsRestClient = new DatabaseColumnsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlDatabaseColumnDatabaseColumnsApiVersion);
            _sqlDatabaseSensitivityLabelSensitivityLabelsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlDatabaseSensitivityLabelResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlDatabaseSensitivityLabelResource.ResourceType, out string sqlDatabaseSensitivityLabelSensitivityLabelsApiVersion);
            _sqlDatabaseSensitivityLabelSensitivityLabelsRestClient = new SensitivityLabelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlDatabaseSensitivityLabelSensitivityLabelsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseColumnData Data
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

        /// <summary> Gets a collection of SqlDatabaseSensitivityLabelResources in the SqlDatabaseColumn. </summary>
        /// <returns> An object representing collection of SqlDatabaseSensitivityLabelResources and their operations over a SqlDatabaseSensitivityLabelResource. </returns>
        public virtual SqlDatabaseSensitivityLabelCollection GetSqlDatabaseSensitivityLabels()
        {
            return GetCachedClient(client => new SqlDatabaseSensitivityLabelCollection(client, Id));
        }

        /// <summary>
        /// Gets the sensitivity label of a given column
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SensitivityLabels_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<SqlDatabaseSensitivityLabelResource>> GetSqlDatabaseSensitivityLabelAsync(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            return await GetSqlDatabaseSensitivityLabels().GetAsync(sensitivityLabelSource, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the sensitivity label of a given column
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SensitivityLabels_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<SqlDatabaseSensitivityLabelResource> GetSqlDatabaseSensitivityLabel(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            return GetSqlDatabaseSensitivityLabels().Get(sensitivityLabelSource, cancellationToken);
        }

        /// <summary>
        /// Get database column
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseColumns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlDatabaseColumnResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseColumnDatabaseColumnsClientDiagnostics.CreateScope("SqlDatabaseColumnResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseColumnDatabaseColumnsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlDatabaseColumnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get database column
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseColumns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlDatabaseColumnResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseColumnDatabaseColumnsClientDiagnostics.CreateScope("SqlDatabaseColumnResource.Get");
            scope.Start();
            try
            {
                var response = _sqlDatabaseColumnDatabaseColumnsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlDatabaseColumnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/enable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SensitivityLabels_EnableRecommendation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> EnableRecommendationSensitivityLabelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("SqlDatabaseColumnResource.EnableRecommendationSensitivityLabel");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseSensitivityLabelSensitivityLabelsRestClient.EnableRecommendationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/enable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SensitivityLabels_EnableRecommendation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response EnableRecommendationSensitivityLabel(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("SqlDatabaseColumnResource.EnableRecommendationSensitivityLabel");
            scope.Start();
            try
            {
                var response = _sqlDatabaseSensitivityLabelSensitivityLabelsRestClient.EnableRecommendation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Disables sensitivity recommendations on a given column
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/disable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SensitivityLabels_DisableRecommendation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DisableRecommendationSensitivityLabelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("SqlDatabaseColumnResource.DisableRecommendationSensitivityLabel");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseSensitivityLabelSensitivityLabelsRestClient.DisableRecommendationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Disables sensitivity recommendations on a given column
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/disable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SensitivityLabels_DisableRecommendation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DisableRecommendationSensitivityLabel(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("SqlDatabaseColumnResource.DisableRecommendationSensitivityLabel");
            scope.Start();
            try
            {
                var response = _sqlDatabaseSensitivityLabelSensitivityLabelsRestClient.DisableRecommendation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
