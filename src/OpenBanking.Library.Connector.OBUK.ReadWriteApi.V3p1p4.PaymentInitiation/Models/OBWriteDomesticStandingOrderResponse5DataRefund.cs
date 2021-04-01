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
    /// Unambiguous identification of the refund account to which a refund will
    /// be made as a result of the transaction.
    /// </summary>
    public partial class OBWriteDomesticStandingOrderResponse5DataRefund
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteDomesticStandingOrderResponse5DataRefund class.
        /// </summary>
        public OBWriteDomesticStandingOrderResponse5DataRefund()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteDomesticStandingOrderResponse5DataRefund class.
        /// </summary>
        /// <param name="account">Provides the details to identify an
        /// account.</param>
        public OBWriteDomesticStandingOrderResponse5DataRefund(OBWriteDomesticStandingOrderResponse5DataRefundAccount account)
        {
            Account = account;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets provides the details to identify an account.
        /// </summary>
        [JsonProperty(PropertyName = "Account")]
        public OBWriteDomesticStandingOrderResponse5DataRefundAccount Account { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Account == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Account");
            }
            if (Account != null)
            {
                Account.Validate();
            }
        }
    }
}