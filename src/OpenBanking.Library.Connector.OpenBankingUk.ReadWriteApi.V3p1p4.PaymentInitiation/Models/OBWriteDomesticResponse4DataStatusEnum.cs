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
    /// Defines values for OBWriteDomesticResponse4DataStatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteDomesticResponse4DataStatusEnum
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
    internal static class OBWriteDomesticResponse4DataStatusEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteDomesticResponse4DataStatusEnum? value)
        {
            return value == null ? null : ((OBWriteDomesticResponse4DataStatusEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteDomesticResponse4DataStatusEnum value)
        {
            switch( value )
            {
                case OBWriteDomesticResponse4DataStatusEnum.AcceptedCreditSettlementCompleted:
                    return "AcceptedCreditSettlementCompleted";
                case OBWriteDomesticResponse4DataStatusEnum.AcceptedSettlementCompleted:
                    return "AcceptedSettlementCompleted";
                case OBWriteDomesticResponse4DataStatusEnum.AcceptedSettlementInProcess:
                    return "AcceptedSettlementInProcess";
                case OBWriteDomesticResponse4DataStatusEnum.AcceptedWithoutPosting:
                    return "AcceptedWithoutPosting";
                case OBWriteDomesticResponse4DataStatusEnum.Pending:
                    return "Pending";
                case OBWriteDomesticResponse4DataStatusEnum.Rejected:
                    return "Rejected";
            }
            return null;
        }

        internal static OBWriteDomesticResponse4DataStatusEnum? ParseOBWriteDomesticResponse4DataStatusEnum(this string value)
        {
            switch( value )
            {
                case "AcceptedCreditSettlementCompleted":
                    return OBWriteDomesticResponse4DataStatusEnum.AcceptedCreditSettlementCompleted;
                case "AcceptedSettlementCompleted":
                    return OBWriteDomesticResponse4DataStatusEnum.AcceptedSettlementCompleted;
                case "AcceptedSettlementInProcess":
                    return OBWriteDomesticResponse4DataStatusEnum.AcceptedSettlementInProcess;
                case "AcceptedWithoutPosting":
                    return OBWriteDomesticResponse4DataStatusEnum.AcceptedWithoutPosting;
                case "Pending":
                    return OBWriteDomesticResponse4DataStatusEnum.Pending;
                case "Rejected":
                    return OBWriteDomesticResponse4DataStatusEnum.Rejected;
            }
            return null;
        }
    }
}