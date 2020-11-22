// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace FinnovationLabs.OpenBanking.Library.Connector.OBUK.ReadWriteApi.V3p1p2.PaymentInitiation.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Result of a funds availability check.
    /// </summary>
    public partial class OBWriteFundsConfirmationResponse1DataFundsAvailableResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteFundsConfirmationResponse1DataFundsAvailableResult class.
        /// </summary>
        public OBWriteFundsConfirmationResponse1DataFundsAvailableResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteFundsConfirmationResponse1DataFundsAvailableResult class.
        /// </summary>
        /// <param name="fundsAvailableDateTime">Date and time at which the
        /// funds availability check was generated.All dates in the JSON
        /// payloads are represented in ISO 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00</param>
        /// <param name="fundsAvailable">Flag to indicate the availability of
        /// funds given the Amount in the consent request.</param>
        public OBWriteFundsConfirmationResponse1DataFundsAvailableResult(System.DateTimeOffset fundsAvailableDateTime, bool fundsAvailable)
        {
            FundsAvailableDateTime = fundsAvailableDateTime;
            FundsAvailable = fundsAvailable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date and time at which the funds availability check
        /// was generated.All dates in the JSON payloads are represented in ISO
        /// 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00
        /// </summary>
        [JsonProperty(PropertyName = "FundsAvailableDateTime")]
        public System.DateTimeOffset FundsAvailableDateTime { get; set; }

        /// <summary>
        /// Gets or sets flag to indicate the availability of funds given the
        /// Amount in the consent request.
        /// </summary>
        [JsonProperty(PropertyName = "FundsAvailable")]
        public bool FundsAvailable { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
