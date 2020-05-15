
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
    /// CompanyIdcontactsDataRelationships
    /// </summary>
    [DataContract]
    public partial class CompanyIdcontactsDataRelationships :  IEquatable<CompanyIdcontactsDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIdcontactsDataRelationships" /> class.
        /// </summary>
        /// <param name="Category">Category.</param>
        /// <param name="ContactPeople">ContactPeople.</param>
        public CompanyIdcontactsDataRelationships(CompanyIdbankFeesDataRelationshipsCategory Category = default(CompanyIdbankFeesDataRelationshipsCategory), CompanyIdcontactsDataRelationshipsContactPeople ContactPeople = default(CompanyIdcontactsDataRelationshipsContactPeople))
        {
            this.Category = Category;
            this.ContactPeople = ContactPeople;
        }
        
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CompanyIdbankFeesDataRelationshipsCategory Category { get; set; }
        /// <summary>
        /// Gets or Sets ContactPeople
        /// </summary>
        [DataMember(Name="contact_people", EmitDefaultValue=false)]
        public CompanyIdcontactsDataRelationshipsContactPeople ContactPeople { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyIdcontactsDataRelationships {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(obj as CompanyIdcontactsDataRelationships);
        }

        /// <summary>
        /// Returns true if CompanyIdcontactsDataRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyIdcontactsDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyIdcontactsDataRelationships other)
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
