namespace Edvido.Integrations.Parasut.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    [DataContract]
    public partial class AccountForm1 : IEquatable<AccountForm1>, IValidatableObject
    {
        public AccountForm1(CompanyIdaccountsData Data = default(CompanyIdaccountsData))
        {
            this.Data = Data;
        }

        [DataMember(Name = "data", EmitDefaultValue = false)]
        public CompanyIdaccountsData Data { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountForm1 {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AccountForm1);
        }

        public bool Equals(AccountForm1 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                );
        }

        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
