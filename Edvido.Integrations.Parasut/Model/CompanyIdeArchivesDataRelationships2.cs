
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
    /// CompanyIdeArchivesDataRelationships
    /// </summary>
    [DataContract]
    public partial class CompanyIdeArchivesDataRelationships2 : IEquatable<CompanyIdeArchivesDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIdeArchivesDataRelationships" /> class.
        /// </summary>
        /// <param name="SalesInvoice">SalesInvoice.</param>
        public CompanyIdeArchivesDataRelationships2(CompanyIdeArchivesDataRelationshipsSalesInvoice SalesInvoice = default(CompanyIdeArchivesDataRelationshipsSalesInvoice))
        {
            this.SalesInvoice = SalesInvoice;
        }

        /// <summary>
        /// Gets or Sets SalesInvoice
        /// </summary>
        [DataMember(Name = "sales_invoice", EmitDefaultValue = false)]
        public CompanyIdeArchivesDataRelationshipsSalesInvoice SalesInvoice { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyIdeArchivesDataRelationships {\n");
            sb.Append("  SalesInvoice: ").Append(SalesInvoice).Append("\n");
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
            return this.Equals(obj as CompanyIdeArchivesDataRelationships);
        }

        /// <summary>
        /// Returns true if CompanyIdeArchivesDataRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyIdeArchivesDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyIdeArchivesDataRelationships other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.SalesInvoice == other.SalesInvoice ||
                    this.SalesInvoice != null &&
                    this.SalesInvoice.Equals(other.SalesInvoice)
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
                if (this.SalesInvoice != null)
                    hash = hash * 59 + this.SalesInvoice.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
