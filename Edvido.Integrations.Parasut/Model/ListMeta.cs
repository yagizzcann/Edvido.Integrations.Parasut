
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// ListMeta
    /// </summary>
    [DataContract]
    public partial class ListMeta :  IEquatable<ListMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMeta" /> class.
        /// </summary>
        /// <param name="CurrentPage">CurrentPage.</param>
        /// <param name="TotalPages">TotalPages.</param>
        /// <param name="TotalCount">TotalCount.</param>
        public ListMeta(int? CurrentPage = default(int?), int? TotalPages = default(int?), int? TotalCount = default(int?))
        {
            this.CurrentPage = CurrentPage;
            this.TotalPages = TotalPages;
            this.TotalCount = TotalCount;
        }
        
        /// <summary>
        /// Gets or Sets CurrentPage
        /// </summary>
        [DataMember(Name="current_page", EmitDefaultValue=false)]
        public int? CurrentPage { get; set; }
        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="total_pages", EmitDefaultValue=false)]
        public int? TotalPages { get; set; }
        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMeta {\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(obj as ListMeta);
        }

        /// <summary>
        /// Returns true if ListMeta instances are equal
        /// </summary>
        /// <param name="other">Instance of ListMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListMeta other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrentPage == other.CurrentPage ||
                    this.CurrentPage != null &&
                    this.CurrentPage.Equals(other.CurrentPage)
                ) && 
                (
                    this.TotalPages == other.TotalPages ||
                    this.TotalPages != null &&
                    this.TotalPages.Equals(other.TotalPages)
                ) && 
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
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
                if (this.CurrentPage != null)
                    hash = hash * 59 + this.CurrentPage.GetHashCode();
                if (this.TotalPages != null)
                    hash = hash * 59 + this.TotalPages.GetHashCode();
                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
