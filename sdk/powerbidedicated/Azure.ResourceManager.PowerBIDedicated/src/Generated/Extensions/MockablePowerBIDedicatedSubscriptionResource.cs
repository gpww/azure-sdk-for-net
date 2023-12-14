// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.PowerBIDedicated;
using Azure.ResourceManager.PowerBIDedicated.Models;

namespace Azure.ResourceManager.PowerBIDedicated.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockablePowerBIDedicatedSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _dedicatedCapacityCapacitiesClientDiagnostics;
        private CapacitiesRestOperations _dedicatedCapacityCapacitiesRestClient;
        private ClientDiagnostics _autoScaleVCoreClientDiagnostics;
        private AutoScaleVCoresRestOperations _autoScaleVCoreRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockablePowerBIDedicatedSubscriptionResource"/> class for mocking. </summary>
        protected MockablePowerBIDedicatedSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockablePowerBIDedicatedSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockablePowerBIDedicatedSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DedicatedCapacityCapacitiesClientDiagnostics => _dedicatedCapacityCapacitiesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PowerBIDedicated", DedicatedCapacityResource.ResourceType.Namespace, Diagnostics);
        private CapacitiesRestOperations DedicatedCapacityCapacitiesRestClient => _dedicatedCapacityCapacitiesRestClient ??= new CapacitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DedicatedCapacityResource.ResourceType));
        private ClientDiagnostics AutoScaleVCoreClientDiagnostics => _autoScaleVCoreClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PowerBIDedicated", AutoScaleVCoreResource.ResourceType.Namespace, Diagnostics);
        private AutoScaleVCoresRestOperations AutoScaleVCoreRestClient => _autoScaleVCoreRestClient ??= new AutoScaleVCoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AutoScaleVCoreResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the Dedicated capacities for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/capacities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DedicatedCapacityResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DedicatedCapacityResource> GetDedicatedCapacitiesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DedicatedCapacityCapacitiesRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new DedicatedCapacityResource(Client, DedicatedCapacityData.DeserializeDedicatedCapacityData(e)), DedicatedCapacityCapacitiesClientDiagnostics, Pipeline, "MockablePowerBIDedicatedSubscriptionResource.GetDedicatedCapacities", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all the Dedicated capacities for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/capacities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DedicatedCapacityResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DedicatedCapacityResource> GetDedicatedCapacities(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DedicatedCapacityCapacitiesRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new DedicatedCapacityResource(Client, DedicatedCapacityData.DeserializeDedicatedCapacityData(e)), DedicatedCapacityCapacitiesClientDiagnostics, Pipeline, "MockablePowerBIDedicatedSubscriptionResource.GetDedicatedCapacities", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for PowerBI Dedicated resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_ListSkus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CapacitySku"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CapacitySku> GetSkusCapacitiesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DedicatedCapacityCapacitiesRestClient.CreateListSkusRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, CapacitySku.DeserializeCapacitySku, DedicatedCapacityCapacitiesClientDiagnostics, Pipeline, "MockablePowerBIDedicatedSubscriptionResource.GetSkusCapacities", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for PowerBI Dedicated resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_ListSkus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CapacitySku"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CapacitySku> GetSkusCapacities(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DedicatedCapacityCapacitiesRestClient.CreateListSkusRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, CapacitySku.DeserializeCapacitySku, DedicatedCapacityCapacitiesClientDiagnostics, Pipeline, "MockablePowerBIDedicatedSubscriptionResource.GetSkusCapacities", "value", null, cancellationToken);
        }

        /// <summary>
        /// Check the name availability in the target location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="content"> The name of the capacity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<CheckCapacityNameAvailabilityResult>> CheckNameAvailabilityCapacityAsync(AzureLocation location, CheckCapacityNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = DedicatedCapacityCapacitiesClientDiagnostics.CreateScope("MockablePowerBIDedicatedSubscriptionResource.CheckNameAvailabilityCapacity");
            scope.Start();
            try
            {
                var response = await DedicatedCapacityCapacitiesRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the name availability in the target location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="content"> The name of the capacity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<CheckCapacityNameAvailabilityResult> CheckNameAvailabilityCapacity(AzureLocation location, CheckCapacityNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = DedicatedCapacityCapacitiesClientDiagnostics.CreateScope("MockablePowerBIDedicatedSubscriptionResource.CheckNameAvailabilityCapacity");
            scope.Start();
            try
            {
                var response = DedicatedCapacityCapacitiesRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the auto scale v-cores for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/autoScaleVCores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutoScaleVCoreResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutoScaleVCoreResource> GetAutoScaleVCoresAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AutoScaleVCoreRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AutoScaleVCoreResource(Client, AutoScaleVCoreData.DeserializeAutoScaleVCoreData(e)), AutoScaleVCoreClientDiagnostics, Pipeline, "MockablePowerBIDedicatedSubscriptionResource.GetAutoScaleVCores", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all the auto scale v-cores for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/autoScaleVCores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutoScaleVCoreResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutoScaleVCoreResource> GetAutoScaleVCores(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AutoScaleVCoreRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new AutoScaleVCoreResource(Client, AutoScaleVCoreData.DeserializeAutoScaleVCoreData(e)), AutoScaleVCoreClientDiagnostics, Pipeline, "MockablePowerBIDedicatedSubscriptionResource.GetAutoScaleVCores", "value", null, cancellationToken);
        }
    }
}
