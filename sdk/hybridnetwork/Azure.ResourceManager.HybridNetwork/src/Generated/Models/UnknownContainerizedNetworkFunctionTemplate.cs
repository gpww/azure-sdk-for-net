// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The UnknownContainerizedNetworkFunctionTemplate. </summary>
    internal partial class UnknownContainerizedNetworkFunctionTemplate : ContainerizedNetworkFunctionTemplate
    {
        /// <summary> Initializes a new instance of <see cref="UnknownContainerizedNetworkFunctionTemplate"/>. </summary>
        /// <param name="nfviType"> The network function type. </param>
        internal UnknownContainerizedNetworkFunctionTemplate(ContainerizedNetworkFunctionNfviType nfviType) : base(nfviType)
        {
            NfviType = nfviType;
        }
    }
}
