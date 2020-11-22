// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace FinnovationLabs.OpenBanking.Library.Connector.OBUK.ReadWriteApi.V3p1p2.PaymentInitiation.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class OBWriteDomesticStandingOrderResponse4Data
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteDomesticStandingOrderResponse4Data class.
        /// </summary>
        public OBWriteDomesticStandingOrderResponse4Data()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteDomesticStandingOrderResponse4Data class.
        /// </summary>
        /// <param name="domesticStandingOrderId">OB: Unique identification as
        /// assigned by the ASPSP to uniquely identify the domestic standing
        /// order resource.</param>
        /// <param name="consentId">OB: Unique identification as assigned by
        /// the ASPSP to uniquely identify the consent resource.</param>
        /// <param name="creationDateTime">Date and time at which the resource
        /// was created.All dates in the JSON payloads are represented in ISO
        /// 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00</param>
        /// <param name="status">Specifies the status of the payment order
        /// resource. Possible values include: 'Cancelled',
        /// 'InitiationCompleted', 'InitiationFailed',
        /// 'InitiationPending'</param>
        /// <param name="statusUpdateDateTime">Date and time at which the
        /// resource status was updated.All dates in the JSON payloads are
        /// represented in ISO 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00</param>
        /// <param name="initiation">The Initiation payload is sent by the
        /// initiating party to the ASPSP. It is used to request movement of
        /// funds from the debtor account to a creditor for a domestic standing
        /// order.</param>
        /// <param name="multiAuthorisation">The multiple authorisation flow
        /// response from the ASPSP.</param>
        public OBWriteDomesticStandingOrderResponse4Data(string domesticStandingOrderId, string consentId, System.DateTimeOffset creationDateTime, OBWriteDomesticStandingOrderResponse4DataStatusEnum status, System.DateTimeOffset statusUpdateDateTime, OBWriteDomesticStandingOrderResponse4DataInitiation initiation, IList<OBWriteDomesticStandingOrderResponse4DataChargesItem> charges = default(IList<OBWriteDomesticStandingOrderResponse4DataChargesItem>), OBWriteDomesticStandingOrderResponse4DataMultiAuthorisation multiAuthorisation = default(OBWriteDomesticStandingOrderResponse4DataMultiAuthorisation))
        {
            DomesticStandingOrderId = domesticStandingOrderId;
            ConsentId = consentId;
            CreationDateTime = creationDateTime;
            Status = status;
            StatusUpdateDateTime = statusUpdateDateTime;
            Charges = charges;
            Initiation = initiation;
            MultiAuthorisation = multiAuthorisation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets OB: Unique identification as assigned by the ASPSP to
        /// uniquely identify the domestic standing order resource.
        /// </summary>
        [JsonProperty(PropertyName = "DomesticStandingOrderId")]
        public string DomesticStandingOrderId { get; set; }

        /// <summary>
        /// Gets or sets OB: Unique identification as assigned by the ASPSP to
        /// uniquely identify the consent resource.
        /// </summary>
        [JsonProperty(PropertyName = "ConsentId")]
        public string ConsentId { get; set; }

        /// <summary>
        /// Gets or sets date and time at which the resource was created.All
        /// dates in the JSON payloads are represented in ISO 8601 date-time
        /// format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00
        /// </summary>
        [JsonProperty(PropertyName = "CreationDateTime")]
        public System.DateTimeOffset CreationDateTime { get; set; }

        /// <summary>
        /// Gets or sets specifies the status of the payment order resource.
        /// Possible values include: 'Cancelled', 'InitiationCompleted',
        /// 'InitiationFailed', 'InitiationPending'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public OBWriteDomesticStandingOrderResponse4DataStatusEnum Status { get; set; }

        /// <summary>
        /// Gets or sets date and time at which the resource status was
        /// updated.All dates in the JSON payloads are represented in ISO 8601
        /// date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00
        /// </summary>
        [JsonProperty(PropertyName = "StatusUpdateDateTime")]
        public System.DateTimeOffset StatusUpdateDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Charges")]
        public IList<OBWriteDomesticStandingOrderResponse4DataChargesItem> Charges { get; set; }

        /// <summary>
        /// Gets or sets the Initiation payload is sent by the initiating party
        /// to the ASPSP. It is used to request movement of funds from the
        /// debtor account to a creditor for a domestic standing order.
        /// </summary>
        [JsonProperty(PropertyName = "Initiation")]
        public OBWriteDomesticStandingOrderResponse4DataInitiation Initiation { get; set; }

        /// <summary>
        /// Gets or sets the multiple authorisation flow response from the
        /// ASPSP.
        /// </summary>
        [JsonProperty(PropertyName = "MultiAuthorisation")]
        public OBWriteDomesticStandingOrderResponse4DataMultiAuthorisation MultiAuthorisation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DomesticStandingOrderId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DomesticStandingOrderId");
            }
            if (ConsentId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConsentId");
            }
            if (Initiation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Initiation");
            }
            if (Charges != null)
            {
                foreach (var element in Charges)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Initiation != null)
            {
                Initiation.Validate();
            }
            if (MultiAuthorisation != null)
            {
                MultiAuthorisation.Validate();
            }
        }
    }
}
