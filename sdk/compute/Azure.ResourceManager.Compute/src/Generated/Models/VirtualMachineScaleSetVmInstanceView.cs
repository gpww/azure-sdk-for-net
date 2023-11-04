// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The instance view of a virtual machine scale set VM. </summary>
    public partial class VirtualMachineScaleSetVmInstanceView
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmInstanceView"/>. </summary>
        internal VirtualMachineScaleSetVmInstanceView()
        {
            Disks = new ChangeTrackingList<DiskInstanceView>();
            Extensions = new ChangeTrackingList<VirtualMachineExtensionInstanceView>();
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmInstanceView"/>. </summary>
        /// <param name="platformUpdateDomain"> The Update Domain count. </param>
        /// <param name="platformFaultDomain"> The Fault Domain count. </param>
        /// <param name="rdpThumbPrint"> The Remote desktop certificate thumbprint. </param>
        /// <param name="vmAgent"> The VM Agent running on the virtual machine. </param>
        /// <param name="maintenanceRedeployStatus"> The Maintenance Operation status on the virtual machine. </param>
        /// <param name="disks"> The disks information. </param>
        /// <param name="extensions"> The extensions information. </param>
        /// <param name="vmHealth"> The health status for the VM. </param>
        /// <param name="bootDiagnostics"> Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. You can easily view the output of your console log. Azure also enables you to see a screenshot of the VM from the hypervisor. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="assignedHost"> Resource id of the dedicated host, on which the virtual machine is allocated through automatic placement, when the virtual machine is associated with a dedicated host group that has automatic placement enabled. Minimum api-version: 2020-06-01. </param>
        /// <param name="placementGroupId"> The placement group in which the VM is running. If the VM is deallocated it will not have a placementGroupId. </param>
        /// <param name="computerName"> Specifies the host OS name of the virtual machine. &lt;br&gt;&lt;br&gt; This name cannot be updated after the VM is created. &lt;br&gt;&lt;br&gt; **Max-length (Windows):** 15 characters &lt;br&gt;&lt;br&gt; **Max-length (Linux):** 64 characters. &lt;br&gt;&lt;br&gt; For naming conventions and restrictions see [Azure infrastructure services implementation guidelines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-infrastructure-subscription-accounts-guidelines?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#1-naming-conventions). </param>
        /// <param name="osName"> The Operating System running on the hybrid machine. </param>
        /// <param name="osVersion"> The version of Operating System running on the hybrid machine. </param>
        /// <param name="hyperVGeneration"> The hypervisor generation of the Virtual Machine [V1, V2]. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetVmInstanceView(int? platformUpdateDomain, int? platformFaultDomain, string rdpThumbPrint, VirtualMachineAgentInstanceView vmAgent, MaintenanceRedeployStatus maintenanceRedeployStatus, IReadOnlyList<DiskInstanceView> disks, IReadOnlyList<VirtualMachineExtensionInstanceView> extensions, VirtualMachineHealthStatus vmHealth, BootDiagnosticsInstanceView bootDiagnostics, IReadOnlyList<InstanceViewStatus> statuses, ResourceIdentifier assignedHost, string placementGroupId, string computerName, string osName, string osVersion, HyperVGeneration? hyperVGeneration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PlatformUpdateDomain = platformUpdateDomain;
            PlatformFaultDomain = platformFaultDomain;
            RdpThumbPrint = rdpThumbPrint;
            VmAgent = vmAgent;
            MaintenanceRedeployStatus = maintenanceRedeployStatus;
            Disks = disks;
            Extensions = extensions;
            VmHealth = vmHealth;
            BootDiagnostics = bootDiagnostics;
            Statuses = statuses;
            AssignedHost = assignedHost;
            PlacementGroupId = placementGroupId;
            ComputerName = computerName;
            OSName = osName;
            OSVersion = osVersion;
            HyperVGeneration = hyperVGeneration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Update Domain count. </summary>
        public int? PlatformUpdateDomain { get; }
        /// <summary> The Fault Domain count. </summary>
        public int? PlatformFaultDomain { get; }
        /// <summary> The Remote desktop certificate thumbprint. </summary>
        public string RdpThumbPrint { get; }
        /// <summary> The VM Agent running on the virtual machine. </summary>
        public VirtualMachineAgentInstanceView VmAgent { get; }
        /// <summary> The Maintenance Operation status on the virtual machine. </summary>
        public MaintenanceRedeployStatus MaintenanceRedeployStatus { get; }
        /// <summary> The disks information. </summary>
        public IReadOnlyList<DiskInstanceView> Disks { get; }
        /// <summary> The extensions information. </summary>
        public IReadOnlyList<VirtualMachineExtensionInstanceView> Extensions { get; }
        /// <summary> The health status for the VM. </summary>
        internal VirtualMachineHealthStatus VmHealth { get; }
        /// <summary> The health status information for the VM. </summary>
        public InstanceViewStatus VmHealthStatus
        {
            get => VmHealth?.Status;
        }

        /// <summary> Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. You can easily view the output of your console log. Azure also enables you to see a screenshot of the VM from the hypervisor. </summary>
        public BootDiagnosticsInstanceView BootDiagnostics { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<InstanceViewStatus> Statuses { get; }
        /// <summary> Resource id of the dedicated host, on which the virtual machine is allocated through automatic placement, when the virtual machine is associated with a dedicated host group that has automatic placement enabled. Minimum api-version: 2020-06-01. </summary>
        public ResourceIdentifier AssignedHost { get; }
        /// <summary> The placement group in which the VM is running. If the VM is deallocated it will not have a placementGroupId. </summary>
        public string PlacementGroupId { get; }
        /// <summary> Specifies the host OS name of the virtual machine. &lt;br&gt;&lt;br&gt; This name cannot be updated after the VM is created. &lt;br&gt;&lt;br&gt; **Max-length (Windows):** 15 characters &lt;br&gt;&lt;br&gt; **Max-length (Linux):** 64 characters. &lt;br&gt;&lt;br&gt; For naming conventions and restrictions see [Azure infrastructure services implementation guidelines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-infrastructure-subscription-accounts-guidelines?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#1-naming-conventions). </summary>
        public string ComputerName { get; }
        /// <summary> The Operating System running on the hybrid machine. </summary>
        public string OSName { get; }
        /// <summary> The version of Operating System running on the hybrid machine. </summary>
        public string OSVersion { get; }
        /// <summary> The hypervisor generation of the Virtual Machine [V1, V2]. </summary>
        public HyperVGeneration? HyperVGeneration { get; }
    }
}
