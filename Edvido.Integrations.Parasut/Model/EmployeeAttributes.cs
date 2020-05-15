
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// EmployeeAttributes
    /// </summary>
    [DataContract]
    public partial class EmployeeAttributes :  IEquatable<EmployeeAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmployeeAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeAttributes" /> class.
        /// </summary>
        /// <param name="Name">Çalışan adı soyadı (required).</param>
        /// <param name="Email">Email.</param>
        /// <param name="Archived">Archived.</param>
        /// <param name="Iban">Iban.</param>
        public EmployeeAttributes(string Name = default(string), string Email = default(string), bool? Archived = default(bool?), string Iban = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for EmployeeAttributes and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Email = Email;
            this.Archived = Archived;
            this.Iban = Iban;
        }
        
        /// <summary>
        /// Bakiye
        /// </summary>
        /// <value>Bakiye</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public decimal? Balance { get; private set; }
        /// <summary>
        /// Gets or Sets TrlBalance
        /// </summary>
        [DataMember(Name="trl_balance", EmitDefaultValue=false)]
        public decimal? TrlBalance { get; private set; }
        /// <summary>
        /// Gets or Sets UsdBalance
        /// </summary>
        [DataMember(Name="usd_balance", EmitDefaultValue=false)]
        public decimal? UsdBalance { get; private set; }
        /// <summary>
        /// Gets or Sets EurBalance
        /// </summary>
        [DataMember(Name="eur_balance", EmitDefaultValue=false)]
        public decimal? EurBalance { get; private set; }
        /// <summary>
        /// Gets or Sets GbpBalance
        /// </summary>
        [DataMember(Name="gbp_balance", EmitDefaultValue=false)]
        public decimal? GbpBalance { get; private set; }
        /// <summary>
        /// Çalışan adı soyadı
        /// </summary>
        /// <value>Çalışan adı soyadı</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [DataMember(Name="archived", EmitDefaultValue=false)]
        public bool? Archived { get; set; }
        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        [DataMember(Name="iban", EmitDefaultValue=false)]
        public string Iban { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeAttributes {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  TrlBalance: ").Append(TrlBalance).Append("\n");
            sb.Append("  UsdBalance: ").Append(UsdBalance).Append("\n");
            sb.Append("  EurBalance: ").Append(EurBalance).Append("\n");
            sb.Append("  GbpBalance: ").Append(GbpBalance).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
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
            return this.Equals(obj as EmployeeAttributes);
        }

        /// <summary>
        /// Returns true if EmployeeAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of EmployeeAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Balance == other.Balance ||
                    this.Balance != null &&
                    this.Balance.Equals(other.Balance)
                ) && 
                (
                    this.TrlBalance == other.TrlBalance ||
                    this.TrlBalance != null &&
                    this.TrlBalance.Equals(other.TrlBalance)
                ) && 
                (
                    this.UsdBalance == other.UsdBalance ||
                    this.UsdBalance != null &&
                    this.UsdBalance.Equals(other.UsdBalance)
                ) && 
                (
                    this.EurBalance == other.EurBalance ||
                    this.EurBalance != null &&
                    this.EurBalance.Equals(other.EurBalance)
                ) && 
                (
                    this.GbpBalance == other.GbpBalance ||
                    this.GbpBalance != null &&
                    this.GbpBalance.Equals(other.GbpBalance)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Archived == other.Archived ||
                    this.Archived != null &&
                    this.Archived.Equals(other.Archived)
                ) && 
                (
                    this.Iban == other.Iban ||
                    this.Iban != null &&
                    this.Iban.Equals(other.Iban)
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
                if (this.Balance != null)
                    hash = hash * 59 + this.Balance.GetHashCode();
                if (this.TrlBalance != null)
                    hash = hash * 59 + this.TrlBalance.GetHashCode();
                if (this.UsdBalance != null)
                    hash = hash * 59 + this.UsdBalance.GetHashCode();
                if (this.EurBalance != null)
                    hash = hash * 59 + this.EurBalance.GetHashCode();
                if (this.GbpBalance != null)
                    hash = hash * 59 + this.GbpBalance.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Archived != null)
                    hash = hash * 59 + this.Archived.GetHashCode();
                if (this.Iban != null)
                    hash = hash * 59 + this.Iban.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
