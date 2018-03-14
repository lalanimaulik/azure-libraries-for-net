// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ReadScale.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReadScale
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class ReadScaleEnumExtension
    {
        internal static string ToSerializedValue(this ReadScale? value)
        {
            return value == null ? null : ((ReadScale)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ReadScale value)
        {
            switch( value )
            {
                case ReadScale.Enabled:
                    return "Enabled";
                case ReadScale.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static ReadScale? ParseReadScale(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return ReadScale.Enabled;
                case "Disabled":
                    return ReadScale.Disabled;
            }
            return null;
        }
    }
}