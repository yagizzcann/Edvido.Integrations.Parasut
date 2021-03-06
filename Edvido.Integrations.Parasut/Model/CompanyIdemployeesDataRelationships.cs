
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
    /// CompanyIdemployeesDataRelationships
    /// </summary>
    [DataContract]
    public partial class CompanyIdemployeesDataRelationships :  IEquatable<CompanyIdemployeesDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIdemployeesDataRelationships" /> class.
        /// </summary>
        /// <param name="Category">Category.</param>
        public CompanyIdemployeesDataRelationships(CompanyIdbankFeesDataRelationshipsCategory Category = default(CompanyIdbankFeesDataRelationshipsCategory))
        {
            this.Category = Category;
        }
        
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CompanyIdbankFeesDataRelationshipsCategory Category { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyIdemployeesDataRelationships {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(obj as CompanyIdemployeesDataRelationships);
        }

        /// <summary>
        /// Returns true if CompanyIdemployeesDataRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyIdemployeesDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyIdemployeesDataRelationships other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
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
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
