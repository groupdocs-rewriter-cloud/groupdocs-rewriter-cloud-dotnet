/*
 * GroupDocs.Rewriter API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 23.8.0
 * Contact: anton.perhunov@aspose.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = GroupDocs.Rewriter.Cloud.Sdk.Client.OpenAPIDateConverter;

namespace GroupDocs.Rewriter.Cloud.Sdk.Model
{
    /// <summary>
    /// TextRequest
    /// </summary>
    [DataContract(Name = "TextRequest")]
    public partial class TextRequest : IEquatable<TextRequest>, IValidatableObject
    {
        /// <summary>
        /// Diversity of text
        /// </summary>
        /// <value>Diversity of text</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DiversityEnum
        {
            /// <summary>
            /// Enum Off for value: Off
            /// </summary>
            [EnumMember(Value = "Off")]
            Off = 1,

            /// <summary>
            /// Enum Medium for value: Medium
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium = 2,

            /// <summary>
            /// Enum High for value: High
            /// </summary>
            [EnumMember(Value = "High")]
            High = 3

        }


        /// <summary>
        /// Diversity of text
        /// </summary>
        /// <value>Diversity of text</value>
        [DataMember(Name = "diversity", EmitDefaultValue = false)]
        public DiversityEnum? Diversity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextRequest" /> class.
        /// </summary>
        /// <param name="language">Language of original text.</param>
        /// <param name="text">Text to rewrite.</param>
        /// <param name="suggestions">Number of suggested variants, 3 maximum.</param>
        /// <param name="diversity">Diversity of text.</param>
        /// <param name="tokenize">Should source and target texts be returned in tokenized form.</param>
        /// <param name="origin">for analysis only.</param>
        public TextRequest(string language = default(string), string text = default(string), int suggestions = default(int), DiversityEnum? diversity = default(DiversityEnum?), bool tokenize = default(bool), string origin = default(string))
        {
            this.Language = language;
            this.Text = text;
            this.Suggestions = suggestions;
            this.Diversity = diversity;
            this.Tokenize = tokenize;
            this.Origin = origin;
        }

        /// <summary>
        /// Language of original text
        /// </summary>
        /// <value>Language of original text</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Text to rewrite
        /// </summary>
        /// <value>Text to rewrite</value>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Number of suggested variants, 3 maximum
        /// </summary>
        /// <value>Number of suggested variants, 3 maximum</value>
        [DataMember(Name = "suggestions", EmitDefaultValue = false)]
        public int Suggestions { get; set; }

        /// <summary>
        /// Should source and target texts be returned in tokenized form
        /// </summary>
        /// <value>Should source and target texts be returned in tokenized form</value>
        [DataMember(Name = "tokenize", EmitDefaultValue = true)]
        public bool Tokenize { get; set; }

        /// <summary>
        /// for analysis only
        /// </summary>
        /// <value>for analysis only</value>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public string Origin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TextRequest {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
            sb.Append("  Diversity: ").Append(Diversity).Append("\n");
            sb.Append("  Tokenize: ").Append(Tokenize).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TextRequest);
        }

        /// <summary>
        /// Returns true if TextRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TextRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Suggestions == input.Suggestions ||
                    this.Suggestions.Equals(input.Suggestions)
                ) && 
                (
                    this.Diversity == input.Diversity ||
                    this.Diversity.Equals(input.Diversity)
                ) && 
                (
                    this.Tokenize == input.Tokenize ||
                    this.Tokenize.Equals(input.Tokenize)
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Suggestions.GetHashCode();
                hashCode = (hashCode * 59) + this.Diversity.GetHashCode();
                hashCode = (hashCode * 59) + this.Tokenize.GetHashCode();
                if (this.Origin != null)
                {
                    hashCode = (hashCode * 59) + this.Origin.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
