// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Marketplace.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UsageEventOkResponse
    {
        /// <summary>
        /// Initializes a new instance of the UsageEventOkResponse class.
        /// </summary>
        public UsageEventOkResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageEventOkResponse class.
        /// </summary>
        /// <param name="usageEventId">Unique identifier associated with the
        /// usage event</param>
        /// <param name="status">Status of the operation. Possible values
        /// include: 'Accepted', 'Expired', 'Duplicate', 'Error',
        /// 'ResourceNotFound', 'ResourceNotAuthorized',
        /// 'InvalidDimension|BadArgument'</param>
        /// <param name="messageTime">Time this message was created in
        /// UTC</param>
        /// <param name="resourceId">Identifier of the resource against which
        /// usage is emitted</param>
        /// <param name="quantity">Number of units consumed</param>
        /// <param name="dimension">Dimension identifier</param>
        /// <param name="effectiveStartTime">Time in UTC when the usage event
        /// occurred</param>
        /// <param name="planId">Plan associated with the purchased
        /// offer</param>
        public UsageEventOkResponse(System.Guid? usageEventId = default(System.Guid?), UsageEventStatusEnum? status = default(UsageEventStatusEnum?), System.DateTime? messageTime = default(System.DateTime?), System.Guid? resourceId = default(System.Guid?), long? quantity = default(long?), string dimension = default(string), System.DateTime? effectiveStartTime = default(System.DateTime?), string planId = default(string))
        {
            UsageEventId = usageEventId;
            Status = status;
            MessageTime = messageTime;
            ResourceId = resourceId;
            Quantity = quantity;
            Dimension = dimension;
            EffectiveStartTime = effectiveStartTime;
            PlanId = planId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier associated with the usage event
        /// </summary>
        [JsonProperty(PropertyName = "usageEventId")]
        public System.Guid? UsageEventId { get; set; }

        /// <summary>
        /// Gets or sets status of the operation. Possible values include:
        /// 'Accepted', 'Expired', 'Duplicate', 'Error', 'ResourceNotFound',
        /// 'ResourceNotAuthorized', 'InvalidDimension|BadArgument'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public UsageEventStatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or sets time this message was created in UTC
        /// </summary>
        [JsonProperty(PropertyName = "messageTime")]
        public System.DateTime? MessageTime { get; set; }

        /// <summary>
        /// Gets or sets identifier of the resource against which usage is
        /// emitted
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public System.Guid? ResourceId { get; set; }

        /// <summary>
        /// Gets or sets number of units consumed
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Gets or sets dimension identifier
        /// </summary>
        [JsonProperty(PropertyName = "dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// Gets or sets time in UTC when the usage event occurred
        /// </summary>
        [JsonProperty(PropertyName = "effectiveStartTime")]
        public System.DateTime? EffectiveStartTime { get; set; }

        /// <summary>
        /// Gets or sets plan associated with the purchased offer
        /// </summary>
        [JsonProperty(PropertyName = "planId")]
        public string PlanId { get; set; }

    }
}
