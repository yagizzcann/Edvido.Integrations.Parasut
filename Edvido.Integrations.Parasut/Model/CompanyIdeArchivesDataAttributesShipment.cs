
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
    /// Gönderi bilgileri
    /// </summary>
    [DataContract]
    public partial class CompanyIdeArchivesDataAttributesShipment :  IEquatable<CompanyIdeArchivesDataAttributesShipment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIdeArchivesDataAttributesShipment" /> class.
        /// </summary>
        /// <param name="Title">Kargo şirketi adı *(Eğer kargo ile gönderiliyorsa)*.</param>
        /// <param name="Vkn">Kargo şirketi VKN *(Eğer kargo ile gönderiliyorsa)*.</param>
        /// <param name="Name">Kurye adı *(Eğer kurye ile gönderiliyorsa)*.</param>
        /// <param name="Tckn">Kurye TCKN *(Eğer kurye ile gönderiliyorsa)*.</param>
        /// <param name="Date">Gönderi tarihi.</param>
        public CompanyIdeArchivesDataAttributesShipment(string Title = default(string), string Vkn = default(string), string Name = default(string), string Tckn = default(string), string Date = default(string))
        {
            this.Title = Title;
            this.Vkn = Vkn;
            this.Name = Name;
            this.Tckn = Tckn;
            this.Date = Date;
        }
        
        /// <summary>
        /// Kargo şirketi adı *(Eğer kargo ile gönderiliyorsa)*
        /// </summary>
        /// <value>Kargo şirketi adı *(Eğer kargo ile gönderiliyorsa)*</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Kargo şirketi VKN *(Eğer kargo ile gönderiliyorsa)*
        /// </summary>
        /// <value>Kargo şirketi VKN *(Eğer kargo ile gönderiliyorsa)*</value>
        [DataMember(Name="vkn", EmitDefaultValue=false)]
        public string Vkn { get; set; }
        /// <summary>
        /// Kurye adı *(Eğer kurye ile gönderiliyorsa)*
        /// </summary>
        /// <value>Kurye adı *(Eğer kurye ile gönderiliyorsa)*</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Kurye TCKN *(Eğer kurye ile gönderiliyorsa)*
        /// </summary>
        /// <value>Kurye TCKN *(Eğer kurye ile gönderiliyorsa)*</value>
        [DataMember(Name="tckn", EmitDefaultValue=false)]
        public string Tckn { get; set; }
        /// <summary>
        /// Gönderi tarihi
        /// </summary>
        /// <value>Gönderi tarihi</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyIdeArchivesDataAttributesShipment {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Vkn: ").Append(Vkn).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tckn: ").Append(Tckn).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(obj as CompanyIdeArchivesDataAttributesShipment);
        }

        /// <summary>
        /// Returns true if CompanyIdeArchivesDataAttributesShipment instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyIdeArchivesDataAttributesShipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyIdeArchivesDataAttributesShipment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Vkn == other.Vkn ||
                    this.Vkn != null &&
                    this.Vkn.Equals(other.Vkn)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Tckn == other.Tckn ||
                    this.Tckn != null &&
                    this.Tckn.Equals(other.Tckn)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Vkn != null)
                    hash = hash * 59 + this.Vkn.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Tckn != null)
                    hash = hash * 59 + this.Tckn.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
