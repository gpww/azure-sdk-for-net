// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceMovePolicy. </summary>
    public partial class ResourceMovePolicy
    {
        /// <summary> Initializes a new instance of <see cref="ResourceMovePolicy"/>. </summary>
        public ResourceMovePolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceMovePolicy"/>. </summary>
        /// <param name="isValidationRequired"></param>
        /// <param name="isCrossResourceGroupMoveEnabled"></param>
        /// <param name="isCrossSubscriptionMoveEnabled"></param>
        internal ResourceMovePolicy(bool? isValidationRequired, bool? isCrossResourceGroupMoveEnabled, bool? isCrossSubscriptionMoveEnabled)
        {
            IsValidationRequired = isValidationRequired;
            IsCrossResourceGroupMoveEnabled = isCrossResourceGroupMoveEnabled;
            IsCrossSubscriptionMoveEnabled = isCrossSubscriptionMoveEnabled;
        }

        /// <summary> Gets or sets the is validation required. </summary>
        public bool? IsValidationRequired { get; set; }
        /// <summary> Gets or sets the is cross resource group move enabled. </summary>
        public bool? IsCrossResourceGroupMoveEnabled { get; set; }
        /// <summary> Gets or sets the is cross subscription move enabled. </summary>
        public bool? IsCrossSubscriptionMoveEnabled { get; set; }
    }
}
