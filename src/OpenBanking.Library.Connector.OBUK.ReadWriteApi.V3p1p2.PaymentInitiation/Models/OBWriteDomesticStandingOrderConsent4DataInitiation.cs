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

    /// <summary>
    /// The Initiation payload is sent by the initiating party to the ASPSP. It
    /// is used to request movement of funds from the debtor account to a
    /// creditor for a domestic standing order.
    /// </summary>
    public partial class OBWriteDomesticStandingOrderConsent4DataInitiation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteDomesticStandingOrderConsent4DataInitiation class.
        /// </summary>
        public OBWriteDomesticStandingOrderConsent4DataInitiation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteDomesticStandingOrderConsent4DataInitiation class.
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
        /// <param name="firstPaymentAmount">The amount of the first Standing
        /// Order</param>
        /// <param name="creditorAccount">Identification assigned by an
        /// institution to identify an account. This identification is known by
        /// the account owner.</param>
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
        /// <param name="recurringPaymentDateTime">The date on which the first
        /// recurring payment for a Standing Order schedule will be made.
        /// Usage: This must be populated only if the first recurring date is
        /// different to the first payment date.All dates in the JSON payloads
        /// are represented in ISO 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00</param>
        /// <param name="finalPaymentDateTime">The date on which the final
        /// payment for a Standing Order schedule will be made.All dates in the
        /// JSON payloads are represented in ISO 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00</param>
        /// <param name="recurringPaymentAmount">The amount of the recurring
        /// Standing Order</param>
        /// <param name="finalPaymentAmount">The amount of the final Standing
        /// Order</param>
        /// <param name="debtorAccount">Provides the details to identify the
        /// debtor account.</param>
        public OBWriteDomesticStandingOrderConsent4DataInitiation(string frequency, System.DateTimeOffset firstPaymentDateTime, OBWriteDomesticStandingOrderConsent4DataInitiationFirstPaymentAmount firstPaymentAmount, OBWriteDomesticStandingOrderConsent4DataInitiationCreditorAccount creditorAccount, string reference = default(string), string numberOfPayments = default(string), System.DateTimeOffset? recurringPaymentDateTime = default(System.DateTimeOffset?), System.DateTimeOffset? finalPaymentDateTime = default(System.DateTimeOffset?), OBWriteDomesticStandingOrderConsent4DataInitiationRecurringPaymentAmount recurringPaymentAmount = default(OBWriteDomesticStandingOrderConsent4DataInitiationRecurringPaymentAmount), OBWriteDomesticStandingOrderConsent4DataInitiationFinalPaymentAmount finalPaymentAmount = default(OBWriteDomesticStandingOrderConsent4DataInitiationFinalPaymentAmount), OBWriteDomesticStandingOrderConsent4DataInitiationDebtorAccount debtorAccount = default(OBWriteDomesticStandingOrderConsent4DataInitiationDebtorAccount), IDictionary<string, object> supplementaryData = default(IDictionary<string, object>))
        {
            Frequency = frequency;
            Reference = reference;
            NumberOfPayments = numberOfPayments;
            FirstPaymentDateTime = firstPaymentDateTime;
            RecurringPaymentDateTime = recurringPaymentDateTime;
            FinalPaymentDateTime = finalPaymentDateTime;
            FirstPaymentAmount = firstPaymentAmount;
            RecurringPaymentAmount = recurringPaymentAmount;
            FinalPaymentAmount = finalPaymentAmount;
            DebtorAccount = debtorAccount;
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
        /// Gets or sets the date on which the first recurring payment for a
        /// Standing Order schedule will be made.
        /// Usage: This must be populated only if the first recurring date is
        /// different to the first payment date.All dates in the JSON payloads
        /// are represented in ISO 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00
        /// </summary>
        [JsonProperty(PropertyName = "RecurringPaymentDateTime")]
        public System.DateTimeOffset? RecurringPaymentDateTime { get; set; }

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
        /// Gets or sets the amount of the first Standing Order
        /// </summary>
        [JsonProperty(PropertyName = "FirstPaymentAmount")]
        public OBWriteDomesticStandingOrderConsent4DataInitiationFirstPaymentAmount FirstPaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets the amount of the recurring Standing Order
        /// </summary>
        [JsonProperty(PropertyName = "RecurringPaymentAmount")]
        public OBWriteDomesticStandingOrderConsent4DataInitiationRecurringPaymentAmount RecurringPaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets the amount of the final Standing Order
        /// </summary>
        [JsonProperty(PropertyName = "FinalPaymentAmount")]
        public OBWriteDomesticStandingOrderConsent4DataInitiationFinalPaymentAmount FinalPaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets provides the details to identify the debtor account.
        /// </summary>
        [JsonProperty(PropertyName = "DebtorAccount")]
        public OBWriteDomesticStandingOrderConsent4DataInitiationDebtorAccount DebtorAccount { get; set; }

        /// <summary>
        /// Gets or sets identification assigned by an institution to identify
        /// an account. This identification is known by the account owner.
        /// </summary>
        [JsonProperty(PropertyName = "CreditorAccount")]
        public OBWriteDomesticStandingOrderConsent4DataInitiationCreditorAccount CreditorAccount { get; set; }

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
            if (FirstPaymentAmount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FirstPaymentAmount");
            }
            if (CreditorAccount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CreditorAccount");
            }
            if (FirstPaymentAmount != null)
            {
                FirstPaymentAmount.Validate();
            }
            if (RecurringPaymentAmount != null)
            {
                RecurringPaymentAmount.Validate();
            }
            if (FinalPaymentAmount != null)
            {
                FinalPaymentAmount.Validate();
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
