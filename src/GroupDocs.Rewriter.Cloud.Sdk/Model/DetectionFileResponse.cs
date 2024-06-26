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
    /// DetectionFileResponse
    /// </summary>
    [DataContract(Name = "DetectionFileResponse")]
    public partial class DetectionFileResponse : IEquatable<DetectionFileResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public HttpStatusCode? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectionFileResponse" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">Information about process.</param>
        /// <param name="probability">The probability that the text turned out to be paraphrased.</param>
        /// <param name="isParaphrased">isParaphrased.</param>
        /// <param name="perParagraphProbability">perParagraphProbability.</param>
        public DetectionFileResponse(HttpStatusCode? status = default(HttpStatusCode?), string message = default(string), float probability = default(float), bool isParaphrased = default(bool), List<float> perParagraphProbability = default(List<float>))
        {
            this.Status = status;
            this.Message = message;
            this.Probability = probability;
            this.IsParaphrased = isParaphrased;
            this.PerParagraphProbability = perParagraphProbability;
        }

        /// <summary>
        /// Information about process
        /// </summary>
        /// <value>Information about process</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// The probability that the text turned out to be paraphrased
        /// </summary>
        /// <value>The probability that the text turned out to be paraphrased</value>
        [DataMember(Name = "probability", EmitDefaultValue = false)]
        public float Probability { get; set; }

        /// <summary>
        /// Gets or Sets IsParaphrased
        /// </summary>
        [DataMember(Name = "isParaphrased", EmitDefaultValue = true)]
        public bool IsParaphrased { get; set; }

        /// <summary>
        /// Gets or Sets PerParagraphProbability
        /// </summary>
        [DataMember(Name = "perParagraphProbability", EmitDefaultValue = false)]
        public List<float> PerParagraphProbability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DetectionFileResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Probability: ").Append(Probability).Append("\n");
            sb.Append("  IsParaphrased: ").Append(IsParaphrased).Append("\n");
            sb.Append("  PerParagraphProbability: ").Append(PerParagraphProbability).Append("\n");
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
            return this.Equals(input as DetectionFileResponse);
        }

        /// <summary>
        /// Returns true if DetectionFileResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DetectionFileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectionFileResponse input)
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
                    this.Probability == input.Probability ||
                    this.Probability.Equals(input.Probability)
                ) && 
                (
                    this.IsParaphrased == input.IsParaphrased ||
                    this.IsParaphrased.Equals(input.IsParaphrased)
                ) && 
                (
                    this.PerParagraphProbability == input.PerParagraphProbability ||
                    this.PerParagraphProbability != null &&
                    input.PerParagraphProbability != null &&
                    this.PerParagraphProbability.SequenceEqual(input.PerParagraphProbability)
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
                hashCode = (hashCode * 59) + this.Probability.GetHashCode();
                hashCode = (hashCode * 59) + this.IsParaphrased.GetHashCode();
                if (this.PerParagraphProbability != null)
                {
                    hashCode = (hashCode * 59) + this.PerParagraphProbability.GetHashCode();
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
