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

    public partial class FulfillmentInternalServerErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FulfillmentInternalServerErrorResponse class.
        /// </summary>
        public FulfillmentInternalServerErrorResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// FulfillmentInternalServerErrorResponse class.
        /// </summary>
        public FulfillmentInternalServerErrorResponse(FulfillmentInternalServerErrorResponseError error = default(FulfillmentInternalServerErrorResponseError))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public FulfillmentInternalServerErrorResponseError Error { get; set; }

    }
}
