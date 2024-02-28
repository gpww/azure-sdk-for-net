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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Subscription
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingAccountPolicyResource"/> and their operations.
    /// Each <see cref="BillingAccountPolicyResource"/> in the collection will belong to the same instance of <see cref="TenantResource"/>.
    /// To get a <see cref="BillingAccountPolicyCollection"/> instance call the GetBillingAccountPolicies method from an instance of <see cref="TenantResource"/>.
    /// </summary>
    public partial class BillingAccountPolicyCollection : ArmCollection
    {
        private readonly ClientDiagnostics _billingAccountPolicyBillingAccountClientDiagnostics;
        private readonly BillingAccountRestOperations _billingAccountPolicyBillingAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingAccountPolicyCollection"/> class for mocking. </summary>
        protected BillingAccountPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingAccountPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BillingAccountPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingAccountPolicyBillingAccountClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Subscription", BillingAccountPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingAccountPolicyResource.ResourceType, out string billingAccountPolicyBillingAccountApiVersion);
            _billingAccountPolicyBillingAccountRestClient = new BillingAccountRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingAccountPolicyBillingAccountApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get Billing Account Policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Subscription/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingAccount_GetPolicy</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountId"> Billing Account Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        public virtual async Task<Response<BillingAccountPolicyResource>> GetAsync(string billingAccountId, CancellationToken cancellationToken = default)
        {
            if (billingAccountId == null)
            {
                throw new ArgumentNullException(nameof(billingAccountId));
            }
            if (billingAccountId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(billingAccountId));
            }

            using var scope = _billingAccountPolicyBillingAccountClientDiagnostics.CreateScope("BillingAccountPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingAccountPolicyBillingAccountRestClient.GetPolicyAsync(billingAccountId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAccountPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Billing Account Policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Subscription/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingAccount_GetPolicy</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountId"> Billing Account Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        public virtual Response<BillingAccountPolicyResource> Get(string billingAccountId, CancellationToken cancellationToken = default)
        {
            if (billingAccountId == null)
            {
                throw new ArgumentNullException(nameof(billingAccountId));
            }
            if (billingAccountId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(billingAccountId));
            }

            using var scope = _billingAccountPolicyBillingAccountClientDiagnostics.CreateScope("BillingAccountPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _billingAccountPolicyBillingAccountRestClient.GetPolicy(billingAccountId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAccountPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Subscription/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingAccount_GetPolicy</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountId"> Billing Account Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string billingAccountId, CancellationToken cancellationToken = default)
        {
            if (billingAccountId == null)
            {
                throw new ArgumentNullException(nameof(billingAccountId));
            }
            if (billingAccountId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(billingAccountId));
            }

            using var scope = _billingAccountPolicyBillingAccountClientDiagnostics.CreateScope("BillingAccountPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingAccountPolicyBillingAccountRestClient.GetPolicyAsync(billingAccountId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Subscription/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingAccount_GetPolicy</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountId"> Billing Account Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        public virtual Response<bool> Exists(string billingAccountId, CancellationToken cancellationToken = default)
        {
            if (billingAccountId == null)
            {
                throw new ArgumentNullException(nameof(billingAccountId));
            }
            if (billingAccountId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(billingAccountId));
            }

            using var scope = _billingAccountPolicyBillingAccountClientDiagnostics.CreateScope("BillingAccountPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingAccountPolicyBillingAccountRestClient.GetPolicy(billingAccountId, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Subscription/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingAccount_GetPolicy</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountId"> Billing Account Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        public virtual async Task<NullableResponse<BillingAccountPolicyResource>> GetIfExistsAsync(string billingAccountId, CancellationToken cancellationToken = default)
        {
            if (billingAccountId == null)
            {
                throw new ArgumentNullException(nameof(billingAccountId));
            }
            if (billingAccountId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(billingAccountId));
            }

            using var scope = _billingAccountPolicyBillingAccountClientDiagnostics.CreateScope("BillingAccountPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _billingAccountPolicyBillingAccountRestClient.GetPolicyAsync(billingAccountId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BillingAccountPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new BillingAccountPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Subscription/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingAccount_GetPolicy</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountId"> Billing Account Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        public virtual NullableResponse<BillingAccountPolicyResource> GetIfExists(string billingAccountId, CancellationToken cancellationToken = default)
        {
            if (billingAccountId == null)
            {
                throw new ArgumentNullException(nameof(billingAccountId));
            }
            if (billingAccountId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(billingAccountId));
            }

            using var scope = _billingAccountPolicyBillingAccountClientDiagnostics.CreateScope("BillingAccountPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _billingAccountPolicyBillingAccountRestClient.GetPolicy(billingAccountId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BillingAccountPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new BillingAccountPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
