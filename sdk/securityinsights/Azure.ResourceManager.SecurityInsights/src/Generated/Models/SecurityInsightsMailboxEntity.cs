// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a mailbox entity. </summary>
    public partial class SecurityInsightsMailboxEntity : SecurityInsightsEntity
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsMailboxEntity"/>. </summary>
        public SecurityInsightsMailboxEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Kind = SecurityInsightsEntityKind.Mailbox;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsMailboxEntity"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="mailboxPrimaryAddress"> The mailbox's primary address. </param>
        /// <param name="displayName"> The mailbox's display name. </param>
        /// <param name="upn"> The mailbox's UPN. </param>
        /// <param name="externalDirectoryObjectId"> The AzureAD identifier of mailbox. Similar to AadUserId in account entity but this property is specific to mailbox object on office side. </param>
        internal SecurityInsightsMailboxEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsEntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, string mailboxPrimaryAddress, string displayName, string upn, Guid? externalDirectoryObjectId) : base(id, name, resourceType, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            MailboxPrimaryAddress = mailboxPrimaryAddress;
            DisplayName = displayName;
            Upn = upn;
            ExternalDirectoryObjectId = externalDirectoryObjectId;
            Kind = kind;
        }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The mailbox's primary address. </summary>
        public string MailboxPrimaryAddress { get; }
        /// <summary> The mailbox's display name. </summary>
        public string DisplayName { get; }
        /// <summary> The mailbox's UPN. </summary>
        public string Upn { get; }
        /// <summary> The AzureAD identifier of mailbox. Similar to AadUserId in account entity but this property is specific to mailbox object on office side. </summary>
        public Guid? ExternalDirectoryObjectId { get; }
    }
}
