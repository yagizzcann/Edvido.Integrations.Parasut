
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// InlineResponse2019DataRelationships
    /// </summary>
    [DataContract]
    public partial class InlineResponse2019DataRelationships :  IEquatable<InlineResponse2019DataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2019DataRelationships" /> class.
        /// </summary>
        /// <param name="Category">Category.</param>
        /// <param name="Spender">Spender.</param>
        /// <param name="Supplier">Supplier.</param>
        /// <param name="Payments">Payments.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="RecurrencePlan">RecurrencePlan.</param>
        /// <param name="ActiveEDocument">ActiveEDocument.</param>
        public InlineResponse2019DataRelationships(CompanyIdbankFeesDataRelationshipsCategory Category = default(CompanyIdbankFeesDataRelationshipsCategory), CompanyIdpurchaseBillsbasicDataRelationshipsPaidByEmployee Spender = default(CompanyIdpurchaseBillsbasicDataRelationshipsPaidByEmployee), CompanyIdpurchaseBillsbasicDataRelationshipsSupplier Supplier = default(CompanyIdpurchaseBillsbasicDataRelationshipsSupplier), InlineResponse2014DataRelationshipsPayments Payments = default(InlineResponse2014DataRelationshipsPayments), CompanyIdbankFeesDataRelationshipsTags Tags = default(CompanyIdbankFeesDataRelationshipsTags), InlineResponse2019DataRelationshipsRecurrencePlan RecurrencePlan = default(InlineResponse2019DataRelationshipsRecurrencePlan), InlineResponse2019DataRelationshipsActiveEDocument ActiveEDocument = default(InlineResponse2019DataRelationshipsActiveEDocument))
        {
            this.Category = Category;
            this.Spender = Spender;
            this.Supplier = Supplier;
            this.Payments = Payments;
            this.Tags = Tags;
            this.RecurrencePlan = RecurrencePlan;
            this.ActiveEDocument = ActiveEDocument;
        }
        
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CompanyIdbankFeesDataRelationshipsCategory Category { get; set; }
        /// <summary>
        /// Gets or Sets Spender
        /// </summary>
        [DataMember(Name="spender", EmitDefaultValue=false)]
        public CompanyIdpurchaseBillsbasicDataRelationshipsPaidByEmployee Spender { get; set; }
        /// <summary>
        /// Gets or Sets Supplier
        /// </summary>
        [DataMember(Name="supplier", EmitDefaultValue=false)]
        public CompanyIdpurchaseBillsbasicDataRelationshipsSupplier Supplier { get; set; }
        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name="payments", EmitDefaultValue=false)]
        public InlineResponse2014DataRelationshipsPayments Payments { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public CompanyIdbankFeesDataRelationshipsTags Tags { get; set; }
        /// <summary>
        /// Gets or Sets RecurrencePlan
        /// </summary>
        [DataMember(Name="recurrence_plan", EmitDefaultValue=false)]
        public InlineResponse2019DataRelationshipsRecurrencePlan RecurrencePlan { get; set; }
        /// <summary>
        /// Gets or Sets ActiveEDocument
        /// </summary>
        [DataMember(Name="active_e_document", EmitDefaultValue=false)]
        public InlineResponse2019DataRelationshipsActiveEDocument ActiveEDocument { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2019DataRelationships {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Spender: ").Append(Spender).Append("\n");
            sb.Append("  Supplier: ").Append(Supplier).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  RecurrencePlan: ").Append(RecurrencePlan).Append("\n");
            sb.Append("  ActiveEDocument: ").Append(ActiveEDocument).Append("\n");
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
            return this.Equals(obj as InlineResponse2019DataRelationships);
        }

        /// <summary>
        /// Returns true if InlineResponse2019DataRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2019DataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2019DataRelationships other)
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
                    this.Spender == other.Spender ||
                    this.Spender != null &&
                    this.Spender.Equals(other.Spender)
                ) && 
                (
                    this.Supplier == other.Supplier ||
                    this.Supplier != null &&
                    this.Supplier.Equals(other.Supplier)
                ) && 
                (
                    this.Payments == other.Payments ||
                    this.Payments != null &&
                    this.Payments.Equals(other.Payments)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
                ) && 
                (
                    this.RecurrencePlan == other.RecurrencePlan ||
                    this.RecurrencePlan != null &&
                    this.RecurrencePlan.Equals(other.RecurrencePlan)
                ) && 
                (
                    this.ActiveEDocument == other.ActiveEDocument ||
                    this.ActiveEDocument != null &&
                    this.ActiveEDocument.Equals(other.ActiveEDocument)
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
                if (this.Spender != null)
                    hash = hash * 59 + this.Spender.GetHashCode();
                if (this.Supplier != null)
                    hash = hash * 59 + this.Supplier.GetHashCode();
                if (this.Payments != null)
                    hash = hash * 59 + this.Payments.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.RecurrencePlan != null)
                    hash = hash * 59 + this.RecurrencePlan.GetHashCode();
                if (this.ActiveEDocument != null)
                    hash = hash * 59 + this.ActiveEDocument.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
