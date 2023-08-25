// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudBareMetalMachineData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("extendedLocation"u8);
            writer.WriteObjectValue(ExtendedLocation);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("bmcConnectionString"u8);
            writer.WriteStringValue(BmcConnectionString);
            writer.WritePropertyName("bmcCredentials"u8);
            writer.WriteObjectValue(BmcCredentials);
            writer.WritePropertyName("bmcMacAddress"u8);
            writer.WriteStringValue(BmcMacAddress);
            writer.WritePropertyName("bootMacAddress"u8);
            writer.WriteStringValue(BootMacAddress);
            writer.WritePropertyName("machineDetails"u8);
            writer.WriteStringValue(MachineDetails);
            writer.WritePropertyName("machineName"u8);
            writer.WriteStringValue(MachineName);
            writer.WritePropertyName("machineSkuId"u8);
            writer.WriteStringValue(MachineSkuId);
            writer.WritePropertyName("rackId"u8);
            writer.WriteStringValue(RackId);
            writer.WritePropertyName("rackSlot"u8);
            writer.WriteNumberValue(RackSlot);
            writer.WritePropertyName("serialNumber"u8);
            writer.WriteStringValue(SerialNumber);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkCloudBareMetalMachineData DeserializeNetworkCloudBareMetalMachineData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyList<ResourceIdentifier>> associatedResourceIds = default;
            string bmcConnectionString = default;
            AdministrativeCredentials bmcCredentials = default;
            string bmcMacAddress = default;
            string bootMacAddress = default;
            Optional<ResourceIdentifier> clusterId = default;
            Optional<BareMetalMachineCordonStatus> cordonStatus = default;
            Optional<BareMetalMachineDetailedStatus> detailedStatus = default;
            Optional<string> detailedStatusMessage = default;
            Optional<HardwareInventory> hardwareInventory = default;
            Optional<HardwareValidationStatus> hardwareValidationStatus = default;
            Optional<IReadOnlyList<string>> hybridAksClustersAssociatedIds = default;
            Optional<string> kubernetesNodeName = default;
            Optional<string> kubernetesVersion = default;
            string machineDetails = default;
            string machineName = default;
            string machineSkuId = default;
            Optional<IPAddress> oamIPv4Address = default;
            Optional<string> oamIPv6Address = default;
            Optional<string> osImage = default;
            Optional<BareMetalMachinePowerState> powerState = default;
            Optional<BareMetalMachineProvisioningState> provisioningState = default;
            ResourceIdentifier rackId = default;
            long rackSlot = default;
            Optional<BareMetalMachineReadyState> readyState = default;
            string serialNumber = default;
            Optional<string> serviceTag = default;
            Optional<IReadOnlyList<string>> virtualMachinesAssociatedIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("associatedResourceIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            associatedResourceIds = array;
                            continue;
                        }
                        if (property0.NameEquals("bmcConnectionString"u8))
                        {
                            bmcConnectionString = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bmcCredentials"u8))
                        {
                            bmcCredentials = AdministrativeCredentials.DeserializeAdministrativeCredentials(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("bmcMacAddress"u8))
                        {
                            bmcMacAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bootMacAddress"u8))
                        {
                            bootMacAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cordonStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cordonStatus = new BareMetalMachineCordonStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new BareMetalMachineDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hardwareInventory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hardwareInventory = HardwareInventory.DeserializeHardwareInventory(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hardwareValidationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hardwareValidationStatus = HardwareValidationStatus.DeserializeHardwareValidationStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hybridAksClustersAssociatedIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            hybridAksClustersAssociatedIds = array;
                            continue;
                        }
                        if (property0.NameEquals("kubernetesNodeName"u8))
                        {
                            kubernetesNodeName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kubernetesVersion"u8))
                        {
                            kubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("machineDetails"u8))
                        {
                            machineDetails = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("machineName"u8))
                        {
                            machineName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("machineSkuId"u8))
                        {
                            machineSkuId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("oamIpv4Address"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            oamIPv4Address = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("oamIpv6Address"u8))
                        {
                            oamIPv6Address = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osImage"u8))
                        {
                            osImage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("powerState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            powerState = new BareMetalMachinePowerState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new BareMetalMachineProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rackId"u8))
                        {
                            rackId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rackSlot"u8))
                        {
                            rackSlot = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("readyState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readyState = new BareMetalMachineReadyState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceTag"u8))
                        {
                            serviceTag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualMachinesAssociatedIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            virtualMachinesAssociatedIds = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkCloudBareMetalMachineData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation, Optional.ToList(associatedResourceIds), bmcConnectionString, bmcCredentials, bmcMacAddress, bootMacAddress, clusterId.Value, Optional.ToNullable(cordonStatus), Optional.ToNullable(detailedStatus), detailedStatusMessage.Value, hardwareInventory.Value, hardwareValidationStatus.Value, Optional.ToList(hybridAksClustersAssociatedIds), kubernetesNodeName.Value, kubernetesVersion.Value, machineDetails, machineName, machineSkuId, oamIPv4Address.Value, oamIPv6Address.Value, osImage.Value, Optional.ToNullable(powerState), Optional.ToNullable(provisioningState), rackId, rackSlot, Optional.ToNullable(readyState), serialNumber, serviceTag.Value, Optional.ToList(virtualMachinesAssociatedIds));
        }
    }
}
