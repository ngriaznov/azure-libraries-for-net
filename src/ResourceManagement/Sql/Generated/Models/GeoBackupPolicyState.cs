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
    /// Defines values for GeoBackupPolicyState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GeoBackupPolicyState
    {
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "Enabled")]
        Enabled
    }
    internal static class GeoBackupPolicyStateEnumExtension
    {
        internal static string ToSerializedValue(this GeoBackupPolicyState? value)
        {
            return value == null ? null : ((GeoBackupPolicyState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this GeoBackupPolicyState value)
        {
            switch( value )
            {
                case GeoBackupPolicyState.Disabled:
                    return "Disabled";
                case GeoBackupPolicyState.Enabled:
                    return "Enabled";
            }
            return null;
        }

        internal static GeoBackupPolicyState? ParseGeoBackupPolicyState(this string value)
        {
            switch( value )
            {
                case "Disabled":
                    return GeoBackupPolicyState.Disabled;
                case "Enabled":
                    return GeoBackupPolicyState.Enabled;
            }
            return null;
        }
    }
}