// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The TmpfsOptions. </summary>
    internal partial class TmpfsOptions
    {
        /// <summary> Initializes a new instance of <see cref="TmpfsOptions"/>. </summary>
        public TmpfsOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TmpfsOptions"/>. </summary>
        /// <param name="size"> Mention the Tmpfs size. </param>
        internal TmpfsOptions(int? size)
        {
            Size = size;
        }

        /// <summary> Mention the Tmpfs size. </summary>
        public int? Size { get; set; }
    }
}
