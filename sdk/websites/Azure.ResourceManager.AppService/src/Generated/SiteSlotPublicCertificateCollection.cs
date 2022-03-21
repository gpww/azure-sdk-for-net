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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of SiteSlotPublicCertificate and their operations over its parent. </summary>
    public partial class SiteSlotPublicCertificateCollection : ArmCollection, IEnumerable<SiteSlotPublicCertificate>, IAsyncEnumerable<SiteSlotPublicCertificate>
    {
        private readonly ClientDiagnostics _siteSlotPublicCertificateWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotPublicCertificateWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotPublicCertificateCollection"/> class for mocking. </summary>
        protected SiteSlotPublicCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotPublicCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotPublicCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotPublicCertificateWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotPublicCertificate.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SiteSlotPublicCertificate.ResourceType, out string siteSlotPublicCertificateWebAppsApiVersion);
            _siteSlotPublicCertificateWebAppsRestClient = new WebAppsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotPublicCertificateWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlot.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlot.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates a hostname binding for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_CreateOrUpdatePublicCertificateSlot
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="publicCertificate"> Public certificate details. This is the JSON representation of a PublicCertificate object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> or <paramref name="publicCertificate"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSlotPublicCertificate>> CreateOrUpdateAsync(WaitUntil waitUntil, string publicCertificateName, PublicCertificateData publicCertificate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));
            Argument.AssertNotNull(publicCertificate, nameof(publicCertificate));

            using var scope = _siteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("SiteSlotPublicCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotPublicCertificateWebAppsRestClient.CreateOrUpdatePublicCertificateSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, publicCertificateName, publicCertificate, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotPublicCertificate>(Response.FromValue(new SiteSlotPublicCertificate(Client, response), response.GetRawResponse()));
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
        /// Description for Creates a hostname binding for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_CreateOrUpdatePublicCertificateSlot
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="publicCertificate"> Public certificate details. This is the JSON representation of a PublicCertificate object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> or <paramref name="publicCertificate"/> is null. </exception>
        public virtual ArmOperation<SiteSlotPublicCertificate> CreateOrUpdate(WaitUntil waitUntil, string publicCertificateName, PublicCertificateData publicCertificate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));
            Argument.AssertNotNull(publicCertificate, nameof(publicCertificate));

            using var scope = _siteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("SiteSlotPublicCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotPublicCertificateWebAppsRestClient.CreateOrUpdatePublicCertificateSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, publicCertificateName, publicCertificate, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotPublicCertificate>(Response.FromValue(new SiteSlotPublicCertificate(Client, response), response.GetRawResponse()));
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
        /// Description for Get the named public certificate for an app (or deployment slot, if specified).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_GetPublicCertificateSlot
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotPublicCertificate>> GetAsync(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _siteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("SiteSlotPublicCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotPublicCertificateWebAppsRestClient.GetPublicCertificateSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, publicCertificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotPublicCertificate(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the named public certificate for an app (or deployment slot, if specified).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_GetPublicCertificateSlot
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual Response<SiteSlotPublicCertificate> Get(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _siteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("SiteSlotPublicCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotPublicCertificateWebAppsRestClient.GetPublicCertificateSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, publicCertificateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotPublicCertificate(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get public certificates for an app or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates
        /// Operation Id: WebApps_ListPublicCertificatesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotPublicCertificate" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotPublicCertificate> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotPublicCertificate>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("SiteSlotPublicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotPublicCertificateWebAppsRestClient.ListPublicCertificatesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotPublicCertificate(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotPublicCertificate>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("SiteSlotPublicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotPublicCertificateWebAppsRestClient.ListPublicCertificatesSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotPublicCertificate(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get public certificates for an app or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates
        /// Operation Id: WebApps_ListPublicCertificatesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotPublicCertificate" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotPublicCertificate> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotPublicCertificate> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("SiteSlotPublicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotPublicCertificateWebAppsRestClient.ListPublicCertificatesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotPublicCertificate(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotPublicCertificate> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("SiteSlotPublicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotPublicCertificateWebAppsRestClient.ListPublicCertificatesSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotPublicCertificate(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_GetPublicCertificateSlot
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _siteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("SiteSlotPublicCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(publicCertificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_GetPublicCertificateSlot
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _siteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("SiteSlotPublicCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(publicCertificateName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_GetPublicCertificateSlot
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotPublicCertificate>> GetIfExistsAsync(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _siteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("SiteSlotPublicCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotPublicCertificateWebAppsRestClient.GetPublicCertificateSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, publicCertificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotPublicCertificate>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotPublicCertificate(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_GetPublicCertificateSlot
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual Response<SiteSlotPublicCertificate> GetIfExists(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _siteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("SiteSlotPublicCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotPublicCertificateWebAppsRestClient.GetPublicCertificateSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, publicCertificateName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotPublicCertificate>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotPublicCertificate(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotPublicCertificate> IEnumerable<SiteSlotPublicCertificate>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotPublicCertificate> IAsyncEnumerable<SiteSlotPublicCertificate>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
