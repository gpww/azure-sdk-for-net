// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.BillingBenefits;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    public partial class SavingsPlanOrderPaymentDetail : IUtf8JsonSerializable, IJsonModel<SavingsPlanOrderPaymentDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SavingsPlanOrderPaymentDetail>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SavingsPlanOrderPaymentDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanOrderPaymentDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanOrderPaymentDetail)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DueOn))
            {
                writer.WritePropertyName("dueDate"u8);
                writer.WriteStringValue(DueOn.Value, "D");
            }
            if (Optional.IsDefined(PayOn))
            {
                writer.WritePropertyName("paymentDate"u8);
                writer.WriteStringValue(PayOn.Value, "D");
            }
            if (Optional.IsDefined(PricingCurrencyTotal))
            {
                writer.WritePropertyName("pricingCurrencyTotal"u8);
                writer.WriteObjectValue(PricingCurrencyTotal);
            }
            if (Optional.IsDefined(BillingCurrencyTotal))
            {
                writer.WritePropertyName("billingCurrencyTotal"u8);
                writer.WriteObjectValue(BillingCurrencyTotal);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ExtendedStatusInfo))
            {
                writer.WritePropertyName("extendedStatusInfo"u8);
                writer.WriteObjectValue(ExtendedStatusInfo);
            }
            if (Optional.IsDefined(BillingAccount))
            {
                writer.WritePropertyName("billingAccount"u8);
                writer.WriteStringValue(BillingAccount);
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

        SavingsPlanOrderPaymentDetail IJsonModel<SavingsPlanOrderPaymentDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanOrderPaymentDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanOrderPaymentDetail)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSavingsPlanOrderPaymentDetail(document.RootElement, options);
        }

        internal static SavingsPlanOrderPaymentDetail DeserializeSavingsPlanOrderPaymentDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? dueDate = default;
            DateTimeOffset? paymentDate = default;
            BillingBenefitsPrice pricingCurrencyTotal = default;
            BillingBenefitsPrice billingCurrencyTotal = default;
            BillingBenefitsPaymentStatus? status = default;
            BillingBenefitsExtendedStatusInfo extendedStatusInfo = default;
            string billingAccount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dueDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dueDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("paymentDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    paymentDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("pricingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pricingCurrencyTotal = BillingBenefitsPrice.DeserializeBillingBenefitsPrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("billingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyTotal = BillingBenefitsPrice.DeserializeBillingBenefitsPrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new BillingBenefitsPaymentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("extendedStatusInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedStatusInfo = BillingBenefitsExtendedStatusInfo.DeserializeBillingBenefitsExtendedStatusInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("billingAccount"u8))
                {
                    billingAccount = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SavingsPlanOrderPaymentDetail(
                dueDate,
                paymentDate,
                pricingCurrencyTotal,
                billingCurrencyTotal,
                status,
                extendedStatusInfo,
                billingAccount,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SavingsPlanOrderPaymentDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanOrderPaymentDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanOrderPaymentDetail)} does not support '{options.Format}' format.");
            }
        }

        SavingsPlanOrderPaymentDetail IPersistableModel<SavingsPlanOrderPaymentDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanOrderPaymentDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSavingsPlanOrderPaymentDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanOrderPaymentDetail)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SavingsPlanOrderPaymentDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
