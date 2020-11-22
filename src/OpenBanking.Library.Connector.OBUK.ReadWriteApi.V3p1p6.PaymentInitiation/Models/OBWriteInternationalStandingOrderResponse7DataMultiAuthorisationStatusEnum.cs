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
    /// OBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnum
    {
        [EnumMember(Value = "Authorised")]
        Authorised,
        [EnumMember(Value = "AwaitingFurtherAuthorisation")]
        AwaitingFurtherAuthorisation,
        [EnumMember(Value = "Rejected")]
        Rejected
    }
    internal static class OBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnum? value)
        {
            return value == null ? null : ((OBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnum value)
        {
            switch( value )
            {
                case OBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnum.Authorised:
                    return "Authorised";
                case OBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnum.AwaitingFurtherAuthorisation:
                    return "AwaitingFurtherAuthorisation";
                case OBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnum.Rejected:
                    return "Rejected";
            }
            return null;
        }

        internal static OBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnum? ParseOBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnum(this string value)
        {
            switch( value )
            {
                case "Authorised":
                    return OBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnum.Authorised;
                case "AwaitingFurtherAuthorisation":
                    return OBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnum.AwaitingFurtherAuthorisation;
                case "Rejected":
                    return OBWriteInternationalStandingOrderResponse7DataMultiAuthorisationStatusEnum.Rejected;
            }
            return null;
        }
    }
}
