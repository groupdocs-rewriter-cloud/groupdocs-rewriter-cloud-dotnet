/*
 * GroupDocs.Rewriter API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 24.4.0
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
    /// CloudTextRequest
    /// </summary>
    [DataContract(Name = "CloudTextRequest")]
    public partial class CloudTextRequest : IEquatable<CloudTextRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudTextRequest" /> class.
        /// </summary>
        /// <param name="language">Language of original text.</param>
        /// <param name="text">Text to rewrite.</param>
        /// <param name="action">Rewrite or summarize.</param>
        /// <param name="texts">Text array to rewrite.</param>
        /// <param name="suggestions">Number of suggested variants, 3 maximum.</param>
        /// <param name="diversity">Diversity of text.</param>
        /// <param name="tokenize">Should source and target texts be returned in tokenized form.</param>
        /// <param name="origin">for analysis only.</param>
        /// <param name="requestId">requestId.</param>
        public CloudTextRequest(int language = default(int), string text = default(string), string action = default(string), List<string> texts = default(List<string>), int suggestions = default(int), int diversity = default(int), bool tokenize = default(bool), string origin = default(string), string requestId = default(string))
        {
            this.Language = language;
            this.Text = text;
            this.Action = action;
            this.Texts = texts;
            this.Suggestions = suggestions;
            this.Diversity = diversity;
            this.Tokenize = tokenize;
            this.Origin = origin;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Language of original text
        /// </summary>
        /// <value>Language of original text</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public int Language { get; set; }

        /// <summary>
        /// Text to rewrite
        /// </summary>
        /// <value>Text to rewrite</value>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Rewrite or summarize
        /// </summary>
        /// <value>Rewrite or summarize</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// Text array to rewrite
        /// </summary>
        /// <value>Text array to rewrite</value>
        [DataMember(Name = "texts", EmitDefaultValue = false)]
        public List<string> Texts { get; set; }

        /// <summary>
        /// Number of suggested variants, 3 maximum
        /// </summary>
        /// <value>Number of suggested variants, 3 maximum</value>
        [DataMember(Name = "suggestions", EmitDefaultValue = false)]
        public int Suggestions { get; set; }

        /// <summary>
        /// Diversity of text
        /// </summary>
        /// <value>Diversity of text</value>
        [DataMember(Name = "diversity", EmitDefaultValue = false)]
        public int Diversity { get; set; }

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
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CloudTextRequest {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Texts: ").Append(Texts).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
            sb.Append("  Diversity: ").Append(Diversity).Append("\n");
            sb.Append("  Tokenize: ").Append(Tokenize).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return this.Equals(input as CloudTextRequest);
        }

        /// <summary>
        /// Returns true if CloudTextRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudTextRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudTextRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Language == input.Language ||
                    this.Language.Equals(input.Language)
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Texts == input.Texts ||
                    this.Texts != null &&
                    input.Texts != null &&
                    this.Texts.SequenceEqual(input.Texts)
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
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                hashCode = (hashCode * 59) + this.Language.GetHashCode();
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.Texts != null)
                {
                    hashCode = (hashCode * 59) + this.Texts.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Suggestions.GetHashCode();
                hashCode = (hashCode * 59) + this.Diversity.GetHashCode();
                hashCode = (hashCode * 59) + this.Tokenize.GetHashCode();
                if (this.Origin != null)
                {
                    hashCode = (hashCode * 59) + this.Origin.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
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
