/*
 * GroupDocs.Rewriter API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 23.11.1
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
    /// ParaphraseTextRequest
    /// </summary>
    [DataContract(Name = "ParaphraseTextRequest")]
    public partial class ParaphraseTextRequest : IEquatable<ParaphraseTextRequest>, IValidatableObject
    {
        /// <summary>
        /// Number of variants for rewriting
        /// </summary>
        /// <value>Number of variants for rewriting</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SuggestionsEnum
        {
            /// <summary>
            /// Enum One for value: One
            /// </summary>
            [EnumMember(Value = "One")]
            One = 1,

            /// <summary>
            /// Enum Two for value: Two
            /// </summary>
            [EnumMember(Value = "Two")]
            Two = 2,

            /// <summary>
            /// Enum Three for value: Three
            /// </summary>
            [EnumMember(Value = "Three")]
            Three = 3

        }


        /// <summary>
        /// Number of variants for rewriting
        /// </summary>
        /// <value>Number of variants for rewriting</value>
        [DataMember(Name = "suggestions", EmitDefaultValue = false)]
        public SuggestionsEnum? Suggestions { get; set; }

        /// <summary>
        /// Gets or Sets DiversityDegree
        /// </summary>
        [DataMember(Name = "diversityDegree", EmitDefaultValue = false)]
        public DegreeEnum? DiversityDegree { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParaphraseTextRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ParaphraseTextRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParaphraseTextRequest" /> class.
        /// </summary>
        /// <param name="language">Set language of text (required).</param>
        /// <param name="text">Single text paragraph.</param>
        /// <param name="texts">Text paragraphs.</param>
        /// <param name="origin">Information about SDK user, like a User-Agent.</param>
        /// <param name="suggestions">Number of variants for rewriting.</param>
        /// <param name="diversityDegree">diversityDegree.</param>
        /// <param name="tokenize">Determines whether to return a tokens list.</param>
        public ParaphraseTextRequest(string language = default(string), string text = default(string), List<string> texts = default(List<string>), string origin = default(string), SuggestionsEnum? suggestions = default(SuggestionsEnum?), DegreeEnum? diversityDegree = default(DegreeEnum?), bool tokenize = default(bool))
        {
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new ArgumentNullException("language is a required property for ParaphraseTextRequest and cannot be null");
            }
            this.Language = language;
            this.Text = text;
            this.Texts = texts;
            this.Origin = origin;
            this.Suggestions = suggestions;
            this.DiversityDegree = diversityDegree;
            this.Tokenize = tokenize;
        }

        /// <summary>
        /// Set language of text
        /// </summary>
        /// <value>Set language of text</value>
        [DataMember(Name = "language", IsRequired = true, EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Single text paragraph
        /// </summary>
        /// <value>Single text paragraph</value>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Text paragraphs
        /// </summary>
        /// <value>Text paragraphs</value>
        [DataMember(Name = "texts", EmitDefaultValue = false)]
        public List<string> Texts { get; set; }

        /// <summary>
        /// Information about SDK user, like a User-Agent
        /// </summary>
        /// <value>Information about SDK user, like a User-Agent</value>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public string Origin { get; set; }

        /// <summary>
        /// Determines whether to return a tokens list
        /// </summary>
        /// <value>Determines whether to return a tokens list</value>
        [DataMember(Name = "tokenize", EmitDefaultValue = true)]
        public bool Tokenize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParaphraseTextRequest {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Texts: ").Append(Texts).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
            sb.Append("  DiversityDegree: ").Append(DiversityDegree).Append("\n");
            sb.Append("  Tokenize: ").Append(Tokenize).Append("\n");
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
            return this.Equals(input as ParaphraseTextRequest);
        }

        /// <summary>
        /// Returns true if ParaphraseTextRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ParaphraseTextRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParaphraseTextRequest input)
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
                    this.Texts == input.Texts ||
                    this.Texts != null &&
                    input.Texts != null &&
                    this.Texts.SequenceEqual(input.Texts)
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Suggestions == input.Suggestions ||
                    this.Suggestions.Equals(input.Suggestions)
                ) && 
                (
                    this.DiversityDegree == input.DiversityDegree ||
                    this.DiversityDegree.Equals(input.DiversityDegree)
                ) && 
                (
                    this.Tokenize == input.Tokenize ||
                    this.Tokenize.Equals(input.Tokenize)
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
                if (this.Texts != null)
                {
                    hashCode = (hashCode * 59) + this.Texts.GetHashCode();
                }
                if (this.Origin != null)
                {
                    hashCode = (hashCode * 59) + this.Origin.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Suggestions.GetHashCode();
                hashCode = (hashCode * 59) + this.DiversityDegree.GetHashCode();
                hashCode = (hashCode * 59) + this.Tokenize.GetHashCode();
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
            // Language (string) minLength
            if (this.Language != null && this.Language.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Language, length must be greater than 1.", new [] { "Language" });
            }

            yield break;
        }
    }

}
