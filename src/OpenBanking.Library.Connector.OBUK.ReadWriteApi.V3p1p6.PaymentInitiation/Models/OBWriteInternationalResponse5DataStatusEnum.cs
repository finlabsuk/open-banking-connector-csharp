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
    /// Defines values for OBWriteInternationalResponse5DataStatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteInternationalResponse5DataStatusEnum
    {
        [EnumMember(Value = "AcceptedCreditSettlementCompleted")]
        AcceptedCreditSettlementCompleted,
        [EnumMember(Value = "AcceptedSettlementCompleted")]
        AcceptedSettlementCompleted,
        [EnumMember(Value = "AcceptedSettlementInProcess")]
        AcceptedSettlementInProcess,
        [EnumMember(Value = "AcceptedWithoutPosting")]
        AcceptedWithoutPosting,
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Rejected")]
        Rejected
    }
    internal static class OBWriteInternationalResponse5DataStatusEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteInternationalResponse5DataStatusEnum? value)
        {
            return value == null ? null : ((OBWriteInternationalResponse5DataStatusEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteInternationalResponse5DataStatusEnum value)
        {
            switch( value )
            {
                case OBWriteInternationalResponse5DataStatusEnum.AcceptedCreditSettlementCompleted:
                    return "AcceptedCreditSettlementCompleted";
                case OBWriteInternationalResponse5DataStatusEnum.AcceptedSettlementCompleted:
                    return "AcceptedSettlementCompleted";
                case OBWriteInternationalResponse5DataStatusEnum.AcceptedSettlementInProcess:
                    return "AcceptedSettlementInProcess";
                case OBWriteInternationalResponse5DataStatusEnum.AcceptedWithoutPosting:
                    return "AcceptedWithoutPosting";
                case OBWriteInternationalResponse5DataStatusEnum.Pending:
                    return "Pending";
                case OBWriteInternationalResponse5DataStatusEnum.Rejected:
                    return "Rejected";
            }
            return null;
        }

        internal static OBWriteInternationalResponse5DataStatusEnum? ParseOBWriteInternationalResponse5DataStatusEnum(this string value)
        {
            switch( value )
            {
                case "AcceptedCreditSettlementCompleted":
                    return OBWriteInternationalResponse5DataStatusEnum.AcceptedCreditSettlementCompleted;
                case "AcceptedSettlementCompleted":
                    return OBWriteInternationalResponse5DataStatusEnum.AcceptedSettlementCompleted;
                case "AcceptedSettlementInProcess":
                    return OBWriteInternationalResponse5DataStatusEnum.AcceptedSettlementInProcess;
                case "AcceptedWithoutPosting":
                    return OBWriteInternationalResponse5DataStatusEnum.AcceptedWithoutPosting;
                case "Pending":
                    return OBWriteInternationalResponse5DataStatusEnum.Pending;
                case "Rejected":
                    return OBWriteInternationalResponse5DataStatusEnum.Rejected;
            }
            return null;
        }
    }
}
