// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The notification associated with a budget. </summary>
    public partial class BudgetAssociatedNotification
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

        /// <summary> Initializes a new instance of <see cref="BudgetAssociatedNotification"/>. </summary>
        /// <param name="isEnabled"> The notification is enabled or not. </param>
        /// <param name="operator"> The comparison operator. </param>
        /// <param name="threshold"> Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000. </param>
        /// <param name="contactEmails"> Email addresses to send the budget notification to when the threshold is exceeded. Must have at least one contact email or contact group specified at the Subscription or Resource Group scopes. All other scopes must have at least one contact email specified. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contactEmails"/> is null. </exception>
        public BudgetAssociatedNotification(bool isEnabled, NotificationAlertTriggerType @operator, decimal threshold, IEnumerable<string> contactEmails)
        {
            if (contactEmails == null)
            {
                throw new ArgumentNullException(nameof(contactEmails));
            }

            IsEnabled = isEnabled;
            Operator = @operator;
            Threshold = threshold;
            ContactEmails = contactEmails.ToList();
            ContactRoles = new ChangeTrackingList<string>();
            ContactGroups = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BudgetAssociatedNotification"/>. </summary>
        /// <param name="isEnabled"> The notification is enabled or not. </param>
        /// <param name="operator"> The comparison operator. </param>
        /// <param name="threshold"> Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000. </param>
        /// <param name="contactEmails"> Email addresses to send the budget notification to when the threshold is exceeded. Must have at least one contact email or contact group specified at the Subscription or Resource Group scopes. All other scopes must have at least one contact email specified. </param>
        /// <param name="contactRoles"> Contact roles to send the budget notification to when the threshold is exceeded. </param>
        /// <param name="contactGroups"> Action groups to send the budget notification to when the threshold is exceeded. Must be provided as a fully qualified Azure resource id. Only supported at Subscription or Resource Group scopes. </param>
        /// <param name="thresholdType"> The type of threshold. </param>
        /// <param name="locale"> Language in which the recipient will receive the notification. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BudgetAssociatedNotification(bool isEnabled, NotificationAlertTriggerType @operator, decimal threshold, IList<string> contactEmails, IList<string> contactRoles, IList<string> contactGroups, NotificationThresholdType? thresholdType, RecipientNotificationLanguageCode? locale, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Operator = @operator;
            Threshold = threshold;
            ContactEmails = contactEmails;
            ContactRoles = contactRoles;
            ContactGroups = contactGroups;
            ThresholdType = thresholdType;
            Locale = locale;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BudgetAssociatedNotification"/> for deserialization. </summary>
        internal BudgetAssociatedNotification()
        {
        }

        /// <summary> The notification is enabled or not. </summary>
        public bool IsEnabled { get; set; }
        /// <summary> The comparison operator. </summary>
        public NotificationAlertTriggerType Operator { get; set; }
        /// <summary> Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000. </summary>
        public decimal Threshold { get; set; }
        /// <summary> Email addresses to send the budget notification to when the threshold is exceeded. Must have at least one contact email or contact group specified at the Subscription or Resource Group scopes. All other scopes must have at least one contact email specified. </summary>
        public IList<string> ContactEmails { get; }
        /// <summary> Contact roles to send the budget notification to when the threshold is exceeded. </summary>
        public IList<string> ContactRoles { get; }
        /// <summary> Action groups to send the budget notification to when the threshold is exceeded. Must be provided as a fully qualified Azure resource id. Only supported at Subscription or Resource Group scopes. </summary>
        public IList<string> ContactGroups { get; }
        /// <summary> The type of threshold. </summary>
        public NotificationThresholdType? ThresholdType { get; set; }
        /// <summary> Language in which the recipient will receive the notification. </summary>
        public RecipientNotificationLanguageCode? Locale { get; set; }
    }
}
