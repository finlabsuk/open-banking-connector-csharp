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
    /// OBWriteInternationalConsentResponse3DataInitiationInstructionPriorityEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteInternationalConsentResponse3DataInitiationInstructionPriorityEnum
    {
        [EnumMember(Value = "Normal")]
        Normal,
        [EnumMember(Value = "Urgent")]
        Urgent
    }
    internal static class OBWriteInternationalConsentResponse3DataInitiationInstructionPriorityEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteInternationalConsentResponse3DataInitiationInstructionPriorityEnum? value)
        {
            return value == null ? null : ((OBWriteInternationalConsentResponse3DataInitiationInstructionPriorityEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteInternationalConsentResponse3DataInitiationInstructionPriorityEnum value)
        {
            switch( value )
            {
                case OBWriteInternationalConsentResponse3DataInitiationInstructionPriorityEnum.Normal:
                    return "Normal";
                case OBWriteInternationalConsentResponse3DataInitiationInstructionPriorityEnum.Urgent:
                    return "Urgent";
            }
            return null;
        }

        internal static OBWriteInternationalConsentResponse3DataInitiationInstructionPriorityEnum? ParseOBWriteInternationalConsentResponse3DataInitiationInstructionPriorityEnum(this string value)
        {
            switch( value )
            {
                case "Normal":
                    return OBWriteInternationalConsentResponse3DataInitiationInstructionPriorityEnum.Normal;
                case "Urgent":
                    return OBWriteInternationalConsentResponse3DataInitiationInstructionPriorityEnum.Urgent;
            }
            return null;
        }
    }
}
