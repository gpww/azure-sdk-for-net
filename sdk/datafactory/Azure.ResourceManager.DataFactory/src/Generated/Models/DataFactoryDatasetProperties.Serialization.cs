// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownDataset))]
    public partial class DataFactoryDatasetProperties : IUtf8JsonSerializable, IJsonModel<DataFactoryDatasetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryDatasetProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryDatasetProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDatasetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDatasetProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Structure))
            {
                writer.WritePropertyName("structure"u8);
                JsonSerializer.Serialize(writer, Structure);
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                JsonSerializer.Serialize(writer, Schema);
            }
            writer.WritePropertyName("linkedServiceName"u8);
            JsonSerializer.Serialize(writer, LinkedServiceName);
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder"u8);
                writer.WriteObjectValue(Folder);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        DataFactoryDatasetProperties IJsonModel<DataFactoryDatasetProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDatasetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDatasetProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryDatasetProperties(document.RootElement, options);
        }

        internal static DataFactoryDatasetProperties DeserializeDataFactoryDatasetProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonMWSObject": return AmazonMwsObjectDataset.DeserializeAmazonMwsObjectDataset(element, options);
                    case "AmazonRdsForOracleTable": return AmazonRdsForOracleTableDataset.DeserializeAmazonRdsForOracleTableDataset(element, options);
                    case "AmazonRdsForSqlServerTable": return AmazonRdsForSqlServerTableDataset.DeserializeAmazonRdsForSqlServerTableDataset(element, options);
                    case "AmazonRedshiftTable": return AmazonRedshiftTableDataset.DeserializeAmazonRedshiftTableDataset(element, options);
                    case "AmazonS3Object": return AmazonS3Dataset.DeserializeAmazonS3Dataset(element, options);
                    case "Avro": return AvroDataset.DeserializeAvroDataset(element, options);
                    case "AzureBlob": return AzureBlobDataset.DeserializeAzureBlobDataset(element, options);
                    case "AzureBlobFSFile": return AzureBlobFSDataset.DeserializeAzureBlobFSDataset(element, options);
                    case "AzureDataExplorerTable": return AzureDataExplorerTableDataset.DeserializeAzureDataExplorerTableDataset(element, options);
                    case "AzureDataLakeStoreFile": return AzureDataLakeStoreDataset.DeserializeAzureDataLakeStoreDataset(element, options);
                    case "AzureDatabricksDeltaLakeDataset": return AzureDatabricksDeltaLakeDataset.DeserializeAzureDatabricksDeltaLakeDataset(element, options);
                    case "AzureMariaDBTable": return AzureMariaDBTableDataset.DeserializeAzureMariaDBTableDataset(element, options);
                    case "AzureMySqlTable": return AzureMySqlTableDataset.DeserializeAzureMySqlTableDataset(element, options);
                    case "AzurePostgreSqlTable": return AzurePostgreSqlTableDataset.DeserializeAzurePostgreSqlTableDataset(element, options);
                    case "AzureSearchIndex": return AzureSearchIndexDataset.DeserializeAzureSearchIndexDataset(element, options);
                    case "AzureSqlDWTable": return AzureSqlDWTableDataset.DeserializeAzureSqlDWTableDataset(element, options);
                    case "AzureSqlMITable": return AzureSqlMITableDataset.DeserializeAzureSqlMITableDataset(element, options);
                    case "AzureSqlTable": return AzureSqlTableDataset.DeserializeAzureSqlTableDataset(element, options);
                    case "AzureTable": return AzureTableDataset.DeserializeAzureTableDataset(element, options);
                    case "Binary": return BinaryDataset.DeserializeBinaryDataset(element, options);
                    case "CassandraTable": return CassandraTableDataset.DeserializeCassandraTableDataset(element, options);
                    case "CommonDataServiceForAppsEntity": return CommonDataServiceForAppsEntityDataset.DeserializeCommonDataServiceForAppsEntityDataset(element, options);
                    case "ConcurObject": return ConcurObjectDataset.DeserializeConcurObjectDataset(element, options);
                    case "CosmosDbMongoDbApiCollection": return CosmosDBMongoDBApiCollectionDataset.DeserializeCosmosDBMongoDBApiCollectionDataset(element, options);
                    case "CosmosDbSqlApiCollection": return CosmosDBSqlApiCollectionDataset.DeserializeCosmosDBSqlApiCollectionDataset(element, options);
                    case "CouchbaseTable": return CouchbaseTableDataset.DeserializeCouchbaseTableDataset(element, options);
                    case "CustomDataset": return CustomDataset.DeserializeCustomDataset(element, options);
                    case "Db2Table": return Db2TableDataset.DeserializeDb2TableDataset(element, options);
                    case "DelimitedText": return DelimitedTextDataset.DeserializeDelimitedTextDataset(element, options);
                    case "DocumentDbCollection": return DocumentDBCollectionDataset.DeserializeDocumentDBCollectionDataset(element, options);
                    case "DrillTable": return DrillTableDataset.DeserializeDrillTableDataset(element, options);
                    case "DynamicsAXResource": return DynamicsAXResourceDataset.DeserializeDynamicsAXResourceDataset(element, options);
                    case "DynamicsCrmEntity": return DynamicsCrmEntityDataset.DeserializeDynamicsCrmEntityDataset(element, options);
                    case "DynamicsEntity": return DynamicsEntityDataset.DeserializeDynamicsEntityDataset(element, options);
                    case "EloquaObject": return EloquaObjectDataset.DeserializeEloquaObjectDataset(element, options);
                    case "Excel": return ExcelDataset.DeserializeExcelDataset(element, options);
                    case "FileShare": return FileShareDataset.DeserializeFileShareDataset(element, options);
                    case "GoogleAdWordsObject": return GoogleAdWordsObjectDataset.DeserializeGoogleAdWordsObjectDataset(element, options);
                    case "GoogleBigQueryObject": return GoogleBigQueryObjectDataset.DeserializeGoogleBigQueryObjectDataset(element, options);
                    case "GreenplumTable": return GreenplumTableDataset.DeserializeGreenplumTableDataset(element, options);
                    case "HBaseObject": return HBaseObjectDataset.DeserializeHBaseObjectDataset(element, options);
                    case "HiveObject": return HiveObjectDataset.DeserializeHiveObjectDataset(element, options);
                    case "HttpFile": return DataFactoryHttpDataset.DeserializeDataFactoryHttpDataset(element, options);
                    case "HubspotObject": return HubspotObjectDataset.DeserializeHubspotObjectDataset(element, options);
                    case "ImpalaObject": return ImpalaObjectDataset.DeserializeImpalaObjectDataset(element, options);
                    case "InformixTable": return InformixTableDataset.DeserializeInformixTableDataset(element, options);
                    case "JiraObject": return JiraObjectDataset.DeserializeJiraObjectDataset(element, options);
                    case "Json": return JsonDataset.DeserializeJsonDataset(element, options);
                    case "LakeHouseTable": return LakeHouseTableDataset.DeserializeLakeHouseTableDataset(element, options);
                    case "MagentoObject": return MagentoObjectDataset.DeserializeMagentoObjectDataset(element, options);
                    case "MariaDBTable": return MariaDBTableDataset.DeserializeMariaDBTableDataset(element, options);
                    case "MarketoObject": return MarketoObjectDataset.DeserializeMarketoObjectDataset(element, options);
                    case "MicrosoftAccessTable": return MicrosoftAccessTableDataset.DeserializeMicrosoftAccessTableDataset(element, options);
                    case "MongoDbAtlasCollection": return MongoDBAtlasCollectionDataset.DeserializeMongoDBAtlasCollectionDataset(element, options);
                    case "MongoDbCollection": return MongoDBCollectionDataset.DeserializeMongoDBCollectionDataset(element, options);
                    case "MongoDbV2Collection": return MongoDBV2CollectionDataset.DeserializeMongoDBV2CollectionDataset(element, options);
                    case "MySqlTable": return MySqlTableDataset.DeserializeMySqlTableDataset(element, options);
                    case "NetezzaTable": return NetezzaTableDataset.DeserializeNetezzaTableDataset(element, options);
                    case "ODataResource": return ODataResourceDataset.DeserializeODataResourceDataset(element, options);
                    case "OdbcTable": return OdbcTableDataset.DeserializeOdbcTableDataset(element, options);
                    case "Office365Table": return Office365Dataset.DeserializeOffice365Dataset(element, options);
                    case "OracleServiceCloudObject": return OracleServiceCloudObjectDataset.DeserializeOracleServiceCloudObjectDataset(element, options);
                    case "OracleTable": return OracleTableDataset.DeserializeOracleTableDataset(element, options);
                    case "Orc": return OrcDataset.DeserializeOrcDataset(element, options);
                    case "Parquet": return ParquetDataset.DeserializeParquetDataset(element, options);
                    case "PaypalObject": return PaypalObjectDataset.DeserializePaypalObjectDataset(element, options);
                    case "PhoenixObject": return PhoenixObjectDataset.DeserializePhoenixObjectDataset(element, options);
                    case "PostgreSqlTable": return PostgreSqlTableDataset.DeserializePostgreSqlTableDataset(element, options);
                    case "PrestoObject": return PrestoObjectDataset.DeserializePrestoObjectDataset(element, options);
                    case "QuickBooksObject": return QuickBooksObjectDataset.DeserializeQuickBooksObjectDataset(element, options);
                    case "RelationalTable": return RelationalTableDataset.DeserializeRelationalTableDataset(element, options);
                    case "ResponsysObject": return ResponsysObjectDataset.DeserializeResponsysObjectDataset(element, options);
                    case "RestResource": return RestResourceDataset.DeserializeRestResourceDataset(element, options);
                    case "SalesforceMarketingCloudObject": return SalesforceMarketingCloudObjectDataset.DeserializeSalesforceMarketingCloudObjectDataset(element, options);
                    case "SalesforceObject": return SalesforceObjectDataset.DeserializeSalesforceObjectDataset(element, options);
                    case "SalesforceServiceCloudObject": return SalesforceServiceCloudObjectDataset.DeserializeSalesforceServiceCloudObjectDataset(element, options);
                    case "SalesforceServiceCloudV2Object": return SalesforceServiceCloudV2ObjectDataset.DeserializeSalesforceServiceCloudV2ObjectDataset(element, options);
                    case "SalesforceV2Object": return SalesforceV2ObjectDataset.DeserializeSalesforceV2ObjectDataset(element, options);
                    case "SapBwCube": return SapBWCubeDataset.DeserializeSapBWCubeDataset(element, options);
                    case "SapCloudForCustomerResource": return SapCloudForCustomerResourceDataset.DeserializeSapCloudForCustomerResourceDataset(element, options);
                    case "SapEccResource": return SapEccResourceDataset.DeserializeSapEccResourceDataset(element, options);
                    case "SapHanaTable": return SapHanaTableDataset.DeserializeSapHanaTableDataset(element, options);
                    case "SapOdpResource": return SapOdpResourceDataset.DeserializeSapOdpResourceDataset(element, options);
                    case "SapOpenHubTable": return SapOpenHubTableDataset.DeserializeSapOpenHubTableDataset(element, options);
                    case "SapTableResource": return SapTableResourceDataset.DeserializeSapTableResourceDataset(element, options);
                    case "ServiceNowObject": return ServiceNowObjectDataset.DeserializeServiceNowObjectDataset(element, options);
                    case "SharePointOnlineListResource": return SharePointOnlineListResourceDataset.DeserializeSharePointOnlineListResourceDataset(element, options);
                    case "ShopifyObject": return ShopifyObjectDataset.DeserializeShopifyObjectDataset(element, options);
                    case "SnowflakeTable": return SnowflakeDataset.DeserializeSnowflakeDataset(element, options);
                    case "SnowflakeV2Table": return SnowflakeV2Dataset.DeserializeSnowflakeV2Dataset(element, options);
                    case "SparkObject": return SparkObjectDataset.DeserializeSparkObjectDataset(element, options);
                    case "SqlServerTable": return SqlServerTableDataset.DeserializeSqlServerTableDataset(element, options);
                    case "SquareObject": return SquareObjectDataset.DeserializeSquareObjectDataset(element, options);
                    case "SybaseTable": return SybaseTableDataset.DeserializeSybaseTableDataset(element, options);
                    case "TeradataTable": return TeradataTableDataset.DeserializeTeradataTableDataset(element, options);
                    case "VerticaTable": return VerticaTableDataset.DeserializeVerticaTableDataset(element, options);
                    case "WarehouseTable": return WarehouseTableDataset.DeserializeWarehouseTableDataset(element, options);
                    case "WebTable": return WebTableDataset.DeserializeWebTableDataset(element, options);
                    case "XeroObject": return XeroObjectDataset.DeserializeXeroObjectDataset(element, options);
                    case "Xml": return XmlDataset.DeserializeXmlDataset(element, options);
                    case "ZohoObject": return ZohoObjectDataset.DeserializeZohoObjectDataset(element, options);
                }
            }
            return UnknownDataset.DeserializeUnknownDataset(element, options);
        }

        BinaryData IPersistableModel<DataFactoryDatasetProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDatasetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDatasetProperties)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryDatasetProperties IPersistableModel<DataFactoryDatasetProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDatasetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryDatasetProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDatasetProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryDatasetProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
