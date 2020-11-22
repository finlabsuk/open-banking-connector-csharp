// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace FinnovationLabs.OpenBanking.Library.Connector.OBUK.ReadWriteApi.V3p1p4.PaymentInitiation.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Initiation payload is sent by the initiating party to the ASPSP. It
    /// is used to request movement of funds using a payment file.
    /// </summary>
    public partial class OBWriteFileResponse2DataInitiation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteFileResponse2DataInitiation class.
        /// </summary>
        public OBWriteFileResponse2DataInitiation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteFileResponse2DataInitiation class.
        /// </summary>
        /// <param name="fileType">Specifies the payment file type.</param>
        /// <param name="fileHash">A base64 encoding of a SHA256 hash of the
        /// file to be uploaded.</param>
        /// <param name="fileReference">Reference for the file.</param>
        /// <param name="numberOfTransactions">Number of individual
        /// transactions contained in the payment information group.</param>
        /// <param name="controlSum">Total of all individual amounts included
        /// in the group, irrespective of currencies.</param>
        /// <param name="requestedExecutionDateTime">Date at which the
        /// initiating party requests the clearing agent to process the
        /// payment.
        /// Usage: This is the date on which the debtor's account is to be
        /// debited.All dates in the JSON payloads are represented in ISO 8601
        /// date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00</param>
        /// <param name="debtorAccount">Unambiguous identification of the
        /// account of the debtor to which a debit entry will be made as a
        /// result of the transaction.</param>
        /// <param name="remittanceInformation">Information supplied to enable
        /// the matching of an entry with the items that the transfer is
        /// intended to settle, such as commercial invoices in an accounts'
        /// receivable system.</param>
        public OBWriteFileResponse2DataInitiation(string fileType, string fileHash, string fileReference = default(string), string numberOfTransactions = default(string), double? controlSum = default(double?), System.DateTimeOffset? requestedExecutionDateTime = default(System.DateTimeOffset?), string localInstrument = default(string), OBWriteFileResponse2DataInitiationDebtorAccount debtorAccount = default(OBWriteFileResponse2DataInitiationDebtorAccount), OBWriteFileResponse2DataInitiationRemittanceInformation remittanceInformation = default(OBWriteFileResponse2DataInitiationRemittanceInformation), IDictionary<string, object> supplementaryData = default(IDictionary<string, object>))
        {
            FileType = fileType;
            FileHash = fileHash;
            FileReference = fileReference;
            NumberOfTransactions = numberOfTransactions;
            ControlSum = controlSum;
            RequestedExecutionDateTime = requestedExecutionDateTime;
            LocalInstrument = localInstrument;
            DebtorAccount = debtorAccount;
            RemittanceInformation = remittanceInformation;
            SupplementaryData = supplementaryData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the payment file type.
        /// </summary>
        [JsonProperty(PropertyName = "FileType")]
        public string FileType { get; set; }

        /// <summary>
        /// Gets or sets a base64 encoding of a SHA256 hash of the file to be
        /// uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "FileHash")]
        public string FileHash { get; set; }

        /// <summary>
        /// Gets or sets reference for the file.
        /// </summary>
        [JsonProperty(PropertyName = "FileReference")]
        public string FileReference { get; set; }

        /// <summary>
        /// Gets or sets number of individual transactions contained in the
        /// payment information group.
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfTransactions")]
        public string NumberOfTransactions { get; set; }

        /// <summary>
        /// Gets or sets total of all individual amounts included in the group,
        /// irrespective of currencies.
        /// </summary>
        [JsonProperty(PropertyName = "ControlSum")]
        public double? ControlSum { get; set; }

        /// <summary>
        /// Gets or sets date at which the initiating party requests the
        /// clearing agent to process the payment.
        /// Usage: This is the date on which the debtor's account is to be
        /// debited.All dates in the JSON payloads are represented in ISO 8601
        /// date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00
        /// </summary>
        [JsonProperty(PropertyName = "RequestedExecutionDateTime")]
        public System.DateTimeOffset? RequestedExecutionDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LocalInstrument")]
        public string LocalInstrument { get; set; }

        /// <summary>
        /// Gets or sets unambiguous identification of the account of the
        /// debtor to which a debit entry will be made as a result of the
        /// transaction.
        /// </summary>
        [JsonProperty(PropertyName = "DebtorAccount")]
        public OBWriteFileResponse2DataInitiationDebtorAccount DebtorAccount { get; set; }

        /// <summary>
        /// Gets or sets information supplied to enable the matching of an
        /// entry with the items that the transfer is intended to settle, such
        /// as commercial invoices in an accounts' receivable system.
        /// </summary>
        [JsonProperty(PropertyName = "RemittanceInformation")]
        public OBWriteFileResponse2DataInitiationRemittanceInformation RemittanceInformation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SupplementaryData")]
        public IDictionary<string, object> SupplementaryData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FileType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileType");
            }
            if (FileHash == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileHash");
            }
            if (DebtorAccount != null)
            {
                DebtorAccount.Validate();
            }
        }
    }
}
