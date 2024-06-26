// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SystemTopicEventSubscriptionsOperations.
    /// </summary>
    public static partial class SystemTopicEventSubscriptionsOperationsExtensions
    {
            /// <summary>
            /// Get an event subscription of a system topic.
            /// </summary>
            /// <remarks>
            /// Get an event subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            public static EventSubscription Get(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName)
            {
                return operations.GetAsync(resourceGroupName, systemTopicName, eventSubscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an event subscription of a system topic.
            /// </summary>
            /// <remarks>
            /// Get an event subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventSubscription> GetAsync(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, systemTopicName, eventSubscriptionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update an event subscription for a system topic.
            /// </summary>
            /// <remarks>
            /// Asynchronously creates or updates an event subscription with the specified
            /// parameters. Existing event subscriptions will be updated with this API.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionInfo'>
            /// Event subscription properties containing the destination and filter
            /// information.
            /// </param>
            public static EventSubscription CreateOrUpdate(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName, EventSubscription eventSubscriptionInfo)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, systemTopicName, eventSubscriptionName, eventSubscriptionInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update an event subscription for a system topic.
            /// </summary>
            /// <remarks>
            /// Asynchronously creates or updates an event subscription with the specified
            /// parameters. Existing event subscriptions will be updated with this API.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionInfo'>
            /// Event subscription properties containing the destination and filter
            /// information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventSubscription> CreateOrUpdateAsync(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName, EventSubscription eventSubscriptionInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, systemTopicName, eventSubscriptionName, eventSubscriptionInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an event subscription of a system topic.
            /// </summary>
            /// <remarks>
            /// Delete an existing event subscription of a system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            public static void Delete(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName)
            {
                operations.DeleteAsync(resourceGroupName, systemTopicName, eventSubscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an event subscription of a system topic.
            /// </summary>
            /// <remarks>
            /// Delete an existing event subscription of a system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, systemTopicName, eventSubscriptionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update event subscription of a system topic.
            /// </summary>
            /// <remarks>
            /// Update an existing event subscription of a system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionUpdateParameters'>
            /// Updated event subscription information.
            /// </param>
            public static EventSubscription Update(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters)
            {
                return operations.UpdateAsync(resourceGroupName, systemTopicName, eventSubscriptionName, eventSubscriptionUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update event subscription of a system topic.
            /// </summary>
            /// <remarks>
            /// Update an existing event subscription of a system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionUpdateParameters'>
            /// Updated event subscription information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventSubscription> UpdateAsync(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, systemTopicName, eventSubscriptionName, eventSubscriptionUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get full URL of an event subscription of a system topic
            /// </summary>
            /// <remarks>
            /// Get the full endpoint URL for an event subscription of a system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            public static EventSubscriptionFullUrl GetFullUrl(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName)
            {
                return operations.GetFullUrlAsync(resourceGroupName, systemTopicName, eventSubscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get full URL of an event subscription of a system topic
            /// </summary>
            /// <remarks>
            /// Get the full endpoint URL for an event subscription of a system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventSubscriptionFullUrl> GetFullUrlAsync(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFullUrlWithHttpMessagesAsync(resourceGroupName, systemTopicName, eventSubscriptionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List event subscriptions of a system topic.
            /// </summary>
            /// <remarks>
            /// List event subscriptions that belong to a specific system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='filter'>
            /// The query used to filter the search results using OData syntax. Filtering
            /// is permitted on the 'name' property only and with limited number of OData
            /// operations. These operations are: the 'contains' function as well as the
            /// following logical operations: not, and, or, eq (for equal), and ne (for not
            /// equal). No arithmetic operations are supported. The following is a valid
            /// filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'.
            /// The following is not a valid filter example: $filter=location eq 'westus'.
            /// </param>
            /// <param name='top'>
            /// The number of results to return per page for the list operation. Valid
            /// range for top parameter is 1 to 100. If not specified, the default number
            /// of results to be returned is 20 items per page.
            /// </param>
            public static IPage<EventSubscription> ListBySystemTopic(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string filter = default(string), int? top = default(int?))
            {
                return operations.ListBySystemTopicAsync(resourceGroupName, systemTopicName, filter, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List event subscriptions of a system topic.
            /// </summary>
            /// <remarks>
            /// List event subscriptions that belong to a specific system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='filter'>
            /// The query used to filter the search results using OData syntax. Filtering
            /// is permitted on the 'name' property only and with limited number of OData
            /// operations. These operations are: the 'contains' function as well as the
            /// following logical operations: not, and, or, eq (for equal), and ne (for not
            /// equal). No arithmetic operations are supported. The following is a valid
            /// filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'.
            /// The following is not a valid filter example: $filter=location eq 'westus'.
            /// </param>
            /// <param name='top'>
            /// The number of results to return per page for the list operation. Valid
            /// range for top parameter is 1 to 100. If not specified, the default number
            /// of results to be returned is 20 items per page.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EventSubscription>> ListBySystemTopicAsync(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string filter = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySystemTopicWithHttpMessagesAsync(resourceGroupName, systemTopicName, filter, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get delivery attributes for an event subscription.
            /// </summary>
            /// <remarks>
            /// Get all delivery attributes for an event subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            public static DeliveryAttributeListResult GetDeliveryAttributes(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName)
            {
                return operations.GetDeliveryAttributesAsync(resourceGroupName, systemTopicName, eventSubscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get delivery attributes for an event subscription.
            /// </summary>
            /// <remarks>
            /// Get all delivery attributes for an event subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeliveryAttributeListResult> GetDeliveryAttributesAsync(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDeliveryAttributesWithHttpMessagesAsync(resourceGroupName, systemTopicName, eventSubscriptionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update an event subscription for a system topic.
            /// </summary>
            /// <remarks>
            /// Asynchronously creates or updates an event subscription with the specified
            /// parameters. Existing event subscriptions will be updated with this API.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionInfo'>
            /// Event subscription properties containing the destination and filter
            /// information.
            /// </param>
            public static EventSubscription BeginCreateOrUpdate(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName, EventSubscription eventSubscriptionInfo)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, systemTopicName, eventSubscriptionName, eventSubscriptionInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update an event subscription for a system topic.
            /// </summary>
            /// <remarks>
            /// Asynchronously creates or updates an event subscription with the specified
            /// parameters. Existing event subscriptions will be updated with this API.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionInfo'>
            /// Event subscription properties containing the destination and filter
            /// information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventSubscription> BeginCreateOrUpdateAsync(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName, EventSubscription eventSubscriptionInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, systemTopicName, eventSubscriptionName, eventSubscriptionInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an event subscription of a system topic.
            /// </summary>
            /// <remarks>
            /// Delete an existing event subscription of a system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            public static void BeginDelete(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, systemTopicName, eventSubscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an event subscription of a system topic.
            /// </summary>
            /// <remarks>
            /// Delete an existing event subscription of a system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, systemTopicName, eventSubscriptionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update event subscription of a system topic.
            /// </summary>
            /// <remarks>
            /// Update an existing event subscription of a system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionUpdateParameters'>
            /// Updated event subscription information.
            /// </param>
            public static EventSubscription BeginUpdate(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, systemTopicName, eventSubscriptionName, eventSubscriptionUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update event subscription of a system topic.
            /// </summary>
            /// <remarks>
            /// Update an existing event subscription of a system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='systemTopicName'>
            /// Name of the system topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionUpdateParameters'>
            /// Updated event subscription information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventSubscription> BeginUpdateAsync(this ISystemTopicEventSubscriptionsOperations operations, string resourceGroupName, string systemTopicName, string eventSubscriptionName, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, systemTopicName, eventSubscriptionName, eventSubscriptionUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List event subscriptions of a system topic.
            /// </summary>
            /// <remarks>
            /// List event subscriptions that belong to a specific system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<EventSubscription> ListBySystemTopicNext(this ISystemTopicEventSubscriptionsOperations operations, string nextPageLink)
            {
                return operations.ListBySystemTopicNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List event subscriptions of a system topic.
            /// </summary>
            /// <remarks>
            /// List event subscriptions that belong to a specific system topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EventSubscription>> ListBySystemTopicNextAsync(this ISystemTopicEventSubscriptionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySystemTopicNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
