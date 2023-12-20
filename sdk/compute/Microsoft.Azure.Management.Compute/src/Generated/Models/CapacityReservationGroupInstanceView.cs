// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CapacityReservationGroupInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CapacityReservationGroupInstanceView class.
        /// </summary>
        public CapacityReservationGroupInstanceView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CapacityReservationGroupInstanceView class.
        /// </summary>
        /// <param name="capacityReservations">List of instance view of the
        /// capacity reservations under the capacity reservation group.</param>
        /// <param name="sharedSubscriptionIds">List of the subscriptions that
        /// the capacity reservation group is shared with. **Note:** Minimum
        /// api-version: 2023-09-01. Please refer to
        /// https://aka.ms/computereservationsharing for more details.</param>
        public CapacityReservationGroupInstanceView(IList<CapacityReservationInstanceViewWithName> capacityReservations = default(IList<CapacityReservationInstanceViewWithName>), IList<SubResourceReadOnly> sharedSubscriptionIds = default(IList<SubResourceReadOnly>))
        {
            CapacityReservations = capacityReservations;
            SharedSubscriptionIds = sharedSubscriptionIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of instance view of the capacity reservations under the
        /// capacity reservation group.
        /// </summary>
        [JsonProperty(PropertyName = "capacityReservations")]
        public IList<CapacityReservationInstanceViewWithName> CapacityReservations { get; private set; }

        /// <summary>
        /// Gets list of the subscriptions that the capacity reservation group
        /// is shared with. **Note:** Minimum api-version: 2023-09-01. Please
        /// refer to https://aka.ms/computereservationsharing for more details.
        /// </summary>
        [JsonProperty(PropertyName = "sharedSubscriptionIds")]
        public IList<SubResourceReadOnly> SharedSubscriptionIds { get; private set; }

    }
}
