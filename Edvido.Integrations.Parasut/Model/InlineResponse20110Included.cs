
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
    /// InlineResponse20110Included
    /// </summary>
    [DataContract]
    public partial class InlineResponse20110Included :  IEquatable<InlineResponse20110Included>, IValidatableObject
    {
        /// <summary>
        /// Type of the resource
        /// </summary>
        /// <value>Type of the resource</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Employees for "employees"
            /// </summary>
            [EnumMember(Value = "employees")]
            Employees,
            
            /// <summary>
            /// Enum Itemcategories for "item_categories"
            /// </summary>
            [EnumMember(Value = "item_categories")]
            Itemcategories,
            
            /// <summary>
            /// Enum Tags for "tags"
            /// </summary>
            [EnumMember(Value = "tags")]
            Tags
        }

        /// <summary>
        /// Type of the resource
        /// </summary>
        /// <value>Type of the resource</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20110Included" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Type">Type of the resource.</param>
        /// <param name="Meta">Meta.</param>
        /// <param name="Attributes">Attributes.</param>
        /// <param name="Relationships">Relationships.</param>
        public InlineResponse20110Included(string Id = default(string), TypeEnum? Type = default(TypeEnum?), InlineResponse200Meta Meta = default(InlineResponse200Meta), Object Attributes = default(Object), Object Relationships = default(Object))
        {
            this.Id = Id;
            this.Type = Type;
            this.Meta = Meta;
            this.Attributes = Attributes;
            this.Relationships = Relationships;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public InlineResponse200Meta Meta { get; set; }
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }
        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [DataMember(Name="relationships", EmitDefaultValue=false)]
        public Object Relationships { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20110Included {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(obj as InlineResponse20110Included);
        }

        /// <summary>
        /// Returns true if InlineResponse20110Included instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20110Included to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20110Included other)
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
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
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
