// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity snowflake source. </summary>
    public partial class SnowflakeSource : CopySource
    {
        /// <summary> Initializes a new instance of <see cref="SnowflakeSource"/>. </summary>
        /// <param name="exportSettings"> Snowflake export settings. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exportSettings"/> is null. </exception>
        public SnowflakeSource(SnowflakeExportCopyCommand exportSettings)
        {
            if (exportSettings == null)
            {
                throw new ArgumentNullException(nameof(exportSettings));
            }

            ExportSettings = exportSettings;
            Type = "SnowflakeSource";
        }

        /// <summary> Initializes a new instance of <see cref="SnowflakeSource"/>. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="query"> Snowflake Sql query. Type: string (or Expression with resultType string). </param>
        /// <param name="exportSettings"> Snowflake export settings. </param>
        internal SnowflakeSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object query, SnowflakeExportCopyCommand exportSettings) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            Query = query;
            ExportSettings = exportSettings;
            Type = type ?? "SnowflakeSource";
        }

        /// <summary> Snowflake Sql query. Type: string (or Expression with resultType string). </summary>
        public object Query { get; set; }
        /// <summary> Snowflake export settings. </summary>
        public SnowflakeExportCopyCommand ExportSettings { get; set; }
    }
}
