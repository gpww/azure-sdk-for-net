// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Profile for gallery sharing to subscription or tenant. </summary>
    public partial class SharingProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SharingProfile"/>. </summary>
        public SharingProfile()
        {
            Groups = new ChangeTrackingList<SharingProfileGroup>();
        }

        /// <summary> Initializes a new instance of <see cref="SharingProfile"/>. </summary>
        /// <param name="permission"> This property allows you to specify the permission of sharing gallery. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Private** &lt;br&gt;&lt;br&gt; **Groups** &lt;br&gt;&lt;br&gt; **Community**. </param>
        /// <param name="groups"> A list of sharing profile groups. </param>
        /// <param name="communityGalleryInfo"> Information of community gallery if current gallery is shared to community. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharingProfile(GallerySharingPermissionType? permission, IReadOnlyList<SharingProfileGroup> groups, CommunityGalleryInfo communityGalleryInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Permission = permission;
            Groups = groups;
            CommunityGalleryInfo = communityGalleryInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> This property allows you to specify the permission of sharing gallery. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Private** &lt;br&gt;&lt;br&gt; **Groups** &lt;br&gt;&lt;br&gt; **Community**. </summary>
        public GallerySharingPermissionType? Permission { get; set; }
        /// <summary> A list of sharing profile groups. </summary>
        public IReadOnlyList<SharingProfileGroup> Groups { get; }
        /// <summary> Information of community gallery if current gallery is shared to community. </summary>
        public CommunityGalleryInfo CommunityGalleryInfo { get; set; }
    }
}
