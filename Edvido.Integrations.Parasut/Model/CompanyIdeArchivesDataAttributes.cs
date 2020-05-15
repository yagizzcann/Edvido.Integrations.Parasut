
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// CompanyIdeArchivesDataAttributes
    /// </summary>
    [DataContract]
    public partial class CompanyIdeArchivesDataAttributes :  IEquatable<CompanyIdeArchivesDataAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIdeArchivesDataAttributes" /> class.
        /// </summary>
        /// <param name="VatWithholdingCode">Tevkifat oranına ait vergi kodu. - *Bu dosyada ilgili kodları bulabilirsiniz: https://www.efatura.gov.tr/dosyalar/kilavuzlar/UBLTR_1.2_Kilavuzlar.zip*.</param>
        /// <param name="VatExemptionReasonCode">KDV&#39;si %0 olan hizmet ve ürünlerin KDV muafiyet sebebi kodu. - *Bu dosyada ilgili kodları bulabilirsiniz: https://www.efatura.gov.tr/dosyalar/kilavuzlar/UBLTR_1.2_Kilavuzlar.zip*.</param>
        /// <param name="VatExemptionReason">Eğer KDV muafiyet sebebi kodu 250 veya 350 ise KDV muafiyet sebebi açıklaması..</param>
        /// <param name="Note">Fatura notu.</param>
        /// <param name="ExciseDutyCodes">ÖTV kodları - *Özel tüketim vergisi faturadaki her kalem için ayrıdır. ÖTV uygulanan her ürün için ÖTV kodu göndermeniz gerekmektedir.*.</param>
        /// <param name="InternetSale">InternetSale.</param>
        /// <param name="Shipment">Shipment.</param>
        public CompanyIdeArchivesDataAttributes(string VatWithholdingCode = default(string), string VatExemptionReasonCode = default(string), string VatExemptionReason = default(string), string Note = default(string), List<CompanyIdeArchivesDataAttributesExciseDutyCodes> ExciseDutyCodes = default(List<CompanyIdeArchivesDataAttributesExciseDutyCodes>), CompanyIdeArchivesDataAttributesInternetSale InternetSale = default(CompanyIdeArchivesDataAttributesInternetSale), CompanyIdeArchivesDataAttributesShipment Shipment = default(CompanyIdeArchivesDataAttributesShipment))
        {
            this.VatWithholdingCode = VatWithholdingCode;
            this.VatExemptionReasonCode = VatExemptionReasonCode;
            this.VatExemptionReason = VatExemptionReason;
            this.Note = Note;
            this.ExciseDutyCodes = ExciseDutyCodes;
            this.InternetSale = InternetSale;
            this.Shipment = Shipment;
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
        /// Gets or Sets InternetSale
        /// </summary>
        [DataMember(Name="internet_sale", EmitDefaultValue=false)]
        public CompanyIdeArchivesDataAttributesInternetSale InternetSale { get; set; }
        /// <summary>
        /// Gets or Sets Shipment
        /// </summary>
        [DataMember(Name="shipment", EmitDefaultValue=false)]
        public CompanyIdeArchivesDataAttributesShipment Shipment { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyIdeArchivesDataAttributes {\n");
            sb.Append("  VatWithholdingCode: ").Append(VatWithholdingCode).Append("\n");
            sb.Append("  VatExemptionReasonCode: ").Append(VatExemptionReasonCode).Append("\n");
            sb.Append("  VatExemptionReason: ").Append(VatExemptionReason).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  ExciseDutyCodes: ").Append(ExciseDutyCodes).Append("\n");
            sb.Append("  InternetSale: ").Append(InternetSale).Append("\n");
            sb.Append("  Shipment: ").Append(Shipment).Append("\n");
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
            return this.Equals(obj as CompanyIdeArchivesDataAttributes);
        }

        /// <summary>
        /// Returns true if CompanyIdeArchivesDataAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyIdeArchivesDataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyIdeArchivesDataAttributes other)
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
                    this.InternetSale == other.InternetSale ||
                    this.InternetSale != null &&
                    this.InternetSale.Equals(other.InternetSale)
                ) && 
                (
                    this.Shipment == other.Shipment ||
                    this.Shipment != null &&
                    this.Shipment.Equals(other.Shipment)
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
                if (this.InternetSale != null)
                    hash = hash * 59 + this.InternetSale.GetHashCode();
                if (this.Shipment != null)
                    hash = hash * 59 + this.Shipment.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
