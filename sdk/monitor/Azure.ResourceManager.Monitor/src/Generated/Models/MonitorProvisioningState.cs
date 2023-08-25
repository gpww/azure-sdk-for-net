// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The provisioning state of the Azure Monitor workspace. Set to Succeeded if everything is healthy. </summary>
    public readonly partial struct MonitorProvisioningState : IEquatable<MonitorProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitorProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitorProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string SucceededValue = "Succeeded";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Creating. </summary>
        public static MonitorProvisioningState Creating { get; } = new MonitorProvisioningState(CreatingValue);
        /// <summary> Succeeded. </summary>
        public static MonitorProvisioningState Succeeded { get; } = new MonitorProvisioningState(SucceededValue);
        /// <summary> Deleting. </summary>
        public static MonitorProvisioningState Deleting { get; } = new MonitorProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static MonitorProvisioningState Failed { get; } = new MonitorProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static MonitorProvisioningState Canceled { get; } = new MonitorProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="MonitorProvisioningState"/> values are the same. </summary>
        public static bool operator ==(MonitorProvisioningState left, MonitorProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitorProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(MonitorProvisioningState left, MonitorProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonitorProvisioningState"/>. </summary>
        public static implicit operator MonitorProvisioningState(string value) => new MonitorProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitorProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitorProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
