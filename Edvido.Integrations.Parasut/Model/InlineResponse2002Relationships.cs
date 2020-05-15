
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// InlineResponse2002Relationships
    /// </summary>
    [DataContract]
    public partial class InlineResponse2002Relationships :  IEquatable<InlineResponse2002Relationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2002Relationships" /> class.
        /// </summary>
        /// <param name="Category">Category.</param>
        /// <param name="ContactPortal">ContactPortal.</param>
        /// <param name="ContactPeople">ContactPeople.</param>
        public InlineResponse2002Relationships(CompanyIdbankFeesDataRelationshipsCategory Category = default(CompanyIdbankFeesDataRelationshipsCategory), InlineResponse2002RelationshipsContactPortal ContactPortal = default(InlineResponse2002RelationshipsContactPortal), InlineResponse2002RelationshipsContactPeople ContactPeople = default(InlineResponse2002RelationshipsContactPeople))
        {
            this.Category = Category;
            this.ContactPortal = ContactPortal;
            this.ContactPeople = ContactPeople;
        }
        
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CompanyIdbankFeesDataRelationshipsCategory Category { get; set; }
        /// <summary>
        /// Gets or Sets ContactPortal
        /// </summary>
        [DataMember(Name="contact_portal", EmitDefaultValue=false)]
        public InlineResponse2002RelationshipsContactPortal ContactPortal { get; set; }
        /// <summary>
        /// Gets or Sets ContactPeople
        /// </summary>
        [DataMember(Name="contact_people", EmitDefaultValue=false)]
        public InlineResponse2002RelationshipsContactPeople ContactPeople { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2002Relationships {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ContactPortal: ").Append(ContactPortal).Append("\n");
            sb.Append("  ContactPeople: ").Append(ContactPeople).Append("\n");
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
            return this.Equals(obj as InlineResponse2002Relationships);
        }

        /// <summary>
        /// Returns true if InlineResponse2002Relationships instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2002Relationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2002Relationships other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.ContactPortal == other.ContactPortal ||
                    this.ContactPortal != null &&
                    this.ContactPortal.Equals(other.ContactPortal)
                ) && 
                (
                    this.ContactPeople == other.ContactPeople ||
                    this.ContactPeople != null &&
                    this.ContactPeople.Equals(other.ContactPeople)
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
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.ContactPortal != null)
                    hash = hash * 59 + this.ContactPortal.GetHashCode();
                if (this.ContactPeople != null)
                    hash = hash * 59 + this.ContactPeople.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
