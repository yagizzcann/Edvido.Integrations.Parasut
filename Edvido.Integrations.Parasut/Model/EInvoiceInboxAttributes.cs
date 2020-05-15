
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// EInvoiceInboxAttributes
    /// </summary>
    [DataContract]
    public partial class EInvoiceInboxAttributes :  IEquatable<EInvoiceInboxAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EInvoiceInboxAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public EInvoiceInboxAttributes()
        {
        }
        
        /// <summary>
        /// Gets or Sets Vkn
        /// </summary>
        [DataMember(Name="vkn", EmitDefaultValue=false)]
        public string Vkn { get; private set; }
        /// <summary>
        /// Gets or Sets EInvoiceAddress
        /// </summary>
        [DataMember(Name="e_invoice_address", EmitDefaultValue=false)]
        public string EInvoiceAddress { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        /// <summary>
        /// Gets or Sets InboxType
        /// </summary>
        [DataMember(Name="inbox_type", EmitDefaultValue=false)]
        public string InboxType { get; private set; }
        /// <summary>
        /// Gets or Sets AddressRegisteredAt
        /// </summary>
        [DataMember(Name="address_registered_at", EmitDefaultValue=false)]
        public DateTime? AddressRegisteredAt { get; private set; }
        /// <summary>
        /// Gets or Sets RegisteredAt
        /// </summary>
        [DataMember(Name="registered_at", EmitDefaultValue=false)]
        public DateTime? RegisteredAt { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EInvoiceInboxAttributes {\n");
            sb.Append("  Vkn: ").Append(Vkn).Append("\n");
            sb.Append("  EInvoiceAddress: ").Append(EInvoiceAddress).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InboxType: ").Append(InboxType).Append("\n");
            sb.Append("  AddressRegisteredAt: ").Append(AddressRegisteredAt).Append("\n");
            sb.Append("  RegisteredAt: ").Append(RegisteredAt).Append("\n");
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
            return this.Equals(obj as EInvoiceInboxAttributes);
        }

        /// <summary>
        /// Returns true if EInvoiceInboxAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of EInvoiceInboxAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EInvoiceInboxAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Vkn == other.Vkn ||
                    this.Vkn != null &&
                    this.Vkn.Equals(other.Vkn)
                ) && 
                (
                    this.EInvoiceAddress == other.EInvoiceAddress ||
                    this.EInvoiceAddress != null &&
                    this.EInvoiceAddress.Equals(other.EInvoiceAddress)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.InboxType == other.InboxType ||
                    this.InboxType != null &&
                    this.InboxType.Equals(other.InboxType)
                ) && 
                (
                    this.AddressRegisteredAt == other.AddressRegisteredAt ||
                    this.AddressRegisteredAt != null &&
                    this.AddressRegisteredAt.Equals(other.AddressRegisteredAt)
                ) && 
                (
                    this.RegisteredAt == other.RegisteredAt ||
                    this.RegisteredAt != null &&
                    this.RegisteredAt.Equals(other.RegisteredAt)
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
                if (this.Vkn != null)
                    hash = hash * 59 + this.Vkn.GetHashCode();
                if (this.EInvoiceAddress != null)
                    hash = hash * 59 + this.EInvoiceAddress.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.InboxType != null)
                    hash = hash * 59 + this.InboxType.GetHashCode();
                if (this.AddressRegisteredAt != null)
                    hash = hash * 59 + this.AddressRegisteredAt.GetHashCode();
                if (this.RegisteredAt != null)
                    hash = hash * 59 + this.RegisteredAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
