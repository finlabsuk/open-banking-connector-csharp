// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace FinnovationLabs.OpenBanking.Library.Connector.OpenBankingUk.ReadWriteApi.V3p1p4.PaymentInitiation.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for OBWriteDomesticStandingOrderResponse5DataStatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteDomesticStandingOrderResponse5DataStatusEnum
    {
        [EnumMember(Value = "Cancelled")]
        Cancelled,
        [EnumMember(Value = "InitiationCompleted")]
        InitiationCompleted,
        [EnumMember(Value = "InitiationFailed")]
        InitiationFailed,
        [EnumMember(Value = "InitiationPending")]
        InitiationPending
    }
    internal static class OBWriteDomesticStandingOrderResponse5DataStatusEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteDomesticStandingOrderResponse5DataStatusEnum? value)
        {
            return value == null ? null : ((OBWriteDomesticStandingOrderResponse5DataStatusEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteDomesticStandingOrderResponse5DataStatusEnum value)
        {
            switch( value )
            {
                case OBWriteDomesticStandingOrderResponse5DataStatusEnum.Cancelled:
                    return "Cancelled";
                case OBWriteDomesticStandingOrderResponse5DataStatusEnum.InitiationCompleted:
                    return "InitiationCompleted";
                case OBWriteDomesticStandingOrderResponse5DataStatusEnum.InitiationFailed:
                    return "InitiationFailed";
                case OBWriteDomesticStandingOrderResponse5DataStatusEnum.InitiationPending:
                    return "InitiationPending";
            }
            return null;
        }

        internal static OBWriteDomesticStandingOrderResponse5DataStatusEnum? ParseOBWriteDomesticStandingOrderResponse5DataStatusEnum(this string value)
        {
            switch( value )
            {
                case "Cancelled":
                    return OBWriteDomesticStandingOrderResponse5DataStatusEnum.Cancelled;
                case "InitiationCompleted":
                    return OBWriteDomesticStandingOrderResponse5DataStatusEnum.InitiationCompleted;
                case "InitiationFailed":
                    return OBWriteDomesticStandingOrderResponse5DataStatusEnum.InitiationFailed;
                case "InitiationPending":
                    return OBWriteDomesticStandingOrderResponse5DataStatusEnum.InitiationPending;
            }
            return null;
        }
    }
}