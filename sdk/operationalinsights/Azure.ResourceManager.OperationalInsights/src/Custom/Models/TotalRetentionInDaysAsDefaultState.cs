// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> True - Value originates from retention in days, False - Customer specific. </summary>
    public readonly partial struct TotalRetentionInDaysAsDefaultState : IEquatable<TotalRetentionInDaysAsDefaultState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TotalRetentionInDaysAsDefaultState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TotalRetentionInDaysAsDefaultState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> Value originates from retention in days. </summary>
        public static TotalRetentionInDaysAsDefaultState True { get; } = new TotalRetentionInDaysAsDefaultState(TrueValue);
        /// <summary> Value is customer specific. </summary>
        public static TotalRetentionInDaysAsDefaultState False { get; } = new TotalRetentionInDaysAsDefaultState(FalseValue);
        /// <summary> Determines if two <see cref="TotalRetentionInDaysAsDefaultState"/> values are the same. </summary>
        public static bool operator ==(TotalRetentionInDaysAsDefaultState left, TotalRetentionInDaysAsDefaultState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TotalRetentionInDaysAsDefaultState"/> values are not the same. </summary>
        public static bool operator !=(TotalRetentionInDaysAsDefaultState left, TotalRetentionInDaysAsDefaultState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TotalRetentionInDaysAsDefaultState"/>. </summary>
        public static implicit operator TotalRetentionInDaysAsDefaultState(string value) => new TotalRetentionInDaysAsDefaultState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TotalRetentionInDaysAsDefaultState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TotalRetentionInDaysAsDefaultState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
