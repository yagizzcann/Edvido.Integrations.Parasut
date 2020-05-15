
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// InlineResponse2014DataRelationships
    /// </summary>
    [DataContract]
    public partial class InlineResponse2014DataRelationships :  IEquatable<InlineResponse2014DataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2014DataRelationships" /> class.
        /// </summary>
        /// <param name="DebitAccount">DebitAccount.</param>
        /// <param name="CreditAccount">CreditAccount.</param>
        /// <param name="Payments">Payments.</param>
        public InlineResponse2014DataRelationships(InlineResponse2014DataRelationshipsDebitAccount DebitAccount = default(InlineResponse2014DataRelationshipsDebitAccount), InlineResponse2014DataRelationshipsDebitAccount CreditAccount = default(InlineResponse2014DataRelationshipsDebitAccount), InlineResponse2014DataRelationshipsPayments Payments = default(InlineResponse2014DataRelationshipsPayments))
        {
            this.DebitAccount = DebitAccount;
            this.CreditAccount = CreditAccount;
            this.Payments = Payments;
        }
        
        /// <summary>
        /// Gets or Sets DebitAccount
        /// </summary>
        [DataMember(Name="debit_account", EmitDefaultValue=false)]
        public InlineResponse2014DataRelationshipsDebitAccount DebitAccount { get; set; }
        /// <summary>
        /// Gets or Sets CreditAccount
        /// </summary>
        [DataMember(Name="credit_account", EmitDefaultValue=false)]
        public InlineResponse2014DataRelationshipsDebitAccount CreditAccount { get; set; }
        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name="payments", EmitDefaultValue=false)]
        public InlineResponse2014DataRelationshipsPayments Payments { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2014DataRelationships {\n");
            sb.Append("  DebitAccount: ").Append(DebitAccount).Append("\n");
            sb.Append("  CreditAccount: ").Append(CreditAccount).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InlineResponse2014DataRelationships);
        }

        /// <summary>
        /// Returns true if InlineResponse2014DataRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2014DataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2014DataRelationships other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DebitAccount == other.DebitAccount ||
                    this.DebitAccount != null &&
                    this.DebitAccount.Equals(other.DebitAccount)
                ) && 
                (
                    this.CreditAccount == other.CreditAccount ||
                    this.CreditAccount != null &&
                    this.CreditAccount.Equals(other.CreditAccount)
                ) && 
                (
                    this.Payments == other.Payments ||
                    this.Payments != null &&
                    this.Payments.Equals(other.Payments)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.DebitAccount != null)
                    hash = hash * 59 + this.DebitAccount.GetHashCode();
                if (this.CreditAccount != null)
                    hash = hash * 59 + this.CreditAccount.GetHashCode();
                if (this.Payments != null)
                    hash = hash * 59 + this.Payments.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
