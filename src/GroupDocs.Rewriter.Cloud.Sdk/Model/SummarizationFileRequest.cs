/*
 * GroupDocs.Rewriter API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 23.11.0
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
    /// SummarizationFileRequest
    /// </summary>
    [DataContract(Name = "SummarizationFileRequest")]
    public partial class SummarizationFileRequest : IEquatable<SummarizationFileRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", IsRequired = true, EmitDefaultValue = true)]
        public SupportedFormats Format { get; set; }
        /// <summary>
        /// Mode of saving. By default is SavingMode.Files
        /// </summary>
        /// <value>Mode of saving. By default is SavingMode.Files</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SavingModeEnum
        {
            /// <summary>
            /// Enum Files for value: Files
            /// </summary>
            [EnumMember(Value = "Files")]
            Files = 1,

            /// <summary>
            /// Enum Archive for value: Archive
            /// </summary>
            [EnumMember(Value = "Archive")]
            Archive = 2,

            /// <summary>
            /// Enum Both for value: Both
            /// </summary>
            [EnumMember(Value = "Both")]
            Both = 3

        }


        /// <summary>
        /// Mode of saving. By default is SavingMode.Files
        /// </summary>
        /// <value>Mode of saving. By default is SavingMode.Files</value>
        [DataMember(Name = "savingMode", EmitDefaultValue = false)]
        public SavingModeEnum? SavingMode { get; set; }

        /// <summary>
        /// Gets or Sets OutputFormat
        /// </summary>
        [DataMember(Name = "outputFormat", IsRequired = true, EmitDefaultValue = true)]
        public SupportedConversionsFormats OutputFormat { get; set; }

        /// <summary>
        /// Gets or Sets SummarizationDegree
        /// </summary>
        [DataMember(Name = "summarizationDegree", EmitDefaultValue = false)]
        public DiversityEnum? SummarizationDegree { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationFileRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SummarizationFileRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationFileRequest" /> class.
        /// </summary>
        /// <param name="language">Set language of text (required).</param>
        /// <param name="format">format (required).</param>
        /// <param name="file">file.</param>
        /// <param name="url">url.</param>
        /// <param name="origin">Information about SDK user, like a User-Agent.</param>
        /// <param name="originalName">originalName.</param>
        /// <param name="savingMode">Mode of saving. By default is SavingMode.Files.</param>
        /// <param name="outputFormat">outputFormat (required).</param>
        /// <param name="summarizationDegree">summarizationDegree.</param>
        /// <param name="minLength">Minimum length of the target text.</param>
        public SummarizationFileRequest(string language = default(string), SupportedFormats format = default(SupportedFormats), byte[] file = default(byte[]), string url = default(string), string origin = default(string), string originalName = default(string), SavingModeEnum? savingMode = default(SavingModeEnum?), SupportedConversionsFormats outputFormat = default(SupportedConversionsFormats), DiversityEnum? summarizationDegree = default(DiversityEnum?), int minLength = default(int))
        {
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new ArgumentNullException("language is a required property for SummarizationFileRequest and cannot be null");
            }
            this.Language = language;
            this.Format = format;
            this.OutputFormat = outputFormat;
            this.File = file;
            this.Url = url;
            this.Origin = origin;
            this.OriginalName = originalName;
            this.SavingMode = savingMode;
            this.SummarizationDegree = summarizationDegree;
            this.MinLength = minLength;
        }

        /// <summary>
        /// Set language of text
        /// </summary>
        /// <value>Set language of text</value>
        [DataMember(Name = "language", IsRequired = true, EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false)]
        public byte[] File { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Information about SDK user, like a User-Agent
        /// </summary>
        /// <value>Information about SDK user, like a User-Agent</value>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or Sets OriginalName
        /// </summary>
        [DataMember(Name = "originalName", EmitDefaultValue = false)]
        public string OriginalName { get; set; }

        /// <summary>
        /// Minimum length of the target text
        /// </summary>
        /// <value>Minimum length of the target text</value>
        [DataMember(Name = "minLength", EmitDefaultValue = false)]
        public int MinLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SummarizationFileRequest {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  OriginalName: ").Append(OriginalName).Append("\n");
            sb.Append("  SavingMode: ").Append(SavingMode).Append("\n");
            sb.Append("  OutputFormat: ").Append(OutputFormat).Append("\n");
            sb.Append("  SummarizationDegree: ").Append(SummarizationDegree).Append("\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
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
            return this.Equals(input as SummarizationFileRequest);
        }

        /// <summary>
        /// Returns true if SummarizationFileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SummarizationFileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummarizationFileRequest input)
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
                    this.Format == input.Format ||
                    this.Format.Equals(input.Format)
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.OriginalName == input.OriginalName ||
                    (this.OriginalName != null &&
                    this.OriginalName.Equals(input.OriginalName))
                ) && 
                (
                    this.SavingMode == input.SavingMode ||
                    this.SavingMode.Equals(input.SavingMode)
                ) && 
                (
                    this.OutputFormat == input.OutputFormat ||
                    this.OutputFormat.Equals(input.OutputFormat)
                ) && 
                (
                    this.SummarizationDegree == input.SummarizationDegree ||
                    this.SummarizationDegree.Equals(input.SummarizationDegree)
                ) && 
                (
                    this.MinLength == input.MinLength ||
                    this.MinLength.Equals(input.MinLength)
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
                hashCode = (hashCode * 59) + this.Format.GetHashCode();
                if (this.File != null)
                {
                    hashCode = (hashCode * 59) + this.File.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.Origin != null)
                {
                    hashCode = (hashCode * 59) + this.Origin.GetHashCode();
                }
                if (this.OriginalName != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SavingMode.GetHashCode();
                hashCode = (hashCode * 59) + this.OutputFormat.GetHashCode();
                hashCode = (hashCode * 59) + this.SummarizationDegree.GetHashCode();
                hashCode = (hashCode * 59) + this.MinLength.GetHashCode();
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
