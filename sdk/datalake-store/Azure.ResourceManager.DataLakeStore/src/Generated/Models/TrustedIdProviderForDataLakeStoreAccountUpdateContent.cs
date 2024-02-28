// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The parameters used to update a trusted identity provider while updating a Data Lake Store account. </summary>
    public partial class TrustedIdProviderForDataLakeStoreAccountUpdateContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TrustedIdProviderForDataLakeStoreAccountUpdateContent"/>. </summary>
        /// <param name="name"> The unique name of the trusted identity provider to update. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public TrustedIdProviderForDataLakeStoreAccountUpdateContent(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="TrustedIdProviderForDataLakeStoreAccountUpdateContent"/>. </summary>
        /// <param name="name"> The unique name of the trusted identity provider to update. </param>
        /// <param name="idProvider"> The URL of this trusted identity provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrustedIdProviderForDataLakeStoreAccountUpdateContent(string name, Uri idProvider, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            IdProvider = idProvider;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TrustedIdProviderForDataLakeStoreAccountUpdateContent"/> for deserialization. </summary>
        internal TrustedIdProviderForDataLakeStoreAccountUpdateContent()
        {
        }

        /// <summary> The unique name of the trusted identity provider to update. </summary>
        public string Name { get; }
        /// <summary> The URL of this trusted identity provider. </summary>
        public Uri IdProvider { get; set; }
    }
}
