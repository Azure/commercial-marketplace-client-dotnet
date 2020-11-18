// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Marketplace.SaaS.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AadIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the AadIdentifier class.
        /// </summary>
        public AadIdentifier()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AadIdentifier class.
        /// </summary>
        public AadIdentifier(string emailId = default(string), System.Guid? objectId = default(System.Guid?), System.Guid? tenantId = default(System.Guid?), string puid = default(string))
        {
            EmailId = emailId;
            ObjectId = objectId;
            TenantId = tenantId;
            Puid = puid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailId")]
        public string EmailId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public System.Guid? ObjectId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "puid")]
        public string Puid { get; set; }

    }
}
