// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary>
    /// A copy activity sink.
    /// Please note <see cref="CopySink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AvroSink"/>, <see cref="AzureBlobFSSink"/>, <see cref="AzureDataExplorerSink"/>, <see cref="AzureDataLakeStoreSink"/>, <see cref="AzureDatabricksDeltaLakeSink"/>, <see cref="AzureMySqlSink"/>, <see cref="AzurePostgreSqlSink"/>, <see cref="AzureQueueSink"/>, <see cref="AzureSearchIndexSink"/>, <see cref="AzureSqlSink"/>, <see cref="AzureTableSink"/>, <see cref="BinarySink"/>, <see cref="BlobSink"/>, <see cref="CommonDataServiceForAppsSink"/>, <see cref="CosmosDbMongoDbApiSink"/>, <see cref="CosmosDbSqlApiSink"/>, <see cref="DelimitedTextSink"/>, <see cref="DocumentDbCollectionSink"/>, <see cref="DynamicsCrmSink"/>, <see cref="DynamicsSink"/>, <see cref="FileSystemSink"/>, <see cref="InformixSink"/>, <see cref="JsonSink"/>, <see cref="MicrosoftAccessSink"/>, <see cref="OdbcSink"/>, <see cref="OracleSink"/>, <see cref="OrcSink"/>, <see cref="ParquetSink"/>, <see cref="RestSink"/>, <see cref="SalesforceServiceCloudSink"/>, <see cref="SalesforceSink"/>, <see cref="SapCloudForCustomerSink"/>, <see cref="SnowflakeSink"/>, <see cref="SqlDWSink"/>, <see cref="SqlMISink"/>, <see cref="SqlServerSink"/> and <see cref="SqlSink"/>.
    /// </summary>
    public abstract partial class CopySink
    {
        /// <summary> Initializes a new instance of <see cref="CopySink"/>. </summary>
        protected CopySink()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="CopySink"/>. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal CopySink(string type, object writeBatchSize, object writeBatchTimeout, object sinkRetryCount, object sinkRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties)
        {
            Type = type;
            WriteBatchSize = writeBatchSize;
            WriteBatchTimeout = writeBatchTimeout;
            SinkRetryCount = sinkRetryCount;
            SinkRetryWait = sinkRetryWait;
            MaxConcurrentConnections = maxConcurrentConnections;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Copy sink type. </summary>
        internal string Type { get; set; }
        /// <summary> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public object WriteBatchSize { get; set; }
        /// <summary> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public object WriteBatchTimeout { get; set; }
        /// <summary> Sink retry count. Type: integer (or Expression with resultType integer). </summary>
        public object SinkRetryCount { get; set; }
        /// <summary> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public object SinkRetryWait { get; set; }
        /// <summary> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </summary>
        public object MaxConcurrentConnections { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
