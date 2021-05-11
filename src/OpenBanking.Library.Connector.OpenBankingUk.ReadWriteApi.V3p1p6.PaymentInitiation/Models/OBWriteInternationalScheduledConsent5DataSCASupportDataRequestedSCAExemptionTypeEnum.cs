// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace FinnovationLabs.OpenBanking.Library.Connector.OpenBankingUk.ReadWriteApi.V3p1p6.PaymentInitiation.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for
    /// OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum
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
    internal static class OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum? value)
        {
            return value == null ? null : ((OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum value)
        {
            switch( value )
            {
                case OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.BillPayment:
                    return "BillPayment";
                case OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.ContactlessTravel:
                    return "ContactlessTravel";
                case OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.EcommerceGoods:
                    return "EcommerceGoods";
                case OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.EcommerceServices:
                    return "EcommerceServices";
                case OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.Kiosk:
                    return "Kiosk";
                case OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.Parking:
                    return "Parking";
                case OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.PartyToParty:
                    return "PartyToParty";
            }
            return null;
        }

        internal static OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum? ParseOBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum(this string value)
        {
            switch( value )
            {
                case "BillPayment":
                    return OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.BillPayment;
                case "ContactlessTravel":
                    return OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.ContactlessTravel;
                case "EcommerceGoods":
                    return OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.EcommerceGoods;
                case "EcommerceServices":
                    return OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.EcommerceServices;
                case "Kiosk":
                    return OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.Kiosk;
                case "Parking":
                    return OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.Parking;
                case "PartyToParty":
                    return OBWriteInternationalScheduledConsent5DataSCASupportDataRequestedSCAExemptionTypeEnum.PartyToParty;
            }
            return null;
        }
    }
}