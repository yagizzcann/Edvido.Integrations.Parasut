
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
    /// AccountAttributes
    /// </summary>
    [DataContract]
    public partial class AccountAttributes :  IEquatable<AccountAttributes>, IValidatableObject
    {
        /// <summary>
        /// Döviz cinsi
        /// </summary>
        /// <value>Döviz cinsi</value>
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
        /// Hesap tipi
        /// </summary>
        /// <value>Hesap tipi</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountTypeEnum
        {
            
            /// <summary>
            /// Enum Cash for "cash"
            /// </summary>
            [EnumMember(Value = "cash")]
            Cash,
            
            /// <summary>
            /// Enum Bank for "bank"
            /// </summary>
            [EnumMember(Value = "bank")]
            Bank,
            
            /// <summary>
            /// Enum Sys for "sys"
            /// </summary>
            [EnumMember(Value = "sys")]
            Sys
        }

        /// <summary>
        /// Döviz cinsi
        /// </summary>
        /// <value>Döviz cinsi</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CurrencyEnum? Currency { get; set; }
        /// <summary>
        /// Hesap tipi
        /// </summary>
        /// <value>Hesap tipi</value>
        [DataMember(Name="account_type", EmitDefaultValue=false)]
        public AccountTypeEnum? AccountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAttributes" /> class.
        /// </summary>
        /// <param name="Name">Hesap ismi (required).</param>
        /// <param name="Currency">Döviz cinsi.</param>
        /// <param name="AccountType">Hesap tipi.</param>
        /// <param name="BankName">Banka ismi.</param>
        /// <param name="BankBranch">Banka şubesi.</param>
        /// <param name="BankAccountNo">Banka hesap no.</param>
        /// <param name="Iban">IBAN.</param>
        /// <param name="Archived">Archived.</param>
        public AccountAttributes(string Name = default(string), CurrencyEnum? Currency = default(CurrencyEnum?), AccountTypeEnum? AccountType = default(AccountTypeEnum?), string BankName = default(string), string BankBranch = default(string), string BankAccountNo = default(string), string Iban = default(string), bool? Archived = default(bool?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for AccountAttributes and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Currency = Currency;
            this.AccountType = AccountType;
            this.BankName = BankName;
            this.BankBranch = BankBranch;
            this.BankAccountNo = BankAccountNo;
            this.Iban = Iban;
            this.Archived = Archived;
        }
        
        /// <summary>
        /// Gets or Sets UsedFor
        /// </summary>
        [DataMember(Name="used_for", EmitDefaultValue=false)]
        public string UsedFor { get; private set; }
        /// <summary>
        /// Gets or Sets LastUsedAt
        /// </summary>
        [DataMember(Name="last_used_at", EmitDefaultValue=false)]
        public DateTime? LastUsedAt { get; private set; }
        /// <summary>
        /// Bakiye
        /// </summary>
        /// <value>Bakiye</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public decimal? Balance { get; private set; }
        /// <summary>
        /// Gets or Sets LastAdjustmentDate
        /// </summary>
        [DataMember(Name="last_adjustment_date", EmitDefaultValue=false)]
        public DateTime? LastAdjustmentDate { get; private set; }
        /// <summary>
        /// Gets or Sets BankIntegrationType
        /// </summary>
        [DataMember(Name="bank_integration_type", EmitDefaultValue=false)]
        public string BankIntegrationType { get; private set; }
        /// <summary>
        /// Gets or Sets AssociateEmail
        /// </summary>
        [DataMember(Name="associate_email", EmitDefaultValue=false)]
        public string AssociateEmail { get; private set; }
        /// <summary>
        /// Hesap ismi
        /// </summary>
        /// <value>Hesap ismi</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Banka ismi
        /// </summary>
        /// <value>Banka ismi</value>
        [DataMember(Name="bank_name", EmitDefaultValue=false)]
        public string BankName { get; set; }
        /// <summary>
        /// Banka şubesi
        /// </summary>
        /// <value>Banka şubesi</value>
        [DataMember(Name="bank_branch", EmitDefaultValue=false)]
        public string BankBranch { get; set; }
        /// <summary>
        /// Banka hesap no
        /// </summary>
        /// <value>Banka hesap no</value>
        [DataMember(Name="bank_account_no", EmitDefaultValue=false)]
        public string BankAccountNo { get; set; }
        /// <summary>
        /// IBAN
        /// </summary>
        /// <value>IBAN</value>
        [DataMember(Name="iban", EmitDefaultValue=false)]
        public string Iban { get; set; }
        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [DataMember(Name="archived", EmitDefaultValue=false)]
        public bool? Archived { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountAttributes {\n");
            sb.Append("  UsedFor: ").Append(UsedFor).Append("\n");
            sb.Append("  LastUsedAt: ").Append(LastUsedAt).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  LastAdjustmentDate: ").Append(LastAdjustmentDate).Append("\n");
            sb.Append("  BankIntegrationType: ").Append(BankIntegrationType).Append("\n");
            sb.Append("  AssociateEmail: ").Append(AssociateEmail).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BankBranch: ").Append(BankBranch).Append("\n");
            sb.Append("  BankAccountNo: ").Append(BankAccountNo).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
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
            return this.Equals(obj as AccountAttributes);
        }

        /// <summary>
        /// Returns true if AccountAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UsedFor == other.UsedFor ||
                    this.UsedFor != null &&
                    this.UsedFor.Equals(other.UsedFor)
                ) && 
                (
                    this.LastUsedAt == other.LastUsedAt ||
                    this.LastUsedAt != null &&
                    this.LastUsedAt.Equals(other.LastUsedAt)
                ) && 
                (
                    this.Balance == other.Balance ||
                    this.Balance != null &&
                    this.Balance.Equals(other.Balance)
                ) && 
                (
                    this.LastAdjustmentDate == other.LastAdjustmentDate ||
                    this.LastAdjustmentDate != null &&
                    this.LastAdjustmentDate.Equals(other.LastAdjustmentDate)
                ) && 
                (
                    this.BankIntegrationType == other.BankIntegrationType ||
                    this.BankIntegrationType != null &&
                    this.BankIntegrationType.Equals(other.BankIntegrationType)
                ) && 
                (
                    this.AssociateEmail == other.AssociateEmail ||
                    this.AssociateEmail != null &&
                    this.AssociateEmail.Equals(other.AssociateEmail)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.AccountType == other.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(other.AccountType)
                ) && 
                (
                    this.BankName == other.BankName ||
                    this.BankName != null &&
                    this.BankName.Equals(other.BankName)
                ) && 
                (
                    this.BankBranch == other.BankBranch ||
                    this.BankBranch != null &&
                    this.BankBranch.Equals(other.BankBranch)
                ) && 
                (
                    this.BankAccountNo == other.BankAccountNo ||
                    this.BankAccountNo != null &&
                    this.BankAccountNo.Equals(other.BankAccountNo)
                ) && 
                (
                    this.Iban == other.Iban ||
                    this.Iban != null &&
                    this.Iban.Equals(other.Iban)
                ) && 
                (
                    this.Archived == other.Archived ||
                    this.Archived != null &&
                    this.Archived.Equals(other.Archived)
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
                if (this.UsedFor != null)
                    hash = hash * 59 + this.UsedFor.GetHashCode();
                if (this.LastUsedAt != null)
                    hash = hash * 59 + this.LastUsedAt.GetHashCode();
                if (this.Balance != null)
                    hash = hash * 59 + this.Balance.GetHashCode();
                if (this.LastAdjustmentDate != null)
                    hash = hash * 59 + this.LastAdjustmentDate.GetHashCode();
                if (this.BankIntegrationType != null)
                    hash = hash * 59 + this.BankIntegrationType.GetHashCode();
                if (this.AssociateEmail != null)
                    hash = hash * 59 + this.AssociateEmail.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.AccountType != null)
                    hash = hash * 59 + this.AccountType.GetHashCode();
                if (this.BankName != null)
                    hash = hash * 59 + this.BankName.GetHashCode();
                if (this.BankBranch != null)
                    hash = hash * 59 + this.BankBranch.GetHashCode();
                if (this.BankAccountNo != null)
                    hash = hash * 59 + this.BankAccountNo.GetHashCode();
                if (this.Iban != null)
                    hash = hash * 59 + this.Iban.GetHashCode();
                if (this.Archived != null)
                    hash = hash * 59 + this.Archived.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
