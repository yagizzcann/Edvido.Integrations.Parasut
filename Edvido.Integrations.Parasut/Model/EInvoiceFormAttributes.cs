
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// EInvoiceFormAttributes
    /// </summary>
    [DataContract]
    public partial class EInvoiceFormAttributes :  IEquatable<EInvoiceFormAttributes>, IValidatableObject
    {
        /// <summary>
        /// Gönderim senaryosu
        /// </summary>
        /// <value>Gönderim senaryosu</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScenarioEnum
        {
            
            /// <summary>
            /// Enum Basic for "basic"
            /// </summary>
            [EnumMember(Value = "basic")]
            Basic,
            
            /// <summary>
            /// Enum Commercial for "commercial"
            /// </summary>
            [EnumMember(Value = "commercial")]
            Commercial
        }

        /// <summary>
        /// Gönderim senaryosu
        /// </summary>
        /// <value>Gönderim senaryosu</value>
        [DataMember(Name="scenario", EmitDefaultValue=false)]
        public ScenarioEnum? Scenario { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EInvoiceFormAttributes" /> class.
        /// </summary>
        /// <param name="VatWithholdingCode">Tevkifat oranına ait vergi kodu. - *Bu dosyada ilgili kodları bulabilirsiniz: https://www.efatura.gov.tr/dosyalar/kilavuzlar/UBLTR_1.2_Kilavuzlar.zip*.</param>
        /// <param name="VatExemptionReasonCode">KDV&#39;si %0 olan hizmet ve ürünlerin KDV muafiyet sebebi kodu. - *Bu dosyada ilgili kodları bulabilirsiniz: https://www.efatura.gov.tr/dosyalar/kilavuzlar/UBLTR_1.2_Kilavuzlar.zip*.</param>
        /// <param name="VatExemptionReason">Eğer KDV muafiyet sebebi kodu 250 veya 350 ise KDV muafiyet sebebi açıklaması..</param>
        /// <param name="Note">Fatura notu.</param>
        /// <param name="ExciseDutyCodes">ÖTV kodları - *Özel tüketim vergisi faturadaki her kalem için ayrıdır. ÖTV uygulanan her ürün için ÖTV kodu göndermeniz gerekmektedir.*.</param>
        /// <param name="Scenario">Gönderim senaryosu.</param>
        /// <param name="To">Alıcının e-Fatura gelen kutusu - *[e-Fatura Gelen Kutusu Öğrenme](/#operation/listEInvoiceInboxes)*.</param>
        public EInvoiceFormAttributes(string VatWithholdingCode = default(string), string VatExemptionReasonCode = default(string), string VatExemptionReason = default(string), string Note = default(string), List<CompanyIdeArchivesDataAttributesExciseDutyCodes> ExciseDutyCodes = default(List<CompanyIdeArchivesDataAttributesExciseDutyCodes>), ScenarioEnum? Scenario = default(ScenarioEnum?), string To = default(string))
        {
            this.VatWithholdingCode = VatWithholdingCode;
            this.VatExemptionReasonCode = VatExemptionReasonCode;
            this.VatExemptionReason = VatExemptionReason;
            this.Note = Note;
            this.ExciseDutyCodes = ExciseDutyCodes;
            this.Scenario = Scenario;
            this.To = To;
        }
        
        /// <summary>
        /// Tevkifat oranına ait vergi kodu. - *Bu dosyada ilgili kodları bulabilirsiniz: https://www.efatura.gov.tr/dosyalar/kilavuzlar/UBLTR_1.2_Kilavuzlar.zip*
        /// </summary>
        /// <value>Tevkifat oranına ait vergi kodu. - *Bu dosyada ilgili kodları bulabilirsiniz: https://www.efatura.gov.tr/dosyalar/kilavuzlar/UBLTR_1.2_Kilavuzlar.zip*</value>
        [DataMember(Name="vat_withholding_code", EmitDefaultValue=false)]
        public string VatWithholdingCode { get; set; }
        /// <summary>
        /// KDV&#39;si %0 olan hizmet ve ürünlerin KDV muafiyet sebebi kodu. - *Bu dosyada ilgili kodları bulabilirsiniz: https://www.efatura.gov.tr/dosyalar/kilavuzlar/UBLTR_1.2_Kilavuzlar.zip*
        /// </summary>
        /// <value>KDV&#39;si %0 olan hizmet ve ürünlerin KDV muafiyet sebebi kodu. - *Bu dosyada ilgili kodları bulabilirsiniz: https://www.efatura.gov.tr/dosyalar/kilavuzlar/UBLTR_1.2_Kilavuzlar.zip*</value>
        [DataMember(Name="vat_exemption_reason_code", EmitDefaultValue=false)]
        public string VatExemptionReasonCode { get; set; }
        /// <summary>
        /// Eğer KDV muafiyet sebebi kodu 250 veya 350 ise KDV muafiyet sebebi açıklaması.
        /// </summary>
        /// <value>Eğer KDV muafiyet sebebi kodu 250 veya 350 ise KDV muafiyet sebebi açıklaması.</value>
        [DataMember(Name="vat_exemption_reason", EmitDefaultValue=false)]
        public string VatExemptionReason { get; set; }
        /// <summary>
        /// Fatura notu
        /// </summary>
        /// <value>Fatura notu</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        /// <summary>
        /// ÖTV kodları - *Özel tüketim vergisi faturadaki her kalem için ayrıdır. ÖTV uygulanan her ürün için ÖTV kodu göndermeniz gerekmektedir.*
        /// </summary>
        /// <value>ÖTV kodları - *Özel tüketim vergisi faturadaki her kalem için ayrıdır. ÖTV uygulanan her ürün için ÖTV kodu göndermeniz gerekmektedir.*</value>
        [DataMember(Name="excise_duty_codes", EmitDefaultValue=false)]
        public List<CompanyIdeArchivesDataAttributesExciseDutyCodes> ExciseDutyCodes { get; set; }
        /// <summary>
        /// Alıcının e-Fatura gelen kutusu - *[e-Fatura Gelen Kutusu Öğrenme](/#operation/listEInvoiceInboxes)*
        /// </summary>
        /// <value>Alıcının e-Fatura gelen kutusu - *[e-Fatura Gelen Kutusu Öğrenme](/#operation/listEInvoiceInboxes)*</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EInvoiceFormAttributes {\n");
            sb.Append("  VatWithholdingCode: ").Append(VatWithholdingCode).Append("\n");
            sb.Append("  VatExemptionReasonCode: ").Append(VatExemptionReasonCode).Append("\n");
            sb.Append("  VatExemptionReason: ").Append(VatExemptionReason).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  ExciseDutyCodes: ").Append(ExciseDutyCodes).Append("\n");
            sb.Append("  Scenario: ").Append(Scenario).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(obj as EInvoiceFormAttributes);
        }

        /// <summary>
        /// Returns true if EInvoiceFormAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of EInvoiceFormAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EInvoiceFormAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.VatWithholdingCode == other.VatWithholdingCode ||
                    this.VatWithholdingCode != null &&
                    this.VatWithholdingCode.Equals(other.VatWithholdingCode)
                ) && 
                (
                    this.VatExemptionReasonCode == other.VatExemptionReasonCode ||
                    this.VatExemptionReasonCode != null &&
                    this.VatExemptionReasonCode.Equals(other.VatExemptionReasonCode)
                ) && 
                (
                    this.VatExemptionReason == other.VatExemptionReason ||
                    this.VatExemptionReason != null &&
                    this.VatExemptionReason.Equals(other.VatExemptionReason)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.ExciseDutyCodes == other.ExciseDutyCodes ||
                    this.ExciseDutyCodes != null &&
                    this.ExciseDutyCodes.SequenceEqual(other.ExciseDutyCodes)
                ) && 
                (
                    this.Scenario == other.Scenario ||
                    this.Scenario != null &&
                    this.Scenario.Equals(other.Scenario)
                ) && 
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
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
                if (this.VatWithholdingCode != null)
                    hash = hash * 59 + this.VatWithholdingCode.GetHashCode();
                if (this.VatExemptionReasonCode != null)
                    hash = hash * 59 + this.VatExemptionReasonCode.GetHashCode();
                if (this.VatExemptionReason != null)
                    hash = hash * 59 + this.VatExemptionReason.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.ExciseDutyCodes != null)
                    hash = hash * 59 + this.ExciseDutyCodes.GetHashCode();
                if (this.Scenario != null)
                    hash = hash * 59 + this.Scenario.GetHashCode();
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
