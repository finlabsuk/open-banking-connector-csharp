/* 
 * Payment Initiation API
 *
 * OpenAPI for Payment Initiation API Specification
 *
 * The version of the OpenAPI document: v3.1.4
 * Contact: ServiceDesk@openbanking.org.uk
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p4.Model
{
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [SourceApiEquivalent(typeof(ObModels.PaymentInitiation.V3p1p2.Model.OBWriteInternational2DataInitiationCreditor))]
    [TargetApiEquivalent(typeof(ObModels.PaymentInitiation.V3p1p2.Model.OBWriteInternational2DataInitiationCreditor))]
    [DataContract]
    public partial class OBWriteInternational3DataInitiationCreditor :  IEquatable<OBWriteInternational3DataInitiationCreditor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternational3DataInitiationCreditor" /> class.
        /// </summary>
        /// <param name="name">Name by which a party is known and which is usually used to identify that party..</param>
        /// <param name="postalAddress">postalAddress.</param>
        public OBWriteInternational3DataInitiationCreditor(string name = default(string), OBPostalAddress6 postalAddress = default(OBPostalAddress6))
        {
            this.Name = name;
            this.PostalAddress = postalAddress;
        }
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        /// <value>Name by which a party is known and which is usually used to identify that party.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PostalAddress
        /// </summary>
        [DataMember(Name="PostalAddress", EmitDefaultValue=false)]
        public OBPostalAddress6 PostalAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteInternational3DataInitiationCreditor {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OBWriteInternational3DataInitiationCreditor);
        }

        /// <summary>
        /// Returns true if OBWriteInternational3DataInitiationCreditor instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteInternational3DataInitiationCreditor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteInternational3DataInitiationCreditor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PostalAddress == input.PostalAddress ||
                    (this.PostalAddress != null &&
                    this.PostalAddress.Equals(input.PostalAddress))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PostalAddress != null)
                    hashCode = hashCode * 59 + this.PostalAddress.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 140)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 140.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}