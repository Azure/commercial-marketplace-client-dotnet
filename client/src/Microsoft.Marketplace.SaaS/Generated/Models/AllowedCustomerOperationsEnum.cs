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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AllowedCustomerOperationsEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AllowedCustomerOperationsEnum
    {
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Update")]
        Update,
        [EnumMember(Value = "Delete")]
        Delete
    }
    internal static class AllowedCustomerOperationsEnumEnumExtension
    {
        internal static string ToSerializedValue(this AllowedCustomerOperationsEnum? value)
        {
            return value == null ? null : ((AllowedCustomerOperationsEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AllowedCustomerOperationsEnum value)
        {
            switch( value )
            {
                case AllowedCustomerOperationsEnum.Read:
                    return "Read";
                case AllowedCustomerOperationsEnum.Update:
                    return "Update";
                case AllowedCustomerOperationsEnum.Delete:
                    return "Delete";
            }
            return null;
        }

        internal static AllowedCustomerOperationsEnum? ParseAllowedCustomerOperationsEnum(this string value)
        {
            switch( value )
            {
                case "Read":
                    return AllowedCustomerOperationsEnum.Read;
                case "Update":
                    return AllowedCustomerOperationsEnum.Update;
                case "Delete":
                    return AllowedCustomerOperationsEnum.Delete;
            }
            return null;
        }
    }
}
