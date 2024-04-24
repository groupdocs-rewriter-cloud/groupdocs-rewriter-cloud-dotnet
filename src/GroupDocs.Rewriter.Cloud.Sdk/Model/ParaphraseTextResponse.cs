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
    /// ParaphraseTextResponse
    /// </summary>
    [DataContract(Name = "ParaphraseTextResponse")]
    public partial class ParaphraseTextResponse : IEquatable<ParaphraseTextResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public HttpStatusCode? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParaphraseTextResponse" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">Information about process.</param>
        /// <param name="paraphraseReult">paraphraseReult.</param>
        /// <param name="paraphraseResults">paraphraseResults.</param>
        /// <param name="sourceList">Return tokenized source text.</param>
        /// <param name="targetList">Return tokenized target text.</param>
        public ParaphraseTextResponse(HttpStatusCode? status = default(HttpStatusCode?), string message = default(string), string paraphraseReult = default(string), List<string> paraphraseResults = default(List<string>), List<string> sourceList = default(List<string>), List<string> targetList = default(List<string>))
        {
            this.Status = status;
            this.Message = message;
            this.ParaphraseReult = paraphraseReult;
            this.ParaphraseResults = paraphraseResults;
            this.SourceList = sourceList;
            this.TargetList = targetList;
        }

        /// <summary>
        /// Information about process
        /// </summary>
        /// <value>Information about process</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ParaphraseReult
        /// </summary>
        [DataMember(Name = "paraphraseReult", EmitDefaultValue = true)]
        public string ParaphraseReult { get; set; }

        /// <summary>
        /// Gets or Sets ParaphraseResults
        /// </summary>
        [DataMember(Name = "paraphraseResults", EmitDefaultValue = true)]
        public List<string> ParaphraseResults { get; set; }

        /// <summary>
        /// Return tokenized source text
        /// </summary>
        /// <value>Return tokenized source text</value>
        [DataMember(Name = "sourceList", EmitDefaultValue = true)]
        public List<string> SourceList { get; set; }

        /// <summary>
        /// Return tokenized target text
        /// </summary>
        /// <value>Return tokenized target text</value>
        [DataMember(Name = "targetList", EmitDefaultValue = true)]
        public List<string> TargetList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParaphraseTextResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ParaphraseReult: ").Append(ParaphraseReult).Append("\n");
            sb.Append("  ParaphraseResults: ").Append(ParaphraseResults).Append("\n");
            sb.Append("  SourceList: ").Append(SourceList).Append("\n");
            sb.Append("  TargetList: ").Append(TargetList).Append("\n");
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
            return this.Equals(input as ParaphraseTextResponse);
        }

        /// <summary>
        /// Returns true if ParaphraseTextResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ParaphraseTextResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParaphraseTextResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ParaphraseReult == input.ParaphraseReult ||
                    (this.ParaphraseReult != null &&
                    this.ParaphraseReult.Equals(input.ParaphraseReult))
                ) && 
                (
                    this.ParaphraseResults == input.ParaphraseResults ||
                    this.ParaphraseResults != null &&
                    input.ParaphraseResults != null &&
                    this.ParaphraseResults.SequenceEqual(input.ParaphraseResults)
                ) && 
                (
                    this.SourceList == input.SourceList ||
                    this.SourceList != null &&
                    input.SourceList != null &&
                    this.SourceList.SequenceEqual(input.SourceList)
                ) && 
                (
                    this.TargetList == input.TargetList ||
                    this.TargetList != null &&
                    input.TargetList != null &&
                    this.TargetList.SequenceEqual(input.TargetList)
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.ParaphraseReult != null)
                {
                    hashCode = (hashCode * 59) + this.ParaphraseReult.GetHashCode();
                }
                if (this.ParaphraseResults != null)
                {
                    hashCode = (hashCode * 59) + this.ParaphraseResults.GetHashCode();
                }
                if (this.SourceList != null)
                {
                    hashCode = (hashCode * 59) + this.SourceList.GetHashCode();
                }
                if (this.TargetList != null)
                {
                    hashCode = (hashCode * 59) + this.TargetList.GetHashCode();
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
