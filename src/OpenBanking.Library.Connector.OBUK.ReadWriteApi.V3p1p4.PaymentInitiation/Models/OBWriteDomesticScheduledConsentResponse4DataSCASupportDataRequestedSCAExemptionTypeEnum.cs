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
    /// OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum
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
    internal static class OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum? value)
        {
            return value == null ? null : ((OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum value)
        {
            switch( value )
            {
                case OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.BillPayment:
                    return "BillPayment";
                case OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.ContactlessTravel:
                    return "ContactlessTravel";
                case OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.EcommerceGoods:
                    return "EcommerceGoods";
                case OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.EcommerceServices:
                    return "EcommerceServices";
                case OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.Kiosk:
                    return "Kiosk";
                case OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.Parking:
                    return "Parking";
                case OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.PartyToParty:
                    return "PartyToParty";
            }
            return null;
        }

        internal static OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum? ParseOBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum(this string value)
        {
            switch( value )
            {
                case "BillPayment":
                    return OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.BillPayment;
                case "ContactlessTravel":
                    return OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.ContactlessTravel;
                case "EcommerceGoods":
                    return OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.EcommerceGoods;
                case "EcommerceServices":
                    return OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.EcommerceServices;
                case "Kiosk":
                    return OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.Kiosk;
                case "Parking":
                    return OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.Parking;
                case "PartyToParty":
                    return OBWriteDomesticScheduledConsentResponse4DataSCASupportDataRequestedSCAExemptionTypeEnum.PartyToParty;
            }
            return null;
        }
    }
}
