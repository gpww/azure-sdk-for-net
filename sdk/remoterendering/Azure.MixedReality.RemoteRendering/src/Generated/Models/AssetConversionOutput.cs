// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> Information about the output of a successful conversion. Only present when the status of the conversion is 'Succeeded'. </summary>
    public partial class AssetConversionOutput
    {
        /// <summary> Initializes a new instance of AssetConversionOutput. </summary>
        internal AssetConversionOutput()
        {
        }

        /// <summary> Initializes a new instance of AssetConversionOutput. </summary>
        /// <param name="outputAssetUri"> URI of the asset generated by the conversion process. </param>
        internal AssetConversionOutput(string outputAssetUri)
        {
            OutputAssetUri = outputAssetUri;
        }
    }
}
