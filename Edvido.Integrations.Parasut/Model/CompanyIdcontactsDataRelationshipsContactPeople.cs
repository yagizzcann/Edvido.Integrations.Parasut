
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
    /// CompanyIdcontactsDataRelationshipsContactPeople
    /// </summary>
    [DataContract]
    public partial class CompanyIdcontactsDataRelationshipsContactPeople :  IEquatable<CompanyIdcontactsDataRelationshipsContactPeople>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIdcontactsDataRelationshipsContactPeople" /> class.
        /// </summary>
        /// <param name="Data">Data.</param>
        public CompanyIdcontactsDataRelationshipsContactPeople(List<CompanyIdcontactsDataRelationshipsContactPeopleData> Data = default(List<CompanyIdcontactsDataRelationshipsContactPeopleData>))
        {
            this.Data = Data;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<CompanyIdcontactsDataRelationshipsContactPeopleData> Data { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyIdcontactsDataRelationshipsContactPeople {\n");
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
            return this.Equals(obj as CompanyIdcontactsDataRelationshipsContactPeople);
        }

        /// <summary>
        /// Returns true if CompanyIdcontactsDataRelationshipsContactPeople instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyIdcontactsDataRelationshipsContactPeople to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyIdcontactsDataRelationshipsContactPeople other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
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
