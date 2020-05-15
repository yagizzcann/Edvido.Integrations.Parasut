
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
    /// TransactionAttributes
    /// </summary>
    [DataContract]
    public partial class TransactionAttributes :  IEquatable<TransactionAttributes>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DebitCurrency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DebitCurrencyEnum
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
        /// Gets or Sets CreditCurrency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CreditCurrencyEnum
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
        /// Gets or Sets DebitCurrency
        /// </summary>
        [DataMember(Name="debit_currency", EmitDefaultValue=false)]
        public DebitCurrencyEnum? DebitCurrency { get; set; }
        /// <summary>
        /// Gets or Sets CreditCurrency
        /// </summary>
        [DataMember(Name="credit_currency", EmitDefaultValue=false)]
        public CreditCurrencyEnum? CreditCurrency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionAttributes" /> class.
        /// </summary>
        /// <param name="TransactionType">TransactionType.</param>
        /// <param name="HumanizedTypeName">HumanizedTypeName.</param>
        /// <param name="Date">Date.</param>
        /// <param name="AmountInTrl">AmountInTrl.</param>
        /// <param name="DebitAmount">DebitAmount.</param>
        /// <param name="DebitCurrency">DebitCurrency.</param>
        /// <param name="CreditAmount">CreditAmount.</param>
        /// <param name="CreditCurrency">CreditCurrency.</param>
        public TransactionAttributes(string TransactionType = default(string), string HumanizedTypeName = default(string), DateTime? Date = default(DateTime?), decimal? AmountInTrl = default(decimal?), decimal? DebitAmount = default(decimal?), DebitCurrencyEnum? DebitCurrency = default(DebitCurrencyEnum?), decimal? CreditAmount = default(decimal?), CreditCurrencyEnum? CreditCurrency = default(CreditCurrencyEnum?))
        {
            this.TransactionType = TransactionType;
            this.HumanizedTypeName = HumanizedTypeName;
            this.Date = Date;
            this.AmountInTrl = AmountInTrl;
            this.DebitAmount = DebitAmount;
            this.DebitCurrency = DebitCurrency;
            this.CreditAmount = CreditAmount;
            this.CreditCurrency = CreditCurrency;
        }
        
        /// <summary>
        /// Gets or Sets TransactionType
        /// </summary>
        [DataMember(Name="transaction_type", EmitDefaultValue=false)]
        public string TransactionType { get; set; }
        /// <summary>
        /// Gets or Sets HumanizedTypeName
        /// </summary>
        [DataMember(Name="humanized_type_name", EmitDefaultValue=false)]
        public string HumanizedTypeName { get; set; }
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }
        /// <summary>
        /// Gets or Sets AmountInTrl
        /// </summary>
        [DataMember(Name="amount_in_trl", EmitDefaultValue=false)]
        public decimal? AmountInTrl { get; set; }
        /// <summary>
        /// Gets or Sets DebitAmount
        /// </summary>
        [DataMember(Name="debit_amount", EmitDefaultValue=false)]
        public decimal? DebitAmount { get; set; }
        /// <summary>
        /// Gets or Sets CreditAmount
        /// </summary>
        [DataMember(Name="credit_amount", EmitDefaultValue=false)]
        public decimal? CreditAmount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionAttributes {\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  HumanizedTypeName: ").Append(HumanizedTypeName).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  AmountInTrl: ").Append(AmountInTrl).Append("\n");
            sb.Append("  DebitAmount: ").Append(DebitAmount).Append("\n");
            sb.Append("  DebitCurrency: ").Append(DebitCurrency).Append("\n");
            sb.Append("  CreditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  CreditCurrency: ").Append(CreditCurrency).Append("\n");
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
            return this.Equals(obj as TransactionAttributes);
        }

        /// <summary>
        /// Returns true if TransactionAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransactionType == other.TransactionType ||
                    this.TransactionType != null &&
                    this.TransactionType.Equals(other.TransactionType)
                ) && 
                (
                    this.HumanizedTypeName == other.HumanizedTypeName ||
                    this.HumanizedTypeName != null &&
                    this.HumanizedTypeName.Equals(other.HumanizedTypeName)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.AmountInTrl == other.AmountInTrl ||
                    this.AmountInTrl != null &&
                    this.AmountInTrl.Equals(other.AmountInTrl)
                ) && 
                (
                    this.DebitAmount == other.DebitAmount ||
                    this.DebitAmount != null &&
                    this.DebitAmount.Equals(other.DebitAmount)
                ) && 
                (
                    this.DebitCurrency == other.DebitCurrency ||
                    this.DebitCurrency != null &&
                    this.DebitCurrency.Equals(other.DebitCurrency)
                ) && 
                (
                    this.CreditAmount == other.CreditAmount ||
                    this.CreditAmount != null &&
                    this.CreditAmount.Equals(other.CreditAmount)
                ) && 
                (
                    this.CreditCurrency == other.CreditCurrency ||
                    this.CreditCurrency != null &&
                    this.CreditCurrency.Equals(other.CreditCurrency)
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
                if (this.TransactionType != null)
                    hash = hash * 59 + this.TransactionType.GetHashCode();
                if (this.HumanizedTypeName != null)
                    hash = hash * 59 + this.HumanizedTypeName.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.AmountInTrl != null)
                    hash = hash * 59 + this.AmountInTrl.GetHashCode();
                if (this.DebitAmount != null)
                    hash = hash * 59 + this.DebitAmount.GetHashCode();
                if (this.DebitCurrency != null)
                    hash = hash * 59 + this.DebitCurrency.GetHashCode();
                if (this.CreditAmount != null)
                    hash = hash * 59 + this.CreditAmount.GetHashCode();
                if (this.CreditCurrency != null)
                    hash = hash * 59 + this.CreditCurrency.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
