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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="WebSiteConfigConnectionStringResource"/> and their operations.
    /// Each <see cref="WebSiteConfigConnectionStringResource"/> in the collection will belong to the same instance of <see cref="WebSiteResource"/>.
    /// To get a <see cref="WebSiteConfigConnectionStringCollection"/> instance call the GetWebSiteConfigConnectionStrings method from an instance of <see cref="WebSiteResource"/>.
    /// </summary>
    public partial class WebSiteConfigConnectionStringCollection : ArmCollection, IEnumerable<WebSiteConfigConnectionStringResource>, IAsyncEnumerable<WebSiteConfigConnectionStringResource>
    {
        private readonly ClientDiagnostics _webSiteConfigConnectionStringWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteConfigConnectionStringWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteConfigConnectionStringCollection"/> class for mocking. </summary>
        protected WebSiteConfigConnectionStringCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteConfigConnectionStringCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSiteConfigConnectionStringCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteConfigConnectionStringWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSiteConfigConnectionStringResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSiteConfigConnectionStringResource.ResourceType, out string webSiteConfigConnectionStringWebAppsApiVersion);
            _webSiteConfigConnectionStringWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteConfigConnectionStringWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets the config reference and status of an app
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings/{connectionStringKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReference</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionStringKey"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual async Task<Response<WebSiteConfigConnectionStringResource>> GetAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _webSiteConfigConnectionStringWebAppsClientDiagnostics.CreateScope("WebSiteConfigConnectionStringCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSiteConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferenceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionStringKey, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteConfigConnectionStringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the config reference and status of an app
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings/{connectionStringKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReference</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionStringKey"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual Response<WebSiteConfigConnectionStringResource> Get(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _webSiteConfigConnectionStringWebAppsClientDiagnostics.CreateScope("WebSiteConfigConnectionStringCollection.Get");
            scope.Start();
            try
            {
                var response = _webSiteConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReference(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionStringKey, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteConfigConnectionStringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the config reference app settings and status of an app
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReferences</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebSiteConfigConnectionStringResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebSiteConfigConnectionStringResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteConfigConnectionStringWebAppsRestClient.CreateGetSiteConnectionStringKeyVaultReferencesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteConfigConnectionStringWebAppsRestClient.CreateGetSiteConnectionStringKeyVaultReferencesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WebSiteConfigConnectionStringResource(Client, ApiKeyVaultReferenceData.DeserializeApiKeyVaultReferenceData(e)), _webSiteConfigConnectionStringWebAppsClientDiagnostics, Pipeline, "WebSiteConfigConnectionStringCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets the config reference app settings and status of an app
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReferences</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebSiteConfigConnectionStringResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebSiteConfigConnectionStringResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteConfigConnectionStringWebAppsRestClient.CreateGetSiteConnectionStringKeyVaultReferencesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteConfigConnectionStringWebAppsRestClient.CreateGetSiteConnectionStringKeyVaultReferencesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WebSiteConfigConnectionStringResource(Client, ApiKeyVaultReferenceData.DeserializeApiKeyVaultReferenceData(e)), _webSiteConfigConnectionStringWebAppsClientDiagnostics, Pipeline, "WebSiteConfigConnectionStringCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings/{connectionStringKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReference</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionStringKey"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _webSiteConfigConnectionStringWebAppsClientDiagnostics.CreateScope("WebSiteConfigConnectionStringCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webSiteConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferenceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionStringKey, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings/{connectionStringKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReference</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionStringKey"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _webSiteConfigConnectionStringWebAppsClientDiagnostics.CreateScope("WebSiteConfigConnectionStringCollection.Exists");
            scope.Start();
            try
            {
                var response = _webSiteConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReference(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionStringKey, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings/{connectionStringKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReference</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionStringKey"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual async Task<NullableResponse<WebSiteConfigConnectionStringResource>> GetIfExistsAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _webSiteConfigConnectionStringWebAppsClientDiagnostics.CreateScope("WebSiteConfigConnectionStringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webSiteConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferenceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionStringKey, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WebSiteConfigConnectionStringResource>(response.GetRawResponse());
                return Response.FromValue(new WebSiteConfigConnectionStringResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings/{connectionStringKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReference</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionStringKey"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual NullableResponse<WebSiteConfigConnectionStringResource> GetIfExists(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _webSiteConfigConnectionStringWebAppsClientDiagnostics.CreateScope("WebSiteConfigConnectionStringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webSiteConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReference(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionStringKey, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WebSiteConfigConnectionStringResource>(response.GetRawResponse());
                return Response.FromValue(new WebSiteConfigConnectionStringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebSiteConfigConnectionStringResource> IEnumerable<WebSiteConfigConnectionStringResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebSiteConfigConnectionStringResource> IAsyncEnumerable<WebSiteConfigConnectionStringResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
