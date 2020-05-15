
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// CompanyIdpurchaseBillsbasicData
    /// </summary>
    [DataContract]
    public partial class CompanyIdpurchaseBillsbasicData :  IEquatable<CompanyIdpurchaseBillsbasicData>, IValidatableObject
    {
        /// <summary>
        /// Type of the resource
        /// </summary>
        /// <value>Type of the resource</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Bills for "purchase_bills"
            /// </summary>
            [EnumMember(Value = "purchase_bills")]
            Bills
        }

        /// <summary>
        /// Type of the resource
        /// </summary>
        /// <value>Type of the resource</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIdpurchaseBillsbasicData" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Type">Type of the resource.</param>
        /// <param name="Attributes">Attributes.</param>
        /// <param name="Relationships">Relationships.</param>
        public CompanyIdpurchaseBillsbasicData(string Id = default(string), TypeEnum? Type = default(TypeEnum?), CompanyIdpurchaseBillsbasicDataAttributes Attributes = default(CompanyIdpurchaseBillsbasicDataAttributes), CompanyIdpurchaseBillsbasicDataRelationships Relationships = default(CompanyIdpurchaseBillsbasicDataRelationships))
        {
            this.Id = Id;
            this.Type = Type;
            this.Attributes = Attributes;
            this.Relationships = Relationships;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public CompanyIdpurchaseBillsbasicDataAttributes Attributes { get; set; }
        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [DataMember(Name="relationships", EmitDefaultValue=false)]
        public CompanyIdpurchaseBillsbasicDataRelationships Relationships { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyIdpurchaseBillsbasicData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
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
            return this.Equals(obj as CompanyIdpurchaseBillsbasicData);
        }

        /// <summary>
        /// Returns true if CompanyIdpurchaseBillsbasicData instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyIdpurchaseBillsbasicData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyIdpurchaseBillsbasicData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.Equals(other.Attributes)
                ) && 
                (
                    this.Relationships == other.Relationships ||
                    this.Relationships != null &&
                    this.Relationships.Equals(other.Relationships)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                if (this.Relationships != null)
                    hash = hash * 59 + this.Relationships.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Id, length must be less than 255.", new [] { "Id" });
            }

            // Type (string) maxLength
            if(this.Type != null && this.Type.ToString().Length > 255)
            {
                yield return new ValidationResult("Invalid value for Type, length must be less than 255.", new [] { "Type" });
            }

            yield break;
        }
    }

}
