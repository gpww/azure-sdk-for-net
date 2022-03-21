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

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of Feature and their operations over its parent. </summary>
    public partial class FeatureCollection : ArmCollection, IEnumerable<Feature>, IAsyncEnumerable<Feature>
    {
        private readonly ClientDiagnostics _featureClientDiagnostics;
        private readonly FeaturesRestOperations _featureRestClient;

        /// <summary> Initializes a new instance of the <see cref="FeatureCollection"/> class for mocking. </summary>
        protected FeatureCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FeatureCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FeatureCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _featureClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", Feature.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(Feature.ResourceType, out string featureApiVersion);
            _featureRestClient = new FeaturesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, featureApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Provider.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Provider.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the preview feature with the specified name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// Operation Id: Features_Get
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual async Task<Response<Feature>> GetAsync(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.Get");
            scope.Start();
            try
            {
                var response = await _featureRestClient.GetAsync(Id.SubscriptionId, Id.Provider, featureName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Feature(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the preview feature with the specified name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// Operation Id: Features_Get
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual Response<Feature> Get(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.Get");
            scope.Start();
            try
            {
                var response = _featureRestClient.Get(Id.SubscriptionId, Id.Provider, featureName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Feature(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the preview features in a provider namespace that are available through AFEC for the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features
        /// Operation Id: Features_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Feature" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Feature> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Feature>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _featureRestClient.ListAsync(Id.SubscriptionId, Id.Provider, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Feature(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Feature>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _featureRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.Provider, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Feature(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all the preview features in a provider namespace that are available through AFEC for the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features
        /// Operation Id: Features_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Feature" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Feature> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Feature> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _featureRestClient.List(Id.SubscriptionId, Id.Provider, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Feature(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Feature> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _featureRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.Provider, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Feature(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// Operation Id: Features_Get
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(featureName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// Operation Id: Features_Get
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual Response<bool> Exists(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(featureName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// Operation Id: Features_Get
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual async Task<Response<Feature>> GetIfExistsAsync(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _featureRestClient.GetAsync(Id.SubscriptionId, Id.Provider, featureName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Feature>(null, response.GetRawResponse());
                return Response.FromValue(new Feature(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// Operation Id: Features_Get
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual Response<Feature> GetIfExists(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _featureRestClient.Get(Id.SubscriptionId, Id.Provider, featureName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Feature>(null, response.GetRawResponse());
                return Response.FromValue(new Feature(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Feature> IEnumerable<Feature>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Feature> IAsyncEnumerable<Feature>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
