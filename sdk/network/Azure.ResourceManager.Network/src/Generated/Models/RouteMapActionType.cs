// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Kind of actions which can be taken on a matched route. Add, Replace, Remove refer to parameters on the route, like community or prefix. </summary>
    public readonly partial struct RouteMapActionType : IEquatable<RouteMapActionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RouteMapActionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RouteMapActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string RemoveValue = "Remove";
        private const string AddValue = "Add";
        private const string ReplaceValue = "Replace";
        private const string DropValue = "Drop";

        /// <summary> Unknown. </summary>
        public static RouteMapActionType Unknown { get; } = new RouteMapActionType(UnknownValue);
        /// <summary> Remove. </summary>
        public static RouteMapActionType Remove { get; } = new RouteMapActionType(RemoveValue);
        /// <summary> Add. </summary>
        public static RouteMapActionType Add { get; } = new RouteMapActionType(AddValue);
        /// <summary> Replace. </summary>
        public static RouteMapActionType Replace { get; } = new RouteMapActionType(ReplaceValue);
        /// <summary> Drop. </summary>
        public static RouteMapActionType Drop { get; } = new RouteMapActionType(DropValue);
        /// <summary> Determines if two <see cref="RouteMapActionType"/> values are the same. </summary>
        public static bool operator ==(RouteMapActionType left, RouteMapActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RouteMapActionType"/> values are not the same. </summary>
        public static bool operator !=(RouteMapActionType left, RouteMapActionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RouteMapActionType"/>. </summary>
        public static implicit operator RouteMapActionType(string value) => new RouteMapActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RouteMapActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RouteMapActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
