

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// InlineResponse2008Relationships
    /// </summary>
    [DataContract]
    public partial class InlineResponse2008Relationships :  IEquatable<InlineResponse2008Relationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2008Relationships" /> class.
        /// </summary>
        /// <param name="ParentCategory">ParentCategory.</param>
        /// <param name="Subcategories">Subcategories.</param>
        public InlineResponse2008Relationships(CompanyIdbankFeesDataRelationshipsCategory ParentCategory = default(CompanyIdbankFeesDataRelationshipsCategory), InlineResponse2008RelationshipsSubcategories Subcategories = default(InlineResponse2008RelationshipsSubcategories))
        {
            this.ParentCategory = ParentCategory;
            this.Subcategories = Subcategories;
        }
        
        /// <summary>
        /// Gets or Sets ParentCategory
        /// </summary>
        [DataMember(Name="parent_category", EmitDefaultValue=false)]
        public CompanyIdbankFeesDataRelationshipsCategory ParentCategory { get; set; }
        /// <summary>
        /// Gets or Sets Subcategories
        /// </summary>
        [DataMember(Name="subcategories", EmitDefaultValue=false)]
        public InlineResponse2008RelationshipsSubcategories Subcategories { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2008Relationships {\n");
            sb.Append("  ParentCategory: ").Append(ParentCategory).Append("\n");
            sb.Append("  Subcategories: ").Append(Subcategories).Append("\n");
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
            return this.Equals(obj as InlineResponse2008Relationships);
        }

        /// <summary>
        /// Returns true if InlineResponse2008Relationships instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2008Relationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2008Relationships other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ParentCategory == other.ParentCategory ||
                    this.ParentCategory != null &&
                    this.ParentCategory.Equals(other.ParentCategory)
                ) && 
                (
                    this.Subcategories == other.Subcategories ||
                    this.Subcategories != null &&
                    this.Subcategories.Equals(other.Subcategories)
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
                if (this.ParentCategory != null)
                    hash = hash * 59 + this.ParentCategory.GetHashCode();
                if (this.Subcategories != null)
                    hash = hash * 59 + this.Subcategories.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
