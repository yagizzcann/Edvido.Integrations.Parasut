
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
    /// CompanyIdeArchivesDataAttributesExciseDutyCodes
    /// </summary>
    [DataContract]
    public partial class CompanyIdeArchivesDataAttributesExciseDutyCodes :  IEquatable<CompanyIdeArchivesDataAttributesExciseDutyCodes>, IValidatableObject
    {
        /// <summary>
        /// ÖTV kodu
        /// </summary>
        /// <value>ÖTV kodu</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SalesExciseDutyCodeEnum
        {
            
            /// <summary>
            /// Enum _57 for "57"
            /// </summary>
            [EnumMember(Value = "57")]
            _57,
            
            /// <summary>
            /// Enum _59 for "59"
            /// </summary>
            [EnumMember(Value = "59")]
            _59,
            
            /// <summary>
            /// Enum _60 for "60"
            /// </summary>
            [EnumMember(Value = "60")]
            _60,
            
            /// <summary>
            /// Enum _61 for "61"
            /// </summary>
            [EnumMember(Value = "61")]
            _61,
            
            /// <summary>
            /// Enum _62 for "62"
            /// </summary>
            [EnumMember(Value = "62")]
            _62,
            
            /// <summary>
            /// Enum _63 for "63"
            /// </summary>
            [EnumMember(Value = "63")]
            _63,
            
            /// <summary>
            /// Enum _9077 for "9077"
            /// </summary>
            [EnumMember(Value = "9077")]
            _9077
        }

        /// <summary>
        /// ÖTV kodu
        /// </summary>
        /// <value>ÖTV kodu</value>
        [DataMember(Name="sales_excise_duty_code", EmitDefaultValue=false)]
        public SalesExciseDutyCodeEnum? SalesExciseDutyCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIdeArchivesDataAttributesExciseDutyCodes" /> class.
        /// </summary>
        /// <param name="Product">Ürün ID.</param>
        /// <param name="SalesExciseDutyCode">ÖTV kodu.</param>
        public CompanyIdeArchivesDataAttributesExciseDutyCodes(int? Product = default(int?), SalesExciseDutyCodeEnum? SalesExciseDutyCode = default(SalesExciseDutyCodeEnum?))
        {
            this.Product = Product;
            this.SalesExciseDutyCode = SalesExciseDutyCode;
        }
        
        /// <summary>
        /// Ürün ID
        /// </summary>
        /// <value>Ürün ID</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public int? Product { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyIdeArchivesDataAttributesExciseDutyCodes {\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  SalesExciseDutyCode: ").Append(SalesExciseDutyCode).Append("\n");
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
            return this.Equals(obj as CompanyIdeArchivesDataAttributesExciseDutyCodes);
        }

        /// <summary>
        /// Returns true if CompanyIdeArchivesDataAttributesExciseDutyCodes instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyIdeArchivesDataAttributesExciseDutyCodes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyIdeArchivesDataAttributesExciseDutyCodes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
                ) && 
                (
                    this.SalesExciseDutyCode == other.SalesExciseDutyCode ||
                    this.SalesExciseDutyCode != null &&
                    this.SalesExciseDutyCode.Equals(other.SalesExciseDutyCode)
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
                if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();
                if (this.SalesExciseDutyCode != null)
                    hash = hash * 59 + this.SalesExciseDutyCode.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
