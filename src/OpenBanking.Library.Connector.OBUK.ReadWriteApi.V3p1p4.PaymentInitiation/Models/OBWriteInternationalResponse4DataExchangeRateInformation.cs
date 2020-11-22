// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace FinnovationLabs.OpenBanking.Library.Connector.OBUK.ReadWriteApi.V3p1p4.PaymentInitiation.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Further detailed information on the exchange rate that has been used in
    /// the payment transaction.
    /// </summary>
    public partial class OBWriteInternationalResponse4DataExchangeRateInformation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteInternationalResponse4DataExchangeRateInformation class.
        /// </summary>
        public OBWriteInternationalResponse4DataExchangeRateInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteInternationalResponse4DataExchangeRateInformation class.
        /// </summary>
        /// <param name="unitCurrency">Currency in which the rate of exchange
        /// is expressed in a currency exchange. In the example 1GBP = xxxCUR,
        /// the unit currency is GBP.</param>
        /// <param name="exchangeRate">The factor used for conversion of an
        /// amount from one currency to another. This reflects the price at
        /// which one currency was bought with another currency.</param>
        /// <param name="rateType">Specifies the type used to complete the
        /// currency exchange. Possible values include: 'Actual', 'Agreed',
        /// 'Indicative'</param>
        /// <param name="contractIdentification">Unique and unambiguous
        /// reference to the foreign exchange contract agreed between the
        /// initiating party/creditor and the debtor agent.</param>
        /// <param name="expirationDateTime">Specified date and time the
        /// exchange rate agreement will expire.All dates in the JSON payloads
        /// are represented in ISO 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00</param>
        public OBWriteInternationalResponse4DataExchangeRateInformation(string unitCurrency, double exchangeRate, OBWriteInternationalResponse4DataExchangeRateInformationRateTypeEnum rateType, string contractIdentification = default(string), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?))
        {
            UnitCurrency = unitCurrency;
            ExchangeRate = exchangeRate;
            RateType = rateType;
            ContractIdentification = contractIdentification;
            ExpirationDateTime = expirationDateTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets currency in which the rate of exchange is expressed in
        /// a currency exchange. In the example 1GBP = xxxCUR, the unit
        /// currency is GBP.
        /// </summary>
        [JsonProperty(PropertyName = "UnitCurrency")]
        public string UnitCurrency { get; set; }

        /// <summary>
        /// Gets or sets the factor used for conversion of an amount from one
        /// currency to another. This reflects the price at which one currency
        /// was bought with another currency.
        /// </summary>
        [JsonProperty(PropertyName = "ExchangeRate")]
        public double ExchangeRate { get; set; }

        /// <summary>
        /// Gets or sets specifies the type used to complete the currency
        /// exchange. Possible values include: 'Actual', 'Agreed', 'Indicative'
        /// </summary>
        [JsonProperty(PropertyName = "RateType")]
        public OBWriteInternationalResponse4DataExchangeRateInformationRateTypeEnum RateType { get; set; }

        /// <summary>
        /// Gets or sets unique and unambiguous reference to the foreign
        /// exchange contract agreed between the initiating party/creditor and
        /// the debtor agent.
        /// </summary>
        [JsonProperty(PropertyName = "ContractIdentification")]
        public string ContractIdentification { get; set; }

        /// <summary>
        /// Gets or sets specified date and time the exchange rate agreement
        /// will expire.All dates in the JSON payloads are represented in ISO
        /// 8601 date-time format.
        /// All date-time fields in responses must include the timezone. An
        /// example is below:
        /// 2017-04-05T10:43:07+00:00
        /// </summary>
        [JsonProperty(PropertyName = "ExpirationDateTime")]
        public System.DateTimeOffset? ExpirationDateTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UnitCurrency == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UnitCurrency");
            }
        }
    }
}
