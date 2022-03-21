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

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary> A class representing collection of VirtualDesktop and their operations over its parent. </summary>
    public partial class VirtualDesktopCollection : ArmCollection, IEnumerable<VirtualDesktop>, IAsyncEnumerable<VirtualDesktop>
    {
        private readonly ClientDiagnostics _virtualDesktopDesktopsClientDiagnostics;
        private readonly DesktopsRestOperations _virtualDesktopDesktopsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualDesktopCollection"/> class for mocking. </summary>
        protected VirtualDesktopCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualDesktopCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualDesktopCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualDesktopDesktopsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", VirtualDesktop.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(VirtualDesktop.ResourceType, out string virtualDesktopDesktopsApiVersion);
            _virtualDesktopDesktopsRestClient = new DesktopsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualDesktopDesktopsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualApplicationGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualApplicationGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a desktop.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}
        /// Operation Id: Desktops_Get
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual async Task<Response<VirtualDesktop>> GetAsync(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualDesktopDesktopsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualDesktop(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a desktop.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}
        /// Operation Id: Desktops_Get
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual Response<VirtualDesktop> Get(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualDesktopDesktopsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualDesktop(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List desktops.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops
        /// Operation Id: Desktops_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualDesktop" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualDesktop> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualDesktop>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualDesktopDesktopsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualDesktop(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List desktops.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops
        /// Operation Id: Desktops_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualDesktop" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualDesktop> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualDesktop> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualDesktopDesktopsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualDesktop(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}
        /// Operation Id: Desktops_Get
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(desktopName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}
        /// Operation Id: Desktops_Get
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual Response<bool> Exists(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(desktopName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}
        /// Operation Id: Desktops_Get
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual async Task<Response<VirtualDesktop>> GetIfExistsAsync(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualDesktopDesktopsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualDesktop>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualDesktop(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}
        /// Operation Id: Desktops_Get
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual Response<VirtualDesktop> GetIfExists(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualDesktopDesktopsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualDesktop>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualDesktop(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualDesktop> IEnumerable<VirtualDesktop>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualDesktop> IAsyncEnumerable<VirtualDesktop>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
