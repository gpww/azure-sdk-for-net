﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Security.KeyVault.Tests
{
    /// <summary>
    /// Key Vault and Managed HSM test environment configuration.
    /// </summary>
    public class KeyVaultTestEnvironment : TestEnvironment
    {
        /// <summary>
        /// The name of the primary blob storage account key.
        /// </summary>
        public const string PrimaryKeyEnvironmentVariableName = "BLOB_PRIMARY_STORAGE_ACCOUNT_KEY";

        private const string StorageUriFormat = "https://{0}.blob.core.windows.net";

        /// <summary>
        /// Gets the default polling interval to use in tests.
        /// </summary>
        public static TimeSpan DefaultPollingInterval { get; } = TimeSpan.FromSeconds(5);

        /// <summary>
        /// Gets the URI to Key Vault.
        /// </summary>
        public string KeyVaultUrl => GetRecordedVariable("AZURE_KEYVAULT_URL");

        /// <summary>
        /// Gets a <see cref="Uri"/> to Key Vault.
        /// </summary>
        public Uri VaultUri => new(KeyVaultUrl, UriKind.Absolute);

        /// <summary>
        /// Gets the URI to Managed HSM.
        /// </summary>
        public string ManagedHsmUrl => GetRecordedOptionalVariable("AZURE_MANAGEDHSM_URL");

        /// <summary>
        /// Gets an OID for the client within the tenant.
        /// </summary>
        public string ClientObjectId => GetRecordedVariable("CLIENT_OBJECTID");

        /// <summary>
        /// Gets the primary blob storage account key.
        /// </summary>
        public string PrimaryStorageAccountKey => GetRecordedVariable(PrimaryKeyEnvironmentVariableName, options => options.IsSecret());

        /// <summary>
        /// Gets the blob storage account name.
        /// </summary>
        public string AccountName => GetRecordedVariable("BLOB_STORAGE_ACCOUNT_NAME");

        /// <summary>
        /// Gets the URI to the blob storage account.
        /// </summary>
        public string StorageUri => string.Format(StorageUriFormat, AccountName);

        /// <summary>
        /// Gets the blob container name.
        /// </summary>
        public string BlobContainerName => GetRecordedVariable("BLOB_CONTAINER_NAME");

        /// <summary>
        /// Gets the value of the "KEYVAULT_SKU" variable, or "premium" if not defined.
        /// </summary>
        /// <remarks>
        /// Test preparation was previously successfully creating premium SKUs (not available in every cloud), so assume premium.
        /// </remarks>
        public string Sku => GetOptionalVariable("SKU") ?? "premium";

        /// <summary>
        /// Gets the value of the "AZURE_KEYVAULT_ATTESTATION_URL" variable.
        /// </summary>
        public Uri AttestationUri => Uri.TryCreate(GetRecordedOptionalVariable("AZURE_KEYVAULT_ATTESTATION_URL"), UriKind.Absolute, out Uri attestationUri)
            ? attestationUri
            : throw new IgnoreException("Required variable 'AZURE_KEYVAULT_ATTESTATION_URL' is not defined");

        /// <summary>
        /// Throws an <see cref="IgnoreException"/> if <see cref="ManagedHsmUrl"/> is not defined.
        /// This should cause a test method to be ignored instead of failing.
        /// </summary>
        public void AssertManagedHsm()
        {
            if (string.IsNullOrEmpty(ManagedHsmUrl))
            {
                throw new IgnoreException($"Required variable 'AZURE_MANAGEDHSM_URL' is not defined");
            }
        }
    }
}
