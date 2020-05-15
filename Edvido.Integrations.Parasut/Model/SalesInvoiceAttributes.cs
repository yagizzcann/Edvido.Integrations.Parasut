

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
    /// SalesInvoiceAttributes
    /// </summary>
    [DataContract]
    public partial class SalesInvoiceAttributes :  IEquatable<SalesInvoiceAttributes>, IValidatableObject
    {
        /// <summary>
        /// Tahsilat durumu
        /// </summary>
        /// <value>Tahsilat durumu</value>
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
        /// Fatura türü
        /// </summary>
        /// <value>Fatura türü</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ItemTypeEnum
        {
            
            /// <summary>
            /// Enum Invoice for "invoice"
            /// </summary>
            [EnumMember(Value = "invoice")]
            Invoice,
            
            /// <summary>
            /// Enum Estimate for "estimate"
            /// </summary>
            [EnumMember(Value = "estimate")]
            Estimate,
            
            /// <summary>
            /// Enum Cancelled for "cancelled"
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled,
            
            /// <summary>
            /// Enum Recurringinvoice for "recurring_invoice"
            /// </summary>
            [EnumMember(Value = "recurring_invoice")]
            Recurringinvoice,
            
            /// <summary>
            /// Enum Recurringestimate for "recurring_estimate"
            /// </summary>
            [EnumMember(Value = "recurring_estimate")]
            Recurringestimate,
            
            /// <summary>
            /// Enum Refund for "refund"
            /// </summary>
            [EnumMember(Value = "refund")]
            Refund
        }

        /// <summary>
        /// Döviz tipi
        /// </summary>
        /// <value>Döviz tipi</value>
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
        /// Tahsilat durumu
        /// </summary>
        /// <value>Tahsilat durumu</value>
        [DataMember(Name="payment_status", EmitDefaultValue=false)]
        public PaymentStatusEnum? PaymentStatus { get; set; }
        /// <summary>
        /// Fatura türü
        /// </summary>
        /// <value>Fatura türü</value>
        [DataMember(Name="item_type", EmitDefaultValue=false)]
        public ItemTypeEnum? ItemType { get; set; }
        /// <summary>
        /// Döviz tipi
        /// </summary>
        /// <value>Döviz tipi</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CurrencyEnum? Currency { get; set; }
        /// <summary>
        /// Gets or Sets InvoiceDiscountType
        /// </summary>
        [DataMember(Name="invoice_discount_type", EmitDefaultValue=false)]
        public InvoiceDiscountTypeEnum? InvoiceDiscountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesInvoiceAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SalesInvoiceAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesInvoiceAttributes" /> class.
        /// </summary>
        /// <param name="ItemType">Fatura türü (required).</param>
        /// <param name="Description">Fatura açıklaması.</param>
        /// <param name="IssueDate">Düzenleme tarihi (required).</param>
        /// <param name="DueDate">Son tahsilat tarihi.</param>
        /// <param name="InvoiceSeries">Fatura seri.</param>
        /// <param name="InvoiceId">Fatura sıra.</param>
        /// <param name="Currency">Döviz tipi.</param>
        /// <param name="ExchangeRate">Döviz kuru.</param>
        /// <param name="WithholdingRate">Stopaj oranı.</param>
        /// <param name="VatWithholdingRate">Tevkifat oranı.</param>
        /// <param name="InvoiceDiscountType">InvoiceDiscountType.</param>
        /// <param name="InvoiceDiscount">InvoiceDiscount.</param>
        /// <param name="BillingAddress">Gönderim adresi.</param>
        /// <param name="BillingPhone">Gönderim adresi telefonu.</param>
        /// <param name="BillingFax">Gönderim adresi faksı.</param>
        /// <param name="TaxOffice">Müşteri vergi dairesi.</param>
        /// <param name="TaxNumber">Müşteri vergi numarası.</param>
        /// <param name="City">City.</param>
        /// <param name="District">District.</param>
        /// <param name="IsAbroad">IsAbroad.</param>
        /// <param name="OrderNo">OrderNo.</param>
        /// <param name="OrderDate">OrderDate.</param>
        /// <param name="ShipmentAddres">ShipmentAddres.</param>
        public SalesInvoiceAttributes(ItemTypeEnum? ItemType = default(ItemTypeEnum?), string Description = default(string), DateTime? IssueDate = default(DateTime?), DateTime? DueDate = default(DateTime?), string InvoiceSeries = default(string), int? InvoiceId = default(int?), CurrencyEnum? Currency = default(CurrencyEnum?), decimal? ExchangeRate = default(decimal?), decimal? WithholdingRate = default(decimal?), decimal? VatWithholdingRate = default(decimal?), InvoiceDiscountTypeEnum? InvoiceDiscountType = default(InvoiceDiscountTypeEnum?), decimal? InvoiceDiscount = default(decimal?), string BillingAddress = default(string), string BillingPhone = default(string), string BillingFax = default(string), string TaxOffice = default(string), string TaxNumber = default(string), string City = default(string), string District = default(string), string IsAbroad = default(string), string OrderNo = default(string), DateTime? OrderDate = default(DateTime?), string ShipmentAddres = default(string))
        {
            // to ensure "ItemType" is required (not null)
            if (ItemType == null)
            {
                throw new InvalidDataException("ItemType is a required property for SalesInvoiceAttributes and cannot be null");
            }
            else
            {
                this.ItemType = ItemType;
            }
            // to ensure "IssueDate" is required (not null)
            if (IssueDate == null)
            {
                throw new InvalidDataException("IssueDate is a required property for SalesInvoiceAttributes and cannot be null");
            }
            else
            {
                this.IssueDate = IssueDate;
            }
            this.Description = Description;
            this.DueDate = DueDate;
            this.InvoiceSeries = InvoiceSeries;
            this.InvoiceId = InvoiceId;
            this.Currency = Currency;
            this.ExchangeRate = ExchangeRate;
            this.WithholdingRate = WithholdingRate;
            this.VatWithholdingRate = VatWithholdingRate;
            this.InvoiceDiscountType = InvoiceDiscountType;
            this.InvoiceDiscount = InvoiceDiscount;
            this.BillingAddress = BillingAddress;
            this.BillingPhone = BillingPhone;
            this.BillingFax = BillingFax;
            this.TaxOffice = TaxOffice;
            this.TaxNumber = TaxNumber;
            this.City = City;
            this.District = District;
            this.IsAbroad = IsAbroad;
            this.OrderNo = OrderNo;
            this.OrderDate = OrderDate;
            this.ShipmentAddres = ShipmentAddres;
        }
        
        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [DataMember(Name="archived", EmitDefaultValue=false)]
        public bool? Archived { get; private set; }
        /// <summary>
        /// Fatura no
        /// </summary>
        /// <value>Fatura no</value>
        [DataMember(Name="invoice_no", EmitDefaultValue=false)]
        public string InvoiceNo { get; private set; }
        /// <summary>
        /// Genel Toplam
        /// </summary>
        /// <value>Genel Toplam</value>
        [DataMember(Name="net_total", EmitDefaultValue=false)]
        public decimal? NetTotal { get; private set; }
        /// <summary>
        /// Ara toplam
        /// </summary>
        /// <value>Ara toplam</value>
        [DataMember(Name="gross_total", EmitDefaultValue=false)]
        public decimal? GrossTotal { get; private set; }
        /// <summary>
        /// Stopaj
        /// </summary>
        /// <value>Stopaj</value>
        [DataMember(Name="withholding", EmitDefaultValue=false)]
        public decimal? Withholding { get; private set; }
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
        /// Toplam KDV
        /// </summary>
        /// <value>Toplam KDV</value>
        [DataMember(Name="total_vat", EmitDefaultValue=false)]
        public decimal? TotalVat { get; private set; }
        /// <summary>
        /// Tevkifat
        /// </summary>
        /// <value>Tevkifat</value>
        [DataMember(Name="vat_withholding", EmitDefaultValue=false)]
        public decimal? VatWithholding { get; private set; }
        /// <summary>
        /// Toplam indirim
        /// </summary>
        /// <value>Toplam indirim</value>
        [DataMember(Name="total_discount", EmitDefaultValue=false)]
        public decimal? TotalDiscount { get; private set; }
        /// <summary>
        /// Gets or Sets TotalInvoiceDiscount
        /// </summary>
        [DataMember(Name="total_invoice_discount", EmitDefaultValue=false)]
        public decimal? TotalInvoiceDiscount { get; private set; }
        /// <summary>
        /// Vergiler Hariç Toplam
        /// </summary>
        /// <value>Vergiler Hariç Toplam</value>
        [DataMember(Name="before_taxes_total", EmitDefaultValue=false)]
        public decimal? BeforeTaxesTotal { get; private set; }
        /// <summary>
        /// Ödenmemiş tutar
        /// </summary>
        /// <value>Ödenmemiş tutar</value>
        [DataMember(Name="remaining", EmitDefaultValue=false)]
        public decimal? Remaining { get; private set; }
        /// <summary>
        /// Gets or Sets RemainingInTrl
        /// </summary>
        [DataMember(Name="remaining_in_trl", EmitDefaultValue=false)]
        public decimal? RemainingInTrl { get; private set; }
        /// <summary>
        /// Fatura açıklaması
        /// </summary>
        /// <value>Fatura açıklaması</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Düzenleme tarihi
        /// </summary>
        /// <value>Düzenleme tarihi</value>
        [DataMember(Name="issue_date", EmitDefaultValue=false)]
        public DateTime? IssueDate { get; set; }
        /// <summary>
        /// Son tahsilat tarihi
        /// </summary>
        /// <value>Son tahsilat tarihi</value>
        [DataMember(Name="due_date", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// Fatura seri
        /// </summary>
        /// <value>Fatura seri</value>
        [DataMember(Name="invoice_series", EmitDefaultValue=false)]
        public string InvoiceSeries { get; set; }
        /// <summary>
        /// Fatura sıra
        /// </summary>
        /// <value>Fatura sıra</value>
        [DataMember(Name="invoice_id", EmitDefaultValue=false)]
        public int? InvoiceId { get; set; }
        /// <summary>
        /// Döviz kuru
        /// </summary>
        /// <value>Döviz kuru</value>
        [DataMember(Name="exchange_rate", EmitDefaultValue=false)]
        public decimal? ExchangeRate { get; set; }
        /// <summary>
        /// Stopaj oranı
        /// </summary>
        /// <value>Stopaj oranı</value>
        [DataMember(Name="withholding_rate", EmitDefaultValue=false)]
        public decimal? WithholdingRate { get; set; }
        /// <summary>
        /// Tevkifat oranı
        /// </summary>
        /// <value>Tevkifat oranı</value>
        [DataMember(Name="vat_withholding_rate", EmitDefaultValue=false)]
        public decimal? VatWithholdingRate { get; set; }
        /// <summary>
        /// Gets or Sets InvoiceDiscount
        /// </summary>
        [DataMember(Name="invoice_discount", EmitDefaultValue=false)]
        public decimal? InvoiceDiscount { get; set; }
        /// <summary>
        /// Gönderim adresi
        /// </summary>
        /// <value>Gönderim adresi</value>
        [DataMember(Name="billing_address", EmitDefaultValue=false)]
        public string BillingAddress { get; set; }
        /// <summary>
        /// Gönderim adresi telefonu
        /// </summary>
        /// <value>Gönderim adresi telefonu</value>
        [DataMember(Name="billing_phone", EmitDefaultValue=false)]
        public string BillingPhone { get; set; }
        /// <summary>
        /// Gönderim adresi faksı
        /// </summary>
        /// <value>Gönderim adresi faksı</value>
        [DataMember(Name="billing_fax", EmitDefaultValue=false)]
        public string BillingFax { get; set; }
        /// <summary>
        /// Müşteri vergi dairesi
        /// </summary>
        /// <value>Müşteri vergi dairesi</value>
        [DataMember(Name="tax_office", EmitDefaultValue=false)]
        public string TaxOffice { get; set; }
        /// <summary>
        /// Müşteri vergi numarası
        /// </summary>
        /// <value>Müşteri vergi numarası</value>
        [DataMember(Name="tax_number", EmitDefaultValue=false)]
        public string TaxNumber { get; set; }
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Gets or Sets District
        /// </summary>
        [DataMember(Name="district", EmitDefaultValue=false)]
        public string District { get; set; }
        /// <summary>
        /// Gets or Sets IsAbroad
        /// </summary>
        [DataMember(Name="is_abroad", EmitDefaultValue=false)]
        public string IsAbroad { get; set; }
        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="order_no", EmitDefaultValue=false)]
        public string OrderNo { get; set; }
        /// <summary>
        /// Gets or Sets OrderDate
        /// </summary>
        [DataMember(Name="order_date", EmitDefaultValue=false)]
        public DateTime? OrderDate { get; set; }
        /// <summary>
        /// Gets or Sets ShipmentAddres
        /// </summary>
        [DataMember(Name="shipment_addres", EmitDefaultValue=false)]
        public string ShipmentAddres { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesInvoiceAttributes {\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  NetTotal: ").Append(NetTotal).Append("\n");
            sb.Append("  GrossTotal: ").Append(GrossTotal).Append("\n");
            sb.Append("  Withholding: ").Append(Withholding).Append("\n");
            sb.Append("  TotalExciseDuty: ").Append(TotalExciseDuty).Append("\n");
            sb.Append("  TotalCommunicationsTax: ").Append(TotalCommunicationsTax).Append("\n");
            sb.Append("  TotalVat: ").Append(TotalVat).Append("\n");
            sb.Append("  VatWithholding: ").Append(VatWithholding).Append("\n");
            sb.Append("  TotalDiscount: ").Append(TotalDiscount).Append("\n");
            sb.Append("  TotalInvoiceDiscount: ").Append(TotalInvoiceDiscount).Append("\n");
            sb.Append("  BeforeTaxesTotal: ").Append(BeforeTaxesTotal).Append("\n");
            sb.Append("  Remaining: ").Append(Remaining).Append("\n");
            sb.Append("  RemainingInTrl: ").Append(RemainingInTrl).Append("\n");
            sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  InvoiceSeries: ").Append(InvoiceSeries).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  WithholdingRate: ").Append(WithholdingRate).Append("\n");
            sb.Append("  VatWithholdingRate: ").Append(VatWithholdingRate).Append("\n");
            sb.Append("  InvoiceDiscountType: ").Append(InvoiceDiscountType).Append("\n");
            sb.Append("  InvoiceDiscount: ").Append(InvoiceDiscount).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  BillingPhone: ").Append(BillingPhone).Append("\n");
            sb.Append("  BillingFax: ").Append(BillingFax).Append("\n");
            sb.Append("  TaxOffice: ").Append(TaxOffice).Append("\n");
            sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  IsAbroad: ").Append(IsAbroad).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  ShipmentAddres: ").Append(ShipmentAddres).Append("\n");
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
            return this.Equals(obj as SalesInvoiceAttributes);
        }

        /// <summary>
        /// Returns true if SalesInvoiceAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of SalesInvoiceAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesInvoiceAttributes other)
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
                    this.InvoiceNo == other.InvoiceNo ||
                    this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(other.InvoiceNo)
                ) && 
                (
                    this.NetTotal == other.NetTotal ||
                    this.NetTotal != null &&
                    this.NetTotal.Equals(other.NetTotal)
                ) && 
                (
                    this.GrossTotal == other.GrossTotal ||
                    this.GrossTotal != null &&
                    this.GrossTotal.Equals(other.GrossTotal)
                ) && 
                (
                    this.Withholding == other.Withholding ||
                    this.Withholding != null &&
                    this.Withholding.Equals(other.Withholding)
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
                    this.VatWithholding == other.VatWithholding ||
                    this.VatWithholding != null &&
                    this.VatWithholding.Equals(other.VatWithholding)
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
                    this.BeforeTaxesTotal == other.BeforeTaxesTotal ||
                    this.BeforeTaxesTotal != null &&
                    this.BeforeTaxesTotal.Equals(other.BeforeTaxesTotal)
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
                    this.InvoiceSeries == other.InvoiceSeries ||
                    this.InvoiceSeries != null &&
                    this.InvoiceSeries.Equals(other.InvoiceSeries)
                ) && 
                (
                    this.InvoiceId == other.InvoiceId ||
                    this.InvoiceId != null &&
                    this.InvoiceId.Equals(other.InvoiceId)
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
                    this.InvoiceDiscountType == other.InvoiceDiscountType ||
                    this.InvoiceDiscountType != null &&
                    this.InvoiceDiscountType.Equals(other.InvoiceDiscountType)
                ) && 
                (
                    this.InvoiceDiscount == other.InvoiceDiscount ||
                    this.InvoiceDiscount != null &&
                    this.InvoiceDiscount.Equals(other.InvoiceDiscount)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.BillingPhone == other.BillingPhone ||
                    this.BillingPhone != null &&
                    this.BillingPhone.Equals(other.BillingPhone)
                ) && 
                (
                    this.BillingFax == other.BillingFax ||
                    this.BillingFax != null &&
                    this.BillingFax.Equals(other.BillingFax)
                ) && 
                (
                    this.TaxOffice == other.TaxOffice ||
                    this.TaxOffice != null &&
                    this.TaxOffice.Equals(other.TaxOffice)
                ) && 
                (
                    this.TaxNumber == other.TaxNumber ||
                    this.TaxNumber != null &&
                    this.TaxNumber.Equals(other.TaxNumber)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.District == other.District ||
                    this.District != null &&
                    this.District.Equals(other.District)
                ) && 
                (
                    this.IsAbroad == other.IsAbroad ||
                    this.IsAbroad != null &&
                    this.IsAbroad.Equals(other.IsAbroad)
                ) && 
                (
                    this.OrderNo == other.OrderNo ||
                    this.OrderNo != null &&
                    this.OrderNo.Equals(other.OrderNo)
                ) && 
                (
                    this.OrderDate == other.OrderDate ||
                    this.OrderDate != null &&
                    this.OrderDate.Equals(other.OrderDate)
                ) && 
                (
                    this.ShipmentAddres == other.ShipmentAddres ||
                    this.ShipmentAddres != null &&
                    this.ShipmentAddres.Equals(other.ShipmentAddres)
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
                if (this.InvoiceNo != null)
                    hash = hash * 59 + this.InvoiceNo.GetHashCode();
                if (this.NetTotal != null)
                    hash = hash * 59 + this.NetTotal.GetHashCode();
                if (this.GrossTotal != null)
                    hash = hash * 59 + this.GrossTotal.GetHashCode();
                if (this.Withholding != null)
                    hash = hash * 59 + this.Withholding.GetHashCode();
                if (this.TotalExciseDuty != null)
                    hash = hash * 59 + this.TotalExciseDuty.GetHashCode();
                if (this.TotalCommunicationsTax != null)
                    hash = hash * 59 + this.TotalCommunicationsTax.GetHashCode();
                if (this.TotalVat != null)
                    hash = hash * 59 + this.TotalVat.GetHashCode();
                if (this.VatWithholding != null)
                    hash = hash * 59 + this.VatWithholding.GetHashCode();
                if (this.TotalDiscount != null)
                    hash = hash * 59 + this.TotalDiscount.GetHashCode();
                if (this.TotalInvoiceDiscount != null)
                    hash = hash * 59 + this.TotalInvoiceDiscount.GetHashCode();
                if (this.BeforeTaxesTotal != null)
                    hash = hash * 59 + this.BeforeTaxesTotal.GetHashCode();
                if (this.Remaining != null)
                    hash = hash * 59 + this.Remaining.GetHashCode();
                if (this.RemainingInTrl != null)
                    hash = hash * 59 + this.RemainingInTrl.GetHashCode();
                if (this.PaymentStatus != null)
                    hash = hash * 59 + this.PaymentStatus.GetHashCode();
                if (this.ItemType != null)
                    hash = hash * 59 + this.ItemType.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.IssueDate != null)
                    hash = hash * 59 + this.IssueDate.GetHashCode();
                if (this.DueDate != null)
                    hash = hash * 59 + this.DueDate.GetHashCode();
                if (this.InvoiceSeries != null)
                    hash = hash * 59 + this.InvoiceSeries.GetHashCode();
                if (this.InvoiceId != null)
                    hash = hash * 59 + this.InvoiceId.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.ExchangeRate != null)
                    hash = hash * 59 + this.ExchangeRate.GetHashCode();
                if (this.WithholdingRate != null)
                    hash = hash * 59 + this.WithholdingRate.GetHashCode();
                if (this.VatWithholdingRate != null)
                    hash = hash * 59 + this.VatWithholdingRate.GetHashCode();
                if (this.InvoiceDiscountType != null)
                    hash = hash * 59 + this.InvoiceDiscountType.GetHashCode();
                if (this.InvoiceDiscount != null)
                    hash = hash * 59 + this.InvoiceDiscount.GetHashCode();
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                if (this.BillingPhone != null)
                    hash = hash * 59 + this.BillingPhone.GetHashCode();
                if (this.BillingFax != null)
                    hash = hash * 59 + this.BillingFax.GetHashCode();
                if (this.TaxOffice != null)
                    hash = hash * 59 + this.TaxOffice.GetHashCode();
                if (this.TaxNumber != null)
                    hash = hash * 59 + this.TaxNumber.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.District != null)
                    hash = hash * 59 + this.District.GetHashCode();
                if (this.IsAbroad != null)
                    hash = hash * 59 + this.IsAbroad.GetHashCode();
                if (this.OrderNo != null)
                    hash = hash * 59 + this.OrderNo.GetHashCode();
                if (this.OrderDate != null)
                    hash = hash * 59 + this.OrderDate.GetHashCode();
                if (this.ShipmentAddres != null)
                    hash = hash * 59 + this.ShipmentAddres.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
