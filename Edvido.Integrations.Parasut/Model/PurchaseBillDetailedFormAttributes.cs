
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// PurchaseBillDetailedFormAttributes
    /// </summary>
    [DataContract]
    public partial class PurchaseBillDetailedFormAttributes :  IEquatable<PurchaseBillDetailedFormAttributes>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ItemTypeEnum
        {
            
            /// <summary>
            /// Enum Purchasebill for "purchase_bill"
            /// </summary>
            [EnumMember(Value = "purchase_bill")]
            Purchasebill,
            
            /// <summary>
            /// Enum Refund for "refund"
            /// </summary>
            [EnumMember(Value = "refund")]
            Refund
        }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrencyEnum
        {
            
            /// <summary>
            /// Enum TRL for "TRL"
            /// </summary>
            [EnumMember(Value = "TRL")]
            TRL,
            
            /// <summary>
            /// Enum USD for "USD"
            /// </summary>
            [EnumMember(Value = "USD")]
            USD,
            
            /// <summary>
            /// Enum EUR for "EUR"
            /// </summary>
            [EnumMember(Value = "EUR")]
            EUR,
            
            /// <summary>
            /// Enum GBP for "GBP"
            /// </summary>
            [EnumMember(Value = "GBP")]
            GBP
        }

        /// <summary>
        /// Gets or Sets InvoiceDiscountType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InvoiceDiscountTypeEnum
        {
            
            /// <summary>
            /// Enum Percentage for "amount percentage"
            /// </summary>
            [EnumMember(Value = "amount percentage")]
            Percentage
        }

        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        [DataMember(Name="item_type", EmitDefaultValue=false)]
        public ItemTypeEnum? ItemType { get; set; }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CurrencyEnum? Currency { get; set; }
        /// <summary>
        /// Gets or Sets InvoiceDiscountType
        /// </summary>
        [DataMember(Name="invoice_discount_type", EmitDefaultValue=false)]
        public InvoiceDiscountTypeEnum? InvoiceDiscountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseBillDetailedFormAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PurchaseBillDetailedFormAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseBillDetailedFormAttributes" /> class.
        /// </summary>
        /// <param name="ItemType">ItemType (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="IssueDate">IssueDate (required).</param>
        /// <param name="DueDate">DueDate (required).</param>
        /// <param name="InvoiceNo">InvoiceNo.</param>
        /// <param name="Currency">Currency (required).</param>
        /// <param name="ExchangeRate">ExchangeRate.</param>
        /// <param name="WithholdingRate">WithholdingRate.</param>
        /// <param name="VatWithholdingRate">VatWithholdingRate.</param>
        /// <param name="InvoiceDiscount">InvoiceDiscount.</param>
        /// <param name="InvoiceDiscountType">InvoiceDiscountType.</param>
        public PurchaseBillDetailedFormAttributes(ItemTypeEnum? ItemType = default(ItemTypeEnum?), string Description = default(string), DateTime? IssueDate = default(DateTime?), DateTime? DueDate = default(DateTime?), string InvoiceNo = default(string), CurrencyEnum? Currency = default(CurrencyEnum?), decimal? ExchangeRate = default(decimal?), decimal? WithholdingRate = default(decimal?), decimal? VatWithholdingRate = default(decimal?), decimal? InvoiceDiscount = default(decimal?), InvoiceDiscountTypeEnum? InvoiceDiscountType = default(InvoiceDiscountTypeEnum?))
        {
            // to ensure "ItemType" is required (not null)
            if (ItemType == null)
            {
                throw new InvalidDataException("ItemType is a required property for PurchaseBillDetailedFormAttributes and cannot be null");
            }
            else
            {
                this.ItemType = ItemType;
            }
            // to ensure "IssueDate" is required (not null)
            if (IssueDate == null)
            {
                throw new InvalidDataException("IssueDate is a required property for PurchaseBillDetailedFormAttributes and cannot be null");
            }
            else
            {
                this.IssueDate = IssueDate;
            }
            // to ensure "DueDate" is required (not null)
            if (DueDate == null)
            {
                throw new InvalidDataException("DueDate is a required property for PurchaseBillDetailedFormAttributes and cannot be null");
            }
            else
            {
                this.DueDate = DueDate;
            }
            // to ensure "Currency" is required (not null)
            if (Currency == null)
            {
                throw new InvalidDataException("Currency is a required property for PurchaseBillDetailedFormAttributes and cannot be null");
            }
            else
            {
                this.Currency = Currency;
            }
            this.Description = Description;
            this.InvoiceNo = InvoiceNo;
            this.ExchangeRate = ExchangeRate;
            this.WithholdingRate = WithholdingRate;
            this.VatWithholdingRate = VatWithholdingRate;
            this.InvoiceDiscount = InvoiceDiscount;
            this.InvoiceDiscountType = InvoiceDiscountType;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets IssueDate
        /// </summary>
        [DataMember(Name="issue_date", EmitDefaultValue=false)]
        public DateTime? IssueDate { get; set; }
        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name="due_date", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// Gets or Sets InvoiceNo
        /// </summary>
        [DataMember(Name="invoice_no", EmitDefaultValue=false)]
        public string InvoiceNo { get; set; }
        /// <summary>
        /// Gets or Sets ExchangeRate
        /// </summary>
        [DataMember(Name="exchange_rate", EmitDefaultValue=false)]
        public decimal? ExchangeRate { get; set; }
        /// <summary>
        /// Gets or Sets WithholdingRate
        /// </summary>
        [DataMember(Name="withholding_rate", EmitDefaultValue=false)]
        public decimal? WithholdingRate { get; set; }
        /// <summary>
        /// Gets or Sets VatWithholdingRate
        /// </summary>
        [DataMember(Name="vat_withholding_rate", EmitDefaultValue=false)]
        public decimal? VatWithholdingRate { get; set; }
        /// <summary>
        /// Gets or Sets InvoiceDiscount
        /// </summary>
        [DataMember(Name="invoice_discount", EmitDefaultValue=false)]
        public decimal? InvoiceDiscount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseBillDetailedFormAttributes {\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  WithholdingRate: ").Append(WithholdingRate).Append("\n");
            sb.Append("  VatWithholdingRate: ").Append(VatWithholdingRate).Append("\n");
            sb.Append("  InvoiceDiscount: ").Append(InvoiceDiscount).Append("\n");
            sb.Append("  InvoiceDiscountType: ").Append(InvoiceDiscountType).Append("\n");
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
            return this.Equals(obj as PurchaseBillDetailedFormAttributes);
        }

        /// <summary>
        /// Returns true if PurchaseBillDetailedFormAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of PurchaseBillDetailedFormAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseBillDetailedFormAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ItemType == other.ItemType ||
                    this.ItemType != null &&
                    this.ItemType.Equals(other.ItemType)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.IssueDate == other.IssueDate ||
                    this.IssueDate != null &&
                    this.IssueDate.Equals(other.IssueDate)
                ) && 
                (
                    this.DueDate == other.DueDate ||
                    this.DueDate != null &&
                    this.DueDate.Equals(other.DueDate)
                ) && 
                (
                    this.InvoiceNo == other.InvoiceNo ||
                    this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(other.InvoiceNo)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.ExchangeRate == other.ExchangeRate ||
                    this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(other.ExchangeRate)
                ) && 
                (
                    this.WithholdingRate == other.WithholdingRate ||
                    this.WithholdingRate != null &&
                    this.WithholdingRate.Equals(other.WithholdingRate)
                ) && 
                (
                    this.VatWithholdingRate == other.VatWithholdingRate ||
                    this.VatWithholdingRate != null &&
                    this.VatWithholdingRate.Equals(other.VatWithholdingRate)
                ) && 
                (
                    this.InvoiceDiscount == other.InvoiceDiscount ||
                    this.InvoiceDiscount != null &&
                    this.InvoiceDiscount.Equals(other.InvoiceDiscount)
                ) && 
                (
                    this.InvoiceDiscountType == other.InvoiceDiscountType ||
                    this.InvoiceDiscountType != null &&
                    this.InvoiceDiscountType.Equals(other.InvoiceDiscountType)
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
                if (this.ItemType != null)
                    hash = hash * 59 + this.ItemType.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.IssueDate != null)
                    hash = hash * 59 + this.IssueDate.GetHashCode();
                if (this.DueDate != null)
                    hash = hash * 59 + this.DueDate.GetHashCode();
                if (this.InvoiceNo != null)
                    hash = hash * 59 + this.InvoiceNo.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.ExchangeRate != null)
                    hash = hash * 59 + this.ExchangeRate.GetHashCode();
                if (this.WithholdingRate != null)
                    hash = hash * 59 + this.WithholdingRate.GetHashCode();
                if (this.VatWithholdingRate != null)
                    hash = hash * 59 + this.VatWithholdingRate.GetHashCode();
                if (this.InvoiceDiscount != null)
                    hash = hash * 59 + this.InvoiceDiscount.GetHashCode();
                if (this.InvoiceDiscountType != null)
                    hash = hash * 59 + this.InvoiceDiscountType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
