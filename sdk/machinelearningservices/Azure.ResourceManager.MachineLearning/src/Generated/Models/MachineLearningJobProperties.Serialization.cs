// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningJobProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningJobProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningJobProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningJobProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ComponentId != null)
            {
                if (ComponentId != null)
                {
                    writer.WritePropertyName("componentId"u8);
                    writer.WriteStringValue(ComponentId);
                }
                else
                {
                    writer.WriteNull("componentId");
                }
            }
            if (ComputeId != null)
            {
                if (ComputeId != null)
                {
                    writer.WritePropertyName("computeId"u8);
                    writer.WriteStringValue(ComputeId);
                }
                else
                {
                    writer.WriteNull("computeId");
                }
            }
            if (DisplayName != null)
            {
                if (DisplayName != null)
                {
                    writer.WritePropertyName("displayName"u8);
                    writer.WriteStringValue(DisplayName);
                }
                else
                {
                    writer.WriteNull("displayName");
                }
            }
            if (ExperimentName != null)
            {
                writer.WritePropertyName("experimentName"u8);
                writer.WriteStringValue(ExperimentName);
            }
            if (Identity != null)
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
            }
            if (IsArchived.HasValue)
            {
                writer.WritePropertyName("isArchived"u8);
                writer.WriteBooleanValue(IsArchived.Value);
            }
            writer.WritePropertyName("jobType"u8);
            writer.WriteStringValue(JobType.ToString());
            if (NotificationSetting != null)
            {
                if (NotificationSetting != null)
                {
                    writer.WritePropertyName("notificationSetting"u8);
                    writer.WriteObjectValue(NotificationSetting);
                }
                else
                {
                    writer.WriteNull("notificationSetting");
                }
            }
            if (!(SecretsConfiguration is ChangeTrackingDictionary<string, SecretConfiguration> collection && collection.IsUndefined))
            {
                if (SecretsConfiguration != null)
                {
                    writer.WritePropertyName("secretsConfiguration"u8);
                    writer.WriteStartObject();
                    foreach (var item in SecretsConfiguration)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("secretsConfiguration");
                }
            }
            if (!(Services is ChangeTrackingDictionary<string, MachineLearningJobService> collection0 && collection0.IsUndefined))
            {
                if (Services != null)
                {
                    writer.WritePropertyName("services"u8);
                    writer.WriteStartObject();
                    foreach (var item in Services)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("services");
                }
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Description != null)
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (!(Properties is ChangeTrackingDictionary<string, string> collection1 && collection1.IsUndefined))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection2 && collection2.IsUndefined))
            {
                if (Tags != null)
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
                else
                {
                    writer.WriteNull("tags");
                }
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
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
            }
            writer.WriteEndObject();
        }

        MachineLearningJobProperties IJsonModel<MachineLearningJobProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningJobProperties(document.RootElement, options);
        }

        internal static MachineLearningJobProperties DeserializeMachineLearningJobProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("jobType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AutoML": return AutoMLJob.DeserializeAutoMLJob(element, options);
                    case "Command": return MachineLearningCommandJob.DeserializeMachineLearningCommandJob(element, options);
                    case "Labeling": return LabelingJobProperties.DeserializeLabelingJobProperties(element, options);
                    case "Pipeline": return MachineLearningPipelineJob.DeserializeMachineLearningPipelineJob(element, options);
                    case "Spark": return SparkJob.DeserializeSparkJob(element, options);
                    case "Sweep": return MachineLearningSweepJob.DeserializeMachineLearningSweepJob(element, options);
                }
            }
            return UnknownJobBase.DeserializeUnknownJobBase(element, options);
        }

        BinaryData IPersistableModel<MachineLearningJobProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobProperties)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningJobProperties IPersistableModel<MachineLearningJobProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningJobProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningJobProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
