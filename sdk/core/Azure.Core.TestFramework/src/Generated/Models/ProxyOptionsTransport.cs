// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Core.TestFramework.Models
{
    /// <summary> The ProxyOptionsTransport. </summary>
    public partial class ProxyOptionsTransport
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProxyOptionsTransport"/>. </summary>
        public ProxyOptionsTransport()
        {
            Certificates = new ChangeTrackingList<ProxyOptionsTransportCertificatesItem>();
        }

        /// <summary> Initializes a new instance of <see cref="ProxyOptionsTransport"/>. </summary>
        /// <param name="allowAutoRedirect"></param>
        /// <param name="tlsValidationCert"></param>
        /// <param name="certificates"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProxyOptionsTransport(bool? allowAutoRedirect, string tlsValidationCert, IList<ProxyOptionsTransportCertificatesItem> certificates, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowAutoRedirect = allowAutoRedirect;
            TLSValidationCert = tlsValidationCert;
            Certificates = certificates;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the allow auto redirect. </summary>
        public bool? AllowAutoRedirect { get; set; }
        /// <summary> Gets or sets the tls validation cert. </summary>
        public string TLSValidationCert { get; set; }
        /// <summary> Gets the certificates. </summary>
        public IList<ProxyOptionsTransportCertificatesItem> Certificates { get; }
    }
}
