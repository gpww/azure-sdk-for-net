// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Application Gateway protocol. </summary>
    public readonly partial struct ApplicationGatewayProtocol : IEquatable<ApplicationGatewayProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewayProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpValue = "Http";
        private const string HttpsValue = "Https";
        private const string TcpValue = "Tcp";
        private const string TlsValue = "Tls";

        /// <summary> Http. </summary>
        public static ApplicationGatewayProtocol Http { get; } = new ApplicationGatewayProtocol(HttpValue);
        /// <summary> Https. </summary>
        public static ApplicationGatewayProtocol Https { get; } = new ApplicationGatewayProtocol(HttpsValue);
        /// <summary> Tcp. </summary>
        public static ApplicationGatewayProtocol Tcp { get; } = new ApplicationGatewayProtocol(TcpValue);
        /// <summary> Tls. </summary>
        public static ApplicationGatewayProtocol Tls { get; } = new ApplicationGatewayProtocol(TlsValue);
        /// <summary> Determines if two <see cref="ApplicationGatewayProtocol"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewayProtocol left, ApplicationGatewayProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewayProtocol"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewayProtocol left, ApplicationGatewayProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGatewayProtocol"/>. </summary>
        public static implicit operator ApplicationGatewayProtocol(string value) => new ApplicationGatewayProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewayProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewayProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
