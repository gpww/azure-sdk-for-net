// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AutoMLVerticalRegression : IUtf8JsonSerializable, IJsonModel<AutoMLVerticalRegression>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoMLVerticalRegression>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutoMLVerticalRegression>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoMLVerticalRegression>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoMLVerticalRegression)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PrimaryMetric.HasValue)
            {
                writer.WritePropertyName("primaryMetric"u8);
                writer.WriteStringValue(PrimaryMetric.Value.ToString());
            }
            if (TrainingSettings != null)
            {
                if (TrainingSettings != null)
                {
                    writer.WritePropertyName("trainingSettings"u8);
                    writer.WriteObjectValue(TrainingSettings);
                }
                else
                {
                    writer.WriteNull("trainingSettings");
                }
            }
            if (!(CvSplitColumnNames is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                if (CvSplitColumnNames != null)
                {
                    writer.WritePropertyName("cvSplitColumnNames"u8);
                    writer.WriteStartArray();
                    foreach (var item in CvSplitColumnNames)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("cvSplitColumnNames");
                }
            }
            if (FeaturizationSettings != null)
            {
                if (FeaturizationSettings != null)
                {
                    writer.WritePropertyName("featurizationSettings"u8);
                    writer.WriteObjectValue(FeaturizationSettings);
                }
                else
                {
                    writer.WriteNull("featurizationSettings");
                }
            }
            if (FixedParameters != null)
            {
                if (FixedParameters != null)
                {
                    writer.WritePropertyName("fixedParameters"u8);
                    writer.WriteObjectValue(FixedParameters);
                }
                else
                {
                    writer.WriteNull("fixedParameters");
                }
            }
            if (LimitSettings != null)
            {
                if (LimitSettings != null)
                {
                    writer.WritePropertyName("limitSettings"u8);
                    writer.WriteObjectValue(LimitSettings);
                }
                else
                {
                    writer.WriteNull("limitSettings");
                }
            }
            if (NCrossValidations != null)
            {
                if (NCrossValidations != null)
                {
                    writer.WritePropertyName("nCrossValidations"u8);
                    writer.WriteObjectValue(NCrossValidations);
                }
                else
                {
                    writer.WriteNull("nCrossValidations");
                }
            }
            if (!(SearchSpace is ChangeTrackingList<TableParameterSubspace> collection0 && collection0.IsUndefined))
            {
                if (SearchSpace != null)
                {
                    writer.WritePropertyName("searchSpace"u8);
                    writer.WriteStartArray();
                    foreach (var item in SearchSpace)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("searchSpace");
                }
            }
            if (SweepSettings != null)
            {
                if (SweepSettings != null)
                {
                    writer.WritePropertyName("sweepSettings"u8);
                    writer.WriteObjectValue(SweepSettings);
                }
                else
                {
                    writer.WriteNull("sweepSettings");
                }
            }
            if (TestData != null)
            {
                if (TestData != null)
                {
                    writer.WritePropertyName("testData"u8);
                    writer.WriteObjectValue(TestData);
                }
                else
                {
                    writer.WriteNull("testData");
                }
            }
            if (TestDataSize.HasValue)
            {
                if (TestDataSize != null)
                {
                    writer.WritePropertyName("testDataSize"u8);
                    writer.WriteNumberValue(TestDataSize.Value);
                }
                else
                {
                    writer.WriteNull("testDataSize");
                }
            }
            if (ValidationData != null)
            {
                if (ValidationData != null)
                {
                    writer.WritePropertyName("validationData"u8);
                    writer.WriteObjectValue(ValidationData);
                }
                else
                {
                    writer.WriteNull("validationData");
                }
            }
            if (ValidationDataSize.HasValue)
            {
                if (ValidationDataSize != null)
                {
                    writer.WritePropertyName("validationDataSize"u8);
                    writer.WriteNumberValue(ValidationDataSize.Value);
                }
                else
                {
                    writer.WriteNull("validationDataSize");
                }
            }
            if (WeightColumnName != null)
            {
                if (WeightColumnName != null)
                {
                    writer.WritePropertyName("weightColumnName"u8);
                    writer.WriteStringValue(WeightColumnName);
                }
                else
                {
                    writer.WriteNull("weightColumnName");
                }
            }
            if (LogVerbosity.HasValue)
            {
                writer.WritePropertyName("logVerbosity"u8);
                writer.WriteStringValue(LogVerbosity.Value.ToString());
            }
            if (TargetColumnName != null)
            {
                if (TargetColumnName != null)
                {
                    writer.WritePropertyName("targetColumnName"u8);
                    writer.WriteStringValue(TargetColumnName);
                }
                else
                {
                    writer.WriteNull("targetColumnName");
                }
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            writer.WritePropertyName("trainingData"u8);
            writer.WriteObjectValue(TrainingData);
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

        AutoMLVerticalRegression IJsonModel<AutoMLVerticalRegression>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoMLVerticalRegression>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoMLVerticalRegression)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoMLVerticalRegression(document.RootElement, options);
        }

        internal static AutoMLVerticalRegression DeserializeAutoMLVerticalRegression(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AutoMLVerticalRegressionPrimaryMetric? primaryMetric = default;
            RegressionTrainingSettings trainingSettings = default;
            IList<string> cvSplitColumnNames = default;
            TableVerticalFeaturizationSettings featurizationSettings = default;
            TableFixedParameters fixedParameters = default;
            TableVerticalLimitSettings limitSettings = default;
            NCrossValidations nCrossValidations = default;
            IList<TableParameterSubspace> searchSpace = default;
            TableSweepSettings sweepSettings = default;
            MachineLearningTableJobInput testData = default;
            double? testDataSize = default;
            MachineLearningTableJobInput validationData = default;
            double? validationDataSize = default;
            string weightColumnName = default;
            MachineLearningLogVerbosity? logVerbosity = default;
            string targetColumnName = default;
            TaskType taskType = default;
            MachineLearningTableJobInput trainingData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMetric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryMetric = new AutoMLVerticalRegressionPrimaryMetric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trainingSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingSettings = null;
                        continue;
                    }
                    trainingSettings = RegressionTrainingSettings.DeserializeRegressionTrainingSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("cvSplitColumnNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cvSplitColumnNames = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    cvSplitColumnNames = array;
                    continue;
                }
                if (property.NameEquals("featurizationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featurizationSettings = null;
                        continue;
                    }
                    featurizationSettings = TableVerticalFeaturizationSettings.DeserializeTableVerticalFeaturizationSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("fixedParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fixedParameters = null;
                        continue;
                    }
                    fixedParameters = TableFixedParameters.DeserializeTableFixedParameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("limitSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        limitSettings = null;
                        continue;
                    }
                    limitSettings = TableVerticalLimitSettings.DeserializeTableVerticalLimitSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nCrossValidations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nCrossValidations = null;
                        continue;
                    }
                    nCrossValidations = NCrossValidations.DeserializeNCrossValidations(property.Value, options);
                    continue;
                }
                if (property.NameEquals("searchSpace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchSpace = null;
                        continue;
                    }
                    List<TableParameterSubspace> array = new List<TableParameterSubspace>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TableParameterSubspace.DeserializeTableParameterSubspace(item, options));
                    }
                    searchSpace = array;
                    continue;
                }
                if (property.NameEquals("sweepSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sweepSettings = null;
                        continue;
                    }
                    sweepSettings = TableSweepSettings.DeserializeTableSweepSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("testData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        testData = null;
                        continue;
                    }
                    testData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("testDataSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        testDataSize = null;
                        continue;
                    }
                    testDataSize = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("validationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationData = null;
                        continue;
                    }
                    validationData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationDataSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationDataSize = null;
                        continue;
                    }
                    validationDataSize = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("weightColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weightColumnName = null;
                        continue;
                    }
                    weightColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logVerbosity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logVerbosity = new MachineLearningLogVerbosity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetColumnName = null;
                        continue;
                    }
                    targetColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trainingData"u8))
                {
                    trainingData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutoMLVerticalRegression(
                logVerbosity,
                targetColumnName,
                taskType,
                trainingData,
                serializedAdditionalRawData,
                primaryMetric,
                trainingSettings,
                cvSplitColumnNames ?? new ChangeTrackingList<string>(),
                featurizationSettings,
                fixedParameters,
                limitSettings,
                nCrossValidations,
                searchSpace ?? new ChangeTrackingList<TableParameterSubspace>(),
                sweepSettings,
                testData,
                testDataSize,
                validationData,
                validationDataSize,
                weightColumnName);
        }

        BinaryData IPersistableModel<AutoMLVerticalRegression>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoMLVerticalRegression>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoMLVerticalRegression)} does not support '{options.Format}' format.");
            }
        }

        AutoMLVerticalRegression IPersistableModel<AutoMLVerticalRegression>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoMLVerticalRegression>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoMLVerticalRegression(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoMLVerticalRegression)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoMLVerticalRegression>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
