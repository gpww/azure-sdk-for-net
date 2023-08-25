// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the SecurityContact data model.
    /// Contact details and configurations for notifications coming from Microsoft Defender for Cloud.
    /// </summary>
    public partial class SecurityContactData : ResourceData
    {
        /// <summary> Initializes a new instance of SecurityContactData. </summary>
        public SecurityContactData()
        {
        }

        /// <summary> Initializes a new instance of SecurityContactData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="emails"> List of email addresses which will get notifications from Microsoft Defender for Cloud by the configurations defined in this security contact. </param>
        /// <param name="phone"> The security contact's phone number. </param>
        /// <param name="alertNotifications"> Defines whether to send email notifications about new security alerts. </param>
        /// <param name="notificationsByRole"> Defines whether to send email notifications from Microsoft Defender for Cloud to persons with specific RBAC roles on the subscription. </param>
        internal SecurityContactData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string emails, string phone, SecurityContactPropertiesAlertNotifications alertNotifications, SecurityContactPropertiesNotificationsByRole notificationsByRole) : base(id, name, resourceType, systemData)
        {
            Emails = emails;
            Phone = phone;
            AlertNotifications = alertNotifications;
            NotificationsByRole = notificationsByRole;
        }

        /// <summary> List of email addresses which will get notifications from Microsoft Defender for Cloud by the configurations defined in this security contact. </summary>
        public string Emails { get; set; }
        /// <summary> The security contact's phone number. </summary>
        public string Phone { get; set; }
        /// <summary> Defines whether to send email notifications about new security alerts. </summary>
        public SecurityContactPropertiesAlertNotifications AlertNotifications { get; set; }
        /// <summary> Defines whether to send email notifications from Microsoft Defender for Cloud to persons with specific RBAC roles on the subscription. </summary>
        public SecurityContactPropertiesNotificationsByRole NotificationsByRole { get; set; }
    }
}
