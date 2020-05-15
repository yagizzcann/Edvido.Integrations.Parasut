
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
    /// EInvoiceAttributes
    /// </summary>
    [DataContract]
    public partial class EInvoiceAttributes :  IEquatable<EInvoiceAttributes>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            
            /// <summary>
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound
        }

        /// <summary>
        /// Gets or Sets ResponseType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResponseTypeEnum
        {
            
            /// <summary>
            /// Enum Accepted for "accepted"
            /// </summary>
            [EnumMember(Value = "accepted")]
            Accepted,
            
            /// <summary>
            /// Enum Rejected for "rejected"
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected,
            
            /// <summary>
            /// Enum Refunded for "refunded"
            /// </summary>
            [EnumMember(Value = "refunded")]
            Refunded
        }

        /// <summary>
        /// Gets or Sets Scenario
        /// </summary>
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
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Waiting for "waiting"
            /// </summary>
            [EnumMember(Value = "waiting")]
            Waiting,
            
            /// <summary>
            /// Enum Failed for "failed"
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed,
            
            /// <summary>
            /// Enum Successful for "successful"
            /// </summary>
            [EnumMember(Value = "successful")]
            Successful
        }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
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
        /// Gets or Sets ItemType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ItemTypeEnum
        {
            
            /// <summary>
            /// Enum Refund for "refund"
            /// </summary>
            [EnumMember(Value = "refund")]
            Refund,
            
            /// <summary>
            /// Enum Invoice for "invoice"
            /// </summary>
            [EnumMember(Value = "invoice")]
            Invoice
        }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Gets or Sets ResponseType
        /// </summary>
        [DataMember(Name="response_type", EmitDefaultValue=false)]
        public ResponseTypeEnum? ResponseType { get; set; }
        /// <summary>
        /// Gets or Sets Scenario
        /// </summary>
        [DataMember(Name="scenario", EmitDefaultValue=false)]
        public ScenarioEnum? Scenario { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CurrencyEnum? Currency { get; set; }
        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        [DataMember(Name="item_type", EmitDefaultValue=false)]
        public ItemTypeEnum? ItemType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EInvoiceAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public EInvoiceAttributes()
        {
        }
        
        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }
        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; private set; }
        /// <summary>
        /// Gets or Sets EnvUuid
        /// </summary>
        [DataMember(Name="env_uuid", EmitDefaultValue=false)]
        public string EnvUuid { get; private set; }
        /// <summary>
        /// Gets or Sets FromAddress
        /// </summary>
        [DataMember(Name="from_address", EmitDefaultValue=false)]
        public string FromAddress { get; private set; }
        /// <summary>
        /// Gets or Sets FromVkn
        /// </summary>
        [DataMember(Name="from_vkn", EmitDefaultValue=false)]
        public string FromVkn { get; private set; }
        /// <summary>
        /// Gets or Sets ToAddress
        /// </summary>
        [DataMember(Name="to_address", EmitDefaultValue=false)]
        public string ToAddress { get; private set; }
        /// <summary>
        /// Gets or Sets ToVkn
        /// </summary>
        [DataMember(Name="to_vkn", EmitDefaultValue=false)]
        public string ToVkn { get; private set; }
        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; private set; }
        /// <summary>
        /// Gets or Sets ContactName
        /// </summary>
        [DataMember(Name="contact_name", EmitDefaultValue=false)]
        public string ContactName { get; private set; }
        /// <summary>
        /// Gets or Sets IssueDate
        /// </summary>
        [DataMember(Name="issue_date", EmitDefaultValue=false)]
        public DateTime? IssueDate { get; private set; }
        /// <summary>
        /// Gets or Sets IsExpired
        /// </summary>
        [DataMember(Name="is_expired", EmitDefaultValue=false)]
        public bool? IsExpired { get; private set; }
        /// <summary>
        /// Gets or Sets IsAnswerable
        /// </summary>
        [DataMember(Name="is_answerable", EmitDefaultValue=false)]
        public bool? IsAnswerable { get; private set; }
        /// <summary>
        /// Gets or Sets NetTotal
        /// </summary>
        [DataMember(Name="net_total", EmitDefaultValue=false)]
        public decimal? NetTotal { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EInvoiceAttributes {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  EnvUuid: ").Append(EnvUuid).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  FromVkn: ").Append(FromVkn).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  ToVkn: ").Append(ToVkn).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  Scenario: ").Append(Scenario).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
            sb.Append("  IsAnswerable: ").Append(IsAnswerable).Append("\n");
            sb.Append("  NetTotal: ").Append(NetTotal).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
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
            return this.Equals(obj as EInvoiceAttributes);
        }

        /// <summary>
        /// Returns true if EInvoiceAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of EInvoiceAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EInvoiceAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.Uuid == other.Uuid ||
                    this.Uuid != null &&
                    this.Uuid.Equals(other.Uuid)
                ) && 
                (
                    this.EnvUuid == other.EnvUuid ||
                    this.EnvUuid != null &&
                    this.EnvUuid.Equals(other.EnvUuid)
                ) && 
                (
                    this.FromAddress == other.FromAddress ||
                    this.FromAddress != null &&
                    this.FromAddress.Equals(other.FromAddress)
                ) && 
                (
                    this.FromVkn == other.FromVkn ||
                    this.FromVkn != null &&
                    this.FromVkn.Equals(other.FromVkn)
                ) && 
                (
                    this.ToAddress == other.ToAddress ||
                    this.ToAddress != null &&
                    this.ToAddress.Equals(other.ToAddress)
                ) && 
                (
                    this.ToVkn == other.ToVkn ||
                    this.ToVkn != null &&
                    this.ToVkn.Equals(other.ToVkn)
                ) && 
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.ResponseType == other.ResponseType ||
                    this.ResponseType != null &&
                    this.ResponseType.Equals(other.ResponseType)
                ) && 
                (
                    this.ContactName == other.ContactName ||
                    this.ContactName != null &&
                    this.ContactName.Equals(other.ContactName)
                ) && 
                (
                    this.Scenario == other.Scenario ||
                    this.Scenario != null &&
                    this.Scenario.Equals(other.Scenario)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.IssueDate == other.IssueDate ||
                    this.IssueDate != null &&
                    this.IssueDate.Equals(other.IssueDate)
                ) && 
                (
                    this.IsExpired == other.IsExpired ||
                    this.IsExpired != null &&
                    this.IsExpired.Equals(other.IsExpired)
                ) && 
                (
                    this.IsAnswerable == other.IsAnswerable ||
                    this.IsAnswerable != null &&
                    this.IsAnswerable.Equals(other.IsAnswerable)
                ) && 
                (
                    this.NetTotal == other.NetTotal ||
                    this.NetTotal != null &&
                    this.NetTotal.Equals(other.NetTotal)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.ItemType == other.ItemType ||
                    this.ItemType != null &&
                    this.ItemType.Equals(other.ItemType)
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
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                if (this.Uuid != null)
                    hash = hash * 59 + this.Uuid.GetHashCode();
                if (this.EnvUuid != null)
                    hash = hash * 59 + this.EnvUuid.GetHashCode();
                if (this.FromAddress != null)
                    hash = hash * 59 + this.FromAddress.GetHashCode();
                if (this.FromVkn != null)
                    hash = hash * 59 + this.FromVkn.GetHashCode();
                if (this.ToAddress != null)
                    hash = hash * 59 + this.ToAddress.GetHashCode();
                if (this.ToVkn != null)
                    hash = hash * 59 + this.ToVkn.GetHashCode();
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.ResponseType != null)
                    hash = hash * 59 + this.ResponseType.GetHashCode();
                if (this.ContactName != null)
                    hash = hash * 59 + this.ContactName.GetHashCode();
                if (this.Scenario != null)
                    hash = hash * 59 + this.Scenario.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.IssueDate != null)
                    hash = hash * 59 + this.IssueDate.GetHashCode();
                if (this.IsExpired != null)
                    hash = hash * 59 + this.IsExpired.GetHashCode();
                if (this.IsAnswerable != null)
                    hash = hash * 59 + this.IsAnswerable.GetHashCode();
                if (this.NetTotal != null)
                    hash = hash * 59 + this.NetTotal.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.ItemType != null)
                    hash = hash * 59 + this.ItemType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
