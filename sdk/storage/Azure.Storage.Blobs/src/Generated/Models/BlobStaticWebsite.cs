// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The properties that enable an account to host a static website. </summary>
    public partial class BlobStaticWebsite
    {
        /// <summary> Initializes a new instance of BlobStaticWebsite. </summary>
        /// <param name="enabled"> Indicates whether this account is hosting a static website. </param>
        /// <param name="indexDocument"> The default name of the index page under each directory. </param>
        /// <param name="errorDocument404Path"> The absolute path of the custom 404 page. </param>
        /// <param name="defaultIndexDocumentPath"> Absolute path of the default index page. </param>
        internal BlobStaticWebsite(bool enabled, string indexDocument, string errorDocument404Path, string defaultIndexDocumentPath)
        {
            Enabled = enabled;
            IndexDocument = indexDocument;
            ErrorDocument404Path = errorDocument404Path;
            DefaultIndexDocumentPath = defaultIndexDocumentPath;
        }

        /// <summary> Indicates whether this account is hosting a static website. </summary>
        public bool Enabled { get; set; }
        /// <summary> The default name of the index page under each directory. </summary>
        public string IndexDocument { get; set; }
        /// <summary> The absolute path of the custom 404 page. </summary>
        public string ErrorDocument404Path { get; set; }
        /// <summary> Absolute path of the default index page. </summary>
        public string DefaultIndexDocumentPath { get; set; }
    }
}
