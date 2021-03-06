
namespace Edvido.Integrations.Parasut.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    /// <summary>
    /// BankFee.
    /// </summary>
    [DataContract]
    public partial class BankFee : IEquatable<BankFee>, IValidatableObject
    {
        /// <summary>
        /// Type of the resource
        /// </summary>
        /// <value>Type of the resource</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Fees for "bank_fees"
            /// </summary>
            [EnumMember(Value = "bank_fees")]
            Fees
        }

        /// <summary>
        /// Gets or sets the Type
        /// Type of the resource.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankFee"/> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Type">Type of the resource.</param>
        /// <param name="Meta">Meta.</param>
        /// <param name="Attributes">Attributes.</param>
        /// <param name="Relationships">Relationships.</param>
        public BankFee(string Id = default(string), TypeEnum? Type = default(TypeEnum?), InlineResponse200Meta Meta = default(InlineResponse200Meta), CompanyIdbankFeesDataAttributes Attributes = default(CompanyIdbankFeesDataAttributes), CompanyIdbankFeesDataRelationships Relationships = default(CompanyIdbankFeesDataRelationships))
        {
            this.Id = Id;
            this.Type = Type;
            this.Meta = Meta;
            this.Attributes = Attributes;
            this.Relationships = Relationships;
        }

        /// <summary>
        /// Gets or sets the Id
        /// Gets or Sets Id.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Meta
        /// Gets or Sets Meta.
        /// </summary>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public InlineResponse200Meta Meta { get; set; }

        /// <summary>
        /// Gets or sets the Attributes
        /// Gets or Sets Attributes.
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public CompanyIdbankFeesDataAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets the Relationships
        /// Gets or Sets Relationships.
        /// </summary>
        [DataMember(Name = "relationships", EmitDefaultValue = false)]
        public CompanyIdbankFeesDataRelationships Relationships { get; set; }

        /// <summary>
        /// Returns the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankFee {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="obj">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BankFee);
        }

        /// <summary>
        /// Returns true if BankFee instances are equal.
        /// </summary>
        /// <param name="other">Instance of BankFee to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(BankFee other)
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
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
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
        /// Gets the hash code.
        /// </summary>
        /// <returns>Hash code.</returns>
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
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                if (this.Relationships != null)
                    hash = hash * 59 + this.Relationships.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// The Validate.
        /// </summary>
        /// <param name="validationContext">The validationContext<see cref="ValidationContext"/>.</param>
        /// <returns>The <see cref="IEnumerable{ValidationResult}"/>.</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Id (string) maxLength
            if (this.Id != null && this.Id.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Id, length must be less than 255.", new[] { "Id" });
            }

            // Type (string) maxLength
            if (this.Type != null && this.Type.ToString().Length > 255)
            {
                yield return new ValidationResult("Invalid value for Type, length must be less than 255.", new[] { "Type" });
            }

            yield break;
        }
    }
}
