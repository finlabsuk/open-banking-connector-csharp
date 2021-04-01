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
    /// OBWriteInternationalScheduledConsentResponse5DataInitiationInstructionPriorityEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteInternationalScheduledConsentResponse5DataInitiationInstructionPriorityEnum
    {
        [EnumMember(Value = "Normal")]
        Normal,
        [EnumMember(Value = "Urgent")]
        Urgent
    }
    internal static class OBWriteInternationalScheduledConsentResponse5DataInitiationInstructionPriorityEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteInternationalScheduledConsentResponse5DataInitiationInstructionPriorityEnum? value)
        {
            return value == null ? null : ((OBWriteInternationalScheduledConsentResponse5DataInitiationInstructionPriorityEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteInternationalScheduledConsentResponse5DataInitiationInstructionPriorityEnum value)
        {
            switch( value )
            {
                case OBWriteInternationalScheduledConsentResponse5DataInitiationInstructionPriorityEnum.Normal:
                    return "Normal";
                case OBWriteInternationalScheduledConsentResponse5DataInitiationInstructionPriorityEnum.Urgent:
                    return "Urgent";
            }
            return null;
        }

        internal static OBWriteInternationalScheduledConsentResponse5DataInitiationInstructionPriorityEnum? ParseOBWriteInternationalScheduledConsentResponse5DataInitiationInstructionPriorityEnum(this string value)
        {
            switch( value )
            {
                case "Normal":
                    return OBWriteInternationalScheduledConsentResponse5DataInitiationInstructionPriorityEnum.Normal;
                case "Urgent":
                    return OBWriteInternationalScheduledConsentResponse5DataInitiationInstructionPriorityEnum.Urgent;
            }
            return null;
        }
    }
}