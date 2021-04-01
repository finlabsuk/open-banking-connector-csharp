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
    /// OBWriteFileConsentResponse3DataAuthorisationAuthorisationTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OBWriteFileConsentResponse3DataAuthorisationAuthorisationTypeEnum
    {
        [EnumMember(Value = "Any")]
        Any,
        [EnumMember(Value = "Single")]
        Single
    }
    internal static class OBWriteFileConsentResponse3DataAuthorisationAuthorisationTypeEnumEnumExtension
    {
        internal static string ToSerializedValue(this OBWriteFileConsentResponse3DataAuthorisationAuthorisationTypeEnum? value)
        {
            return value == null ? null : ((OBWriteFileConsentResponse3DataAuthorisationAuthorisationTypeEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OBWriteFileConsentResponse3DataAuthorisationAuthorisationTypeEnum value)
        {
            switch( value )
            {
                case OBWriteFileConsentResponse3DataAuthorisationAuthorisationTypeEnum.Any:
                    return "Any";
                case OBWriteFileConsentResponse3DataAuthorisationAuthorisationTypeEnum.Single:
                    return "Single";
            }
            return null;
        }

        internal static OBWriteFileConsentResponse3DataAuthorisationAuthorisationTypeEnum? ParseOBWriteFileConsentResponse3DataAuthorisationAuthorisationTypeEnum(this string value)
        {
            switch( value )
            {
                case "Any":
                    return OBWriteFileConsentResponse3DataAuthorisationAuthorisationTypeEnum.Any;
                case "Single":
                    return OBWriteFileConsentResponse3DataAuthorisationAuthorisationTypeEnum.Single;
            }
            return null;
        }
    }
}