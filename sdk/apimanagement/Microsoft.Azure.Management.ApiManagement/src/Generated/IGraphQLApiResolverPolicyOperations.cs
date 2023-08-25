// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// GraphQLApiResolverPolicyOperations operations.
    /// </summary>
    public partial interface IGraphQLApiResolverPolicyOperations
    {
        /// <summary>
        /// Get the list of policy configuration at the GraphQL API Resolver
        /// level.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API revision identifier. Must be unique in the current API
        /// Management service instance. Non-current revision has ;rev=n as a
        /// suffix where n is the revision number.
        /// </param>
        /// <param name='resolverId'>
        /// Resolver identifier within a GraphQL API. Must be unique in the
        /// current API Management service instance.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyContract>>> ListByResolverWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string resolverId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the entity state (Etag) version of the GraphQL API resolver
        /// policy specified by its identifier.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API revision identifier. Must be unique in the current API
        /// Management service instance. Non-current revision has ;rev=n as a
        /// suffix where n is the revision number.
        /// </param>
        /// <param name='resolverId'>
        /// Resolver identifier within a GraphQL API. Must be unique in the
        /// current API Management service instance.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<GraphQLApiResolverPolicyGetEntityTagHeaders>> GetEntityTagWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string resolverId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the policy configuration at the GraphQL API Resolver level.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API revision identifier. Must be unique in the current API
        /// Management service instance. Non-current revision has ;rev=n as a
        /// suffix where n is the revision number.
        /// </param>
        /// <param name='resolverId'>
        /// Resolver identifier within a GraphQL API. Must be unique in the
        /// current API Management service instance.
        /// </param>
        /// <param name='format'>
        /// Policy Export Format. Possible values include: 'xml', 'rawxml'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PolicyContract,GraphQLApiResolverPolicyGetHeaders>> GetWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string resolverId, string format = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates policy configuration for the GraphQL API
        /// Resolver level.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API revision identifier. Must be unique in the current API
        /// Management service instance. Non-current revision has ;rev=n as a
        /// suffix where n is the revision number.
        /// </param>
        /// <param name='resolverId'>
        /// Resolver identifier within a GraphQL API. Must be unique in the
        /// current API Management service instance.
        /// </param>
        /// <param name='parameters'>
        /// The policy contents to apply.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. Not required when creating an entity, but
        /// required when updating an entity.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PolicyContract,GraphQLApiResolverPolicyCreateOrUpdateHeaders>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string resolverId, PolicyContract parameters, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the policy configuration at the GraphQL Api Resolver.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API revision identifier. Must be unique in the current API
        /// Management service instance. Non-current revision has ;rev=n as a
        /// suffix where n is the revision number.
        /// </param>
        /// <param name='resolverId'>
        /// Resolver identifier within a GraphQL API. Must be unique in the
        /// current API Management service instance.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. ETag should match the current entity state from
        /// the header response of the GET request or it should be * for
        /// unconditional update.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string resolverId, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the list of policy configuration at the GraphQL API Resolver
        /// level.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyContract>>> ListByResolverNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
