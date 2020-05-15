

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
    /// CompanyIdpurchaseBillsbasicDataRelationships
    /// </summary>
    [DataContract]
    public partial class CompanyIdpurchaseBillsbasicDataRelationships :  IEquatable<CompanyIdpurchaseBillsbasicDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIdpurchaseBillsbasicDataRelationships" /> class.
        /// </summary>
        /// <param name="Supplier">Supplier.</param>
        /// <param name="PaidByEmployee">PaidByEmployee.</param>
        /// <param name="Category">Category.</param>
        /// <param name="Tags">Tags.</param>
        public CompanyIdpurchaseBillsbasicDataRelationships(CompanyIdpurchaseBillsbasicDataRelationshipsSupplier Supplier = default(CompanyIdpurchaseBillsbasicDataRelationshipsSupplier), CompanyIdpurchaseBillsbasicDataRelationshipsPaidByEmployee PaidByEmployee = default(CompanyIdpurchaseBillsbasicDataRelationshipsPaidByEmployee), CompanyIdbankFeesDataRelationshipsCategory Category = default(CompanyIdbankFeesDataRelationshipsCategory), CompanyIdbankFeesDataRelationshipsTags Tags = default(CompanyIdbankFeesDataRelationshipsTags))
        {
            this.Supplier = Supplier;
            this.PaidByEmployee = PaidByEmployee;
            this.Category = Category;
            this.Tags = Tags;
        }
        
        /// <summary>
        /// Gets or Sets Supplier
        /// </summary>
        [DataMember(Name="supplier", EmitDefaultValue=false)]
        public CompanyIdpurchaseBillsbasicDataRelationshipsSupplier Supplier { get; set; }
        /// <summary>
        /// Gets or Sets PaidByEmployee
        /// </summary>
        [DataMember(Name="paid_by_employee", EmitDefaultValue=false)]
        public CompanyIdpurchaseBillsbasicDataRelationshipsPaidByEmployee PaidByEmployee { get; set; }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CompanyIdbankFeesDataRelationshipsCategory Category { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public CompanyIdbankFeesDataRelationshipsTags Tags { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyIdpurchaseBillsbasicDataRelationships {\n");
            sb.Append("  Supplier: ").Append(Supplier).Append("\n");
            sb.Append("  PaidByEmployee: ").Append(PaidByEmployee).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(obj as CompanyIdpurchaseBillsbasicDataRelationships);
        }

        /// <summary>
        /// Returns true if CompanyIdpurchaseBillsbasicDataRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyIdpurchaseBillsbasicDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyIdpurchaseBillsbasicDataRelationships other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Supplier == other.Supplier ||
                    this.Supplier != null &&
                    this.Supplier.Equals(other.Supplier)
                ) && 
                (
                    this.PaidByEmployee == other.PaidByEmployee ||
                    this.PaidByEmployee != null &&
                    this.PaidByEmployee.Equals(other.PaidByEmployee)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
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
                if (this.Supplier != null)
                    hash = hash * 59 + this.Supplier.GetHashCode();
                if (this.PaidByEmployee != null)
                    hash = hash * 59 + this.PaidByEmployee.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
