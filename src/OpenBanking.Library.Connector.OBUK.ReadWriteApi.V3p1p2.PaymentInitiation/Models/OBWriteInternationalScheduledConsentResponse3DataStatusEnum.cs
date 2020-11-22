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
    /// OBWriteInternationalScheduledConsentResponse3DataStatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteInternationalScheduledConsentResponse3DataStatusEnum
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
    internal static class OBWriteInternationalScheduledConsentResponse3DataStatusEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteInternationalScheduledConsentResponse3DataStatusEnum? value)
        {
            return value == null ? null : ((OBWriteInternationalScheduledConsentResponse3DataStatusEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteInternationalScheduledConsentResponse3DataStatusEnum value)
        {
            switch( value )
            {
                case OBWriteInternationalScheduledConsentResponse3DataStatusEnum.Authorised:
                    return "Authorised";
                case OBWriteInternationalScheduledConsentResponse3DataStatusEnum.AwaitingAuthorisation:
                    return "AwaitingAuthorisation";
                case OBWriteInternationalScheduledConsentResponse3DataStatusEnum.Consumed:
                    return "Consumed";
                case OBWriteInternationalScheduledConsentResponse3DataStatusEnum.Rejected:
                    return "Rejected";
            }
            return null;
        }

        internal static OBWriteInternationalScheduledConsentResponse3DataStatusEnum? ParseOBWriteInternationalScheduledConsentResponse3DataStatusEnum(this string value)
        {
            switch( value )
            {
                case "Authorised":
                    return OBWriteInternationalScheduledConsentResponse3DataStatusEnum.Authorised;
                case "AwaitingAuthorisation":
                    return OBWriteInternationalScheduledConsentResponse3DataStatusEnum.AwaitingAuthorisation;
                case "Consumed":
                    return OBWriteInternationalScheduledConsentResponse3DataStatusEnum.Consumed;
                case "Rejected":
                    return OBWriteInternationalScheduledConsentResponse3DataStatusEnum.Rejected;
            }
            return null;
        }
    }
}
