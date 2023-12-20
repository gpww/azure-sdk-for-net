// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GalleryImageVersionsOperations.
    /// </summary>
    public static partial class GalleryImageVersionsOperationsExtensions
    {
            /// <summary>
            /// Create or update a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version is to
            /// be created.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be created. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryImageVersion'>
            /// Parameters supplied to the create or update gallery image version
            /// operation.
            /// </param>
            public static GalleryImageVersion CreateOrUpdate(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersion galleryImageVersion)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version is to
            /// be created.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be created. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryImageVersion'>
            /// Parameters supplied to the create or update gallery image version
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryImageVersion> CreateOrUpdateAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersion galleryImageVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version is to
            /// be updated.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be updated. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryImageVersion'>
            /// Parameters supplied to the update gallery image version operation.
            /// </param>
            public static GalleryImageVersion Update(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersionUpdate galleryImageVersion)
            {
                return operations.UpdateAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version is to
            /// be updated.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be updated. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryImageVersion'>
            /// Parameters supplied to the update gallery image version operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryImageVersion> UpdateAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersionUpdate galleryImageVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves information about a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version
            /// resides.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be retrieved.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. Possible values include:
            /// 'ReplicationStatus', 'UefiSettings'
            /// </param>
            public static GalleryImageVersion Get(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves information about a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version
            /// resides.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be retrieved.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. Possible values include:
            /// 'ReplicationStatus', 'UefiSettings'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryImageVersion> GetAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version
            /// resides.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be deleted.
            /// </param>
            public static void Delete(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName)
            {
                operations.DeleteAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version
            /// resides.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List gallery image versions in a gallery image definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the Shared Image Gallery Image Definition from which the Image
            /// Versions are to be listed.
            /// </param>
            public static IPage<GalleryImageVersion> ListByGalleryImage(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName)
            {
                return operations.ListByGalleryImageAsync(resourceGroupName, galleryName, galleryImageName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List gallery image versions in a gallery image definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the Shared Image Gallery Image Definition from which the Image
            /// Versions are to be listed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GalleryImageVersion>> ListByGalleryImageAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByGalleryImageWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version is to
            /// be created.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be created. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryImageVersion'>
            /// Parameters supplied to the create or update gallery image version
            /// operation.
            /// </param>
            public static GalleryImageVersion BeginCreateOrUpdate(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersion galleryImageVersion)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version is to
            /// be created.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be created. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryImageVersion'>
            /// Parameters supplied to the create or update gallery image version
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryImageVersion> BeginCreateOrUpdateAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersion galleryImageVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version is to
            /// be updated.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be updated. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryImageVersion'>
            /// Parameters supplied to the update gallery image version operation.
            /// </param>
            public static GalleryImageVersion BeginUpdate(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersionUpdate galleryImageVersion)
            {
                return operations.BeginUpdateAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version is to
            /// be updated.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be updated. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryImageVersion'>
            /// Parameters supplied to the update gallery image version operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryImageVersion> BeginUpdateAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersionUpdate galleryImageVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version
            /// resides.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be deleted.
            /// </param>
            public static void BeginDelete(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery image definition in which the Image Version
            /// resides.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery image version to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List gallery image versions in a gallery image definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<GalleryImageVersion> ListByGalleryImageNext(this IGalleryImageVersionsOperations operations, string nextPageLink)
            {
                return operations.ListByGalleryImageNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List gallery image versions in a gallery image definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GalleryImageVersion>> ListByGalleryImageNextAsync(this IGalleryImageVersionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByGalleryImageNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
