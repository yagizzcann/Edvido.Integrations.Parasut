
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
    /// CompanyIdpurchaseBillsdetailedDataRelationshipsDetailsRelationships
    /// </summary>
    [DataContract]
    public partial class CompanyIdpurchaseBillsdetailedDataRelationshipsDetailsRelationships :  IEquatable<CompanyIdpurchaseBillsdetailedDataRelationshipsDetailsRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIdpurchaseBillsdetailedDataRelationshipsDetailsRelationships" /> class.
        /// </summary>
        /// <param name="Product">Product.</param>
        public CompanyIdpurchaseBillsdetailedDataRelationshipsDetailsRelationships(CompanyIdpurchaseBillsdetailedDataRelationshipsDetailsRelationshipsProduct Product = default(CompanyIdpurchaseBillsdetailedDataRelationshipsDetailsRelationshipsProduct))
        {
            this.Product = Product;
        }
        
        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public CompanyIdpurchaseBillsdetailedDataRelationshipsDetailsRelationshipsProduct Product { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyIdpurchaseBillsdetailedDataRelationshipsDetailsRelationships {\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
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
            return this.Equals(obj as CompanyIdpurchaseBillsdetailedDataRelationshipsDetailsRelationships);
        }

        /// <summary>
        /// Returns true if CompanyIdpurchaseBillsdetailedDataRelationshipsDetailsRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyIdpurchaseBillsdetailedDataRelationshipsDetailsRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyIdpurchaseBillsdetailedDataRelationshipsDetailsRelationships other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
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
                if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
