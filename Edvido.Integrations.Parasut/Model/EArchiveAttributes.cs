
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
    /// EArchiveAttributes
    /// </summary>
    [DataContract]
    public partial class EArchiveAttributes :  IEquatable<EArchiveAttributes>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Bounced for "bounced"
            /// </summary>
            [EnumMember(Value = "bounced")]
            Bounced,
            
            /// <summary>
            /// Enum Sent for "sent"
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent,
            
            /// <summary>
            /// Enum Printed for "printed"
            /// </summary>
            [EnumMember(Value = "printed")]
            Printed,
            
            /// <summary>
            /// Enum Legalized for "legalized"
            /// </summary>
            [EnumMember(Value = "legalized")]
            Legalized
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EArchiveAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public EArchiveAttributes()
        {
        }
        
        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; private set; }
        /// <summary>
        /// Gets or Sets Vkn
        /// </summary>
        [DataMember(Name="vkn", EmitDefaultValue=false)]
        public string Vkn { get; private set; }
        /// <summary>
        /// Gets or Sets InvoiceNumber
        /// </summary>
        [DataMember(Name="invoice_number", EmitDefaultValue=false)]
        public string InvoiceNumber { get; private set; }
        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; private set; }
        /// <summary>
        /// Gets or Sets IsPrinted
        /// </summary>
        [DataMember(Name="is_printed", EmitDefaultValue=false)]
        public bool? IsPrinted { get; private set; }
        /// <summary>
        /// Gets or Sets PrintedAt
        /// </summary>
        [DataMember(Name="printed_at", EmitDefaultValue=false)]
        public DateTime? PrintedAt { get; private set; }
        /// <summary>
        /// Gets or Sets CancellableUntil
        /// </summary>
        [DataMember(Name="cancellable_until", EmitDefaultValue=false)]
        public DateTime? CancellableUntil { get; private set; }
        /// <summary>
        /// Gets or Sets IsSigned
        /// </summary>
        [DataMember(Name="is_signed", EmitDefaultValue=false)]
        public bool? IsSigned { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EArchiveAttributes {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Vkn: ").Append(Vkn).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  IsPrinted: ").Append(IsPrinted).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PrintedAt: ").Append(PrintedAt).Append("\n");
            sb.Append("  CancellableUntil: ").Append(CancellableUntil).Append("\n");
            sb.Append("  IsSigned: ").Append(IsSigned).Append("\n");
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
            return this.Equals(obj as EArchiveAttributes);
        }

        /// <summary>
        /// Returns true if EArchiveAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of EArchiveAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EArchiveAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Uuid == other.Uuid ||
                    this.Uuid != null &&
                    this.Uuid.Equals(other.Uuid)
                ) && 
                (
                    this.Vkn == other.Vkn ||
                    this.Vkn != null &&
                    this.Vkn.Equals(other.Vkn)
                ) && 
                (
                    this.InvoiceNumber == other.InvoiceNumber ||
                    this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(other.InvoiceNumber)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.IsPrinted == other.IsPrinted ||
                    this.IsPrinted != null &&
                    this.IsPrinted.Equals(other.IsPrinted)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.PrintedAt == other.PrintedAt ||
                    this.PrintedAt != null &&
                    this.PrintedAt.Equals(other.PrintedAt)
                ) && 
                (
                    this.CancellableUntil == other.CancellableUntil ||
                    this.CancellableUntil != null &&
                    this.CancellableUntil.Equals(other.CancellableUntil)
                ) && 
                (
                    this.IsSigned == other.IsSigned ||
                    this.IsSigned != null &&
                    this.IsSigned.Equals(other.IsSigned)
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
                if (this.Uuid != null)
                    hash = hash * 59 + this.Uuid.GetHashCode();
                if (this.Vkn != null)
                    hash = hash * 59 + this.Vkn.GetHashCode();
                if (this.InvoiceNumber != null)
                    hash = hash * 59 + this.InvoiceNumber.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.IsPrinted != null)
                    hash = hash * 59 + this.IsPrinted.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.PrintedAt != null)
                    hash = hash * 59 + this.PrintedAt.GetHashCode();
                if (this.CancellableUntil != null)
                    hash = hash * 59 + this.CancellableUntil.GetHashCode();
                if (this.IsSigned != null)
                    hash = hash * 59 + this.IsSigned.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
