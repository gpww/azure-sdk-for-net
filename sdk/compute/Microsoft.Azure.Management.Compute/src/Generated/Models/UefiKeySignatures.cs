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

    /// <summary>
    /// Additional UEFI key signatures that will be added to the image in
    /// addition to the signature templates
    /// </summary>
    public partial class UefiKeySignatures
    {
        /// <summary>
        /// Initializes a new instance of the UefiKeySignatures class.
        /// </summary>
        public UefiKeySignatures()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UefiKeySignatures class.
        /// </summary>
        /// <param name="pk">The Platform Key of this image version.</param>
        /// <param name="kek">The Key Encryption Keys of this image
        /// version.</param>
        /// <param name="db">The database of UEFI keys for this image
        /// version.</param>
        /// <param name="dbx">The database of revoked UEFI keys for this image
        /// version.</param>
        public UefiKeySignatures(UefiKey pk = default(UefiKey), IList<UefiKey> kek = default(IList<UefiKey>), IList<UefiKey> db = default(IList<UefiKey>), IList<UefiKey> dbx = default(IList<UefiKey>))
        {
            Pk = pk;
            Kek = kek;
            Db = db;
            Dbx = dbx;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Platform Key of this image version.
        /// </summary>
        [JsonProperty(PropertyName = "pk")]
        public UefiKey Pk { get; set; }

        /// <summary>
        /// Gets or sets the Key Encryption Keys of this image version.
        /// </summary>
        [JsonProperty(PropertyName = "kek")]
        public IList<UefiKey> Kek { get; set; }

        /// <summary>
        /// Gets or sets the database of UEFI keys for this image version.
        /// </summary>
        [JsonProperty(PropertyName = "db")]
        public IList<UefiKey> Db { get; set; }

        /// <summary>
        /// Gets or sets the database of revoked UEFI keys for this image
        /// version.
        /// </summary>
        [JsonProperty(PropertyName = "dbx")]
        public IList<UefiKey> Dbx { get; set; }

    }
}
