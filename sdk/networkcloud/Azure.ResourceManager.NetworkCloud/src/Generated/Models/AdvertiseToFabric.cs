// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The indicator of if this advertisement is also made to the network fabric associated with the Network Cloud Cluster. This field is ignored if fabricPeeringEnabled is set to False. </summary>
    public readonly partial struct AdvertiseToFabric : IEquatable<AdvertiseToFabric>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AdvertiseToFabric"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AdvertiseToFabric(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static AdvertiseToFabric True { get; } = new AdvertiseToFabric(TrueValue);
        /// <summary> False. </summary>
        public static AdvertiseToFabric False { get; } = new AdvertiseToFabric(FalseValue);
        /// <summary> Determines if two <see cref="AdvertiseToFabric"/> values are the same. </summary>
        public static bool operator ==(AdvertiseToFabric left, AdvertiseToFabric right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AdvertiseToFabric"/> values are not the same. </summary>
        public static bool operator !=(AdvertiseToFabric left, AdvertiseToFabric right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AdvertiseToFabric"/>. </summary>
        public static implicit operator AdvertiseToFabric(string value) => new AdvertiseToFabric(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AdvertiseToFabric other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AdvertiseToFabric other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
