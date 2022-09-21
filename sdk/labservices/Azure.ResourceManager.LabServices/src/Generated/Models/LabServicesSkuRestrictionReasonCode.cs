// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The reason for the restriction. </summary>
    public readonly partial struct LabServicesSkuRestrictionReasonCode : IEquatable<LabServicesSkuRestrictionReasonCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LabServicesSkuRestrictionReasonCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LabServicesSkuRestrictionReasonCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QuotaIdValue = "QuotaId";
        private const string NotAvailableForSubscriptionValue = "NotAvailableForSubscription";

        /// <summary> QuotaId. </summary>
        public static LabServicesSkuRestrictionReasonCode QuotaId { get; } = new LabServicesSkuRestrictionReasonCode(QuotaIdValue);
        /// <summary> NotAvailableForSubscription. </summary>
        public static LabServicesSkuRestrictionReasonCode NotAvailableForSubscription { get; } = new LabServicesSkuRestrictionReasonCode(NotAvailableForSubscriptionValue);
        /// <summary> Determines if two <see cref="LabServicesSkuRestrictionReasonCode"/> values are the same. </summary>
        public static bool operator ==(LabServicesSkuRestrictionReasonCode left, LabServicesSkuRestrictionReasonCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LabServicesSkuRestrictionReasonCode"/> values are not the same. </summary>
        public static bool operator !=(LabServicesSkuRestrictionReasonCode left, LabServicesSkuRestrictionReasonCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LabServicesSkuRestrictionReasonCode"/>. </summary>
        public static implicit operator LabServicesSkuRestrictionReasonCode(string value) => new LabServicesSkuRestrictionReasonCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LabServicesSkuRestrictionReasonCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LabServicesSkuRestrictionReasonCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
