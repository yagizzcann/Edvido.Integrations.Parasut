
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
    /// ItemCategoryAttributes
    /// </summary>
    [DataContract]
    public partial class ItemCategoryAttributes :  IEquatable<ItemCategoryAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemCategoryAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemCategoryAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemCategoryAttributes" /> class.
        /// </summary>
        /// <param name="Name">Kategori adı (required).</param>
        /// <param name="BgColor">Renk.</param>
        /// <param name="TextColor">Yazı rengi.</param>
        /// <param name="CategoryType">Kategori tipi.</param>
        /// <param name="ParentId">ParentId.</param>
        public ItemCategoryAttributes(string Name = default(string), string BgColor = default(string), string TextColor = default(string), string CategoryType = default(string), int? ParentId = default(int?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ItemCategoryAttributes and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.BgColor = BgColor;
            this.TextColor = TextColor;
            this.CategoryType = CategoryType;
            this.ParentId = ParentId;
        }
        
        /// <summary>
        /// Gets or Sets FullPath
        /// </summary>
        [DataMember(Name="full_path", EmitDefaultValue=false)]
        public string FullPath { get; private set; }
        /// <summary>
        /// Kategori adı
        /// </summary>
        /// <value>Kategori adı</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Renk
        /// </summary>
        /// <value>Renk</value>
        [DataMember(Name="bg_color", EmitDefaultValue=false)]
        public string BgColor { get; set; }
        /// <summary>
        /// Yazı rengi
        /// </summary>
        /// <value>Yazı rengi</value>
        [DataMember(Name="text_color", EmitDefaultValue=false)]
        public string TextColor { get; set; }
        /// <summary>
        /// Kategori tipi
        /// </summary>
        /// <value>Kategori tipi</value>
        [DataMember(Name="category_type", EmitDefaultValue=false)]
        public string CategoryType { get; set; }
        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="parent_id", EmitDefaultValue=false)]
        public int? ParentId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemCategoryAttributes {\n");
            sb.Append("  FullPath: ").Append(FullPath).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BgColor: ").Append(BgColor).Append("\n");
            sb.Append("  TextColor: ").Append(TextColor).Append("\n");
            sb.Append("  CategoryType: ").Append(CategoryType).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
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
            return this.Equals(obj as ItemCategoryAttributes);
        }

        /// <summary>
        /// Returns true if ItemCategoryAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemCategoryAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemCategoryAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FullPath == other.FullPath ||
                    this.FullPath != null &&
                    this.FullPath.Equals(other.FullPath)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.BgColor == other.BgColor ||
                    this.BgColor != null &&
                    this.BgColor.Equals(other.BgColor)
                ) && 
                (
                    this.TextColor == other.TextColor ||
                    this.TextColor != null &&
                    this.TextColor.Equals(other.TextColor)
                ) && 
                (
                    this.CategoryType == other.CategoryType ||
                    this.CategoryType != null &&
                    this.CategoryType.Equals(other.CategoryType)
                ) && 
                (
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
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
                if (this.FullPath != null)
                    hash = hash * 59 + this.FullPath.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.BgColor != null)
                    hash = hash * 59 + this.BgColor.GetHashCode();
                if (this.TextColor != null)
                    hash = hash * 59 + this.TextColor.GetHashCode();
                if (this.CategoryType != null)
                    hash = hash * 59 + this.CategoryType.GetHashCode();
                if (this.ParentId != null)
                    hash = hash * 59 + this.ParentId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
