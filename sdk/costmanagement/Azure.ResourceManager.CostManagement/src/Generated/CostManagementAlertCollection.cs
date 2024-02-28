// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="CostManagementAlertResource"/> and their operations.
    /// Each <see cref="CostManagementAlertResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="CostManagementAlertCollection"/> instance call the GetCostManagementAlerts method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class CostManagementAlertCollection : ArmCollection, IEnumerable<CostManagementAlertResource>, IAsyncEnumerable<CostManagementAlertResource>
    {
        private readonly ClientDiagnostics _costManagementAlertAlertsClientDiagnostics;
        private readonly AlertsRestOperations _costManagementAlertAlertsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CostManagementAlertCollection"/> class for mocking. </summary>
        protected CostManagementAlertCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CostManagementAlertCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CostManagementAlertCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _costManagementAlertAlertsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CostManagement", CostManagementAlertResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CostManagementAlertResource.ResourceType, out string costManagementAlertAlertsApiVersion);
            _costManagementAlertAlertsRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, costManagementAlertAlertsApiVersion);
        }

        /// <summary>
        /// Gets the alert for the scope by alert ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertId"> Alert ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alertId"/> is null. </exception>
        public virtual async Task<Response<CostManagementAlertResource>> GetAsync(string alertId, CancellationToken cancellationToken = default)
        {
            if (alertId == null)
            {
                throw new ArgumentNullException(nameof(alertId));
            }

            using var scope = _costManagementAlertAlertsClientDiagnostics.CreateScope("CostManagementAlertCollection.Get");
            scope.Start();
            try
            {
                var response = await _costManagementAlertAlertsRestClient.GetAsync(Id, alertId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CostManagementAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the alert for the scope by alert ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertId"> Alert ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alertId"/> is null. </exception>
        public virtual Response<CostManagementAlertResource> Get(string alertId, CancellationToken cancellationToken = default)
        {
            if (alertId == null)
            {
                throw new ArgumentNullException(nameof(alertId));
            }

            using var scope = _costManagementAlertAlertsClientDiagnostics.CreateScope("CostManagementAlertCollection.Get");
            scope.Start();
            try
            {
                var response = _costManagementAlertAlertsRestClient.Get(Id, alertId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CostManagementAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the alerts for scope defined.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/alerts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CostManagementAlertResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CostManagementAlertResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _costManagementAlertAlertsRestClient.CreateListRequest(Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CostManagementAlertResource(Client, CostManagementAlertData.DeserializeCostManagementAlertData(e)), _costManagementAlertAlertsClientDiagnostics, Pipeline, "CostManagementAlertCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the alerts for scope defined.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/alerts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CostManagementAlertResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CostManagementAlertResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _costManagementAlertAlertsRestClient.CreateListRequest(Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CostManagementAlertResource(Client, CostManagementAlertData.DeserializeCostManagementAlertData(e)), _costManagementAlertAlertsClientDiagnostics, Pipeline, "CostManagementAlertCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertId"> Alert ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alertId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string alertId, CancellationToken cancellationToken = default)
        {
            if (alertId == null)
            {
                throw new ArgumentNullException(nameof(alertId));
            }

            using var scope = _costManagementAlertAlertsClientDiagnostics.CreateScope("CostManagementAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = await _costManagementAlertAlertsRestClient.GetAsync(Id, alertId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.CostManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertId"> Alert ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alertId"/> is null. </exception>
        public virtual Response<bool> Exists(string alertId, CancellationToken cancellationToken = default)
        {
            if (alertId == null)
            {
                throw new ArgumentNullException(nameof(alertId));
            }

            using var scope = _costManagementAlertAlertsClientDiagnostics.CreateScope("CostManagementAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = _costManagementAlertAlertsRestClient.Get(Id, alertId, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.CostManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertId"> Alert ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alertId"/> is null. </exception>
        public virtual async Task<NullableResponse<CostManagementAlertResource>> GetIfExistsAsync(string alertId, CancellationToken cancellationToken = default)
        {
            if (alertId == null)
            {
                throw new ArgumentNullException(nameof(alertId));
            }

            using var scope = _costManagementAlertAlertsClientDiagnostics.CreateScope("CostManagementAlertCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _costManagementAlertAlertsRestClient.GetAsync(Id, alertId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CostManagementAlertResource>(response.GetRawResponse());
                return Response.FromValue(new CostManagementAlertResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.CostManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertId"> Alert ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alertId"/> is null. </exception>
        public virtual NullableResponse<CostManagementAlertResource> GetIfExists(string alertId, CancellationToken cancellationToken = default)
        {
            if (alertId == null)
            {
                throw new ArgumentNullException(nameof(alertId));
            }

            using var scope = _costManagementAlertAlertsClientDiagnostics.CreateScope("CostManagementAlertCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _costManagementAlertAlertsRestClient.Get(Id, alertId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CostManagementAlertResource>(response.GetRawResponse());
                return Response.FromValue(new CostManagementAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CostManagementAlertResource> IEnumerable<CostManagementAlertResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CostManagementAlertResource> IAsyncEnumerable<CostManagementAlertResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
