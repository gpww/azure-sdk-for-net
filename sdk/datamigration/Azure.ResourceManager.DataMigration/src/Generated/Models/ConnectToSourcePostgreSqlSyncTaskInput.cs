// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that validates connection to PostgreSQL and source server requirements. </summary>
    internal partial class ConnectToSourcePostgreSqlSyncTaskInput
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

        /// <summary> Initializes a new instance of <see cref="ConnectToSourcePostgreSqlSyncTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Connection information for source PostgreSQL server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/> is null. </exception>
        public ConnectToSourcePostgreSqlSyncTaskInput(PostgreSqlConnectionInfo sourceConnectionInfo)
        {
            if (sourceConnectionInfo == null)
            {
                throw new ArgumentNullException(nameof(sourceConnectionInfo));
            }

            SourceConnectionInfo = sourceConnectionInfo;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToSourcePostgreSqlSyncTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Connection information for source PostgreSQL server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectToSourcePostgreSqlSyncTaskInput(PostgreSqlConnectionInfo sourceConnectionInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToSourcePostgreSqlSyncTaskInput"/> for deserialization. </summary>
        internal ConnectToSourcePostgreSqlSyncTaskInput()
        {
        }

        /// <summary> Connection information for source PostgreSQL server. </summary>
        public PostgreSqlConnectionInfo SourceConnectionInfo { get; set; }
    }
}
