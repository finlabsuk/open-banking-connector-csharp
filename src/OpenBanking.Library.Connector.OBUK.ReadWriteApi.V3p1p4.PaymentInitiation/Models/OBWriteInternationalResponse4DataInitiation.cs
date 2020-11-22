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
    /// is used to request movement of funds from the debtor account to a
    /// creditor for a single international payment.
    /// </summary>
    public partial class OBWriteInternationalResponse4DataInitiation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteInternationalResponse4DataInitiation class.
        /// </summary>
        public OBWriteInternationalResponse4DataInitiation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteInternationalResponse4DataInitiation class.
        /// </summary>
        /// <param name="instructionIdentification">Unique identification as
        /// assigned by an instructing party for an instructed party to
        /// unambiguously identify the instruction.
        /// Usage: the  instruction identification is a point to point
        /// reference that can be used between the instructing party and the
        /// instructed party to refer to the individual instruction. It can be
        /// included in several messages related to the instruction.</param>
        /// <param name="endToEndIdentification">Unique identification assigned
        /// by the initiating party to unambiguously identify the transaction.
        /// This identification is passed on, unchanged, throughout the entire
        /// end-to-end chain.
        /// Usage: The end-to-end identification can be used for reconciliation
        /// or to link tasks relating to the transaction. It can be included in
        /// several messages related to the transaction.
        /// OB: The Faster Payments Scheme can only access 31 characters for
        /// the EndToEndIdentification field.</param>
        /// <param name="currencyOfTransfer">Specifies the currency of the to
        /// be transferred amount, which is different from the currency of the
        /// debtor's account.</param>
        /// <param name="instructedAmount">Amount of money to be moved between
        /// the debtor and creditor, before deduction of charges, expressed in
        /// the currency as ordered by the initiating party.
        /// Usage: This amount has to be transported unchanged through the
        /// transaction chain.</param>
        /// <param name="creditorAccount">Unambiguous identification of the
        /// account of the creditor to which a credit entry will be posted as a
        /// result of the payment transaction.</param>
        /// <param name="instructionPriority">Indicator of the urgency or order
        /// of importance that the instructing party would like the instructed
        /// party to apply to the processing of the instruction. Possible
        /// values include: 'Normal', 'Urgent'</param>
        /// <param name="purpose">Specifies the external purpose code in the
        /// format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published
        /// separately.
        /// External code sets can be downloaded from www.iso20022.org.</param>
        /// <param name="extendedPurpose">Specifies the purpose of an
        /// international payment, when there is no corresponding 4 character
        /// code available in the ISO20022 list of Purpose Codes.</param>
        /// <param name="chargeBearer">Possible values include:
        /// 'BorneByCreditor', 'BorneByDebtor', 'FollowingServiceLevel',
        /// 'Shared'</param>
        /// <param name="destinationCountryCode">Country in which Credit
        /// Account is domiciled. Code to identify a country, a dependency, or
        /// another area of particular geopolitical interest, on the basis of
        /// country names obtained from the United Nations (ISO 3166, Alpha-2
        /// code).</param>
        /// <param name="exchangeRateInformation">Provides details on the
        /// currency exchange rate and contract.</param>
        /// <param name="debtorAccount">Unambiguous identification of the
        /// account of the debtor to which a debit entry will be made as a
        /// result of the transaction.</param>
        /// <param name="creditor">Party to which an amount of money is
        /// due.</param>
        /// <param name="creditorAgent">Financial institution servicing an
        /// account for the creditor.</param>
        /// <param name="remittanceInformation">Information supplied to enable
        /// the matching of an entry with the items that the transfer is
        /// intended to settle, such as commercial invoices in an accounts'
        /// receivable system.</param>
        public OBWriteInternationalResponse4DataInitiation(string instructionIdentification, string endToEndIdentification, string currencyOfTransfer, OBWriteInternationalResponse4DataInitiationInstructedAmount instructedAmount, OBWriteInternationalResponse4DataInitiationCreditorAccount creditorAccount, string localInstrument = default(string), OBWriteInternationalResponse4DataInitiationInstructionPriorityEnum? instructionPriority = default(OBWriteInternationalResponse4DataInitiationInstructionPriorityEnum?), string purpose = default(string), string extendedPurpose = default(string), OBChargeBearerType1CodeEnum? chargeBearer = default(OBChargeBearerType1CodeEnum?), string destinationCountryCode = default(string), OBWriteInternationalResponse4DataInitiationExchangeRateInformation exchangeRateInformation = default(OBWriteInternationalResponse4DataInitiationExchangeRateInformation), OBWriteInternationalResponse4DataInitiationDebtorAccount debtorAccount = default(OBWriteInternationalResponse4DataInitiationDebtorAccount), OBWriteInternationalResponse4DataInitiationCreditor creditor = default(OBWriteInternationalResponse4DataInitiationCreditor), OBWriteInternationalResponse4DataInitiationCreditorAgent creditorAgent = default(OBWriteInternationalResponse4DataInitiationCreditorAgent), OBWriteInternationalResponse4DataInitiationRemittanceInformation remittanceInformation = default(OBWriteInternationalResponse4DataInitiationRemittanceInformation), IDictionary<string, object> supplementaryData = default(IDictionary<string, object>))
        {
            InstructionIdentification = instructionIdentification;
            EndToEndIdentification = endToEndIdentification;
            LocalInstrument = localInstrument;
            InstructionPriority = instructionPriority;
            Purpose = purpose;
            ExtendedPurpose = extendedPurpose;
            ChargeBearer = chargeBearer;
            CurrencyOfTransfer = currencyOfTransfer;
            DestinationCountryCode = destinationCountryCode;
            InstructedAmount = instructedAmount;
            ExchangeRateInformation = exchangeRateInformation;
            DebtorAccount = debtorAccount;
            Creditor = creditor;
            CreditorAgent = creditorAgent;
            CreditorAccount = creditorAccount;
            RemittanceInformation = remittanceInformation;
            SupplementaryData = supplementaryData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identification as assigned by an instructing
        /// party for an instructed party to unambiguously identify the
        /// instruction.
        /// Usage: the  instruction identification is a point to point
        /// reference that can be used between the instructing party and the
        /// instructed party to refer to the individual instruction. It can be
        /// included in several messages related to the instruction.
        /// </summary>
        [JsonProperty(PropertyName = "InstructionIdentification")]
        public string InstructionIdentification { get; set; }

        /// <summary>
        /// Gets or sets unique identification assigned by the initiating party
        /// to unambiguously identify the transaction. This identification is
        /// passed on, unchanged, throughout the entire end-to-end chain.
        /// Usage: The end-to-end identification can be used for reconciliation
        /// or to link tasks relating to the transaction. It can be included in
        /// several messages related to the transaction.
        /// OB: The Faster Payments Scheme can only access 31 characters for
        /// the EndToEndIdentification field.
        /// </summary>
        [JsonProperty(PropertyName = "EndToEndIdentification")]
        public string EndToEndIdentification { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LocalInstrument")]
        public string LocalInstrument { get; set; }

        /// <summary>
        /// Gets or sets indicator of the urgency or order of importance that
        /// the instructing party would like the instructed party to apply to
        /// the processing of the instruction. Possible values include:
        /// 'Normal', 'Urgent'
        /// </summary>
        [JsonProperty(PropertyName = "InstructionPriority")]
        public OBWriteInternationalResponse4DataInitiationInstructionPriorityEnum? InstructionPriority { get; set; }

        /// <summary>
        /// Gets or sets specifies the external purpose code in the format of
        /// character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published
        /// separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [JsonProperty(PropertyName = "Purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Gets or sets specifies the purpose of an international payment,
        /// when there is no corresponding 4 character code available in the
        /// ISO20022 list of Purpose Codes.
        /// </summary>
        [JsonProperty(PropertyName = "ExtendedPurpose")]
        public string ExtendedPurpose { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'BorneByCreditor',
        /// 'BorneByDebtor', 'FollowingServiceLevel', 'Shared'
        /// </summary>
        [JsonProperty(PropertyName = "ChargeBearer")]
        public OBChargeBearerType1CodeEnum? ChargeBearer { get; set; }

        /// <summary>
        /// Gets or sets specifies the currency of the to be transferred
        /// amount, which is different from the currency of the debtor's
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "CurrencyOfTransfer")]
        public string CurrencyOfTransfer { get; set; }

        /// <summary>
        /// Gets or sets country in which Credit Account is domiciled. Code to
        /// identify a country, a dependency, or another area of particular
        /// geopolitical interest, on the basis of country names obtained from
        /// the United Nations (ISO 3166, Alpha-2 code).
        /// </summary>
        [JsonProperty(PropertyName = "DestinationCountryCode")]
        public string DestinationCountryCode { get; set; }

        /// <summary>
        /// Gets or sets amount of money to be moved between the debtor and
        /// creditor, before deduction of charges, expressed in the currency as
        /// ordered by the initiating party.
        /// Usage: This amount has to be transported unchanged through the
        /// transaction chain.
        /// </summary>
        [JsonProperty(PropertyName = "InstructedAmount")]
        public OBWriteInternationalResponse4DataInitiationInstructedAmount InstructedAmount { get; set; }

        /// <summary>
        /// Gets or sets provides details on the currency exchange rate and
        /// contract.
        /// </summary>
        [JsonProperty(PropertyName = "ExchangeRateInformation")]
        public OBWriteInternationalResponse4DataInitiationExchangeRateInformation ExchangeRateInformation { get; set; }

        /// <summary>
        /// Gets or sets unambiguous identification of the account of the
        /// debtor to which a debit entry will be made as a result of the
        /// transaction.
        /// </summary>
        [JsonProperty(PropertyName = "DebtorAccount")]
        public OBWriteInternationalResponse4DataInitiationDebtorAccount DebtorAccount { get; set; }

        /// <summary>
        /// Gets or sets party to which an amount of money is due.
        /// </summary>
        [JsonProperty(PropertyName = "Creditor")]
        public OBWriteInternationalResponse4DataInitiationCreditor Creditor { get; set; }

        /// <summary>
        /// Gets or sets financial institution servicing an account for the
        /// creditor.
        /// </summary>
        [JsonProperty(PropertyName = "CreditorAgent")]
        public OBWriteInternationalResponse4DataInitiationCreditorAgent CreditorAgent { get; set; }

        /// <summary>
        /// Gets or sets unambiguous identification of the account of the
        /// creditor to which a credit entry will be posted as a result of the
        /// payment transaction.
        /// </summary>
        [JsonProperty(PropertyName = "CreditorAccount")]
        public OBWriteInternationalResponse4DataInitiationCreditorAccount CreditorAccount { get; set; }

        /// <summary>
        /// Gets or sets information supplied to enable the matching of an
        /// entry with the items that the transfer is intended to settle, such
        /// as commercial invoices in an accounts' receivable system.
        /// </summary>
        [JsonProperty(PropertyName = "RemittanceInformation")]
        public OBWriteInternationalResponse4DataInitiationRemittanceInformation RemittanceInformation { get; set; }

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
            if (InstructionIdentification == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InstructionIdentification");
            }
            if (EndToEndIdentification == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EndToEndIdentification");
            }
            if (CurrencyOfTransfer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CurrencyOfTransfer");
            }
            if (InstructedAmount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InstructedAmount");
            }
            if (CreditorAccount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CreditorAccount");
            }
            if (InstructedAmount != null)
            {
                InstructedAmount.Validate();
            }
            if (ExchangeRateInformation != null)
            {
                ExchangeRateInformation.Validate();
            }
            if (DebtorAccount != null)
            {
                DebtorAccount.Validate();
            }
            if (CreditorAccount != null)
            {
                CreditorAccount.Validate();
            }
        }
    }
}
