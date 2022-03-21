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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SitePrivateEndpointConnection along with the instance operations that can be performed on it. </summary>
    public partial class SitePrivateEndpointConnection : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SitePrivateEndpointConnection"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sitePrivateEndpointConnectionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _sitePrivateEndpointConnectionWebAppsRestClient;
        private readonly RemotePrivateEndpointConnectionARMResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="SitePrivateEndpointConnection"/> class for mocking. </summary>
        protected SitePrivateEndpointConnection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SitePrivateEndpointConnection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SitePrivateEndpointConnection(ArmClient client, RemotePrivateEndpointConnectionARMResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SitePrivateEndpointConnection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SitePrivateEndpointConnection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sitePrivateEndpointConnectionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string sitePrivateEndpointConnectionWebAppsApiVersion);
            _sitePrivateEndpointConnectionWebAppsRestClient = new WebAppsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sitePrivateEndpointConnectionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/privateEndpointConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RemotePrivateEndpointConnectionARMResourceData Data
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

        /// <summary>
        /// Description for Gets a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_GetPrivateEndpointConnection
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SitePrivateEndpointConnection>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sitePrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SitePrivateEndpointConnection.Get");
            scope.Start();
            try
            {
                var response = await _sitePrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SitePrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_GetPrivateEndpointConnection
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SitePrivateEndpointConnection> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sitePrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SitePrivateEndpointConnection.Get");
            scope.Start();
            try
            {
                var response = _sitePrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SitePrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_DeletePrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<BinaryData>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sitePrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SitePrivateEndpointConnection.Delete");
            scope.Start();
            try
            {
                var response = await _sitePrivateEndpointConnectionWebAppsRestClient.DeletePrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<BinaryData>(new BinaryDataOperationSource(), _sitePrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _sitePrivateEndpointConnectionWebAppsRestClient.CreateDeletePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Deletes a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_DeletePrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<BinaryData> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sitePrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SitePrivateEndpointConnection.Delete");
            scope.Start();
            try
            {
                var response = _sitePrivateEndpointConnectionWebAppsRestClient.DeletePrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation<BinaryData>(new BinaryDataOperationSource(), _sitePrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _sitePrivateEndpointConnectionWebAppsRestClient.CreateDeletePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
    }
}
