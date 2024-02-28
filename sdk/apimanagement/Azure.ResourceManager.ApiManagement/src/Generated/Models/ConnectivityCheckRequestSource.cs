// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Definitions about the connectivity check origin. </summary>
    public partial class ConnectivityCheckRequestSource
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

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestSource"/>. </summary>
        /// <param name="region"> The API Management service region from where to start the connectivity check operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="region"/> is null. </exception>
        public ConnectivityCheckRequestSource(string region)
        {
            if (region == null)
            {
                throw new ArgumentNullException(nameof(region));
            }

            Region = region;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestSource"/>. </summary>
        /// <param name="region"> The API Management service region from where to start the connectivity check operation. </param>
        /// <param name="instance"> The particular VMSS instance from which to fire the request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectivityCheckRequestSource(string region, long? instance, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Region = region;
            Instance = instance;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestSource"/> for deserialization. </summary>
        internal ConnectivityCheckRequestSource()
        {
        }

        /// <summary> The API Management service region from where to start the connectivity check operation. </summary>
        public string Region { get; }
        /// <summary> The particular VMSS instance from which to fire the request. </summary>
        public long? Instance { get; set; }
    }
}
