// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// This is the OS disk image.
    /// </summary>
    public partial class GalleryOSDiskImage : GalleryDiskImage
    {
        /// <summary>
        /// Initializes a new instance of the GalleryOSDiskImage class.
        /// </summary>
        public GalleryOSDiskImage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryOSDiskImage class.
        /// </summary>
        /// <param name="sizeInGB">It indicates the size of the VHD to
        /// create.</param>
        /// <param name="hostCaching">The host caching of the disk. Valid
        /// values are 'None', 'ReadOnly', and 'ReadWrite'. Possible values
        /// include: 'None', 'ReadOnly', 'ReadWrite'</param>
        public GalleryOSDiskImage(int? sizeInGB = default(int?), HostCaching? hostCaching = default(HostCaching?))
            : base(sizeInGB, hostCaching)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}