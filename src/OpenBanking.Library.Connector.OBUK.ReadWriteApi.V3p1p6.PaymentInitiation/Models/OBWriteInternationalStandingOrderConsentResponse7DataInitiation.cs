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

    /// <summary>
    /// The Initiation payload is sent by the initiating party to the ASPSP. It
    /// is used to request movement of funds from the debtor account to a
    /// creditor for an international standing order.
    /// </summary>
    public partial class OBWriteInternationalStandingOrderConsentResponse7DataInitiation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteInternationalStandingOrderConsentResponse7DataInitiation
        /// class.
        /// </summary>
        public OBWriteInternationalStandingOrderConsentResponse7DataInitiation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteInternationalStandingOrderConsentResponse7DataInitiation
        /// class.
        /// </summary>
        /// <param name="frequency">Individual Definitions:
        /// EvryDay - Every day
        /// EvryWorkgDay - Every working day
        /// IntrvlWkDay - An interval specified in weeks (01 to 09), and the
        /// day within the week (01 to 07)
        /// WkInMnthDay - A monthly interval, specifying the week of the month
        /// (01 to 05) and day within the week (01 to 07)
        /// IntrvlMnthDay - An interval specified in months (between 01 to 06,
        /// 12, 24), specifying the day within the month (-5 to -1, 1 to 31)
        /// QtrDay - Quarterly (either ENGLISH, SCOTTISH, or RECEIVED).
        /// ENGLISH = Paid on the 25th March, 24th June, 29th September and
        /// 25th December.
        /// SCOTTISH = Paid on the 2nd February, 15th May, 1st August and 11th
        /// November.
        /// RECEIVED = Paid on the 20th March, 19th June, 24th September and
        /// 20th December.
        /// Individual Patterns:
        /// EvryDay (ScheduleCode)
        /// EvryWorkgDay (ScheduleCode)
        /// IntrvlWkDay:IntervalInWeeks:DayInWeek (ScheduleCode +
        /// IntervalInWeeks + DayInWeek)
        /// WkInMnthDay:WeekInMonth:DayInWeek (ScheduleCode + WeekInMonth +
        /// DayInWeek)
        /// IntrvlMnthDay:IntervalInMonths:DayInMonth (ScheduleCode +
        /// IntervalInMonths + DayInMonth)
        /// QtrDay: + either (ENGLISH, SCOTTISH or RECEIVED) ScheduleCode +
        /// QuarterDay
        /// The regular expression for this element combines five smaller
        /// versions for each permitted pattern. To aid legibility - the
        /// components are presented individually here:
        /// EvryDay
        /// EvryWorkgDay
        /// IntrvlWkDay:0[1-9]:0[1-7]
        /// WkInMnthDay:0[1-5]:0[1-7]
        /// IntrvlMnthDay:(0[1-6]|12|24):(-0[1-5]|0[1-9]|[12][0-9]|3[01])
        /// QtrDay:(ENGLISH|SCOTTISH|RECEIVED)
        /// Full Regular Expression:
        /// ^(EvryDay)$|^(EvryWorkgDay)$|^(IntrvlWkDay:0[1-9]:0[1-7])$|^(WkInMnthDay:0[1-5]:0[1-7])$|^(IntrvlMnthDay:(0[1-6]|12|24):(-0[1-5]|0[1-9]|[12][0-9]|3[01]))$|^(QtrDay:(ENGLISH|SCOTTISH|RECEIVED))$</param>
        /// <param name="firstPaymentDateTime">The date on which the first
        /// payment for a Standing Order schedule will be made.All dates in the
        /// JSON payloads are represented in ISO 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00</param>
        /// <param name="currencyOfTransfer">Specifies the currency of the to
        /// be transferred amount, which is different from the currency of the
        /// debtor's account.</param>
        /// <param name="instructedAmount">Amount of money to be moved between
        /// the debtor and creditor, before deduction of charges, expressed in
        /// the currency as ordered by the initiating party.
        /// Usage: This amount has to be transported unchanged through the
        /// transaction chain.</param>
        /// <param name="creditorAccount">Provides the details to identify the
        /// beneficiary account.</param>
        /// <param name="reference">Unique reference, as assigned by the
        /// creditor, to unambiguously refer to the payment transaction.
        /// Usage: If available, the initiating party should provide this
        /// reference in the structured remittance information, to enable
        /// reconciliation by the creditor upon receipt of the amount of money.
        /// If the business context requires the use of a creditor reference or
        /// a payment remit identification, and only one identifier can be
        /// passed through the end-to-end chain, the creditor's reference or
        /// payment remittance identification should be quoted in the
        /// end-to-end transaction identification.</param>
        /// <param name="numberOfPayments">Number of the payments that will be
        /// made in completing this frequency sequence including any executed
        /// since the sequence start date.</param>
        /// <param name="finalPaymentDateTime">The date on which the final
        /// payment for a Standing Order schedule will be made.All dates in the
        /// JSON payloads are represented in ISO 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00</param>
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
        /// <param name="debtorAccount">Provides the details to identify the
        /// debtor account.</param>
        /// <param name="creditor">Party to which an amount of money is
        /// due.</param>
        /// <param name="creditorAgent">Party that manages the account on
        /// behalf of the account owner, that is manages the registration and
        /// booking of entries on the account, calculates balances on the
        /// account and provides information about the account.
        /// This is the servicer of the beneficiary account.</param>
        public OBWriteInternationalStandingOrderConsentResponse7DataInitiation(string frequency, System.DateTimeOffset firstPaymentDateTime, string currencyOfTransfer, OBWriteInternationalStandingOrderConsentResponse7DataInitiationInstructedAmount instructedAmount, OBWriteInternationalStandingOrderConsentResponse7DataInitiationCreditorAccount creditorAccount, string reference = default(string), string numberOfPayments = default(string), System.DateTimeOffset? finalPaymentDateTime = default(System.DateTimeOffset?), string purpose = default(string), string extendedPurpose = default(string), OBChargeBearerType1CodeEnum? chargeBearer = default(OBChargeBearerType1CodeEnum?), string destinationCountryCode = default(string), OBWriteInternationalStandingOrderConsentResponse7DataInitiationDebtorAccount debtorAccount = default(OBWriteInternationalStandingOrderConsentResponse7DataInitiationDebtorAccount), OBWriteInternationalStandingOrderConsentResponse7DataInitiationCreditor creditor = default(OBWriteInternationalStandingOrderConsentResponse7DataInitiationCreditor), OBWriteInternationalStandingOrderConsentResponse7DataInitiationCreditorAgent creditorAgent = default(OBWriteInternationalStandingOrderConsentResponse7DataInitiationCreditorAgent), IDictionary<string, object> supplementaryData = default(IDictionary<string, object>))
        {
            Frequency = frequency;
            Reference = reference;
            NumberOfPayments = numberOfPayments;
            FirstPaymentDateTime = firstPaymentDateTime;
            FinalPaymentDateTime = finalPaymentDateTime;
            Purpose = purpose;
            ExtendedPurpose = extendedPurpose;
            ChargeBearer = chargeBearer;
            CurrencyOfTransfer = currencyOfTransfer;
            DestinationCountryCode = destinationCountryCode;
            InstructedAmount = instructedAmount;
            DebtorAccount = debtorAccount;
            Creditor = creditor;
            CreditorAgent = creditorAgent;
            CreditorAccount = creditorAccount;
            SupplementaryData = supplementaryData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets individual Definitions:
        /// EvryDay - Every day
        /// EvryWorkgDay - Every working day
        /// IntrvlWkDay - An interval specified in weeks (01 to 09), and the
        /// day within the week (01 to 07)
        /// WkInMnthDay - A monthly interval, specifying the week of the month
        /// (01 to 05) and day within the week (01 to 07)
        /// IntrvlMnthDay - An interval specified in months (between 01 to 06,
        /// 12, 24), specifying the day within the month (-5 to -1, 1 to 31)
        /// QtrDay - Quarterly (either ENGLISH, SCOTTISH, or RECEIVED).
        /// ENGLISH = Paid on the 25th March, 24th June, 29th September and
        /// 25th December.
        /// SCOTTISH = Paid on the 2nd February, 15th May, 1st August and 11th
        /// November.
        /// RECEIVED = Paid on the 20th March, 19th June, 24th September and
        /// 20th December.
        /// Individual Patterns:
        /// EvryDay (ScheduleCode)
        /// EvryWorkgDay (ScheduleCode)
        /// IntrvlWkDay:IntervalInWeeks:DayInWeek (ScheduleCode +
        /// IntervalInWeeks + DayInWeek)
        /// WkInMnthDay:WeekInMonth:DayInWeek (ScheduleCode + WeekInMonth +
        /// DayInWeek)
        /// IntrvlMnthDay:IntervalInMonths:DayInMonth (ScheduleCode +
        /// IntervalInMonths + DayInMonth)
        /// QtrDay: + either (ENGLISH, SCOTTISH or RECEIVED) ScheduleCode +
        /// QuarterDay
        /// The regular expression for this element combines five smaller
        /// versions for each permitted pattern. To aid legibility - the
        /// components are presented individually here:
        /// EvryDay
        /// EvryWorkgDay
        /// IntrvlWkDay:0[1-9]:0[1-7]
        /// WkInMnthDay:0[1-5]:0[1-7]
        /// IntrvlMnthDay:(0[1-6]|12|24):(-0[1-5]|0[1-9]|[12][0-9]|3[01])
        /// QtrDay:(ENGLISH|SCOTTISH|RECEIVED)
        /// Full Regular Expression:
        /// ^(EvryDay)$|^(EvryWorkgDay)$|^(IntrvlWkDay:0[1-9]:0[1-7])$|^(WkInMnthDay:0[1-5]:0[1-7])$|^(IntrvlMnthDay:(0[1-6]|12|24):(-0[1-5]|0[1-9]|[12][0-9]|3[01]))$|^(QtrDay:(ENGLISH|SCOTTISH|RECEIVED))$
        /// </summary>
        [JsonProperty(PropertyName = "Frequency")]
        public string Frequency { get; set; }

        /// <summary>
        /// Gets or sets unique reference, as assigned by the creditor, to
        /// unambiguously refer to the payment transaction.
        /// Usage: If available, the initiating party should provide this
        /// reference in the structured remittance information, to enable
        /// reconciliation by the creditor upon receipt of the amount of money.
        /// If the business context requires the use of a creditor reference or
        /// a payment remit identification, and only one identifier can be
        /// passed through the end-to-end chain, the creditor's reference or
        /// payment remittance identification should be quoted in the
        /// end-to-end transaction identification.
        /// </summary>
        [JsonProperty(PropertyName = "Reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets number of the payments that will be made in completing
        /// this frequency sequence including any executed since the sequence
        /// start date.
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfPayments")]
        public string NumberOfPayments { get; set; }

        /// <summary>
        /// Gets or sets the date on which the first payment for a Standing
        /// Order schedule will be made.All dates in the JSON payloads are
        /// represented in ISO 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00
        /// </summary>
        [JsonProperty(PropertyName = "FirstPaymentDateTime")]
        public System.DateTimeOffset FirstPaymentDateTime { get; set; }

        /// <summary>
        /// Gets or sets the date on which the final payment for a Standing
        /// Order schedule will be made.All dates in the JSON payloads are
        /// represented in ISO 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00
        /// </summary>
        [JsonProperty(PropertyName = "FinalPaymentDateTime")]
        public System.DateTimeOffset? FinalPaymentDateTime { get; set; }

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
        public OBWriteInternationalStandingOrderConsentResponse7DataInitiationInstructedAmount InstructedAmount { get; set; }

        /// <summary>
        /// Gets or sets provides the details to identify the debtor account.
        /// </summary>
        [JsonProperty(PropertyName = "DebtorAccount")]
        public OBWriteInternationalStandingOrderConsentResponse7DataInitiationDebtorAccount DebtorAccount { get; set; }

        /// <summary>
        /// Gets or sets party to which an amount of money is due.
        /// </summary>
        [JsonProperty(PropertyName = "Creditor")]
        public OBWriteInternationalStandingOrderConsentResponse7DataInitiationCreditor Creditor { get; set; }

        /// <summary>
        /// Gets or sets party that manages the account on behalf of the
        /// account owner, that is manages the registration and booking of
        /// entries on the account, calculates balances on the account and
        /// provides information about the account.
        /// This is the servicer of the beneficiary account.
        /// </summary>
        [JsonProperty(PropertyName = "CreditorAgent")]
        public OBWriteInternationalStandingOrderConsentResponse7DataInitiationCreditorAgent CreditorAgent { get; set; }

        /// <summary>
        /// Gets or sets provides the details to identify the beneficiary
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "CreditorAccount")]
        public OBWriteInternationalStandingOrderConsentResponse7DataInitiationCreditorAccount CreditorAccount { get; set; }

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
            if (Frequency == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Frequency");
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
