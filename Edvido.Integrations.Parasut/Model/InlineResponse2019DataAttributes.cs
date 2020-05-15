
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
    /// InlineResponse2019DataAttributes
    /// </summary>
    [DataContract]
    public partial class InlineResponse2019DataAttributes :  IEquatable<InlineResponse2019DataAttributes>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets PaymentStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentStatusEnum
        {
            
            /// <summary>
            /// Enum Paid for "paid"
            /// </summary>
            [EnumMember(Value = "paid")]
            Paid,
            
            /// <summary>
            /// Enum Overdue for "overdue"
            /// </summary>
            [EnumMember(Value = "overdue")]
            Overdue,
            
            /// <summary>
            /// Enum Unpaid for "unpaid"
            /// </summary>
            [EnumMember(Value = "unpaid")]
            Unpaid,
            
            /// <summary>
            /// Enum Partiallypaid for "partially_paid"
            /// </summary>
            [EnumMember(Value = "partially_paid")]
            Partiallypaid
        }

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
            /// Enum Cancelled for "cancelled"
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled,
            
            /// <summary>
            /// Enum Recurringpurchasebill for "recurring_purchase_bill"
            /// </summary>
            [EnumMember(Value = "recurring_purchase_bill")]
            Recurringpurchasebill,
            
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
        /// Gets or Sets PaymentStatus
        /// </summary>
        [DataMember(Name="payment_status", EmitDefaultValue=false)]
        public PaymentStatusEnum? PaymentStatus { get; set; }
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
        /// Initializes a new instance of the <see cref="InlineResponse2019DataAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2019DataAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2019DataAttributes" /> class.
        /// </summary>
        /// <param name="TotalVat">TotalVat (required).</param>
        /// <param name="ItemType">ItemType (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="IssueDate">IssueDate (required).</param>
        /// <param name="DueDate">DueDate (required).</param>
        /// <param name="InvoiceNo">InvoiceNo.</param>
        /// <param name="Currency">Currency (required).</param>
        /// <param name="ExchangeRate">ExchangeRate.</param>
        /// <param name="NetTotal">NetTotal (required).</param>
        /// <param name="WithholdingRate">WithholdingRate.</param>
        /// <param name="VatWithholdingRate">VatWithholdingRate.</param>
        /// <param name="InvoiceDiscountType">InvoiceDiscountType.</param>
        /// <param name="InvoiceDiscount">InvoiceDiscount.</param>
        public InlineResponse2019DataAttributes(decimal? TotalVat = default(decimal?), ItemTypeEnum? ItemType = default(ItemTypeEnum?), string Description = default(string), DateTime? IssueDate = default(DateTime?), DateTime? DueDate = default(DateTime?), string InvoiceNo = default(string), CurrencyEnum? Currency = default(CurrencyEnum?), decimal? ExchangeRate = default(decimal?), decimal? NetTotal = default(decimal?), decimal? WithholdingRate = default(decimal?), decimal? VatWithholdingRate = default(decimal?), InvoiceDiscountTypeEnum? InvoiceDiscountType = default(InvoiceDiscountTypeEnum?), decimal? InvoiceDiscount = default(decimal?))
        {
            // to ensure "TotalVat" is required (not null)
            if (TotalVat == null)
            {
                throw new InvalidDataException("TotalVat is a required property for InlineResponse2019DataAttributes and cannot be null");
            }
            else
            {
                this.TotalVat = TotalVat;
            }
            // to ensure "ItemType" is required (not null)
            if (ItemType == null)
            {
                throw new InvalidDataException("ItemType is a required property for InlineResponse2019DataAttributes and cannot be null");
            }
            else
            {
                this.ItemType = ItemType;
            }
            // to ensure "IssueDate" is required (not null)
            if (IssueDate == null)
            {
                throw new InvalidDataException("IssueDate is a required property for InlineResponse2019DataAttributes and cannot be null");
            }
            else
            {
                this.IssueDate = IssueDate;
            }
            // to ensure "DueDate" is required (not null)
            if (DueDate == null)
            {
                throw new InvalidDataException("DueDate is a required property for InlineResponse2019DataAttributes and cannot be null");
            }
            else
            {
                this.DueDate = DueDate;
            }
            // to ensure "Currency" is required (not null)
            if (Currency == null)
            {
                throw new InvalidDataException("Currency is a required property for InlineResponse2019DataAttributes and cannot be null");
            }
            else
            {
                this.Currency = Currency;
            }
            // to ensure "NetTotal" is required (not null)
            if (NetTotal == null)
            {
                throw new InvalidDataException("NetTotal is a required property for InlineResponse2019DataAttributes and cannot be null");
            }
            else
            {
                this.NetTotal = NetTotal;
            }
            this.Description = Description;
            this.InvoiceNo = InvoiceNo;
            this.ExchangeRate = ExchangeRate;
            this.WithholdingRate = WithholdingRate;
            this.VatWithholdingRate = VatWithholdingRate;
            this.InvoiceDiscountType = InvoiceDiscountType;
            this.InvoiceDiscount = InvoiceDiscount;
        }
        
        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [DataMember(Name="archived", EmitDefaultValue=false)]
        public bool? Archived { get; private set; }
        /// <summary>
        /// Gets or Sets TotalPaid
        /// </summary>
        [DataMember(Name="total_paid", EmitDefaultValue=false)]
        public decimal? TotalPaid { get; private set; }
        /// <summary>
        /// Gets or Sets GrossTotal
        /// </summary>
        [DataMember(Name="gross_total", EmitDefaultValue=false)]
        public decimal? GrossTotal { get; private set; }
        /// <summary>
        /// Gets or Sets TotalExciseDuty
        /// </summary>
        [DataMember(Name="total_excise_duty", EmitDefaultValue=false)]
        public decimal? TotalExciseDuty { get; private set; }
        /// <summary>
        /// Gets or Sets TotalCommunicationsTax
        /// </summary>
        [DataMember(Name="total_communications_tax", EmitDefaultValue=false)]
        public decimal? TotalCommunicationsTax { get; private set; }
        /// <summary>
        /// Gets or Sets TotalVat
        /// </summary>
        [DataMember(Name="total_vat", EmitDefaultValue=false)]
        public decimal? TotalVat { get; set; }
        /// <summary>
        /// Gets or Sets TotalDiscount
        /// </summary>
        [DataMember(Name="total_discount", EmitDefaultValue=false)]
        public decimal? TotalDiscount { get; private set; }
        /// <summary>
        /// Gets or Sets TotalInvoiceDiscount
        /// </summary>
        [DataMember(Name="total_invoice_discount", EmitDefaultValue=false)]
        public decimal? TotalInvoiceDiscount { get; private set; }
        /// <summary>
        /// Gets or Sets Remaining
        /// </summary>
        [DataMember(Name="remaining", EmitDefaultValue=false)]
        public decimal? Remaining { get; private set; }
        /// <summary>
        /// Gets or Sets RemainingInTrl
        /// </summary>
        [DataMember(Name="remaining_in_trl", EmitDefaultValue=false)]
        public decimal? RemainingInTrl { get; private set; }
        /// <summary>
        /// Gets or Sets IsDetailed
        /// </summary>
        [DataMember(Name="is_detailed", EmitDefaultValue=false)]
        public bool? IsDetailed { get; private set; }
        /// <summary>
        /// Gets or Sets SharingsCount
        /// </summary>
        [DataMember(Name="sharings_count", EmitDefaultValue=false)]
        public int? SharingsCount { get; private set; }
        /// <summary>
        /// Gets or Sets EInvoicesCount
        /// </summary>
        [DataMember(Name="e_invoices_count", EmitDefaultValue=false)]
        public int? EInvoicesCount { get; private set; }
        /// <summary>
        /// Gets or Sets RemainingReimbursement
        /// </summary>
        [DataMember(Name="remaining_reimbursement", EmitDefaultValue=false)]
        public decimal? RemainingReimbursement { get; private set; }
        /// <summary>
        /// Gets or Sets RemainingReimbursementInTrl
        /// </summary>
        [DataMember(Name="remaining_reimbursement_in_trl", EmitDefaultValue=false)]
        public decimal? RemainingReimbursementInTrl { get; private set; }
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
        /// Gets or Sets NetTotal
        /// </summary>
        [DataMember(Name="net_total", EmitDefaultValue=false)]
        public decimal? NetTotal { get; set; }
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
            sb.Append("class InlineResponse2019DataAttributes {\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  TotalPaid: ").Append(TotalPaid).Append("\n");
            sb.Append("  GrossTotal: ").Append(GrossTotal).Append("\n");
            sb.Append("  TotalExciseDuty: ").Append(TotalExciseDuty).Append("\n");
            sb.Append("  TotalCommunicationsTax: ").Append(TotalCommunicationsTax).Append("\n");
            sb.Append("  TotalVat: ").Append(TotalVat).Append("\n");
            sb.Append("  TotalDiscount: ").Append(TotalDiscount).Append("\n");
            sb.Append("  TotalInvoiceDiscount: ").Append(TotalInvoiceDiscount).Append("\n");
            sb.Append("  Remaining: ").Append(Remaining).Append("\n");
            sb.Append("  RemainingInTrl: ").Append(RemainingInTrl).Append("\n");
            sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
            sb.Append("  IsDetailed: ").Append(IsDetailed).Append("\n");
            sb.Append("  SharingsCount: ").Append(SharingsCount).Append("\n");
            sb.Append("  EInvoicesCount: ").Append(EInvoicesCount).Append("\n");
            sb.Append("  RemainingReimbursement: ").Append(RemainingReimbursement).Append("\n");
            sb.Append("  RemainingReimbursementInTrl: ").Append(RemainingReimbursementInTrl).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  NetTotal: ").Append(NetTotal).Append("\n");
            sb.Append("  WithholdingRate: ").Append(WithholdingRate).Append("\n");
            sb.Append("  VatWithholdingRate: ").Append(VatWithholdingRate).Append("\n");
            sb.Append("  InvoiceDiscountType: ").Append(InvoiceDiscountType).Append("\n");
            sb.Append("  InvoiceDiscount: ").Append(InvoiceDiscount).Append("\n");
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
            return this.Equals(obj as InlineResponse2019DataAttributes);
        }

        /// <summary>
        /// Returns true if InlineResponse2019DataAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2019DataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2019DataAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Archived == other.Archived ||
                    this.Archived != null &&
                    this.Archived.Equals(other.Archived)
                ) && 
                (
                    this.TotalPaid == other.TotalPaid ||
                    this.TotalPaid != null &&
                    this.TotalPaid.Equals(other.TotalPaid)
                ) && 
                (
                    this.GrossTotal == other.GrossTotal ||
                    this.GrossTotal != null &&
                    this.GrossTotal.Equals(other.GrossTotal)
                ) && 
                (
                    this.TotalExciseDuty == other.TotalExciseDuty ||
                    this.TotalExciseDuty != null &&
                    this.TotalExciseDuty.Equals(other.TotalExciseDuty)
                ) && 
                (
                    this.TotalCommunicationsTax == other.TotalCommunicationsTax ||
                    this.TotalCommunicationsTax != null &&
                    this.TotalCommunicationsTax.Equals(other.TotalCommunicationsTax)
                ) && 
                (
                    this.TotalVat == other.TotalVat ||
                    this.TotalVat != null &&
                    this.TotalVat.Equals(other.TotalVat)
                ) && 
                (
                    this.TotalDiscount == other.TotalDiscount ||
                    this.TotalDiscount != null &&
                    this.TotalDiscount.Equals(other.TotalDiscount)
                ) && 
                (
                    this.TotalInvoiceDiscount == other.TotalInvoiceDiscount ||
                    this.TotalInvoiceDiscount != null &&
                    this.TotalInvoiceDiscount.Equals(other.TotalInvoiceDiscount)
                ) && 
                (
                    this.Remaining == other.Remaining ||
                    this.Remaining != null &&
                    this.Remaining.Equals(other.Remaining)
                ) && 
                (
                    this.RemainingInTrl == other.RemainingInTrl ||
                    this.RemainingInTrl != null &&
                    this.RemainingInTrl.Equals(other.RemainingInTrl)
                ) && 
                (
                    this.PaymentStatus == other.PaymentStatus ||
                    this.PaymentStatus != null &&
                    this.PaymentStatus.Equals(other.PaymentStatus)
                ) && 
                (
                    this.IsDetailed == other.IsDetailed ||
                    this.IsDetailed != null &&
                    this.IsDetailed.Equals(other.IsDetailed)
                ) && 
                (
                    this.SharingsCount == other.SharingsCount ||
                    this.SharingsCount != null &&
                    this.SharingsCount.Equals(other.SharingsCount)
                ) && 
                (
                    this.EInvoicesCount == other.EInvoicesCount ||
                    this.EInvoicesCount != null &&
                    this.EInvoicesCount.Equals(other.EInvoicesCount)
                ) && 
                (
                    this.RemainingReimbursement == other.RemainingReimbursement ||
                    this.RemainingReimbursement != null &&
                    this.RemainingReimbursement.Equals(other.RemainingReimbursement)
                ) && 
                (
                    this.RemainingReimbursementInTrl == other.RemainingReimbursementInTrl ||
                    this.RemainingReimbursementInTrl != null &&
                    this.RemainingReimbursementInTrl.Equals(other.RemainingReimbursementInTrl)
                ) && 
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
                    this.NetTotal == other.NetTotal ||
                    this.NetTotal != null &&
                    this.NetTotal.Equals(other.NetTotal)
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
                    this.InvoiceDiscountType == other.InvoiceDiscountType ||
                    this.InvoiceDiscountType != null &&
                    this.InvoiceDiscountType.Equals(other.InvoiceDiscountType)
                ) && 
                (
                    this.InvoiceDiscount == other.InvoiceDiscount ||
                    this.InvoiceDiscount != null &&
                    this.InvoiceDiscount.Equals(other.InvoiceDiscount)
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
                if (this.Archived != null)
                    hash = hash * 59 + this.Archived.GetHashCode();
                if (this.TotalPaid != null)
                    hash = hash * 59 + this.TotalPaid.GetHashCode();
                if (this.GrossTotal != null)
                    hash = hash * 59 + this.GrossTotal.GetHashCode();
                if (this.TotalExciseDuty != null)
                    hash = hash * 59 + this.TotalExciseDuty.GetHashCode();
                if (this.TotalCommunicationsTax != null)
                    hash = hash * 59 + this.TotalCommunicationsTax.GetHashCode();
                if (this.TotalVat != null)
                    hash = hash * 59 + this.TotalVat.GetHashCode();
                if (this.TotalDiscount != null)
                    hash = hash * 59 + this.TotalDiscount.GetHashCode();
                if (this.TotalInvoiceDiscount != null)
                    hash = hash * 59 + this.TotalInvoiceDiscount.GetHashCode();
                if (this.Remaining != null)
                    hash = hash * 59 + this.Remaining.GetHashCode();
                if (this.RemainingInTrl != null)
                    hash = hash * 59 + this.RemainingInTrl.GetHashCode();
                if (this.PaymentStatus != null)
                    hash = hash * 59 + this.PaymentStatus.GetHashCode();
                if (this.IsDetailed != null)
                    hash = hash * 59 + this.IsDetailed.GetHashCode();
                if (this.SharingsCount != null)
                    hash = hash * 59 + this.SharingsCount.GetHashCode();
                if (this.EInvoicesCount != null)
                    hash = hash * 59 + this.EInvoicesCount.GetHashCode();
                if (this.RemainingReimbursement != null)
                    hash = hash * 59 + this.RemainingReimbursement.GetHashCode();
                if (this.RemainingReimbursementInTrl != null)
                    hash = hash * 59 + this.RemainingReimbursementInTrl.GetHashCode();
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
                if (this.NetTotal != null)
                    hash = hash * 59 + this.NetTotal.GetHashCode();
                if (this.WithholdingRate != null)
                    hash = hash * 59 + this.WithholdingRate.GetHashCode();
                if (this.VatWithholdingRate != null)
                    hash = hash * 59 + this.VatWithholdingRate.GetHashCode();
                if (this.InvoiceDiscountType != null)
                    hash = hash * 59 + this.InvoiceDiscountType.GetHashCode();
                if (this.InvoiceDiscount != null)
                    hash = hash * 59 + this.InvoiceDiscount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
