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
    /// OBWriteDomesticScheduledConsentResponse3DataPermissionEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteDomesticScheduledConsentResponse3DataPermissionEnum
    {
        [EnumMember(Value = "Create")]
        Create
    }
    internal static class OBWriteDomesticScheduledConsentResponse3DataPermissionEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteDomesticScheduledConsentResponse3DataPermissionEnum? value)
        {
            return value == null ? null : ((OBWriteDomesticScheduledConsentResponse3DataPermissionEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteDomesticScheduledConsentResponse3DataPermissionEnum value)
        {
            switch( value )
            {
                case OBWriteDomesticScheduledConsentResponse3DataPermissionEnum.Create:
                    return "Create";
            }
            return null;
        }

        internal static OBWriteDomesticScheduledConsentResponse3DataPermissionEnum? ParseOBWriteDomesticScheduledConsentResponse3DataPermissionEnum(this string value)
        {
            switch( value )
            {
                case "Create":
                    return OBWriteDomesticScheduledConsentResponse3DataPermissionEnum.Create;
            }
            return null;
        }
    }
}
