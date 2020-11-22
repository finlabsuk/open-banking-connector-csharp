// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace FinnovationLabs.OpenBanking.Library.Connector.OBUK.ReadWriteApi.V3p1p6.PaymentInitiation.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items
    /// that the transfer is intended to settle, such as commercial invoices in
    /// an accounts' receivable system.
    /// </summary>
    public partial class OBWriteInternationalConsent5DataInitiationRemittanceInformation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteInternationalConsent5DataInitiationRemittanceInformation
        /// class.
        /// </summary>
        public OBWriteInternationalConsent5DataInitiationRemittanceInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OBWriteInternationalConsent5DataInitiationRemittanceInformation
        /// class.
        /// </summary>
        /// <param name="unstructured">Information supplied to enable the
        /// matching/reconciliation of an entry with the items that the payment
        /// is intended to settle, such as commercial invoices in an accounts'
        /// receivable system, in an unstructured form.</param>
        /// <param name="reference">Unique reference, as assigned by the
        /// creditor, to unambiguously refer to the payment transaction.
        /// Usage: If available, the initiating party should provide this
        /// reference in the structured remittance information, to enable
        /// reconciliation by the creditor upon receipt of the amount of money.
        /// If the business context requires the use of a creditor reference or
        /// a payment remit identification, and only one identifier can be
        /// passed through the end-to-end chain, the creditor's reference or
        /// payment remittance identification should be quoted in the
        /// end-to-end transaction identification.
        /// OB: The Faster Payments Scheme can only accept 18 characters for
        /// the ReferenceInformation field - which is where this ISO field will
        /// be mapped.</param>
        public OBWriteInternationalConsent5DataInitiationRemittanceInformation(string unstructured = default(string), string reference = default(string))
        {
            Unstructured = unstructured;
            Reference = reference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information supplied to enable the
        /// matching/reconciliation of an entry with the items that the payment
        /// is intended to settle, such as commercial invoices in an accounts'
        /// receivable system, in an unstructured form.
        /// </summary>
        [JsonProperty(PropertyName = "Unstructured")]
        public string Unstructured { get; set; }

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
        /// OB: The Faster Payments Scheme can only accept 18 characters for
        /// the ReferenceInformation field - which is where this ISO field will
        /// be mapped.
        /// </summary>
        [JsonProperty(PropertyName = "Reference")]
        public string Reference { get; set; }

    }
}
