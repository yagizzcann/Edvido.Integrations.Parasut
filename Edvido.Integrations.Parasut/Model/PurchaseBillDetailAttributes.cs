

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
    /// PurchaseBillDetailAttributes
    /// </summary>
    [DataContract]
    public partial class PurchaseBillDetailAttributes :  IEquatable<PurchaseBillDetailAttributes>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DiscountType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DiscountTypeEnum
        {
            
            /// <summary>
            /// Enum Percentage for "amount percentage"
            /// </summary>
            [EnumMember(Value = "amount percentage")]
            Percentage
        }

        /// <summary>
        /// Gets or Sets ExciseDutyType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExciseDutyTypeEnum
        {
            
            /// <summary>
            /// Enum Percentage for "amount percentage"
            /// </summary>
            [EnumMember(Value = "amount percentage")]
            Percentage
        }

        /// <summary>
        /// Gets or Sets DiscountType
        /// </summary>
        [DataMember(Name="discount_type", EmitDefaultValue=false)]
        public DiscountTypeEnum? DiscountType { get; set; }
        /// <summary>
        /// Gets or Sets ExciseDutyType
        /// </summary>
        [DataMember(Name="excise_duty_type", EmitDefaultValue=false)]
        public ExciseDutyTypeEnum? ExciseDutyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseBillDetailAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PurchaseBillDetailAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseBillDetailAttributes" /> class.
        /// </summary>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="UnitPrice">UnitPrice (required).</param>
        /// <param name="VatRate">VatRate (required).</param>
        /// <param name="DiscountType">DiscountType.</param>
        /// <param name="DiscountValue">DiscountValue.</param>
        /// <param name="ExciseDutyType">ExciseDutyType.</param>
        /// <param name="ExciseDutyValue">ExciseDutyValue.</param>
        /// <param name="CommunicationsTaxRate">CommunicationsTaxRate.</param>
        /// <param name="Description">Description.</param>
        public PurchaseBillDetailAttributes(decimal? Quantity = default(decimal?), decimal? UnitPrice = default(decimal?), decimal? VatRate = default(decimal?), DiscountTypeEnum? DiscountType = default(DiscountTypeEnum?), decimal? DiscountValue = default(decimal?), ExciseDutyTypeEnum? ExciseDutyType = default(ExciseDutyTypeEnum?), decimal? ExciseDutyValue = default(decimal?), decimal? CommunicationsTaxRate = default(decimal?), string Description = default(string))
        {
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for PurchaseBillDetailAttributes and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "UnitPrice" is required (not null)
            if (UnitPrice == null)
            {
                throw new InvalidDataException("UnitPrice is a required property for PurchaseBillDetailAttributes and cannot be null");
            }
            else
            {
                this.UnitPrice = UnitPrice;
            }
            // to ensure "VatRate" is required (not null)
            if (VatRate == null)
            {
                throw new InvalidDataException("VatRate is a required property for PurchaseBillDetailAttributes and cannot be null");
            }
            else
            {
                this.VatRate = VatRate;
            }
            this.DiscountType = DiscountType;
            this.DiscountValue = DiscountValue;
            this.ExciseDutyType = ExciseDutyType;
            this.ExciseDutyValue = ExciseDutyValue;
            this.CommunicationsTaxRate = CommunicationsTaxRate;
            this.Description = Description;
        }
        
        /// <summary>
        /// Gets or Sets NetTotal
        /// </summary>
        [DataMember(Name="net_total", EmitDefaultValue=false)]
        public decimal? NetTotal { get; private set; }
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="unit_price", EmitDefaultValue=false)]
        public decimal? UnitPrice { get; set; }
        /// <summary>
        /// Gets or Sets VatRate
        /// </summary>
        [DataMember(Name="vat_rate", EmitDefaultValue=false)]
        public decimal? VatRate { get; set; }
        /// <summary>
        /// Gets or Sets DiscountValue
        /// </summary>
        [DataMember(Name="discount_value", EmitDefaultValue=false)]
        public decimal? DiscountValue { get; set; }
        /// <summary>
        /// Gets or Sets ExciseDutyValue
        /// </summary>
        [DataMember(Name="excise_duty_value", EmitDefaultValue=false)]
        public decimal? ExciseDutyValue { get; set; }
        /// <summary>
        /// Gets or Sets CommunicationsTaxRate
        /// </summary>
        [DataMember(Name="communications_tax_rate", EmitDefaultValue=false)]
        public decimal? CommunicationsTaxRate { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseBillDetailAttributes {\n");
            sb.Append("  NetTotal: ").Append(NetTotal).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  VatRate: ").Append(VatRate).Append("\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
            sb.Append("  DiscountValue: ").Append(DiscountValue).Append("\n");
            sb.Append("  ExciseDutyType: ").Append(ExciseDutyType).Append("\n");
            sb.Append("  ExciseDutyValue: ").Append(ExciseDutyValue).Append("\n");
            sb.Append("  CommunicationsTaxRate: ").Append(CommunicationsTaxRate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as PurchaseBillDetailAttributes);
        }

        /// <summary>
        /// Returns true if PurchaseBillDetailAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of PurchaseBillDetailAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseBillDetailAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NetTotal == other.NetTotal ||
                    this.NetTotal != null &&
                    this.NetTotal.Equals(other.NetTotal)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.UnitPrice == other.UnitPrice ||
                    this.UnitPrice != null &&
                    this.UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    this.VatRate == other.VatRate ||
                    this.VatRate != null &&
                    this.VatRate.Equals(other.VatRate)
                ) && 
                (
                    this.DiscountType == other.DiscountType ||
                    this.DiscountType != null &&
                    this.DiscountType.Equals(other.DiscountType)
                ) && 
                (
                    this.DiscountValue == other.DiscountValue ||
                    this.DiscountValue != null &&
                    this.DiscountValue.Equals(other.DiscountValue)
                ) && 
                (
                    this.ExciseDutyType == other.ExciseDutyType ||
                    this.ExciseDutyType != null &&
                    this.ExciseDutyType.Equals(other.ExciseDutyType)
                ) && 
                (
                    this.ExciseDutyValue == other.ExciseDutyValue ||
                    this.ExciseDutyValue != null &&
                    this.ExciseDutyValue.Equals(other.ExciseDutyValue)
                ) && 
                (
                    this.CommunicationsTaxRate == other.CommunicationsTaxRate ||
                    this.CommunicationsTaxRate != null &&
                    this.CommunicationsTaxRate.Equals(other.CommunicationsTaxRate)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.NetTotal != null)
                    hash = hash * 59 + this.NetTotal.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.UnitPrice != null)
                    hash = hash * 59 + this.UnitPrice.GetHashCode();
                if (this.VatRate != null)
                    hash = hash * 59 + this.VatRate.GetHashCode();
                if (this.DiscountType != null)
                    hash = hash * 59 + this.DiscountType.GetHashCode();
                if (this.DiscountValue != null)
                    hash = hash * 59 + this.DiscountValue.GetHashCode();
                if (this.ExciseDutyType != null)
                    hash = hash * 59 + this.ExciseDutyType.GetHashCode();
                if (this.ExciseDutyValue != null)
                    hash = hash * 59 + this.ExciseDutyValue.GetHashCode();
                if (this.CommunicationsTaxRate != null)
                    hash = hash * 59 + this.CommunicationsTaxRate.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
