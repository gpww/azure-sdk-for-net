// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the gallery Application Definition that you want to update. </summary>
    public partial class GalleryApplicationPatch : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationPatch"/>. </summary>
        public GalleryApplicationPatch()
        {
            CustomActions = new ChangeTrackingList<GalleryApplicationCustomAction>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> The description of this gallery Application Definition resource. This property is updatable. </param>
        /// <param name="eula"> The Eula agreement for the gallery Application Definition. </param>
        /// <param name="privacyStatementUri"> The privacy statement uri. </param>
        /// <param name="releaseNoteUri"> The release note uri. </param>
        /// <param name="endOfLifeOn"> The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="supportedOSType"> This property allows you to specify the supported type of the OS that application is built for. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </param>
        /// <param name="customActions"> A list of custom actions that can be performed with all of the Gallery Application Versions within this Gallery Application. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryApplicationPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string eula, Uri privacyStatementUri, Uri releaseNoteUri, DateTimeOffset? endOfLifeOn, SupportedOperatingSystemType? supportedOSType, IList<GalleryApplicationCustomAction> customActions, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            Eula = eula;
            PrivacyStatementUri = privacyStatementUri;
            ReleaseNoteUri = releaseNoteUri;
            EndOfLifeOn = endOfLifeOn;
            SupportedOSType = supportedOSType;
            CustomActions = customActions;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The description of this gallery Application Definition resource. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> The Eula agreement for the gallery Application Definition. </summary>
        public string Eula { get; set; }
        /// <summary> The privacy statement uri. </summary>
        public Uri PrivacyStatementUri { get; set; }
        /// <summary> The release note uri. </summary>
        public Uri ReleaseNoteUri { get; set; }
        /// <summary> The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeOn { get; set; }
        /// <summary> This property allows you to specify the supported type of the OS that application is built for. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </summary>
        public SupportedOperatingSystemType? SupportedOSType { get; set; }
        /// <summary> A list of custom actions that can be performed with all of the Gallery Application Versions within this Gallery Application. </summary>
        public IList<GalleryApplicationCustomAction> CustomActions { get; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
