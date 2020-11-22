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
    /// OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum
    {
        [EnumMember(Value = "BillPayment")]
        BillPayment,
        [EnumMember(Value = "ContactlessTravel")]
        ContactlessTravel,
        [EnumMember(Value = "EcommerceGoods")]
        EcommerceGoods,
        [EnumMember(Value = "EcommerceServices")]
        EcommerceServices,
        [EnumMember(Value = "Kiosk")]
        Kiosk,
        [EnumMember(Value = "Parking")]
        Parking,
        [EnumMember(Value = "PartyToParty")]
        PartyToParty
    }
    internal static class OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum? value)
        {
            return value == null ? null : ((OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum value)
        {
            switch( value )
            {
                case OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.BillPayment:
                    return "BillPayment";
                case OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.ContactlessTravel:
                    return "ContactlessTravel";
                case OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.EcommerceGoods:
                    return "EcommerceGoods";
                case OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.EcommerceServices:
                    return "EcommerceServices";
                case OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.Kiosk:
                    return "Kiosk";
                case OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.Parking:
                    return "Parking";
                case OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.PartyToParty:
                    return "PartyToParty";
            }
            return null;
        }

        internal static OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum? ParseOBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum(this string value)
        {
            switch( value )
            {
                case "BillPayment":
                    return OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.BillPayment;
                case "ContactlessTravel":
                    return OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.ContactlessTravel;
                case "EcommerceGoods":
                    return OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.EcommerceGoods;
                case "EcommerceServices":
                    return OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.EcommerceServices;
                case "Kiosk":
                    return OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.Kiosk;
                case "Parking":
                    return OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.Parking;
                case "PartyToParty":
                    return OBWriteDomesticScheduledConsent4DataSCASupportDataRequestedSCAExemptionTypeEnum.PartyToParty;
            }
            return null;
        }
    }
}
