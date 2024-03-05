// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Analytics.Synapse.Spark;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkBatchJobOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (Optional.IsDefined(ArtifactId))
            {
                writer.WritePropertyName("artifactId"u8);
                writer.WriteStringValue(ArtifactId);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("file"u8);
            writer.WriteStringValue(File);
            if (Optional.IsDefined(ClassName))
            {
                writer.WritePropertyName("className"u8);
                writer.WriteStringValue(ClassName);
            }
            if (Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("args"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Jars))
            {
                writer.WritePropertyName("jars"u8);
                writer.WriteStartArray();
                foreach (var item in Jars)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PythonFiles))
            {
                writer.WritePropertyName("pyFiles"u8);
                writer.WriteStartArray();
                foreach (var item in PythonFiles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files"u8);
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Archives))
            {
                writer.WritePropertyName("archives"u8);
                writer.WriteStartArray();
                foreach (var item in Archives)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Configuration))
            {
                writer.WritePropertyName("conf"u8);
                writer.WriteStartObject();
                foreach (var item in Configuration)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(DriverMemory))
            {
                writer.WritePropertyName("driverMemory"u8);
                writer.WriteStringValue(DriverMemory);
            }
            if (Optional.IsDefined(DriverCores))
            {
                writer.WritePropertyName("driverCores"u8);
                writer.WriteNumberValue(DriverCores.Value);
            }
            if (Optional.IsDefined(ExecutorMemory))
            {
                writer.WritePropertyName("executorMemory"u8);
                writer.WriteStringValue(ExecutorMemory);
            }
            if (Optional.IsDefined(ExecutorCores))
            {
                writer.WritePropertyName("executorCores"u8);
                writer.WriteNumberValue(ExecutorCores.Value);
            }
            if (Optional.IsDefined(ExecutorCount))
            {
                writer.WritePropertyName("numExecutors"u8);
                writer.WriteNumberValue(ExecutorCount.Value);
            }
            writer.WriteEndObject();
        }
    }
}
