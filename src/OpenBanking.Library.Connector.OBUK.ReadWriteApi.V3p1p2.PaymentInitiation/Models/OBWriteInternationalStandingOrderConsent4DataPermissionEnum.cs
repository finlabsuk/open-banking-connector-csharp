// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace FinnovationLabs.OpenBanking.Library.Connector.OBUK.ReadWriteApi.V3p1p2.PaymentInitiation.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for
    /// OBWriteInternationalStandingOrderConsent4DataPermissionEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteInternationalStandingOrderConsent4DataPermissionEnum
    {
        [EnumMember(Value = "Create")]
        Create
    }
    internal static class OBWriteInternationalStandingOrderConsent4DataPermissionEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteInternationalStandingOrderConsent4DataPermissionEnum? value)
        {
            return value == null ? null : ((OBWriteInternationalStandingOrderConsent4DataPermissionEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteInternationalStandingOrderConsent4DataPermissionEnum value)
        {
            switch( value )
            {
                case OBWriteInternationalStandingOrderConsent4DataPermissionEnum.Create:
                    return "Create";
            }
            return null;
        }

        internal static OBWriteInternationalStandingOrderConsent4DataPermissionEnum? ParseOBWriteInternationalStandingOrderConsent4DataPermissionEnum(this string value)
        {
            switch( value )
            {
                case "Create":
                    return OBWriteInternationalStandingOrderConsent4DataPermissionEnum.Create;
            }
            return null;
        }
    }
}