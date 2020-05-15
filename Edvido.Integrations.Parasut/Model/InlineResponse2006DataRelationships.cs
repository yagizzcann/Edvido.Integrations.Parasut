
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// InlineResponse2006DataRelationships
    /// </summary>
    [DataContract]
    public partial class InlineResponse2006DataRelationships :  IEquatable<InlineResponse2006DataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2006DataRelationships" /> class.
        /// </summary>
        /// <param name="Invoice">Invoice.</param>
        public InlineResponse2006DataRelationships(InlineResponse2006DataRelationshipsInvoice Invoice = default(InlineResponse2006DataRelationshipsInvoice))
        {
            this.Invoice = Invoice;
        }
        
        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public InlineResponse2006DataRelationshipsInvoice Invoice { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2006DataRelationships {\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
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
            return this.Equals(obj as InlineResponse2006DataRelationships);
        }

        /// <summary>
        /// Returns true if InlineResponse2006DataRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2006DataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2006DataRelationships other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Invoice == other.Invoice ||
                    this.Invoice != null &&
                    this.Invoice.Equals(other.Invoice)
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
                if (this.Invoice != null)
                    hash = hash * 59 + this.Invoice.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
