// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the operating system disk used by the virtual machine. For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview). </summary>
    public partial class VirtualMachineOSDisk
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineOSDisk"/>. </summary>
        /// <param name="createOption"> Specifies how the virtual machine should be created. Possible values are: **Attach.** This value is used when you are using a specialized disk to create the virtual machine. **FromImage.** This value is used when you are using an image to create the virtual machine. If you are using a platform image, you should also use the imageReference element described above. If you are using a marketplace image, you should also use the plan element previously described. </param>
        public VirtualMachineOSDisk(DiskCreateOptionType createOption)
        {
            CreateOption = createOption;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineOSDisk"/>. </summary>
        /// <param name="osType"> This property allows you to specify the type of the OS that is included in the disk if creating a VM from user-image or a specialized VHD. Possible values are: **Windows,** **Linux.**. </param>
        /// <param name="encryptionSettings"> Specifies the encryption settings for the OS Disk. Minimum api-version: 2015-06-15. </param>
        /// <param name="name"> The disk name. </param>
        /// <param name="vhd"> The virtual hard disk. </param>
        /// <param name="image"> The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist. </param>
        /// <param name="caching"> Specifies the caching requirements. Possible values are: **None,** **ReadOnly,** **ReadWrite.** The defaulting behavior is: **None for Standard storage. ReadOnly for Premium storage.**. </param>
        /// <param name="writeAcceleratorEnabled"> Specifies whether writeAccelerator should be enabled or disabled on the disk. </param>
        /// <param name="diffDiskSettings"> Specifies the ephemeral Disk Settings for the operating system disk used by the virtual machine. </param>
        /// <param name="createOption"> Specifies how the virtual machine should be created. Possible values are: **Attach.** This value is used when you are using a specialized disk to create the virtual machine. **FromImage.** This value is used when you are using an image to create the virtual machine. If you are using a platform image, you should also use the imageReference element described above. If you are using a marketplace image, you should also use the plan element previously described. </param>
        /// <param name="diskSizeGB"> Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. The property 'diskSizeGB' is the number of bytes x 1024^3 for the disk and the value cannot be larger than 1023. </param>
        /// <param name="managedDisk"> The managed disk parameters. </param>
        /// <param name="deleteOption"> Specifies whether OS Disk should be deleted or detached upon VM deletion. Possible values are: **Delete.** If this value is used, the OS disk is deleted when VM is deleted. **Detach.** If this value is used, the os disk is retained after VM is deleted. The default value is set to **Detach**. For an ephemeral OS Disk, the default value is set to **Delete**. The user cannot change the delete option for an ephemeral OS Disk. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineOSDisk(SupportedOperatingSystemType? osType, DiskEncryptionSettings encryptionSettings, string name, VirtualHardDisk vhd, VirtualHardDisk image, CachingType? caching, bool? writeAcceleratorEnabled, DiffDiskSettings diffDiskSettings, DiskCreateOptionType createOption, int? diskSizeGB, VirtualMachineManagedDisk managedDisk, DiskDeleteOptionType? deleteOption, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OSType = osType;
            EncryptionSettings = encryptionSettings;
            Name = name;
            Vhd = vhd;
            Image = image;
            Caching = caching;
            WriteAcceleratorEnabled = writeAcceleratorEnabled;
            DiffDiskSettings = diffDiskSettings;
            CreateOption = createOption;
            DiskSizeGB = diskSizeGB;
            ManagedDisk = managedDisk;
            DeleteOption = deleteOption;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineOSDisk"/> for deserialization. </summary>
        internal VirtualMachineOSDisk()
        {
        }

        /// <summary> This property allows you to specify the type of the OS that is included in the disk if creating a VM from user-image or a specialized VHD. Possible values are: **Windows,** **Linux.**. </summary>
        public SupportedOperatingSystemType? OSType { get; set; }
        /// <summary> Specifies the encryption settings for the OS Disk. Minimum api-version: 2015-06-15. </summary>
        public DiskEncryptionSettings EncryptionSettings { get; set; }
        /// <summary> The disk name. </summary>
        public string Name { get; set; }
        /// <summary> The virtual hard disk. </summary>
        internal VirtualHardDisk Vhd { get; set; }
        /// <summary> Specifies the virtual hard disk's uri. </summary>
        public Uri VhdUri
        {
            get => Vhd is null ? default : Vhd.Uri;
            set
            {
                if (Vhd is null)
                    Vhd = new VirtualHardDisk();
                Vhd.Uri = value;
            }
        }

        /// <summary> The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist. </summary>
        internal VirtualHardDisk Image { get; set; }
        /// <summary> Specifies the virtual hard disk's uri. </summary>
        public Uri ImageUri
        {
            get => Image is null ? default : Image.Uri;
            set
            {
                if (Image is null)
                    Image = new VirtualHardDisk();
                Image.Uri = value;
            }
        }

        /// <summary> Specifies the caching requirements. Possible values are: **None,** **ReadOnly,** **ReadWrite.** The defaulting behavior is: **None for Standard storage. ReadOnly for Premium storage.**. </summary>
        public CachingType? Caching { get; set; }
        /// <summary> Specifies whether writeAccelerator should be enabled or disabled on the disk. </summary>
        public bool? WriteAcceleratorEnabled { get; set; }
        /// <summary> Specifies the ephemeral Disk Settings for the operating system disk used by the virtual machine. </summary>
        public DiffDiskSettings DiffDiskSettings { get; set; }
        /// <summary> Specifies how the virtual machine should be created. Possible values are: **Attach.** This value is used when you are using a specialized disk to create the virtual machine. **FromImage.** This value is used when you are using an image to create the virtual machine. If you are using a platform image, you should also use the imageReference element described above. If you are using a marketplace image, you should also use the plan element previously described. </summary>
        public DiskCreateOptionType CreateOption { get; set; }
        /// <summary> Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. The property 'diskSizeGB' is the number of bytes x 1024^3 for the disk and the value cannot be larger than 1023. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> The managed disk parameters. </summary>
        public VirtualMachineManagedDisk ManagedDisk { get; set; }
        /// <summary> Specifies whether OS Disk should be deleted or detached upon VM deletion. Possible values are: **Delete.** If this value is used, the OS disk is deleted when VM is deleted. **Detach.** If this value is used, the os disk is retained after VM is deleted. The default value is set to **Detach**. For an ephemeral OS Disk, the default value is set to **Delete**. The user cannot change the delete option for an ephemeral OS Disk. </summary>
        public DiskDeleteOptionType? DeleteOption { get; set; }
    }
}
