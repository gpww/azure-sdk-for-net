// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> A resource Api configuration for the Telephony channel. </summary>
    public partial class TelephonyChannelResourceApiConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="TelephonyChannelResourceApiConfiguration"/>. </summary>
        public TelephonyChannelResourceApiConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TelephonyChannelResourceApiConfiguration"/>. </summary>
        /// <param name="id"> The id of config. </param>
        /// <param name="providerName"> The provider name. </param>
        /// <param name="cognitiveServiceSubscriptionKey"> The cognitive service subscription key. </param>
        /// <param name="cognitiveServiceRegion"> The cognitive service region. </param>
        /// <param name="cognitiveServiceResourceId"> The cognitive service resourceId. </param>
        /// <param name="defaultLocale"> The default locale. </param>
        internal TelephonyChannelResourceApiConfiguration(string id, string providerName, string cognitiveServiceSubscriptionKey, string cognitiveServiceRegion, ResourceIdentifier cognitiveServiceResourceId, string defaultLocale)
        {
            Id = id;
            ProviderName = providerName;
            CognitiveServiceSubscriptionKey = cognitiveServiceSubscriptionKey;
            CognitiveServiceRegion = cognitiveServiceRegion;
            CognitiveServiceResourceId = cognitiveServiceResourceId;
            DefaultLocale = defaultLocale;
        }

        /// <summary> The id of config. </summary>
        public string Id { get; set; }
        /// <summary> The provider name. </summary>
        public string ProviderName { get; set; }
        /// <summary> The cognitive service subscription key. </summary>
        public string CognitiveServiceSubscriptionKey { get; set; }
        /// <summary> The cognitive service region. </summary>
        public string CognitiveServiceRegion { get; set; }
        /// <summary> The cognitive service resourceId. </summary>
        public ResourceIdentifier CognitiveServiceResourceId { get; set; }
        /// <summary> The default locale. </summary>
        public string DefaultLocale { get; set; }
    }
}
