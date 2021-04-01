// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace FinnovationLabs.OpenBanking.Library.Connector.OBUK.ReadWriteApi.V3p1p6.PaymentInitiation.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for OBWriteInternationalConsentResponse6DataStatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteInternationalConsentResponse6DataStatusEnum
    {
        [EnumMember(Value = "Authorised")]
        Authorised,
        [EnumMember(Value = "AwaitingAuthorisation")]
        AwaitingAuthorisation,
        [EnumMember(Value = "Consumed")]
        Consumed,
        [EnumMember(Value = "Rejected")]
        Rejected
    }
    internal static class OBWriteInternationalConsentResponse6DataStatusEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteInternationalConsentResponse6DataStatusEnum? value)
        {
            return value == null ? null : ((OBWriteInternationalConsentResponse6DataStatusEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteInternationalConsentResponse6DataStatusEnum value)
        {
            switch( value )
            {
                case OBWriteInternationalConsentResponse6DataStatusEnum.Authorised:
                    return "Authorised";
                case OBWriteInternationalConsentResponse6DataStatusEnum.AwaitingAuthorisation:
                    return "AwaitingAuthorisation";
                case OBWriteInternationalConsentResponse6DataStatusEnum.Consumed:
                    return "Consumed";
                case OBWriteInternationalConsentResponse6DataStatusEnum.Rejected:
                    return "Rejected";
            }
            return null;
        }

        internal static OBWriteInternationalConsentResponse6DataStatusEnum? ParseOBWriteInternationalConsentResponse6DataStatusEnum(this string value)
        {
            switch( value )
            {
                case "Authorised":
                    return OBWriteInternationalConsentResponse6DataStatusEnum.Authorised;
                case "AwaitingAuthorisation":
                    return OBWriteInternationalConsentResponse6DataStatusEnum.AwaitingAuthorisation;
                case "Consumed":
                    return OBWriteInternationalConsentResponse6DataStatusEnum.Consumed;
                case "Rejected":
                    return OBWriteInternationalConsentResponse6DataStatusEnum.Rejected;
            }
            return null;
        }
    }
}