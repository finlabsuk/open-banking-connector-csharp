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
    /// OBWriteInternationalScheduledResponse5DataInitiationInstructionPriorityEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteInternationalScheduledResponse5DataInitiationInstructionPriorityEnum
    {
        [EnumMember(Value = "Normal")]
        Normal,
        [EnumMember(Value = "Urgent")]
        Urgent
    }
    internal static class OBWriteInternationalScheduledResponse5DataInitiationInstructionPriorityEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteInternationalScheduledResponse5DataInitiationInstructionPriorityEnum? value)
        {
            return value == null ? null : ((OBWriteInternationalScheduledResponse5DataInitiationInstructionPriorityEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteInternationalScheduledResponse5DataInitiationInstructionPriorityEnum value)
        {
            switch( value )
            {
                case OBWriteInternationalScheduledResponse5DataInitiationInstructionPriorityEnum.Normal:
                    return "Normal";
                case OBWriteInternationalScheduledResponse5DataInitiationInstructionPriorityEnum.Urgent:
                    return "Urgent";
            }
            return null;
        }

        internal static OBWriteInternationalScheduledResponse5DataInitiationInstructionPriorityEnum? ParseOBWriteInternationalScheduledResponse5DataInitiationInstructionPriorityEnum(this string value)
        {
            switch( value )
            {
                case "Normal":
                    return OBWriteInternationalScheduledResponse5DataInitiationInstructionPriorityEnum.Normal;
                case "Urgent":
                    return OBWriteInternationalScheduledResponse5DataInitiationInstructionPriorityEnum.Urgent;
            }
            return null;
        }
    }
}
