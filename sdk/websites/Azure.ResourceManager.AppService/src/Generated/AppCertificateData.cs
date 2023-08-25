// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the AppCertificate data model.
    /// SSL certificate for an app.
    /// </summary>
    public partial class AppCertificateData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of AppCertificateData. </summary>
        /// <param name="location"> The location. </param>
        public AppCertificateData(AzureLocation location) : base(location)
        {
            HostNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AppCertificateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="password"> Certificate password. </param>
        /// <param name="friendlyName"> Friendly name of the certificate. </param>
        /// <param name="subjectName"> Subject name of the certificate. </param>
        /// <param name="hostNames"> Host names the certificate applies to. </param>
        /// <param name="pfxBlob"> Pfx blob. </param>
        /// <param name="siteName"> App name. </param>
        /// <param name="selfLink"> Self link. </param>
        /// <param name="issuer"> Certificate issuer. </param>
        /// <param name="issueOn"> Certificate issue Date. </param>
        /// <param name="expireOn"> Certificate expiration date. </param>
        /// <param name="thumbprintString"> Certificate thumbprint. </param>
        /// <param name="isValid"> Is the certificate valid?. </param>
        /// <param name="cerBlob"> Raw bytes of .cer file. </param>
        /// <param name="publicKeyHash"> Public key hash. </param>
        /// <param name="hostingEnvironmentProfile"> Specification for the App Service Environment to use for the certificate. </param>
        /// <param name="keyVaultId"> Key Vault Csm resource Id. </param>
        /// <param name="keyVaultSecretName"> Key Vault secret name. </param>
        /// <param name="keyVaultSecretStatus"> Status of the Key Vault secret. </param>
        /// <param name="serverFarmId"> Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}". </param>
        /// <param name="canonicalName"> CNAME of the certificate to be issued via free certificate. </param>
        /// <param name="domainValidationMethod"> Method of domain validation for free cert. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal AppCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string password, string friendlyName, string subjectName, IList<string> hostNames, byte[] pfxBlob, string siteName, string selfLink, string issuer, DateTimeOffset? issueOn, DateTimeOffset? expireOn, string thumbprintString, bool? isValid, byte[] cerBlob, string publicKeyHash, HostingEnvironmentProfile hostingEnvironmentProfile, ResourceIdentifier keyVaultId, string keyVaultSecretName, KeyVaultSecretStatus? keyVaultSecretStatus, ResourceIdentifier serverFarmId, string canonicalName, string domainValidationMethod, string kind) : base(id, name, resourceType, systemData, tags, location)
        {
            Password = password;
            FriendlyName = friendlyName;
            SubjectName = subjectName;
            HostNames = hostNames;
            PfxBlob = pfxBlob;
            SiteName = siteName;
            SelfLink = selfLink;
            Issuer = issuer;
            IssueOn = issueOn;
            ExpireOn = expireOn;
            ThumbprintString = thumbprintString;
            IsValid = isValid;
            CerBlob = cerBlob;
            PublicKeyHash = publicKeyHash;
            HostingEnvironmentProfile = hostingEnvironmentProfile;
            KeyVaultId = keyVaultId;
            KeyVaultSecretName = keyVaultSecretName;
            KeyVaultSecretStatus = keyVaultSecretStatus;
            ServerFarmId = serverFarmId;
            CanonicalName = canonicalName;
            DomainValidationMethod = domainValidationMethod;
            Kind = kind;
        }

        /// <summary> Certificate password. </summary>
        public string Password { get; set; }
        /// <summary> Friendly name of the certificate. </summary>
        public string FriendlyName { get; }
        /// <summary> Subject name of the certificate. </summary>
        public string SubjectName { get; }
        /// <summary> Host names the certificate applies to. </summary>
        public IList<string> HostNames { get; }
        /// <summary> Pfx blob. </summary>
        public byte[] PfxBlob { get; set; }
        /// <summary> App name. </summary>
        public string SiteName { get; }
        /// <summary> Self link. </summary>
        public string SelfLink { get; }
        /// <summary> Certificate issuer. </summary>
        public string Issuer { get; }
        /// <summary> Certificate issue Date. </summary>
        public DateTimeOffset? IssueOn { get; }
        /// <summary> Certificate expiration date. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> Certificate thumbprint. </summary>
        public string ThumbprintString { get; }
        /// <summary> Is the certificate valid?. </summary>
        public bool? IsValid { get; }
        /// <summary> Raw bytes of .cer file. </summary>
        public byte[] CerBlob { get; }
        /// <summary> Public key hash. </summary>
        public string PublicKeyHash { get; }
        /// <summary> Specification for the App Service Environment to use for the certificate. </summary>
        public HostingEnvironmentProfile HostingEnvironmentProfile { get; }
        /// <summary> Key Vault Csm resource Id. </summary>
        public ResourceIdentifier KeyVaultId { get; set; }
        /// <summary> Key Vault secret name. </summary>
        public string KeyVaultSecretName { get; set; }
        /// <summary> Status of the Key Vault secret. </summary>
        public KeyVaultSecretStatus? KeyVaultSecretStatus { get; }
        /// <summary> Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}". </summary>
        public ResourceIdentifier ServerFarmId { get; set; }
        /// <summary> CNAME of the certificate to be issued via free certificate. </summary>
        public string CanonicalName { get; set; }
        /// <summary> Method of domain validation for free cert. </summary>
        public string DomainValidationMethod { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
