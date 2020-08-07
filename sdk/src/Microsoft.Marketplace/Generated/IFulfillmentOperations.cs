// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Marketplace
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// FulfillmentOperations operations.
    /// </summary>
    public partial interface IFulfillmentOperations
    {
        /// <summary>
        /// Resolve a subscription
        /// </summary>
        /// <remarks>
        /// The resolve endpoint enables the publisher to resolve a marketplace
        /// token to a persistent resource ID. The resource ID is the unique
        /// identifier for a SaaS subscription. When a user is redirected to a
        /// partner's website, the URL contains a token in the query
        /// parameters. The partner is expected to use this token and make a
        /// request to resolve it. The response contains the unique SaaS
        /// subscription ID, name, offer ID, and plan for the resource. This
        /// token is valid for one hour only.
        /// </remarks>
        /// <param name='xMsMarketplaceToken'>
        /// The token query parameter in the URL when the user is redirected to
        /// the SaaS partner's website from Azure (for example,
        /// https://contoso.com/signup?token=..). Note, The URL decodes the
        /// token value from the browser before using it.
        /// </param>
        /// <param name='requestId'>
        /// A unique string value for tracking the request from the client,
        /// preferably a GUID. If this value isn't provided, one will be
        /// generated and provided in the response headers.
        /// </param>
        /// <param name='correlationId'>
        /// A unique string value for operation on the client. This parameter
        /// correlates all events from client operation with events on the
        /// server side. If this value isn't provided, one will be generated
        /// and provided in the response headers.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ResolvedSubscription>> ResolveWithHttpMessagesAsync(string xMsMarketplaceToken, System.Guid? requestId = default(System.Guid?), System.Guid? correlationId = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List subscriptions
        /// </summary>
        /// <remarks>
        /// Lists all the SaaS subscriptions for a publisher.
        /// </remarks>
        /// <param name='continuationToken'>
        /// Optional value, only used for ListSubscriptions.
        /// </param>
        /// <param name='requestId'>
        /// A unique string value for tracking the request from the client,
        /// preferably a GUID. If this value isn't provided, one will be
        /// generated and provided in the response headers.
        /// </param>
        /// <param name='correlationId'>
        /// A unique string value for operation on the client. This parameter
        /// correlates all events from client operation with events on the
        /// server side. If this value isn't provided, one will be generated
        /// and provided in the response headers.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Subscription>>> ListSubscriptionsWithHttpMessagesAsync(string continuationToken = default(string), System.Guid? requestId = default(System.Guid?), System.Guid? correlationId = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get subscription
        /// </summary>
        /// <remarks>
        /// Gets the specified SaaS subscription. Use this call to get license
        /// information and plan information.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='requestId'>
        /// A unique string value for tracking the request from the client,
        /// preferably a GUID. If this value isn't provided, one will be
        /// generated and provided in the response headers.
        /// </param>
        /// <param name='correlationId'>
        /// A unique string value for operation on the client. This parameter
        /// correlates all events from client operation with events on the
        /// server side. If this value isn't provided, one will be generated
        /// and provided in the response headers.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Subscription>> GetSubscriptionWithHttpMessagesAsync(System.Guid subscriptionId, System.Guid? requestId = default(System.Guid?), System.Guid? correlationId = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Patch a subscription
        /// </summary>
        /// <remarks>
        /// Use this call to update the plan, the user count (quantity), or
        /// both.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='requestId'>
        /// A unique string value for tracking the request from the client,
        /// preferably a GUID. If this value isn't provided, one will be
        /// generated and provided in the response headers.
        /// </param>
        /// <param name='correlationId'>
        /// A unique string value for operation on the client. This parameter
        /// correlates all events from client operation with events on the
        /// server side. If this value isn't provided, one will be generated
        /// and provided in the response headers.
        /// </param>
        /// <param name='planId'>
        /// </param>
        /// <param name='quantity'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<FulfillmentUpdateSubscriptionHeaders>> UpdateSubscriptionWithHttpMessagesAsync(System.Guid subscriptionId, System.Guid? requestId = default(System.Guid?), System.Guid? correlationId = default(System.Guid?), string planId = default(string), long? quantity = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a subscription
        /// </summary>
        /// <remarks>
        /// Unsubscribe and delete the specified subscription.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='requestId'>
        /// A unique string value for tracking the request from the client,
        /// preferably a GUID. If this value isn't provided, one will be
        /// generated and provided in the response headers.
        /// </param>
        /// <param name='correlationId'>
        /// A unique string value for operation on the client. This parameter
        /// correlates all events from client operation with events on the
        /// server side. If this value isn't provided, one will be generated
        /// and provided in the response headers.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<FulfillmentDeleteSubscriptionHeaders>> DeleteSubscriptionWithHttpMessagesAsync(System.Guid subscriptionId, System.Guid? requestId = default(System.Guid?), System.Guid? correlationId = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List available plans
        /// </summary>
        /// <remarks>
        /// Use this call to find out if there are any private or public offers
        /// for the current publisher.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='requestId'>
        /// A unique string value for tracking the request from the client,
        /// preferably a GUID. If this value isn't provided, one will be
        /// generated and provided in the response headers.
        /// </param>
        /// <param name='correlationId'>
        /// A unique string value for operation on the client. This parameter
        /// correlates all events from client operation with events on the
        /// server side. If this value isn't provided, one will be generated
        /// and provided in the response headers.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SubscriptionPlans>> ListAvailablePlansWithHttpMessagesAsync(System.Guid subscriptionId, System.Guid? requestId = default(System.Guid?), System.Guid? correlationId = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Activate a subscription
        /// </summary>
        /// <remarks>
        /// Use this call to activate a subscription.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='requestId'>
        /// A unique string value for tracking the request from the client,
        /// preferably a GUID. If this value isn't provided, one will be
        /// generated and provided in the response headers.
        /// </param>
        /// <param name='correlationId'>
        /// A unique string value for operation on the client. This parameter
        /// correlates all events from client operation with events on the
        /// server side. If this value isn't provided, one will be generated
        /// and provided in the response headers.
        /// </param>
        /// <param name='planId'>
        /// </param>
        /// <param name='quantity'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ActivateSubscriptionWithHttpMessagesAsync(System.Guid subscriptionId, System.Guid? requestId = default(System.Guid?), System.Guid? correlationId = default(System.Guid?), string planId = default(string), long? quantity = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List subscriptions
        /// </summary>
        /// <remarks>
        /// Lists all the SaaS subscriptions for a publisher.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='requestId'>
        /// A unique string value for tracking the request from the client,
        /// preferably a GUID. If this value isn't provided, one will be
        /// generated and provided in the response headers.
        /// </param>
        /// <param name='correlationId'>
        /// A unique string value for operation on the client. This parameter
        /// correlates all events from client operation with events on the
        /// server side. If this value isn't provided, one will be generated
        /// and provided in the response headers.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Subscription>>> ListSubscriptionsNextWithHttpMessagesAsync(string nextPageLink, System.Guid? requestId = default(System.Guid?), System.Guid? correlationId = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
