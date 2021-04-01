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
    /// OBWriteInternationalScheduledConsent3DataAuthorisationAuthorisationTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteInternationalScheduledConsent3DataAuthorisationAuthorisationTypeEnum
    {
        [EnumMember(Value = "Any")]
        Any,
        [EnumMember(Value = "Single")]
        Single
    }
    internal static class OBWriteInternationalScheduledConsent3DataAuthorisationAuthorisationTypeEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteInternationalScheduledConsent3DataAuthorisationAuthorisationTypeEnum? value)
        {
            return value == null ? null : ((OBWriteInternationalScheduledConsent3DataAuthorisationAuthorisationTypeEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteInternationalScheduledConsent3DataAuthorisationAuthorisationTypeEnum value)
        {
            switch( value )
            {
                case OBWriteInternationalScheduledConsent3DataAuthorisationAuthorisationTypeEnum.Any:
                    return "Any";
                case OBWriteInternationalScheduledConsent3DataAuthorisationAuthorisationTypeEnum.Single:
                    return "Single";
            }
            return null;
        }

        internal static OBWriteInternationalScheduledConsent3DataAuthorisationAuthorisationTypeEnum? ParseOBWriteInternationalScheduledConsent3DataAuthorisationAuthorisationTypeEnum(this string value)
        {
            switch( value )
            {
                case "Any":
                    return OBWriteInternationalScheduledConsent3DataAuthorisationAuthorisationTypeEnum.Any;
                case "Single":
                    return OBWriteInternationalScheduledConsent3DataAuthorisationAuthorisationTypeEnum.Single;
            }
            return null;
        }
    }
}