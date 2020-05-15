
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// InlineResponse2002Attributes
    /// </summary>
    [DataContract]
    public partial class InlineResponse2002Attributes :  IEquatable<InlineResponse2002Attributes>, IValidatableObject
    {
        /// <summary>
        /// Tip
        /// </summary>
        /// <value>Tip</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContactTypeEnum
        {
            
            /// <summary>
            /// Enum Person for "person"
            /// </summary>
            [EnumMember(Value = "person")]
            Person,
            
            /// <summary>
            /// Enum Company for "company"
            /// </summary>
            [EnumMember(Value = "company")]
            Company
        }

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountTypeEnum
        {
            
            /// <summary>
            /// Enum Customer for "customer"
            /// </summary>
            [EnumMember(Value = "customer")]
            Customer,
            
            /// <summary>
            /// Enum Supplier for "supplier"
            /// </summary>
            [EnumMember(Value = "supplier")]
            Supplier
        }

        /// <summary>
        /// Tip
        /// </summary>
        /// <value>Tip</value>
        [DataMember(Name="contact_type", EmitDefaultValue=false)]
        public ContactTypeEnum? ContactType { get; set; }
        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name="account_type", EmitDefaultValue=false)]
        public AccountTypeEnum? AccountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2002Attributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2002Attributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2002Attributes" /> class.
        /// </summary>
        /// <param name="Email">E-posta.</param>
        /// <param name="Name">Müşteri/tedarikçi ismi (required).</param>
        /// <param name="ShortName">ShortName.</param>
        /// <param name="ContactType">Tip.</param>
        /// <param name="TaxOffice">Vergi dairesi.</param>
        /// <param name="TaxNumber">Vergi numarası/TC kimlik no.</param>
        /// <param name="District">İlçe.</param>
        /// <param name="City">İl.</param>
        /// <param name="Address">Address.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Fax">Fax.</param>
        /// <param name="IsAbroad">IsAbroad.</param>
        /// <param name="Archived">Archived.</param>
        /// <param name="Iban">Iban.</param>
        /// <param name="AccountType">AccountType (required).</param>
        public InlineResponse2002Attributes(string Email = default(string), string Name = default(string), string ShortName = default(string), ContactTypeEnum? ContactType = default(ContactTypeEnum?), string TaxOffice = default(string), string TaxNumber = default(string), string District = default(string), string City = default(string), string Address = default(string), string Phone = default(string), string Fax = default(string), bool? IsAbroad = default(bool?), bool? Archived = default(bool?), string Iban = default(string), AccountTypeEnum? AccountType = default(AccountTypeEnum?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for InlineResponse2002Attributes and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "AccountType" is required (not null)
            if (AccountType == null)
            {
                throw new InvalidDataException("AccountType is a required property for InlineResponse2002Attributes and cannot be null");
            }
            else
            {
                this.AccountType = AccountType;
            }
            this.Email = Email;
            this.ShortName = ShortName;
            this.ContactType = ContactType;
            this.TaxOffice = TaxOffice;
            this.TaxNumber = TaxNumber;
            this.District = District;
            this.City = City;
            this.Address = Address;
            this.Phone = Phone;
            this.Fax = Fax;
            this.IsAbroad = IsAbroad;
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
        /// TL Bakiye
        /// </summary>
        /// <value>TL Bakiye</value>
        [DataMember(Name="trl_balance", EmitDefaultValue=false)]
        public decimal? TrlBalance { get; private set; }
        /// <summary>
        /// USD Bakiye
        /// </summary>
        /// <value>USD Bakiye</value>
        [DataMember(Name="usd_balance", EmitDefaultValue=false)]
        public decimal? UsdBalance { get; private set; }
        /// <summary>
        /// EUR Bakiye
        /// </summary>
        /// <value>EUR Bakiye</value>
        [DataMember(Name="eur_balance", EmitDefaultValue=false)]
        public decimal? EurBalance { get; private set; }
        /// <summary>
        /// GBP Bakiye
        /// </summary>
        /// <value>GBP Bakiye</value>
        [DataMember(Name="gbp_balance", EmitDefaultValue=false)]
        public decimal? GbpBalance { get; private set; }
        /// <summary>
        /// E-posta
        /// </summary>
        /// <value>E-posta</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Müşteri/tedarikçi ismi
        /// </summary>
        /// <value>Müşteri/tedarikçi ismi</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name="short_name", EmitDefaultValue=false)]
        public string ShortName { get; set; }
        /// <summary>
        /// Vergi dairesi
        /// </summary>
        /// <value>Vergi dairesi</value>
        [DataMember(Name="tax_office", EmitDefaultValue=false)]
        public string TaxOffice { get; set; }
        /// <summary>
        /// Vergi numarası/TC kimlik no
        /// </summary>
        /// <value>Vergi numarası/TC kimlik no</value>
        [DataMember(Name="tax_number", EmitDefaultValue=false)]
        public string TaxNumber { get; set; }
        /// <summary>
        /// İlçe
        /// </summary>
        /// <value>İlçe</value>
        [DataMember(Name="district", EmitDefaultValue=false)]
        public string District { get; set; }
        /// <summary>
        /// İl
        /// </summary>
        /// <value>İl</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }
        /// <summary>
        /// Gets or Sets IsAbroad
        /// </summary>
        [DataMember(Name="is_abroad", EmitDefaultValue=false)]
        public bool? IsAbroad { get; set; }
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
            sb.Append("class InlineResponse2002Attributes {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  TrlBalance: ").Append(TrlBalance).Append("\n");
            sb.Append("  UsdBalance: ").Append(UsdBalance).Append("\n");
            sb.Append("  EurBalance: ").Append(EurBalance).Append("\n");
            sb.Append("  GbpBalance: ").Append(GbpBalance).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  ContactType: ").Append(ContactType).Append("\n");
            sb.Append("  TaxOffice: ").Append(TaxOffice).Append("\n");
            sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  IsAbroad: ").Append(IsAbroad).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
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
            return this.Equals(obj as InlineResponse2002Attributes);
        }

        /// <summary>
        /// Returns true if InlineResponse2002Attributes instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2002Attributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2002Attributes other)
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
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ShortName == other.ShortName ||
                    this.ShortName != null &&
                    this.ShortName.Equals(other.ShortName)
                ) && 
                (
                    this.ContactType == other.ContactType ||
                    this.ContactType != null &&
                    this.ContactType.Equals(other.ContactType)
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
                    this.District == other.District ||
                    this.District != null &&
                    this.District.Equals(other.District)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Fax == other.Fax ||
                    this.Fax != null &&
                    this.Fax.Equals(other.Fax)
                ) && 
                (
                    this.IsAbroad == other.IsAbroad ||
                    this.IsAbroad != null &&
                    this.IsAbroad.Equals(other.IsAbroad)
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
                ) && 
                (
                    this.AccountType == other.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(other.AccountType)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ShortName != null)
                    hash = hash * 59 + this.ShortName.GetHashCode();
                if (this.ContactType != null)
                    hash = hash * 59 + this.ContactType.GetHashCode();
                if (this.TaxOffice != null)
                    hash = hash * 59 + this.TaxOffice.GetHashCode();
                if (this.TaxNumber != null)
                    hash = hash * 59 + this.TaxNumber.GetHashCode();
                if (this.District != null)
                    hash = hash * 59 + this.District.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Fax != null)
                    hash = hash * 59 + this.Fax.GetHashCode();
                if (this.IsAbroad != null)
                    hash = hash * 59 + this.IsAbroad.GetHashCode();
                if (this.Archived != null)
                    hash = hash * 59 + this.Archived.GetHashCode();
                if (this.Iban != null)
                    hash = hash * 59 + this.Iban.GetHashCode();
                if (this.AccountType != null)
                    hash = hash * 59 + this.AccountType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
