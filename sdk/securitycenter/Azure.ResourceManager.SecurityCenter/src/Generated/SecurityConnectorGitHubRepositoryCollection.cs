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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityConnectorGitHubRepositoryResource"/> and their operations.
    /// Each <see cref="SecurityConnectorGitHubRepositoryResource"/> in the collection will belong to the same instance of <see cref="SecurityConnectorGitHubOwnerResource"/>.
    /// To get a <see cref="SecurityConnectorGitHubRepositoryCollection"/> instance call the GetSecurityConnectorGitHubRepositories method from an instance of <see cref="SecurityConnectorGitHubOwnerResource"/>.
    /// </summary>
    public partial class SecurityConnectorGitHubRepositoryCollection : ArmCollection, IEnumerable<SecurityConnectorGitHubRepositoryResource>, IAsyncEnumerable<SecurityConnectorGitHubRepositoryResource>
    {
        private readonly ClientDiagnostics _securityConnectorGitHubRepositoryGitHubReposClientDiagnostics;
        private readonly GitHubReposRestOperations _securityConnectorGitHubRepositoryGitHubReposRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorGitHubRepositoryCollection"/> class for mocking. </summary>
        protected SecurityConnectorGitHubRepositoryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorGitHubRepositoryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityConnectorGitHubRepositoryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityConnectorGitHubRepositoryGitHubReposClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SecurityConnectorGitHubRepositoryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityConnectorGitHubRepositoryResource.ResourceType, out string securityConnectorGitHubRepositoryGitHubReposApiVersion);
            _securityConnectorGitHubRepositoryGitHubReposRestClient = new GitHubReposRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityConnectorGitHubRepositoryGitHubReposApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SecurityConnectorGitHubOwnerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SecurityConnectorGitHubOwnerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Returns a monitored GitHub repository.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        public virtual async Task<Response<SecurityConnectorGitHubRepositoryResource>> GetAsync(string repoName, CancellationToken cancellationToken = default)
        {
            if (repoName == null)
            {
                throw new ArgumentNullException(nameof(repoName));
            }
            if (repoName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(repoName));
            }

            using var scope = _securityConnectorGitHubRepositoryGitHubReposClientDiagnostics.CreateScope("SecurityConnectorGitHubRepositoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityConnectorGitHubRepositoryGitHubReposRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, repoName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGitHubRepositoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored GitHub repository.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        public virtual Response<SecurityConnectorGitHubRepositoryResource> Get(string repoName, CancellationToken cancellationToken = default)
        {
            if (repoName == null)
            {
                throw new ArgumentNullException(nameof(repoName));
            }
            if (repoName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(repoName));
            }

            using var scope = _securityConnectorGitHubRepositoryGitHubReposClientDiagnostics.CreateScope("SecurityConnectorGitHubRepositoryCollection.Get");
            scope.Start();
            try
            {
                var response = _securityConnectorGitHubRepositoryGitHubReposRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, repoName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGitHubRepositoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of GitHub repositories onboarded to the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}/repos</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepos_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityConnectorGitHubRepositoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityConnectorGitHubRepositoryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityConnectorGitHubRepositoryGitHubReposRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityConnectorGitHubRepositoryGitHubReposRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityConnectorGitHubRepositoryResource(Client, SecurityConnectorGitHubRepositoryData.DeserializeSecurityConnectorGitHubRepositoryData(e)), _securityConnectorGitHubRepositoryGitHubReposClientDiagnostics, Pipeline, "SecurityConnectorGitHubRepositoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of GitHub repositories onboarded to the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}/repos</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepos_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityConnectorGitHubRepositoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityConnectorGitHubRepositoryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityConnectorGitHubRepositoryGitHubReposRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityConnectorGitHubRepositoryGitHubReposRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityConnectorGitHubRepositoryResource(Client, SecurityConnectorGitHubRepositoryData.DeserializeSecurityConnectorGitHubRepositoryData(e)), _securityConnectorGitHubRepositoryGitHubReposClientDiagnostics, Pipeline, "SecurityConnectorGitHubRepositoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string repoName, CancellationToken cancellationToken = default)
        {
            if (repoName == null)
            {
                throw new ArgumentNullException(nameof(repoName));
            }
            if (repoName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(repoName));
            }

            using var scope = _securityConnectorGitHubRepositoryGitHubReposClientDiagnostics.CreateScope("SecurityConnectorGitHubRepositoryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityConnectorGitHubRepositoryGitHubReposRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, repoName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        public virtual Response<bool> Exists(string repoName, CancellationToken cancellationToken = default)
        {
            if (repoName == null)
            {
                throw new ArgumentNullException(nameof(repoName));
            }
            if (repoName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(repoName));
            }

            using var scope = _securityConnectorGitHubRepositoryGitHubReposClientDiagnostics.CreateScope("SecurityConnectorGitHubRepositoryCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityConnectorGitHubRepositoryGitHubReposRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, repoName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityConnectorGitHubRepositoryResource>> GetIfExistsAsync(string repoName, CancellationToken cancellationToken = default)
        {
            if (repoName == null)
            {
                throw new ArgumentNullException(nameof(repoName));
            }
            if (repoName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(repoName));
            }

            using var scope = _securityConnectorGitHubRepositoryGitHubReposClientDiagnostics.CreateScope("SecurityConnectorGitHubRepositoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityConnectorGitHubRepositoryGitHubReposRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, repoName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityConnectorGitHubRepositoryResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGitHubRepositoryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        public virtual NullableResponse<SecurityConnectorGitHubRepositoryResource> GetIfExists(string repoName, CancellationToken cancellationToken = default)
        {
            if (repoName == null)
            {
                throw new ArgumentNullException(nameof(repoName));
            }
            if (repoName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(repoName));
            }

            using var scope = _securityConnectorGitHubRepositoryGitHubReposClientDiagnostics.CreateScope("SecurityConnectorGitHubRepositoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityConnectorGitHubRepositoryGitHubReposRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, repoName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityConnectorGitHubRepositoryResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGitHubRepositoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityConnectorGitHubRepositoryResource> IEnumerable<SecurityConnectorGitHubRepositoryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityConnectorGitHubRepositoryResource> IAsyncEnumerable<SecurityConnectorGitHubRepositoryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
