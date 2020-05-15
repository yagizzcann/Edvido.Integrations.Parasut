
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// InlineResponse2007Relationships
    /// </summary>
    [DataContract]
    public partial class InlineResponse2007Relationships :  IEquatable<InlineResponse2007Relationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2007Relationships" /> class.
        /// </summary>
        /// <param name="Category">Category.</param>
        /// <param name="ManagedByUser">ManagedByUser.</param>
        /// <param name="ManagedByUserRole">ManagedByUserRole.</param>
        public InlineResponse2007Relationships(CompanyIdbankFeesDataRelationshipsCategory Category = default(CompanyIdbankFeesDataRelationshipsCategory), InlineResponse2007RelationshipsManagedByUser ManagedByUser = default(InlineResponse2007RelationshipsManagedByUser), InlineResponse2007RelationshipsManagedByUserRole ManagedByUserRole = default(InlineResponse2007RelationshipsManagedByUserRole))
        {
            this.Category = Category;
            this.ManagedByUser = ManagedByUser;
            this.ManagedByUserRole = ManagedByUserRole;
        }
        
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CompanyIdbankFeesDataRelationshipsCategory Category { get; set; }
        /// <summary>
        /// Gets or Sets ManagedByUser
        /// </summary>
        [DataMember(Name="managed_by_user", EmitDefaultValue=false)]
        public InlineResponse2007RelationshipsManagedByUser ManagedByUser { get; set; }
        /// <summary>
        /// Gets or Sets ManagedByUserRole
        /// </summary>
        [DataMember(Name="managed_by_user_role", EmitDefaultValue=false)]
        public InlineResponse2007RelationshipsManagedByUserRole ManagedByUserRole { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2007Relationships {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ManagedByUser: ").Append(ManagedByUser).Append("\n");
            sb.Append("  ManagedByUserRole: ").Append(ManagedByUserRole).Append("\n");
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
            return this.Equals(obj as InlineResponse2007Relationships);
        }

        /// <summary>
        /// Returns true if InlineResponse2007Relationships instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2007Relationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2007Relationships other)
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
                    this.ManagedByUser == other.ManagedByUser ||
                    this.ManagedByUser != null &&
                    this.ManagedByUser.Equals(other.ManagedByUser)
                ) && 
                (
                    this.ManagedByUserRole == other.ManagedByUserRole ||
                    this.ManagedByUserRole != null &&
                    this.ManagedByUserRole.Equals(other.ManagedByUserRole)
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
                if (this.ManagedByUser != null)
                    hash = hash * 59 + this.ManagedByUser.GetHashCode();
                if (this.ManagedByUserRole != null)
                    hash = hash * 59 + this.ManagedByUserRole.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
