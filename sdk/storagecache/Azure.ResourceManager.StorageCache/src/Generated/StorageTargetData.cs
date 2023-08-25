// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageCache.Models;

namespace Azure.ResourceManager.StorageCache
{
    /// <summary>
    /// A class representing the StorageTarget data model.
    /// Type of the Storage Target.
    /// </summary>
    public partial class StorageTargetData : ResourceData
    {
        /// <summary> Initializes a new instance of StorageTargetData. </summary>
        public StorageTargetData()
        {
            Junctions = new ChangeTrackingList<NamespaceJunction>();
        }

        /// <summary> Initializes a new instance of StorageTargetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="junctions"> List of cache namespace junctions to target for namespace associations. </param>
        /// <param name="targetType"> Type of the Storage Target. </param>
        /// <param name="provisioningState"> ARM provisioning state, see https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property. </param>
        /// <param name="state"> Storage target operational state. </param>
        /// <param name="nfs3"> Properties when targetType is nfs3. </param>
        /// <param name="clfs"> Properties when targetType is clfs. </param>
        /// <param name="unknown"> Properties when targetType is unknown. </param>
        /// <param name="blobNfs"> Properties when targetType is blobNfs. </param>
        /// <param name="allocationPercentage"> The percentage of cache space allocated for this storage target. </param>
        /// <param name="location"> Region name string. </param>
        internal StorageTargetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<NamespaceJunction> junctions, StorageTargetType? targetType, StorageCacheProvisioningStateType? provisioningState, StorageTargetOperationalStateType? state, Nfs3Target nfs3, ClfsTarget clfs, UnknownTarget unknown, BlobNfsTarget blobNfs, int? allocationPercentage, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Junctions = junctions;
            TargetType = targetType;
            ProvisioningState = provisioningState;
            State = state;
            Nfs3 = nfs3;
            Clfs = clfs;
            Unknown = unknown;
            BlobNfs = blobNfs;
            AllocationPercentage = allocationPercentage;
            Location = location;
        }

        /// <summary> List of cache namespace junctions to target for namespace associations. </summary>
        public IList<NamespaceJunction> Junctions { get; }
        /// <summary> Type of the Storage Target. </summary>
        public StorageTargetType? TargetType { get; set; }
        /// <summary> ARM provisioning state, see https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property. </summary>
        public StorageCacheProvisioningStateType? ProvisioningState { get; }
        /// <summary> Storage target operational state. </summary>
        public StorageTargetOperationalStateType? State { get; set; }
        /// <summary> Properties when targetType is nfs3. </summary>
        public Nfs3Target Nfs3 { get; set; }
        /// <summary> Properties when targetType is clfs. </summary>
        internal ClfsTarget Clfs { get; set; }
        /// <summary> Resource ID of storage container. </summary>
        public ResourceIdentifier ClfsTarget
        {
            get => Clfs is null ? default : Clfs.Target;
            set
            {
                if (Clfs is null)
                    Clfs = new ClfsTarget();
                Clfs.Target = value;
            }
        }

        /// <summary> Properties when targetType is unknown. </summary>
        internal UnknownTarget Unknown { get; set; }
        /// <summary> Dictionary of string-&gt;string pairs containing information about the Storage Target. </summary>
        public IDictionary<string, string> UnknownAttributes
        {
            get
            {
                if (Unknown is null)
                    Unknown = new UnknownTarget();
                return Unknown.Attributes;
            }
        }

        /// <summary> Properties when targetType is blobNfs. </summary>
        public BlobNfsTarget BlobNfs { get; set; }
        /// <summary> The percentage of cache space allocated for this storage target. </summary>
        public int? AllocationPercentage { get; }
        /// <summary> Region name string. </summary>
        public AzureLocation? Location { get; }
    }
}
