
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
    /// InlineResponse20010Relationships
    /// </summary>
    [DataContract]
    public partial class InlineResponse20010Relationships :  IEquatable<InlineResponse20010Relationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20010Relationships" /> class.
        /// </summary>
        /// <param name="Category">Category.</param>
        /// <param name="Contact">Contact.</param>
        /// <param name="Details">Details.</param>
        /// <param name="Payments">Payments.</param>
        /// <param name="PaymentsTx">PaymentsTx.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Sharings">Sharings.</param>
        /// <param name="RecurrencePlan">RecurrencePlan.</param>
        /// <param name="ActiveEDocument">ActiveEDocument.</param>
        public InlineResponse20010Relationships(CompanyIdbankFeesDataRelationshipsCategory Category = default(CompanyIdbankFeesDataRelationshipsCategory), CompanyIdpurchaseBillsbasicDataRelationshipsSupplier Contact = default(CompanyIdpurchaseBillsbasicDataRelationshipsSupplier), InlineResponse20010RelationshipsDetails Details = default(InlineResponse20010RelationshipsDetails), InlineResponse2014DataRelationshipsPayments Payments = default(InlineResponse2014DataRelationshipsPayments), InlineResponse20010RelationshipsPaymentsTx PaymentsTx = default(InlineResponse20010RelationshipsPaymentsTx), CompanyIdbankFeesDataRelationshipsTags Tags = default(CompanyIdbankFeesDataRelationshipsTags), InlineResponse20010RelationshipsSharings Sharings = default(InlineResponse20010RelationshipsSharings), InlineResponse2019DataRelationshipsRecurrencePlan RecurrencePlan = default(InlineResponse2019DataRelationshipsRecurrencePlan), InlineResponse20010RelationshipsActiveEDocument ActiveEDocument = default(InlineResponse20010RelationshipsActiveEDocument))
        {
            this.Category = Category;
            this.Contact = Contact;
            this.Details = Details;
            this.Payments = Payments;
            this.PaymentsTx = PaymentsTx;
            this.Tags = Tags;
            this.Sharings = Sharings;
            this.RecurrencePlan = RecurrencePlan;
            this.ActiveEDocument = ActiveEDocument;
        }
        
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CompanyIdbankFeesDataRelationshipsCategory Category { get; set; }
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public CompanyIdpurchaseBillsbasicDataRelationshipsSupplier Contact { get; set; }
        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public InlineResponse20010RelationshipsDetails Details { get; set; }
        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name="payments", EmitDefaultValue=false)]
        public InlineResponse2014DataRelationshipsPayments Payments { get; set; }
        /// <summary>
        /// Gets or Sets PaymentsTx
        /// </summary>
        [DataMember(Name="payments.tx", EmitDefaultValue=false)]
        public InlineResponse20010RelationshipsPaymentsTx PaymentsTx { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public CompanyIdbankFeesDataRelationshipsTags Tags { get; set; }
        /// <summary>
        /// Gets or Sets Sharings
        /// </summary>
        [DataMember(Name="sharings", EmitDefaultValue=false)]
        public InlineResponse20010RelationshipsSharings Sharings { get; set; }
        /// <summary>
        /// Gets or Sets RecurrencePlan
        /// </summary>
        [DataMember(Name="recurrence_plan", EmitDefaultValue=false)]
        public InlineResponse2019DataRelationshipsRecurrencePlan RecurrencePlan { get; set; }
        /// <summary>
        /// Gets or Sets ActiveEDocument
        /// </summary>
        [DataMember(Name="active_e_document", EmitDefaultValue=false)]
        public InlineResponse20010RelationshipsActiveEDocument ActiveEDocument { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20010Relationships {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  PaymentsTx: ").Append(PaymentsTx).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Sharings: ").Append(Sharings).Append("\n");
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
            return this.Equals(obj as InlineResponse20010Relationships);
        }

        /// <summary>
        /// Returns true if InlineResponse20010Relationships instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20010Relationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20010Relationships other)
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
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
                ) && 
                (
                    this.Payments == other.Payments ||
                    this.Payments != null &&
                    this.Payments.Equals(other.Payments)
                ) && 
                (
                    this.PaymentsTx == other.PaymentsTx ||
                    this.PaymentsTx != null &&
                    this.PaymentsTx.Equals(other.PaymentsTx)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
                ) && 
                (
                    this.Sharings == other.Sharings ||
                    this.Sharings != null &&
                    this.Sharings.Equals(other.Sharings)
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
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.Payments != null)
                    hash = hash * 59 + this.Payments.GetHashCode();
                if (this.PaymentsTx != null)
                    hash = hash * 59 + this.PaymentsTx.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.Sharings != null)
                    hash = hash * 59 + this.Sharings.GetHashCode();
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
