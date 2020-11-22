// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace FinnovationLabs.OpenBanking.Library.Connector.OBUK.ReadWriteApi.V3p1p6.PaymentInitiation.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OBWriteInternationalConsentResponse6
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteInternationalConsentResponse6 class.
        /// </summary>
        public OBWriteInternationalConsentResponse6()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteInternationalConsentResponse6 class.
        /// </summary>
        public OBWriteInternationalConsentResponse6(OBWriteInternationalConsentResponse6Data data, OBRisk1 risk, Links links = default(Links), Meta meta = default(Meta))
        {
            Data = data;
            Risk = risk;
            Links = links;
            Meta = meta;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Data")]
        public OBWriteInternationalConsentResponse6Data Data { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Risk")]
        public OBRisk1 Risk { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Links")]
        public Links Links { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Meta")]
        public Meta Meta { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Data == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Data");
            }
            if (Risk == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Risk");
            }
            if (Data != null)
            {
                Data.Validate();
            }
            if (Risk != null)
            {
                Risk.Validate();
            }
            if (Links != null)
            {
                Links.Validate();
            }
        }
    }
}
