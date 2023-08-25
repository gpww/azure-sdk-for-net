// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The operator to be matched. </summary>
    public readonly partial struct WebApplicationFirewallOperator : IEquatable<WebApplicationFirewallOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebApplicationFirewallOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IPMatchValue = "IPMatch";
        private const string EqualValue = "Equal";
        private const string ContainsValue = "Contains";
        private const string LessThanValue = "LessThan";
        private const string GreaterThanValue = "GreaterThan";
        private const string LessThanOrEqualValue = "LessThanOrEqual";
        private const string GreaterThanOrEqualValue = "GreaterThanOrEqual";
        private const string BeginsWithValue = "BeginsWith";
        private const string EndsWithValue = "EndsWith";
        private const string RegexValue = "Regex";
        private const string GeoMatchValue = "GeoMatch";
        private const string AnyValue = "Any";

        /// <summary> IPMatch. </summary>
        public static WebApplicationFirewallOperator IPMatch { get; } = new WebApplicationFirewallOperator(IPMatchValue);
        /// <summary> Equal. </summary>
        public static WebApplicationFirewallOperator Equal { get; } = new WebApplicationFirewallOperator(EqualValue);
        /// <summary> Contains. </summary>
        public static WebApplicationFirewallOperator Contains { get; } = new WebApplicationFirewallOperator(ContainsValue);
        /// <summary> LessThan. </summary>
        public static WebApplicationFirewallOperator LessThan { get; } = new WebApplicationFirewallOperator(LessThanValue);
        /// <summary> GreaterThan. </summary>
        public static WebApplicationFirewallOperator GreaterThan { get; } = new WebApplicationFirewallOperator(GreaterThanValue);
        /// <summary> LessThanOrEqual. </summary>
        public static WebApplicationFirewallOperator LessThanOrEqual { get; } = new WebApplicationFirewallOperator(LessThanOrEqualValue);
        /// <summary> GreaterThanOrEqual. </summary>
        public static WebApplicationFirewallOperator GreaterThanOrEqual { get; } = new WebApplicationFirewallOperator(GreaterThanOrEqualValue);
        /// <summary> BeginsWith. </summary>
        public static WebApplicationFirewallOperator BeginsWith { get; } = new WebApplicationFirewallOperator(BeginsWithValue);
        /// <summary> EndsWith. </summary>
        public static WebApplicationFirewallOperator EndsWith { get; } = new WebApplicationFirewallOperator(EndsWithValue);
        /// <summary> Regex. </summary>
        public static WebApplicationFirewallOperator Regex { get; } = new WebApplicationFirewallOperator(RegexValue);
        /// <summary> GeoMatch. </summary>
        public static WebApplicationFirewallOperator GeoMatch { get; } = new WebApplicationFirewallOperator(GeoMatchValue);
        /// <summary> Any. </summary>
        public static WebApplicationFirewallOperator Any { get; } = new WebApplicationFirewallOperator(AnyValue);
        /// <summary> Determines if two <see cref="WebApplicationFirewallOperator"/> values are the same. </summary>
        public static bool operator ==(WebApplicationFirewallOperator left, WebApplicationFirewallOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebApplicationFirewallOperator"/> values are not the same. </summary>
        public static bool operator !=(WebApplicationFirewallOperator left, WebApplicationFirewallOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WebApplicationFirewallOperator"/>. </summary>
        public static implicit operator WebApplicationFirewallOperator(string value) => new WebApplicationFirewallOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebApplicationFirewallOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebApplicationFirewallOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
