// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Information used to connect to an Azure Storage Container using Blobfuse. </summary>
    public partial class BatchBlobFileSystemConfiguration
    {
        /// <summary> Initializes a new instance of BatchBlobFileSystemConfiguration. </summary>
        /// <param name="accountName"> The Azure Storage Account name. </param>
        /// <param name="containerName"> The Azure Blob Storage Container name. </param>
        /// <param name="relativeMountPath"> All file systems are mounted relative to the Batch mounts directory, accessible via the AZ_BATCH_NODE_MOUNTS_DIR environment variable. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/>, <paramref name="containerName"/> or <paramref name="relativeMountPath"/> is null. </exception>
        public BatchBlobFileSystemConfiguration(string accountName, string containerName, string relativeMountPath)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(containerName, nameof(containerName));
            Argument.AssertNotNull(relativeMountPath, nameof(relativeMountPath));

            AccountName = accountName;
            ContainerName = containerName;
            RelativeMountPath = relativeMountPath;
        }

        /// <summary> Initializes a new instance of BatchBlobFileSystemConfiguration. </summary>
        /// <param name="accountName"> The Azure Storage Account name. </param>
        /// <param name="containerName"> The Azure Blob Storage Container name. </param>
        /// <param name="accountKey"> This property is mutually exclusive with both sasKey and identity; exactly one must be specified. </param>
        /// <param name="sasKey"> This property is mutually exclusive with both accountKey and identity; exactly one must be specified. </param>
        /// <param name="blobfuseOptions"> These are 'net use' options in Windows and 'mount' options in Linux. </param>
        /// <param name="relativeMountPath"> All file systems are mounted relative to the Batch mounts directory, accessible via the AZ_BATCH_NODE_MOUNTS_DIR environment variable. </param>
        /// <param name="identity"> This property is mutually exclusive with both accountKey and sasKey; exactly one must be specified. </param>
        internal BatchBlobFileSystemConfiguration(string accountName, string containerName, string accountKey, string sasKey, string blobfuseOptions, string relativeMountPath, ComputeNodeIdentityReference identity)
        {
            AccountName = accountName;
            ContainerName = containerName;
            AccountKey = accountKey;
            SasKey = sasKey;
            BlobfuseOptions = blobfuseOptions;
            RelativeMountPath = relativeMountPath;
            Identity = identity;
        }

        /// <summary> The Azure Storage Account name. </summary>
        public string AccountName { get; set; }
        /// <summary> The Azure Blob Storage Container name. </summary>
        public string ContainerName { get; set; }
        /// <summary> This property is mutually exclusive with both sasKey and identity; exactly one must be specified. </summary>
        public string AccountKey { get; set; }
        /// <summary> This property is mutually exclusive with both accountKey and identity; exactly one must be specified. </summary>
        public string SasKey { get; set; }
        /// <summary> These are 'net use' options in Windows and 'mount' options in Linux. </summary>
        public string BlobfuseOptions { get; set; }
        /// <summary> All file systems are mounted relative to the Batch mounts directory, accessible via the AZ_BATCH_NODE_MOUNTS_DIR environment variable. </summary>
        public string RelativeMountPath { get; set; }
        /// <summary> This property is mutually exclusive with both accountKey and sasKey; exactly one must be specified. </summary>
        internal ComputeNodeIdentityReference Identity { get; set; }
        /// <summary> The ARM resource id of the user assigned identity. </summary>
        public ResourceIdentifier IdentityResourceId
        {
            get => Identity is null ? default : Identity.ResourceId;
            set
            {
                if (Identity is null)
                    Identity = new ComputeNodeIdentityReference();
                Identity.ResourceId = value;
            }
        }
    }
}
