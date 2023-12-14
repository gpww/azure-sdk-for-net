// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Returns the requested manifest file. </summary>
    internal partial class ManifestWrapper : Manifest
    {
        /// <summary> Initializes a new instance of <see cref="ManifestWrapper"/>. </summary>
        internal ManifestWrapper()
        {
            Manifests = new ChangeTrackingList<ManifestListAttributes>();
            Layers = new ChangeTrackingList<OciDescriptor>();
            FsLayers = new ChangeTrackingList<FsLayer>();
            History = new ChangeTrackingList<History>();
            Signatures = new ChangeTrackingList<ImageSignature>();
        }

        /// <summary> Initializes a new instance of <see cref="ManifestWrapper"/>. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        /// <param name="mediaType"> Media type for this Manifest. </param>
        /// <param name="manifests"> (ManifestList, OCIIndex) List of V2 image layer information. </param>
        /// <param name="config"> (V2, OCI) Image config descriptor. </param>
        /// <param name="layers"> (V2, OCI) List of V2 image layer information. </param>
        /// <param name="annotations"> (OCI, OCIIndex) Additional metadata. </param>
        /// <param name="architecture"> (V1) CPU architecture. </param>
        /// <param name="name"> (V1) Image name. </param>
        /// <param name="tag"> (V1) Image tag. </param>
        /// <param name="fsLayers"> (V1) List of layer information. </param>
        /// <param name="history"> (V1) Image history. </param>
        /// <param name="signatures"> (V1) Image signature. </param>
        internal ManifestWrapper(int? schemaVersion, string mediaType, IReadOnlyList<ManifestListAttributes> manifests, OciDescriptor config, IReadOnlyList<OciDescriptor> layers, OciAnnotations annotations, string architecture, string name, string tag, IReadOnlyList<FsLayer> fsLayers, IReadOnlyList<History> history, IReadOnlyList<ImageSignature> signatures) : base(schemaVersion)
        {
            MediaType = mediaType;
            Manifests = manifests;
            Config = config;
            Layers = layers;
            Annotations = annotations;
            Architecture = architecture;
            Name = name;
            Tag = tag;
            FsLayers = fsLayers;
            History = history;
            Signatures = signatures;
        }

        /// <summary> Media type for this Manifest. </summary>
        public string MediaType { get; }
        /// <summary> (ManifestList, OCIIndex) List of V2 image layer information. </summary>
        public IReadOnlyList<ManifestListAttributes> Manifests { get; }
        /// <summary> (V2, OCI) Image config descriptor. </summary>
        public OciDescriptor Config { get; }
        /// <summary> (V2, OCI) List of V2 image layer information. </summary>
        public IReadOnlyList<OciDescriptor> Layers { get; }
        /// <summary> (OCI, OCIIndex) Additional metadata. </summary>
        public OciAnnotations Annotations { get; }
        /// <summary> (V1) CPU architecture. </summary>
        public string Architecture { get; }
        /// <summary> (V1) Image name. </summary>
        public string Name { get; }
        /// <summary> (V1) Image tag. </summary>
        public string Tag { get; }
        /// <summary> (V1) List of layer information. </summary>
        public IReadOnlyList<FsLayer> FsLayers { get; }
        /// <summary> (V1) Image history. </summary>
        public IReadOnlyList<History> History { get; }
        /// <summary> (V1) Image signature. </summary>
        public IReadOnlyList<ImageSignature> Signatures { get; }
    }
}
