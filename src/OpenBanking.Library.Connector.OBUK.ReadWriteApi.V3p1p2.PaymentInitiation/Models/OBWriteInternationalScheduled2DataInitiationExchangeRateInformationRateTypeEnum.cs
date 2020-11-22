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
    /// OBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnum
    {
        [EnumMember(Value = "Actual")]
        Actual,
        [EnumMember(Value = "Agreed")]
        Agreed,
        [EnumMember(Value = "Indicative")]
        Indicative
    }
    internal static class OBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnum? value)
        {
            return value == null ? null : ((OBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnum value)
        {
            switch( value )
            {
                case OBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnum.Actual:
                    return "Actual";
                case OBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnum.Agreed:
                    return "Agreed";
                case OBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnum.Indicative:
                    return "Indicative";
            }
            return null;
        }

        internal static OBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnum? ParseOBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnum(this string value)
        {
            switch( value )
            {
                case "Actual":
                    return OBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnum.Actual;
                case "Agreed":
                    return OBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnum.Agreed;
                case "Indicative":
                    return OBWriteInternationalScheduled2DataInitiationExchangeRateInformationRateTypeEnum.Indicative;
            }
            return null;
        }
    }
}
