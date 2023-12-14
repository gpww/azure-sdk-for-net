// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a cloud service Extension. </summary>
    public partial class CloudServiceExtension
    {
        /// <summary> Initializes a new instance of <see cref="CloudServiceExtension"/>. </summary>
        public CloudServiceExtension()
        {
            RolesAppliedTo = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CloudServiceExtension"/>. </summary>
        /// <param name="name"> The name of the extension. </param>
        /// <param name="publisher"> The name of the extension handler publisher. </param>
        /// <param name="cloudServiceExtensionPropertiesType"> Specifies the type of the extension. </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the extension. Specifies the version of the extension. If this element is not specified or an asterisk (*) is used as the value, the latest version of the extension is used. If the value is specified with a major version number and an asterisk as the minor version number (X.), the latest minor version of the specified major version is selected. If a major version number and a minor version number are specified (X.Y), the specific extension version is selected. If a version is specified, an auto-upgrade is performed on the role instance. </param>
        /// <param name="autoUpgradeMinorVersion"> Explicitly specify whether platform can automatically upgrade typeHandlerVersion to higher minor versions when they become available. </param>
        /// <param name="settings"> Public settings for the extension. For JSON extensions, this is the JSON settings for the extension. For XML Extension (like RDP), this is the XML setting for the extension. </param>
        /// <param name="protectedSettings"> Protected settings for the extension which are encrypted before sent to the role instance. </param>
        /// <param name="protectedSettingsFromKeyVault"> Protected settings for the extension, referenced using KeyVault which are encrypted before sent to the role instance. </param>
        /// <param name="forceUpdateTag">
        /// Tag to force apply the provided public and protected settings.
        /// Changing the tag value allows for re-running the extension without changing any of the public or protected settings.
        /// If forceUpdateTag is not changed, updates to public or protected settings would still be applied by the handler.
        /// If neither forceUpdateTag nor any of public or protected settings change, extension would flow to the role instance with the same sequence-number, and
        /// it is up to handler implementation whether to re-run it or not
        /// </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="rolesAppliedTo"> Optional list of roles to apply this extension. If property is not specified or '*' is specified, extension is applied to all roles in the cloud service. </param>
        internal CloudServiceExtension(string name, string publisher, string cloudServiceExtensionPropertiesType, string typeHandlerVersion, bool? autoUpgradeMinorVersion, BinaryData settings, BinaryData protectedSettings, CloudServiceVaultAndSecretReference protectedSettingsFromKeyVault, string forceUpdateTag, string provisioningState, IList<string> rolesAppliedTo)
        {
            Name = name;
            Publisher = publisher;
            CloudServiceExtensionPropertiesType = cloudServiceExtensionPropertiesType;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProtectedSettingsFromKeyVault = protectedSettingsFromKeyVault;
            ForceUpdateTag = forceUpdateTag;
            ProvisioningState = provisioningState;
            RolesAppliedTo = rolesAppliedTo;
        }

        /// <summary> The name of the extension. </summary>
        public string Name { get; set; }
        /// <summary> The name of the extension handler publisher. </summary>
        public string Publisher { get; set; }
        /// <summary> Specifies the type of the extension. </summary>
        public string CloudServiceExtensionPropertiesType { get; set; }
        /// <summary> Specifies the version of the extension. Specifies the version of the extension. If this element is not specified or an asterisk (*) is used as the value, the latest version of the extension is used. If the value is specified with a major version number and an asterisk as the minor version number (X.), the latest minor version of the specified major version is selected. If a major version number and a minor version number are specified (X.Y), the specific extension version is selected. If a version is specified, an auto-upgrade is performed on the role instance. </summary>
        public string TypeHandlerVersion { get; set; }
        /// <summary> Explicitly specify whether platform can automatically upgrade typeHandlerVersion to higher minor versions when they become available. </summary>
        public bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// Public settings for the extension. For JSON extensions, this is the JSON settings for the extension. For XML Extension (like RDP), this is the XML setting for the extension.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Settings { get; set; }
        /// <summary>
        /// Protected settings for the extension which are encrypted before sent to the role instance.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData ProtectedSettings { get; set; }
        /// <summary> Protected settings for the extension, referenced using KeyVault which are encrypted before sent to the role instance. </summary>
        public CloudServiceVaultAndSecretReference ProtectedSettingsFromKeyVault { get; set; }
        /// <summary>
        /// Tag to force apply the provided public and protected settings.
        /// Changing the tag value allows for re-running the extension without changing any of the public or protected settings.
        /// If forceUpdateTag is not changed, updates to public or protected settings would still be applied by the handler.
        /// If neither forceUpdateTag nor any of public or protected settings change, extension would flow to the role instance with the same sequence-number, and
        /// it is up to handler implementation whether to re-run it or not
        /// </summary>
        public string ForceUpdateTag { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> Optional list of roles to apply this extension. If property is not specified or '*' is specified, extension is applied to all roles in the cloud service. </summary>
        public IList<string> RolesAppliedTo { get; }
    }
}
