// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace FinnovationLabs.OpenBanking.Library.Connector.OBUK.ReadWriteApi.V3p1p4.PaymentInitiation.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for
    /// OBWriteInternationalStandingOrderResponse6DataStatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteInternationalStandingOrderResponse6DataStatusEnum
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
    internal static class OBWriteInternationalStandingOrderResponse6DataStatusEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteInternationalStandingOrderResponse6DataStatusEnum? value)
        {
            return value == null ? null : ((OBWriteInternationalStandingOrderResponse6DataStatusEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteInternationalStandingOrderResponse6DataStatusEnum value)
        {
            switch( value )
            {
                case OBWriteInternationalStandingOrderResponse6DataStatusEnum.Cancelled:
                    return "Cancelled";
                case OBWriteInternationalStandingOrderResponse6DataStatusEnum.InitiationCompleted:
                    return "InitiationCompleted";
                case OBWriteInternationalStandingOrderResponse6DataStatusEnum.InitiationFailed:
                    return "InitiationFailed";
                case OBWriteInternationalStandingOrderResponse6DataStatusEnum.InitiationPending:
                    return "InitiationPending";
            }
            return null;
        }

        internal static OBWriteInternationalStandingOrderResponse6DataStatusEnum? ParseOBWriteInternationalStandingOrderResponse6DataStatusEnum(this string value)
        {
            switch( value )
            {
                case "Cancelled":
                    return OBWriteInternationalStandingOrderResponse6DataStatusEnum.Cancelled;
                case "InitiationCompleted":
                    return OBWriteInternationalStandingOrderResponse6DataStatusEnum.InitiationCompleted;
                case "InitiationFailed":
                    return OBWriteInternationalStandingOrderResponse6DataStatusEnum.InitiationFailed;
                case "InitiationPending":
                    return OBWriteInternationalStandingOrderResponse6DataStatusEnum.InitiationPending;
            }
            return null;
        }
    }
}