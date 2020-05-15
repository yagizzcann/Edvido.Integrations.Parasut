

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
    /// PaymentFormAttributes
    /// </summary>
    [DataContract]
    public partial class PaymentFormAttributes :  IEquatable<PaymentFormAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentFormAttributes" /> class.
        /// </summary>
        /// <param name="Description">Ödeme/Tahsilat Açıklaması.</param>
        /// <param name="AccountId">Kasa veya Banka - *Bu parametre ayrıca ödemenin/tahsilatın hangi döviz kuru ile yapılacağını belirler.*.</param>
        /// <param name="Date">Ödeme/Tahsilat tarihi.</param>
        /// <param name="Amount">Ödeme/Tahsilat tutarı.</param>
        /// <param name="ExchangeRate">Döviz kuru - *Eğer ödeme/tahsilat, faturadan farklı bir döviz kuru ile yapılacaksa; döviz kurunun TL karşılığını belirtin. Eğer ödeme/tahsilat, fatura ile aynı döviz kuru ile yapılacaksa; \&quot;1.0\&quot; değerini girin veya boş bırakın.*.</param>
        public PaymentFormAttributes(string Description = default(string), int? AccountId = default(int?), DateTime? Date = default(DateTime?), decimal? Amount = default(decimal?), decimal? ExchangeRate = default(decimal?))
        {
            this.Description = Description;
            this.AccountId = AccountId;
            this.Date = Date;
            this.Amount = Amount;
            this.ExchangeRate = ExchangeRate;
        }
        
        /// <summary>
        /// Ödeme/Tahsilat Açıklaması
        /// </summary>
        /// <value>Ödeme/Tahsilat Açıklaması</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Kasa veya Banka - *Bu parametre ayrıca ödemenin/tahsilatın hangi döviz kuru ile yapılacağını belirler.*
        /// </summary>
        /// <value>Kasa veya Banka - *Bu parametre ayrıca ödemenin/tahsilatın hangi döviz kuru ile yapılacağını belirler.*</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public int? AccountId { get; set; }
        /// <summary>
        /// Ödeme/Tahsilat tarihi
        /// </summary>
        /// <value>Ödeme/Tahsilat tarihi</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }
        /// <summary>
        /// Ödeme/Tahsilat tutarı
        /// </summary>
        /// <value>Ödeme/Tahsilat tutarı</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// Döviz kuru - *Eğer ödeme/tahsilat, faturadan farklı bir döviz kuru ile yapılacaksa; döviz kurunun TL karşılığını belirtin. Eğer ödeme/tahsilat, fatura ile aynı döviz kuru ile yapılacaksa; \&quot;1.0\&quot; değerini girin veya boş bırakın.*
        /// </summary>
        /// <value>Döviz kuru - *Eğer ödeme/tahsilat, faturadan farklı bir döviz kuru ile yapılacaksa; döviz kurunun TL karşılığını belirtin. Eğer ödeme/tahsilat, fatura ile aynı döviz kuru ile yapılacaksa; \&quot;1.0\&quot; değerini girin veya boş bırakın.*</value>
        [DataMember(Name="exchange_rate", EmitDefaultValue=false)]
        public decimal? ExchangeRate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentFormAttributes {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
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
            return this.Equals(obj as PaymentFormAttributes);
        }

        /// <summary>
        /// Returns true if PaymentFormAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentFormAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentFormAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.ExchangeRate == other.ExchangeRate ||
                    this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(other.ExchangeRate)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.ExchangeRate != null)
                    hash = hash * 59 + this.ExchangeRate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
