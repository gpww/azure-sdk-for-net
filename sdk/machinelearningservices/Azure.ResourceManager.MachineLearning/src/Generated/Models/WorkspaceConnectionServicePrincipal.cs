// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The WorkspaceConnectionServicePrincipal. </summary>
    public partial class WorkspaceConnectionServicePrincipal
    {
        /// <summary> Initializes a new instance of <see cref="WorkspaceConnectionServicePrincipal"/>. </summary>
        public WorkspaceConnectionServicePrincipal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceConnectionServicePrincipal"/>. </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="tenantId"></param>
        internal WorkspaceConnectionServicePrincipal(string clientId, string clientSecret, Guid? tenantId)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            TenantId = tenantId;
        }

        /// <summary> Gets or sets the client id. </summary>
        public string ClientId { get; set; }
        /// <summary> Gets or sets the client secret. </summary>
        public string ClientSecret { get; set; }
        /// <summary> Gets or sets the tenant id. </summary>
        public Guid? TenantId { get; set; }
    }
}
