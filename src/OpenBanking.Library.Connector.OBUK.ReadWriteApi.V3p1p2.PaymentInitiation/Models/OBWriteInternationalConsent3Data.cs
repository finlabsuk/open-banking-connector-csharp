// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace FinnovationLabs.OpenBanking.Library.Connector.OBUK.ReadWriteApi.V3p1p2.PaymentInitiation.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OBWriteInternationalConsent3Data
    {
        /// <summary>
        /// Initializes a new instance of the OBWriteInternationalConsent3Data
        /// class.
        /// </summary>
        public OBWriteInternationalConsent3Data()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OBWriteInternationalConsent3Data
        /// class.
        /// </summary>
        /// <param name="initiation">The Initiation payload is sent by the
        /// initiating party to the ASPSP. It is used to request movement of
        /// funds from the debtor account to a creditor for a single
        /// international payment.</param>
        /// <param name="authorisation">The authorisation type request from the
        /// TPP.</param>
        /// <param name="sCASupportData">Supporting Data provided by TPP, when
        /// requesting SCA Exemption.</param>
        public OBWriteInternationalConsent3Data(OBWriteInternationalConsent3DataInitiation initiation, OBWriteInternationalConsent3DataAuthorisation authorisation = default(OBWriteInternationalConsent3DataAuthorisation), OBWriteInternationalConsent3DataSCASupportData sCASupportData = default(OBWriteInternationalConsent3DataSCASupportData))
        {
            Initiation = initiation;
            Authorisation = authorisation;
            SCASupportData = sCASupportData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Initiation payload is sent by the initiating party
        /// to the ASPSP. It is used to request movement of funds from the
        /// debtor account to a creditor for a single international payment.
        /// </summary>
        [JsonProperty(PropertyName = "Initiation")]
        public OBWriteInternationalConsent3DataInitiation Initiation { get; set; }

        /// <summary>
        /// Gets or sets the authorisation type request from the TPP.
        /// </summary>
        [JsonProperty(PropertyName = "Authorisation")]
        public OBWriteInternationalConsent3DataAuthorisation Authorisation { get; set; }

        /// <summary>
        /// Gets or sets supporting Data provided by TPP, when requesting SCA
        /// Exemption.
        /// </summary>
        [JsonProperty(PropertyName = "SCASupportData")]
        public OBWriteInternationalConsent3DataSCASupportData SCASupportData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Initiation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Initiation");
            }
            if (Initiation != null)
            {
                Initiation.Validate();
            }
            if (Authorisation != null)
            {
                Authorisation.Validate();
            }
        }
    }
}