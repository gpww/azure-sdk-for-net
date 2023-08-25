// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Listener of an application gateway. </summary>
    public partial class ApplicationGatewayListener : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ApplicationGatewayListener. </summary>
        public ApplicationGatewayListener()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayListener. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="frontendIPConfiguration"> Frontend IP configuration resource of an application gateway. </param>
        /// <param name="frontendPort"> Frontend port resource of an application gateway. </param>
        /// <param name="protocol"> Protocol of the listener. </param>
        /// <param name="sslCertificate"> SSL certificate resource of an application gateway. </param>
        /// <param name="sslProfile"> SSL profile resource of the application gateway. </param>
        /// <param name="provisioningState"> The provisioning state of the listener resource. </param>
        internal ApplicationGatewayListener(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, WritableSubResource frontendIPConfiguration, WritableSubResource frontendPort, ApplicationGatewayProtocol? protocol, WritableSubResource sslCertificate, WritableSubResource sslProfile, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            FrontendIPConfiguration = frontendIPConfiguration;
            FrontendPort = frontendPort;
            Protocol = protocol;
            SslCertificate = sslCertificate;
            SslProfile = sslProfile;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Frontend IP configuration resource of an application gateway. </summary>
        internal WritableSubResource FrontendIPConfiguration { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier FrontendIPConfigurationId
        {
            get => FrontendIPConfiguration is null ? default : FrontendIPConfiguration.Id;
            set
            {
                if (FrontendIPConfiguration is null)
                    FrontendIPConfiguration = new WritableSubResource();
                FrontendIPConfiguration.Id = value;
            }
        }

        /// <summary> Frontend port resource of an application gateway. </summary>
        internal WritableSubResource FrontendPort { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier FrontendPortId
        {
            get => FrontendPort is null ? default : FrontendPort.Id;
            set
            {
                if (FrontendPort is null)
                    FrontendPort = new WritableSubResource();
                FrontendPort.Id = value;
            }
        }

        /// <summary> Protocol of the listener. </summary>
        public ApplicationGatewayProtocol? Protocol { get; set; }
        /// <summary> SSL certificate resource of an application gateway. </summary>
        internal WritableSubResource SslCertificate { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SslCertificateId
        {
            get => SslCertificate is null ? default : SslCertificate.Id;
            set
            {
                if (SslCertificate is null)
                    SslCertificate = new WritableSubResource();
                SslCertificate.Id = value;
            }
        }

        /// <summary> SSL profile resource of the application gateway. </summary>
        internal WritableSubResource SslProfile { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SslProfileId
        {
            get => SslProfile is null ? default : SslProfile.Id;
            set
            {
                if (SslProfile is null)
                    SslProfile = new WritableSubResource();
                SslProfile.Id = value;
            }
        }

        /// <summary> The provisioning state of the listener resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
