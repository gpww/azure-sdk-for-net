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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the data disk to be detached.
    /// </summary>
    public partial class DataDisksToDetach
    {
        /// <summary>
        /// Initializes a new instance of the DataDisksToDetach class.
        /// </summary>
        public DataDisksToDetach()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataDisksToDetach class.
        /// </summary>
        /// <param name="diskId">ID of the managed data disk.</param>
        /// <param name="detachOption">Supported options available for Detach
        /// of a disk from a VM. Refer to DetachOption object reference for
        /// more details. Possible values include: 'ForceDetach'</param>
        public DataDisksToDetach(string diskId, string detachOption = default(string))
        {
            DiskId = diskId;
            DetachOption = detachOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of the managed data disk.
        /// </summary>
        [JsonProperty(PropertyName = "diskId")]
        public string DiskId { get; set; }

        /// <summary>
        /// Gets or sets supported options available for Detach of a disk from
        /// a VM. Refer to DetachOption object reference for more details.
        /// Possible values include: 'ForceDetach'
        /// </summary>
        [JsonProperty(PropertyName = "detachOption")]
        public string DetachOption { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DiskId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DiskId");
            }
        }
    }
}
