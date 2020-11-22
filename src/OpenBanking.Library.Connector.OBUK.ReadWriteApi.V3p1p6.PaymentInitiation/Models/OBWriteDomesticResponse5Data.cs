// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace FinnovationLabs.OpenBanking.Library.Connector.OBUK.ReadWriteApi.V3p1p6.PaymentInitiation.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class OBWriteDomesticResponse5Data
    {
        /// <summary>
        /// Initializes a new instance of the OBWriteDomesticResponse5Data
        /// class.
        /// </summary>
        public OBWriteDomesticResponse5Data()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OBWriteDomesticResponse5Data
        /// class.
        /// </summary>
        /// <param name="domesticPaymentId">OB: Unique identification as
        /// assigned by the ASPSP to uniquely identify the domestic payment
        /// resource.</param>
        /// <param name="consentId">OB: Unique identification as assigned by
        /// the ASPSP to uniquely identify the consent resource.</param>
        /// <param name="creationDateTime">Date and time at which the message
        /// was created.All dates in the JSON payloads are represented in ISO
        /// 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00</param>
        /// <param name="status">Specifies the status of the payment
        /// information group. Possible values include:
        /// 'AcceptedCreditSettlementCompleted', 'AcceptedSettlementCompleted',
        /// 'AcceptedSettlementInProcess', 'AcceptedWithoutPosting', 'Pending',
        /// 'Rejected'</param>
        /// <param name="statusUpdateDateTime">Date and time at which the
        /// resource status was updated.All dates in the JSON payloads are
        /// represented in ISO 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00</param>
        /// <param name="initiation">The Initiation payload is sent by the
        /// initiating party to the ASPSP. It is used to request movement of
        /// funds from the debtor account to a creditor for a single domestic
        /// payment.</param>
        /// <param name="expectedExecutionDateTime">Expected execution date and
        /// time for the payment resource.All dates in the JSON payloads are
        /// represented in ISO 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00</param>
        /// <param name="expectedSettlementDateTime">Expected settlement date
        /// and time for the payment resource.All dates in the JSON payloads
        /// are represented in ISO 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00</param>
        /// <param name="refund">Unambiguous identification of the refund
        /// account to which a refund will be made as a result of the
        /// transaction.</param>
        /// <param name="multiAuthorisation">The multiple authorisation flow
        /// response from the ASPSP.</param>
        public OBWriteDomesticResponse5Data(string domesticPaymentId, string consentId, System.DateTimeOffset creationDateTime, OBWriteDomesticResponse5DataStatusEnum status, System.DateTimeOffset statusUpdateDateTime, OBWriteDomesticResponse5DataInitiation initiation, System.DateTimeOffset? expectedExecutionDateTime = default(System.DateTimeOffset?), System.DateTimeOffset? expectedSettlementDateTime = default(System.DateTimeOffset?), OBWriteDomesticResponse5DataRefund refund = default(OBWriteDomesticResponse5DataRefund), IList<OBWriteDomesticResponse5DataChargesItem> charges = default(IList<OBWriteDomesticResponse5DataChargesItem>), OBWriteDomesticResponse5DataMultiAuthorisation multiAuthorisation = default(OBWriteDomesticResponse5DataMultiAuthorisation), OBDebtorIdentification1 debtor = default(OBDebtorIdentification1))
        {
            DomesticPaymentId = domesticPaymentId;
            ConsentId = consentId;
            CreationDateTime = creationDateTime;
            Status = status;
            StatusUpdateDateTime = statusUpdateDateTime;
            ExpectedExecutionDateTime = expectedExecutionDateTime;
            ExpectedSettlementDateTime = expectedSettlementDateTime;
            Refund = refund;
            Charges = charges;
            Initiation = initiation;
            MultiAuthorisation = multiAuthorisation;
            Debtor = debtor;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets OB: Unique identification as assigned by the ASPSP to
        /// uniquely identify the domestic payment resource.
        /// </summary>
        [JsonProperty(PropertyName = "DomesticPaymentId")]
        public string DomesticPaymentId { get; set; }

        /// <summary>
        /// Gets or sets OB: Unique identification as assigned by the ASPSP to
        /// uniquely identify the consent resource.
        /// </summary>
        [JsonProperty(PropertyName = "ConsentId")]
        public string ConsentId { get; set; }

        /// <summary>
        /// Gets or sets date and time at which the message was created.All
        /// dates in the JSON payloads are represented in ISO 8601 date-time
        /// format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00
        /// </summary>
        [JsonProperty(PropertyName = "CreationDateTime")]
        public System.DateTimeOffset CreationDateTime { get; set; }

        /// <summary>
        /// Gets or sets specifies the status of the payment information group.
        /// Possible values include: 'AcceptedCreditSettlementCompleted',
        /// 'AcceptedSettlementCompleted', 'AcceptedSettlementInProcess',
        /// 'AcceptedWithoutPosting', 'Pending', 'Rejected'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public OBWriteDomesticResponse5DataStatusEnum Status { get; set; }

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
        /// Gets or sets expected execution date and time for the payment
        /// resource.All dates in the JSON payloads are represented in ISO 8601
        /// date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00
        /// </summary>
        [JsonProperty(PropertyName = "ExpectedExecutionDateTime")]
        public System.DateTimeOffset? ExpectedExecutionDateTime { get; set; }

        /// <summary>
        /// Gets or sets expected settlement date and time for the payment
        /// resource.All dates in the JSON payloads are represented in ISO 8601
        /// date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00
        /// </summary>
        [JsonProperty(PropertyName = "ExpectedSettlementDateTime")]
        public System.DateTimeOffset? ExpectedSettlementDateTime { get; set; }

        /// <summary>
        /// Gets or sets unambiguous identification of the refund account to
        /// which a refund will be made as a result of the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "Refund")]
        public OBWriteDomesticResponse5DataRefund Refund { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Charges")]
        public IList<OBWriteDomesticResponse5DataChargesItem> Charges { get; set; }

        /// <summary>
        /// Gets or sets the Initiation payload is sent by the initiating party
        /// to the ASPSP. It is used to request movement of funds from the
        /// debtor account to a creditor for a single domestic payment.
        /// </summary>
        [JsonProperty(PropertyName = "Initiation")]
        public OBWriteDomesticResponse5DataInitiation Initiation { get; set; }

        /// <summary>
        /// Gets or sets the multiple authorisation flow response from the
        /// ASPSP.
        /// </summary>
        [JsonProperty(PropertyName = "MultiAuthorisation")]
        public OBWriteDomesticResponse5DataMultiAuthorisation MultiAuthorisation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Debtor")]
        public OBDebtorIdentification1 Debtor { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DomesticPaymentId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DomesticPaymentId");
            }
            if (ConsentId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConsentId");
            }
            if (Initiation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Initiation");
            }
            if (Refund != null)
            {
                Refund.Validate();
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
