// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Changelog list. </summary>
    public partial class RulestackChangelog
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

        /// <summary> Initializes a new instance of <see cref="RulestackChangelog"/>. </summary>
        /// <param name="changes"> list of changes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="changes"/> is null. </exception>
        internal RulestackChangelog(IEnumerable<string> changes)
        {
            if (changes == null)
            {
                throw new ArgumentNullException(nameof(changes));
            }

            Changes = changes.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RulestackChangelog"/>. </summary>
        /// <param name="changes"> list of changes. </param>
        /// <param name="lastCommittedOn"> lastCommitted timestamp. </param>
        /// <param name="lastModifiedOn"> lastModified timestamp. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RulestackChangelog(IReadOnlyList<string> changes, DateTimeOffset? lastCommittedOn, DateTimeOffset? lastModifiedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Changes = changes;
            LastCommittedOn = lastCommittedOn;
            LastModifiedOn = lastModifiedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RulestackChangelog"/> for deserialization. </summary>
        internal RulestackChangelog()
        {
        }

        /// <summary> list of changes. </summary>
        public IReadOnlyList<string> Changes { get; }
        /// <summary> lastCommitted timestamp. </summary>
        public DateTimeOffset? LastCommittedOn { get; }
        /// <summary> lastModified timestamp. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
    }
}
