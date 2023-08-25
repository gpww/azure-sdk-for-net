// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The state of the resource. </summary>
    public readonly partial struct KustoClusterState : IEquatable<KustoClusterState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KustoClusterState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KustoClusterState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UnavailableValue = "Unavailable";
        private const string RunningValue = "Running";
        private const string DeletingValue = "Deleting";
        private const string DeletedValue = "Deleted";
        private const string StoppingValue = "Stopping";
        private const string StoppedValue = "Stopped";
        private const string StartingValue = "Starting";
        private const string UpdatingValue = "Updating";
        private const string MigratedValue = "Migrated";

        /// <summary> Creating. </summary>
        public static KustoClusterState Creating { get; } = new KustoClusterState(CreatingValue);
        /// <summary> Unavailable. </summary>
        public static KustoClusterState Unavailable { get; } = new KustoClusterState(UnavailableValue);
        /// <summary> Running. </summary>
        public static KustoClusterState Running { get; } = new KustoClusterState(RunningValue);
        /// <summary> Deleting. </summary>
        public static KustoClusterState Deleting { get; } = new KustoClusterState(DeletingValue);
        /// <summary> Deleted. </summary>
        public static KustoClusterState Deleted { get; } = new KustoClusterState(DeletedValue);
        /// <summary> Stopping. </summary>
        public static KustoClusterState Stopping { get; } = new KustoClusterState(StoppingValue);
        /// <summary> Stopped. </summary>
        public static KustoClusterState Stopped { get; } = new KustoClusterState(StoppedValue);
        /// <summary> Starting. </summary>
        public static KustoClusterState Starting { get; } = new KustoClusterState(StartingValue);
        /// <summary> Updating. </summary>
        public static KustoClusterState Updating { get; } = new KustoClusterState(UpdatingValue);
        /// <summary> Migrated. </summary>
        public static KustoClusterState Migrated { get; } = new KustoClusterState(MigratedValue);
        /// <summary> Determines if two <see cref="KustoClusterState"/> values are the same. </summary>
        public static bool operator ==(KustoClusterState left, KustoClusterState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KustoClusterState"/> values are not the same. </summary>
        public static bool operator !=(KustoClusterState left, KustoClusterState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KustoClusterState"/>. </summary>
        public static implicit operator KustoClusterState(string value) => new KustoClusterState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KustoClusterState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KustoClusterState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
