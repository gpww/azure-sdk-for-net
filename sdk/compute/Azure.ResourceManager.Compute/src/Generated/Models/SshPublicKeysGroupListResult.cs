// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The list SSH public keys operation response. </summary>
    internal partial class SshPublicKeysGroupListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SshPublicKeysGroupListResult"/>. </summary>
        /// <param name="value"> The list of SSH public keys. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SshPublicKeysGroupListResult(IEnumerable<SshPublicKeyData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SshPublicKeysGroupListResult"/>. </summary>
        /// <param name="value"> The list of SSH public keys. </param>
        /// <param name="nextLink"> The URI to fetch the next page of SSH public keys. Call ListNext() with this URI to fetch the next page of SSH public keys. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SshPublicKeysGroupListResult(IReadOnlyList<SshPublicKeyData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SshPublicKeysGroupListResult"/> for deserialization. </summary>
        internal SshPublicKeysGroupListResult()
        {
        }

        /// <summary> The list of SSH public keys. </summary>
        public IReadOnlyList<SshPublicKeyData> Value { get; }
        /// <summary> The URI to fetch the next page of SSH public keys. Call ListNext() with this URI to fetch the next page of SSH public keys. </summary>
        public string NextLink { get; }
    }
}
