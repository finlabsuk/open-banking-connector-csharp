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

    /// <summary>
    /// Provides the details to identify the debtor account.
    /// </summary>
    public partial class OBWriteDomesticStandingOrder3DataInitiationDebtorAccount
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteDomesticStandingOrder3DataInitiationDebtorAccount class.
        /// </summary>
        public OBWriteDomesticStandingOrder3DataInitiationDebtorAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteDomesticStandingOrder3DataInitiationDebtorAccount class.
        /// </summary>
        /// <param name="name">The account name is the name or names of the
        /// account owner(s) represented at an account level, as displayed by
        /// the ASPSP's online channels.
        /// Note, the account name is not the product name or the nickname of
        /// the account.</param>
        public OBWriteDomesticStandingOrder3DataInitiationDebtorAccount(string schemeName, string identification, string name = default(string), string secondaryIdentification = default(string))
        {
            SchemeName = schemeName;
            Identification = identification;
            Name = name;
            SecondaryIdentification = secondaryIdentification;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchemeName")]
        public string SchemeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Identification")]
        public string Identification { get; set; }

        /// <summary>
        /// Gets or sets the account name is the name or names of the account
        /// owner(s) represented at an account level, as displayed by the
        /// ASPSP's online channels.
        /// Note, the account name is not the product name or the nickname of
        /// the account.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SecondaryIdentification")]
        public string SecondaryIdentification { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SchemeName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchemeName");
            }
            if (Identification == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Identification");
            }
        }
    }
}