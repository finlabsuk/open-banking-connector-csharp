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
    /// Defines values for
    /// OBWriteDomesticScheduledConsentResponse5DataStatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteDomesticScheduledConsentResponse5DataStatusEnum
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
    internal static class OBWriteDomesticScheduledConsentResponse5DataStatusEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteDomesticScheduledConsentResponse5DataStatusEnum? value)
        {
            return value == null ? null : ((OBWriteDomesticScheduledConsentResponse5DataStatusEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteDomesticScheduledConsentResponse5DataStatusEnum value)
        {
            switch( value )
            {
                case OBWriteDomesticScheduledConsentResponse5DataStatusEnum.Authorised:
                    return "Authorised";
                case OBWriteDomesticScheduledConsentResponse5DataStatusEnum.AwaitingAuthorisation:
                    return "AwaitingAuthorisation";
                case OBWriteDomesticScheduledConsentResponse5DataStatusEnum.Consumed:
                    return "Consumed";
                case OBWriteDomesticScheduledConsentResponse5DataStatusEnum.Rejected:
                    return "Rejected";
            }
            return null;
        }

        internal static OBWriteDomesticScheduledConsentResponse5DataStatusEnum? ParseOBWriteDomesticScheduledConsentResponse5DataStatusEnum(this string value)
        {
            switch( value )
            {
                case "Authorised":
                    return OBWriteDomesticScheduledConsentResponse5DataStatusEnum.Authorised;
                case "AwaitingAuthorisation":
                    return OBWriteDomesticScheduledConsentResponse5DataStatusEnum.AwaitingAuthorisation;
                case "Consumed":
                    return OBWriteDomesticScheduledConsentResponse5DataStatusEnum.Consumed;
                case "Rejected":
                    return OBWriteDomesticScheduledConsentResponse5DataStatusEnum.Rejected;
            }
            return null;
        }
    }
}
