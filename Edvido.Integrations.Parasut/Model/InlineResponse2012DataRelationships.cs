
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
    /// InlineResponse2012DataRelationships
    /// </summary>
    [DataContract]
    public partial class InlineResponse2012DataRelationships :  IEquatable<InlineResponse2012DataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2012DataRelationships" /> class.
        /// </summary>
        /// <param name="Payable">Payable.</param>
        /// <param name="Tx">Tx.</param>
        public InlineResponse2012DataRelationships(InlineResponse2012DataRelationshipsPayable Payable = default(InlineResponse2012DataRelationshipsPayable), InlineResponse2012DataRelationshipsTx Tx = default(InlineResponse2012DataRelationshipsTx))
        {
            this.Payable = Payable;
            this.Tx = Tx;
        }
        
        /// <summary>
        /// Gets or Sets Payable
        /// </summary>
        [DataMember(Name="payable", EmitDefaultValue=false)]
        public InlineResponse2012DataRelationshipsPayable Payable { get; set; }
        /// <summary>
        /// Gets or Sets Tx
        /// </summary>
        [DataMember(Name="tx", EmitDefaultValue=false)]
        public InlineResponse2012DataRelationshipsTx Tx { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2012DataRelationships {\n");
            sb.Append("  Payable: ").Append(Payable).Append("\n");
            sb.Append("  Tx: ").Append(Tx).Append("\n");
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
            return this.Equals(obj as InlineResponse2012DataRelationships);
        }

        /// <summary>
        /// Returns true if InlineResponse2012DataRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2012DataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2012DataRelationships other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Payable == other.Payable ||
                    this.Payable != null &&
                    this.Payable.Equals(other.Payable)
                ) && 
                (
                    this.Tx == other.Tx ||
                    this.Tx != null &&
                    this.Tx.Equals(other.Tx)
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
                if (this.Payable != null)
                    hash = hash * 59 + this.Payable.GetHashCode();
                if (this.Tx != null)
                    hash = hash * 59 + this.Tx.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
