
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// İnternet satışı bilgileri
    /// </summary>
    [DataContract]
    public partial class CompanyIdeArchivesDataAttributesInternetSale :  IEquatable<CompanyIdeArchivesDataAttributesInternetSale>, IValidatableObject
    {
        /// <summary>
        /// Ödeme tipi
        /// </summary>
        /// <value>Ödeme tipi</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentTypeEnum
        {
            
            /// <summary>
            /// Enum KREDIKARTIBANKAKARTI for "KREDIKARTI/BANKAKARTI"
            /// </summary>
            [EnumMember(Value = "KREDIKARTI/BANKAKARTI")]
            KREDIKARTIBANKAKARTI,
            
            /// <summary>
            /// Enum EFTHAVALE for "EFT/HAVALE"
            /// </summary>
            [EnumMember(Value = "EFT/HAVALE")]
            EFTHAVALE,
            
            /// <summary>
            /// Enum KAPIDAODEME for "KAPIDAODEME"
            /// </summary>
            [EnumMember(Value = "KAPIDAODEME")]
            KAPIDAODEME,
            
            /// <summary>
            /// Enum ODEMEARACISI for "ODEMEARACISI"
            /// </summary>
            [EnumMember(Value = "ODEMEARACISI")]
            ODEMEARACISI
        }

        /// <summary>
        /// Ödeme tipi
        /// </summary>
        /// <value>Ödeme tipi</value>
        [DataMember(Name="payment_type", EmitDefaultValue=false)]
        public PaymentTypeEnum? PaymentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIdeArchivesDataAttributesInternetSale" /> class.
        /// </summary>
        /// <param name="Url">İnternet adresi.</param>
        /// <param name="PaymentType">Ödeme tipi.</param>
        /// <param name="PaymentPlatform">Ödeme platformu - *(iyzico, payu gibi)*.</param>
        /// <param name="PaymentDate">Ödeme tarihi.</param>
        public CompanyIdeArchivesDataAttributesInternetSale(string Url = default(string), PaymentTypeEnum? PaymentType = default(PaymentTypeEnum?), string PaymentPlatform = default(string), DateTime? PaymentDate = default(DateTime?))
        {
            this.Url = Url;
            this.PaymentType = PaymentType;
            this.PaymentPlatform = PaymentPlatform;
            this.PaymentDate = PaymentDate;
        }
        
        /// <summary>
        /// İnternet adresi
        /// </summary>
        /// <value>İnternet adresi</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// Ödeme platformu - *(iyzico, payu gibi)*
        /// </summary>
        /// <value>Ödeme platformu - *(iyzico, payu gibi)*</value>
        [DataMember(Name="payment_platform", EmitDefaultValue=false)]
        public string PaymentPlatform { get; set; }
        /// <summary>
        /// Ödeme tarihi
        /// </summary>
        /// <value>Ödeme tarihi</value>
        [DataMember(Name="payment_date", EmitDefaultValue=false)]
        public DateTime? PaymentDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyIdeArchivesDataAttributesInternetSale {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  PaymentPlatform: ").Append(PaymentPlatform).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
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
            return this.Equals(obj as CompanyIdeArchivesDataAttributesInternetSale);
        }

        /// <summary>
        /// Returns true if CompanyIdeArchivesDataAttributesInternetSale instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyIdeArchivesDataAttributesInternetSale to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyIdeArchivesDataAttributesInternetSale other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.PaymentType == other.PaymentType ||
                    this.PaymentType != null &&
                    this.PaymentType.Equals(other.PaymentType)
                ) && 
                (
                    this.PaymentPlatform == other.PaymentPlatform ||
                    this.PaymentPlatform != null &&
                    this.PaymentPlatform.Equals(other.PaymentPlatform)
                ) && 
                (
                    this.PaymentDate == other.PaymentDate ||
                    this.PaymentDate != null &&
                    this.PaymentDate.Equals(other.PaymentDate)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.PaymentType != null)
                    hash = hash * 59 + this.PaymentType.GetHashCode();
                if (this.PaymentPlatform != null)
                    hash = hash * 59 + this.PaymentPlatform.GetHashCode();
                if (this.PaymentDate != null)
                    hash = hash * 59 + this.PaymentDate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
