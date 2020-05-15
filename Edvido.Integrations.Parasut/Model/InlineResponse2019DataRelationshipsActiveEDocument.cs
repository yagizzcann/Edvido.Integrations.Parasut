
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// InlineResponse2019DataRelationshipsActiveEDocument
    /// </summary>
    [DataContract]
    public partial class InlineResponse2019DataRelationshipsActiveEDocument :  IEquatable<InlineResponse2019DataRelationshipsActiveEDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2019DataRelationshipsActiveEDocument" /> class.
        /// </summary>
        /// <param name="Data">Data.</param>
        public InlineResponse2019DataRelationshipsActiveEDocument(InlineResponse2019DataRelationshipsActiveEDocumentData Data = default(InlineResponse2019DataRelationshipsActiveEDocumentData))
        {
            this.Data = Data;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public InlineResponse2019DataRelationshipsActiveEDocumentData Data { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2019DataRelationshipsActiveEDocument {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(obj as InlineResponse2019DataRelationshipsActiveEDocument);
        }

        /// <summary>
        /// Returns true if InlineResponse2019DataRelationshipsActiveEDocument instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2019DataRelationshipsActiveEDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2019DataRelationshipsActiveEDocument other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
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
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
