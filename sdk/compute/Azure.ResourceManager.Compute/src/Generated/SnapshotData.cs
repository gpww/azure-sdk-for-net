// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the Snapshot data model.
    /// Snapshot resource.
    /// </summary>
    public partial class SnapshotData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SnapshotData"/>. </summary>
        /// <param name="location"> The location. </param>
        public SnapshotData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="managedBy"> Unused. Always Null. </param>
        /// <param name="sku"> The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for incremental snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot. </param>
        /// <param name="extendedLocation"> The extended location where the snapshot will be created. Extended location cannot be changed. </param>
        /// <param name="timeCreated"> The time when the snapshot was created. </param>
        /// <param name="osType"> The Operating System type. </param>
        /// <param name="hyperVGeneration"> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </param>
        /// <param name="purchasePlan"> Purchase plan information for the image from which the source disk for the snapshot was originally created. </param>
        /// <param name="supportedCapabilities"> List of supported capabilities for the image from which the source disk from the snapshot was originally created. </param>
        /// <param name="creationData"> Disk source information. CreationData information cannot be changed after the disk has been created. </param>
        /// <param name="diskSizeGB"> If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size. </param>
        /// <param name="diskSizeBytes"> The size of the disk in bytes. This field is read only. </param>
        /// <param name="diskState"> The state of the snapshot. </param>
        /// <param name="uniqueId"> Unique Guid identifying the resource. </param>
        /// <param name="encryptionSettingsGroup"> Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot. </param>
        /// <param name="provisioningState"> The disk provisioning state. </param>
        /// <param name="incremental"> Whether a snapshot is incremental. Incremental snapshots on the same disk occupy less space than full snapshots and can be diffed. </param>
        /// <param name="incrementalSnapshotFamilyId"> Incremental snapshots for a disk share an incremental snapshot family id. The Get Page Range Diff API can only be called on incremental snapshots with the same family id. </param>
        /// <param name="encryption"> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </param>
        /// <param name="networkAccessPolicy"> Policy for accessing the disk via network. </param>
        /// <param name="diskAccessId"> ARM id of the DiskAccess resource for using private endpoints on disks. </param>
        /// <param name="securityProfile"> Contains the security related information for the resource. </param>
        /// <param name="supportsHibernation"> Indicates the OS on a snapshot supports hibernation. </param>
        /// <param name="publicNetworkAccess"> Policy for controlling export on the disk. </param>
        /// <param name="completionPercent"> Percentage complete for the background copy when a resource is created via the CopyStart operation. </param>
        /// <param name="copyCompletionError"> Indicates the error details if the background copy of a resource created via the CopyStart operation fails. </param>
        /// <param name="dataAccessAuthMode"> Additional authentication requirements when exporting or uploading to a disk or snapshot. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SnapshotData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string managedBy, SnapshotSku sku, ExtendedLocation extendedLocation, DateTimeOffset? timeCreated, SupportedOperatingSystemType? osType, HyperVGeneration? hyperVGeneration, DiskPurchasePlan purchasePlan, SupportedCapabilities supportedCapabilities, DiskCreationData creationData, int? diskSizeGB, long? diskSizeBytes, DiskState? diskState, string uniqueId, EncryptionSettingsGroup encryptionSettingsGroup, string provisioningState, bool? incremental, string incrementalSnapshotFamilyId, DiskEncryption encryption, NetworkAccessPolicy? networkAccessPolicy, ResourceIdentifier diskAccessId, DiskSecurityProfile securityProfile, bool? supportsHibernation, DiskPublicNetworkAccess? publicNetworkAccess, float? completionPercent, CopyCompletionError copyCompletionError, DataAccessAuthMode? dataAccessAuthMode, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ManagedBy = managedBy;
            Sku = sku;
            ExtendedLocation = extendedLocation;
            TimeCreated = timeCreated;
            OSType = osType;
            HyperVGeneration = hyperVGeneration;
            PurchasePlan = purchasePlan;
            SupportedCapabilities = supportedCapabilities;
            CreationData = creationData;
            DiskSizeGB = diskSizeGB;
            DiskSizeBytes = diskSizeBytes;
            DiskState = diskState;
            UniqueId = uniqueId;
            EncryptionSettingsGroup = encryptionSettingsGroup;
            ProvisioningState = provisioningState;
            Incremental = incremental;
            IncrementalSnapshotFamilyId = incrementalSnapshotFamilyId;
            Encryption = encryption;
            NetworkAccessPolicy = networkAccessPolicy;
            DiskAccessId = diskAccessId;
            SecurityProfile = securityProfile;
            SupportsHibernation = supportsHibernation;
            PublicNetworkAccess = publicNetworkAccess;
            CompletionPercent = completionPercent;
            CopyCompletionError = copyCompletionError;
            DataAccessAuthMode = dataAccessAuthMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotData"/> for deserialization. </summary>
        internal SnapshotData()
        {
        }

        /// <summary> Unused. Always Null. </summary>
        public string ManagedBy { get; }
        /// <summary> The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for incremental snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot. </summary>
        public SnapshotSku Sku { get; set; }
        /// <summary> The extended location where the snapshot will be created. Extended location cannot be changed. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The time when the snapshot was created. </summary>
        public DateTimeOffset? TimeCreated { get; }
        /// <summary> The Operating System type. </summary>
        public SupportedOperatingSystemType? OSType { get; set; }
        /// <summary> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </summary>
        public HyperVGeneration? HyperVGeneration { get; set; }
        /// <summary> Purchase plan information for the image from which the source disk for the snapshot was originally created. </summary>
        public DiskPurchasePlan PurchasePlan { get; set; }
        /// <summary> List of supported capabilities for the image from which the source disk from the snapshot was originally created. </summary>
        public SupportedCapabilities SupportedCapabilities { get; set; }
        /// <summary> Disk source information. CreationData information cannot be changed after the disk has been created. </summary>
        public DiskCreationData CreationData { get; set; }
        /// <summary> If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> The size of the disk in bytes. This field is read only. </summary>
        public long? DiskSizeBytes { get; }
        /// <summary> The state of the snapshot. </summary>
        public DiskState? DiskState { get; }
        /// <summary> Unique Guid identifying the resource. </summary>
        public string UniqueId { get; }
        /// <summary> Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot. </summary>
        public EncryptionSettingsGroup EncryptionSettingsGroup { get; set; }
        /// <summary> The disk provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> Whether a snapshot is incremental. Incremental snapshots on the same disk occupy less space than full snapshots and can be diffed. </summary>
        public bool? Incremental { get; set; }
        /// <summary> Incremental snapshots for a disk share an incremental snapshot family id. The Get Page Range Diff API can only be called on incremental snapshots with the same family id. </summary>
        public string IncrementalSnapshotFamilyId { get; }
        /// <summary> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </summary>
        public DiskEncryption Encryption { get; set; }
        /// <summary> Policy for accessing the disk via network. </summary>
        public NetworkAccessPolicy? NetworkAccessPolicy { get; set; }
        /// <summary> ARM id of the DiskAccess resource for using private endpoints on disks. </summary>
        public ResourceIdentifier DiskAccessId { get; set; }
        /// <summary> Contains the security related information for the resource. </summary>
        public DiskSecurityProfile SecurityProfile { get; set; }
        /// <summary> Indicates the OS on a snapshot supports hibernation. </summary>
        public bool? SupportsHibernation { get; set; }
        /// <summary> Policy for controlling export on the disk. </summary>
        public DiskPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Percentage complete for the background copy when a resource is created via the CopyStart operation. </summary>
        public float? CompletionPercent { get; set; }
        /// <summary> Indicates the error details if the background copy of a resource created via the CopyStart operation fails. </summary>
        public CopyCompletionError CopyCompletionError { get; set; }
        /// <summary> Additional authentication requirements when exporting or uploading to a disk or snapshot. </summary>
        public DataAccessAuthMode? DataAccessAuthMode { get; set; }
    }
}
