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
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A Class representing a SiteRecoveryJob along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteRecoveryJobResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteRecoveryJobResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetSiteRecoveryJob method.
    /// </summary>
    public partial class SiteRecoveryJobResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteRecoveryJobResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string jobName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteRecoveryJobReplicationJobsClientDiagnostics;
        private readonly ReplicationJobsRestOperations _siteRecoveryJobReplicationJobsRestClient;
        private readonly SiteRecoveryJobData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryJobResource"/> class for mocking. </summary>
        protected SiteRecoveryJobResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteRecoveryJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteRecoveryJobResource(ArmClient client, SiteRecoveryJobData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteRecoveryJobResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteRecoveryJobReplicationJobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteRecoveryJobReplicationJobsApiVersion);
            _siteRecoveryJobReplicationJobsRestClient = new ReplicationJobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryJobReplicationJobsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.RecoveryServices/vaults/replicationJobs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteRecoveryJobData Data
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
        /// Get the details of an Azure Site Recovery job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteRecoveryJobResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobResource.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryJobReplicationJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of an Azure Site Recovery job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteRecoveryJobResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobResource.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryJobReplicationJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to cancel an Azure Site Recovery job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Cancel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<SiteRecoveryJobResource>> CancelAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobResource.Cancel");
            scope.Start();
            try
            {
                var response = await _siteRecoveryJobReplicationJobsRestClient.CancelAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryJobResource>(new SiteRecoveryJobOperationSource(Client), _siteRecoveryJobReplicationJobsClientDiagnostics, Pipeline, _siteRecoveryJobReplicationJobsRestClient.CreateCancelRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to cancel an Azure Site Recovery job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Cancel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<SiteRecoveryJobResource> Cancel(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobResource.Cancel");
            scope.Start();
            try
            {
                var response = _siteRecoveryJobReplicationJobsRestClient.Cancel(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryJobResource>(new SiteRecoveryJobOperationSource(Client), _siteRecoveryJobReplicationJobsClientDiagnostics, Pipeline, _siteRecoveryJobReplicationJobsRestClient.CreateCancelRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to restart an Azure Site Recovery job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}/restart</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Restart</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<SiteRecoveryJobResource>> RestartAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobResource.Restart");
            scope.Start();
            try
            {
                var response = await _siteRecoveryJobReplicationJobsRestClient.RestartAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryJobResource>(new SiteRecoveryJobOperationSource(Client), _siteRecoveryJobReplicationJobsClientDiagnostics, Pipeline, _siteRecoveryJobReplicationJobsRestClient.CreateRestartRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to restart an Azure Site Recovery job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}/restart</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Restart</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<SiteRecoveryJobResource> Restart(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobResource.Restart");
            scope.Start();
            try
            {
                var response = _siteRecoveryJobReplicationJobsRestClient.Restart(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryJobResource>(new SiteRecoveryJobOperationSource(Client), _siteRecoveryJobReplicationJobsClientDiagnostics, Pipeline, _siteRecoveryJobReplicationJobsRestClient.CreateRestartRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to resume an Azure Site Recovery job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}/resume</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Resume</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Resume rob comments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteRecoveryJobResource>> ResumeAsync(WaitUntil waitUntil, ReplicationResumeJobContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobResource.Resume");
            scope.Start();
            try
            {
                var response = await _siteRecoveryJobReplicationJobsRestClient.ResumeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryJobResource>(new SiteRecoveryJobOperationSource(Client), _siteRecoveryJobReplicationJobsClientDiagnostics, Pipeline, _siteRecoveryJobReplicationJobsRestClient.CreateResumeRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to resume an Azure Site Recovery job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}/resume</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Resume</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Resume rob comments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<SiteRecoveryJobResource> Resume(WaitUntil waitUntil, ReplicationResumeJobContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobResource.Resume");
            scope.Start();
            try
            {
                var response = _siteRecoveryJobReplicationJobsRestClient.Resume(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryJobResource>(new SiteRecoveryJobOperationSource(Client), _siteRecoveryJobReplicationJobsClientDiagnostics, Pipeline, _siteRecoveryJobReplicationJobsRestClient.CreateResumeRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to export the details of the Azure Site Recovery jobs of the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/export</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Export</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> job query filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteRecoveryJobResource>> ExportAsync(WaitUntil waitUntil, SiteRecoveryJobQueryContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobResource.Export");
            scope.Start();
            try
            {
                var response = await _siteRecoveryJobReplicationJobsRestClient.ExportAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryJobResource>(new SiteRecoveryJobOperationSource(Client), _siteRecoveryJobReplicationJobsClientDiagnostics, Pipeline, _siteRecoveryJobReplicationJobsRestClient.CreateExportRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to export the details of the Azure Site Recovery jobs of the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/export</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Export</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> job query filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<SiteRecoveryJobResource> Export(WaitUntil waitUntil, SiteRecoveryJobQueryContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobResource.Export");
            scope.Start();
            try
            {
                var response = _siteRecoveryJobReplicationJobsRestClient.Export(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryJobResource>(new SiteRecoveryJobOperationSource(Client), _siteRecoveryJobReplicationJobsClientDiagnostics, Pipeline, _siteRecoveryJobReplicationJobsRestClient.CreateExportRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, content).Request, response, OperationFinalStateVia.Location);
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
