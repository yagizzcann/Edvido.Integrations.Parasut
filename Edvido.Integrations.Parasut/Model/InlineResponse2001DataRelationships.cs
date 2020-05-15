
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// InlineResponse2001DataRelationships
    /// </summary>
    [DataContract]
    public partial class InlineResponse2001DataRelationships :  IEquatable<InlineResponse2001DataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2001DataRelationships" /> class.
        /// </summary>
        /// <param name="UserRoles">UserRoles.</param>
        /// <param name="Companies">Companies.</param>
        /// <param name="Profile">Profile.</param>
        public InlineResponse2001DataRelationships(InlineResponse2001DataRelationshipsUserRoles UserRoles = default(InlineResponse2001DataRelationshipsUserRoles), InlineResponse2001DataRelationshipsCompanies Companies = default(InlineResponse2001DataRelationshipsCompanies), InlineResponse2001DataRelationshipsProfile Profile = default(InlineResponse2001DataRelationshipsProfile))
        {
            this.UserRoles = UserRoles;
            this.Companies = Companies;
            this.Profile = Profile;
        }
        
        /// <summary>
        /// Gets or Sets UserRoles
        /// </summary>
        [DataMember(Name="user_roles", EmitDefaultValue=false)]
        public InlineResponse2001DataRelationshipsUserRoles UserRoles { get; set; }
        /// <summary>
        /// Gets or Sets Companies
        /// </summary>
        [DataMember(Name="companies", EmitDefaultValue=false)]
        public InlineResponse2001DataRelationshipsCompanies Companies { get; set; }
        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public InlineResponse2001DataRelationshipsProfile Profile { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2001DataRelationships {\n");
            sb.Append("  UserRoles: ").Append(UserRoles).Append("\n");
            sb.Append("  Companies: ").Append(Companies).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
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
            return this.Equals(obj as InlineResponse2001DataRelationships);
        }

        /// <summary>
        /// Returns true if InlineResponse2001DataRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2001DataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2001DataRelationships other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserRoles == other.UserRoles ||
                    this.UserRoles != null &&
                    this.UserRoles.Equals(other.UserRoles)
                ) && 
                (
                    this.Companies == other.Companies ||
                    this.Companies != null &&
                    this.Companies.Equals(other.Companies)
                ) && 
                (
                    this.Profile == other.Profile ||
                    this.Profile != null &&
                    this.Profile.Equals(other.Profile)
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
                if (this.UserRoles != null)
                    hash = hash * 59 + this.UserRoles.GetHashCode();
                if (this.Companies != null)
                    hash = hash * 59 + this.Companies.GetHashCode();
                if (this.Profile != null)
                    hash = hash * 59 + this.Profile.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
