
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
    /// SalaryAttributes
    /// </summary>
    [DataContract]
    public partial class SalaryAttributes :  IEquatable<SalaryAttributes>, IValidatableObject
    {
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
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CurrencyEnum? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SalaryAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SalaryAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SalaryAttributes" /> class.
        /// </summary>
        /// <param name="Description">Description (required).</param>
        /// <param name="Currency">Currency (required).</param>
        /// <param name="IssueDate">IssueDate (required).</param>
        /// <param name="DueDate">DueDate (required).</param>
        /// <param name="ExchangeRate">ExchangeRate.</param>
        /// <param name="NetTotal">NetTotal (required).</param>
        public SalaryAttributes(string Description = default(string), CurrencyEnum? Currency = default(CurrencyEnum?), DateTime? IssueDate = default(DateTime?), DateTime? DueDate = default(DateTime?), decimal? ExchangeRate = default(decimal?), decimal? NetTotal = default(decimal?))
        {
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for SalaryAttributes and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Currency" is required (not null)
            if (Currency == null)
            {
                throw new InvalidDataException("Currency is a required property for SalaryAttributes and cannot be null");
            }
            else
            {
                this.Currency = Currency;
            }
            // to ensure "IssueDate" is required (not null)
            if (IssueDate == null)
            {
                throw new InvalidDataException("IssueDate is a required property for SalaryAttributes and cannot be null");
            }
            else
            {
                this.IssueDate = IssueDate;
            }
            // to ensure "DueDate" is required (not null)
            if (DueDate == null)
            {
                throw new InvalidDataException("DueDate is a required property for SalaryAttributes and cannot be null");
            }
            else
            {
                this.DueDate = DueDate;
            }
            // to ensure "NetTotal" is required (not null)
            if (NetTotal == null)
            {
                throw new InvalidDataException("NetTotal is a required property for SalaryAttributes and cannot be null");
            }
            else
            {
                this.NetTotal = NetTotal;
            }
            this.ExchangeRate = ExchangeRate;
        }
        
        /// <summary>
        /// Gets or Sets TotalPaid
        /// </summary>
        [DataMember(Name="total_paid", EmitDefaultValue=false)]
        public decimal? TotalPaid { get; private set; }
        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [DataMember(Name="archived", EmitDefaultValue=false)]
        public bool? Archived { get; private set; }
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalaryAttributes {\n");
            sb.Append("  TotalPaid: ").Append(TotalPaid).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  Remaining: ").Append(Remaining).Append("\n");
            sb.Append("  RemainingInTrl: ").Append(RemainingInTrl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  NetTotal: ").Append(NetTotal).Append("\n");
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
            return this.Equals(obj as SalaryAttributes);
        }

        /// <summary>
        /// Returns true if SalaryAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of SalaryAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalaryAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalPaid == other.TotalPaid ||
                    this.TotalPaid != null &&
                    this.TotalPaid.Equals(other.TotalPaid)
                ) && 
                (
                    this.Archived == other.Archived ||
                    this.Archived != null &&
                    this.Archived.Equals(other.Archived)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
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
                    this.ExchangeRate == other.ExchangeRate ||
                    this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(other.ExchangeRate)
                ) && 
                (
                    this.NetTotal == other.NetTotal ||
                    this.NetTotal != null &&
                    this.NetTotal.Equals(other.NetTotal)
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
                if (this.TotalPaid != null)
                    hash = hash * 59 + this.TotalPaid.GetHashCode();
                if (this.Archived != null)
                    hash = hash * 59 + this.Archived.GetHashCode();
                if (this.Remaining != null)
                    hash = hash * 59 + this.Remaining.GetHashCode();
                if (this.RemainingInTrl != null)
                    hash = hash * 59 + this.RemainingInTrl.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.IssueDate != null)
                    hash = hash * 59 + this.IssueDate.GetHashCode();
                if (this.DueDate != null)
                    hash = hash * 59 + this.DueDate.GetHashCode();
                if (this.ExchangeRate != null)
                    hash = hash * 59 + this.ExchangeRate.GetHashCode();
                if (this.NetTotal != null)
                    hash = hash * 59 + this.NetTotal.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
