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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="BackupProtectionPolicyResource"/> and their operations.
    /// Each <see cref="BackupProtectionPolicyResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="BackupProtectionPolicyCollection"/> instance call the GetBackupProtectionPolicies method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class BackupProtectionPolicyCollection : ArmCollection, IEnumerable<BackupProtectionPolicyResource>, IAsyncEnumerable<BackupProtectionPolicyResource>
    {
        private readonly ClientDiagnostics _backupProtectionPolicyProtectionPoliciesClientDiagnostics;
        private readonly ProtectionPoliciesRestOperations _backupProtectionPolicyProtectionPoliciesRestClient;
        private readonly ClientDiagnostics _backupProtectionPolicyBackupPoliciesClientDiagnostics;
        private readonly BackupPoliciesRestOperations _backupProtectionPolicyBackupPoliciesRestClient;
        private readonly string _vaultName;

        /// <summary> Initializes a new instance of the <see cref="BackupProtectionPolicyCollection"/> class for mocking. </summary>
        protected BackupProtectionPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackupProtectionPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        internal BackupProtectionPolicyCollection(ArmClient client, ResourceIdentifier id, string vaultName) : base(client, id)
        {
            _vaultName = vaultName;
            _backupProtectionPolicyProtectionPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", BackupProtectionPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BackupProtectionPolicyResource.ResourceType, out string backupProtectionPolicyProtectionPoliciesApiVersion);
            _backupProtectionPolicyProtectionPoliciesRestClient = new ProtectionPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupProtectionPolicyProtectionPoliciesApiVersion);
            _backupProtectionPolicyBackupPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", BackupProtectionPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BackupProtectionPolicyResource.ResourceType, out string backupProtectionPolicyBackupPoliciesApiVersion);
            _backupProtectionPolicyBackupPoliciesRestClient = new BackupPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupProtectionPolicyBackupPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or modifies a backup policy. This is an asynchronous operation. Status of the operation can be fetched
        /// using GetPolicyOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> Backup policy to be created. </param>
        /// <param name="data"> resource backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BackupProtectionPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string policyName, BackupProtectionPolicyData data, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }
            if (policyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(policyName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _backupProtectionPolicyProtectionPoliciesClientDiagnostics.CreateScope("BackupProtectionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _backupProtectionPolicyProtectionPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, policyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesBackupArmOperation<BackupProtectionPolicyResource>(Response.FromValue(new BackupProtectionPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Creates or modifies a backup policy. This is an asynchronous operation. Status of the operation can be fetched
        /// using GetPolicyOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> Backup policy to be created. </param>
        /// <param name="data"> resource backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BackupProtectionPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string policyName, BackupProtectionPolicyData data, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }
            if (policyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(policyName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _backupProtectionPolicyProtectionPoliciesClientDiagnostics.CreateScope("BackupProtectionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _backupProtectionPolicyProtectionPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, policyName, data, cancellationToken);
                var operation = new RecoveryServicesBackupArmOperation<BackupProtectionPolicyResource>(Response.FromValue(new BackupProtectionPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Provides the details of the backup policies associated to Recovery Services Vault. This is an asynchronous
        /// operation. Status of the operation can be fetched using GetPolicyOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> Backup policy information to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<BackupProtectionPolicyResource>> GetAsync(string policyName, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }
            if (policyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(policyName));
            }

            using var scope = _backupProtectionPolicyProtectionPoliciesClientDiagnostics.CreateScope("BackupProtectionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _backupProtectionPolicyProtectionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupProtectionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides the details of the backup policies associated to Recovery Services Vault. This is an asynchronous
        /// operation. Status of the operation can be fetched using GetPolicyOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> Backup policy information to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<BackupProtectionPolicyResource> Get(string policyName, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }
            if (policyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(policyName));
            }

            using var scope = _backupProtectionPolicyProtectionPoliciesClientDiagnostics.CreateScope("BackupProtectionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _backupProtectionPolicyProtectionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, policyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupProtectionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists of backup policies associated with Recovery Services Vault. API provides pagination parameters to fetch
        /// scoped results.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BackupProtectionPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BackupProtectionPolicyResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _backupProtectionPolicyBackupPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _backupProtectionPolicyBackupPoliciesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _vaultName, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BackupProtectionPolicyResource(Client, BackupProtectionPolicyData.DeserializeBackupProtectionPolicyData(e)), _backupProtectionPolicyBackupPoliciesClientDiagnostics, Pipeline, "BackupProtectionPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists of backup policies associated with Recovery Services Vault. API provides pagination parameters to fetch
        /// scoped results.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BackupProtectionPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BackupProtectionPolicyResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _backupProtectionPolicyBackupPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _backupProtectionPolicyBackupPoliciesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _vaultName, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BackupProtectionPolicyResource(Client, BackupProtectionPolicyData.DeserializeBackupProtectionPolicyData(e)), _backupProtectionPolicyBackupPoliciesClientDiagnostics, Pipeline, "BackupProtectionPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> Backup policy information to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policyName, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }
            if (policyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(policyName));
            }

            using var scope = _backupProtectionPolicyProtectionPoliciesClientDiagnostics.CreateScope("BackupProtectionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _backupProtectionPolicyProtectionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> Backup policy information to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyName, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }
            if (policyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(policyName));
            }

            using var scope = _backupProtectionPolicyProtectionPoliciesClientDiagnostics.CreateScope("BackupProtectionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _backupProtectionPolicyProtectionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, policyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> Backup policy information to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<NullableResponse<BackupProtectionPolicyResource>> GetIfExistsAsync(string policyName, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }
            if (policyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(policyName));
            }

            using var scope = _backupProtectionPolicyProtectionPoliciesClientDiagnostics.CreateScope("BackupProtectionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _backupProtectionPolicyProtectionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BackupProtectionPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new BackupProtectionPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> Backup policy information to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual NullableResponse<BackupProtectionPolicyResource> GetIfExists(string policyName, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }
            if (policyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(policyName));
            }

            using var scope = _backupProtectionPolicyProtectionPoliciesClientDiagnostics.CreateScope("BackupProtectionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _backupProtectionPolicyProtectionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, policyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BackupProtectionPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new BackupProtectionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BackupProtectionPolicyResource> IEnumerable<BackupProtectionPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BackupProtectionPolicyResource> IAsyncEnumerable<BackupProtectionPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
