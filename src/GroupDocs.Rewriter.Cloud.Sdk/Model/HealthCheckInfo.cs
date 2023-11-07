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
    /// HealthCheckInfo
    /// </summary>
    [DataContract(Name = "HealthCheckInfo")]
    public partial class HealthCheckInfo : IEquatable<HealthCheckInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheckInfo" /> class.
        /// </summary>
        /// <param name="filesProcessorStatus">filesProcessorStatus.</param>
        /// <param name="paraphrasingStatus">paraphrasingStatus.</param>
        /// <param name="detectorStatus">detectorStatus.</param>
        /// <param name="summarizationStatus">summarizationStatus.</param>
        public HealthCheckInfo(string filesProcessorStatus = default(string), string paraphrasingStatus = default(string), string detectorStatus = default(string), string summarizationStatus = default(string))
        {
            this.FilesProcessorStatus = filesProcessorStatus;
            this.ParaphrasingStatus = paraphrasingStatus;
            this.DetectorStatus = detectorStatus;
            this.SummarizationStatus = summarizationStatus;
        }

        /// <summary>
        /// Gets or Sets FilesProcessorStatus
        /// </summary>
        [DataMember(Name = "filesProcessorStatus", EmitDefaultValue = false)]
        public string FilesProcessorStatus { get; set; }

        /// <summary>
        /// Gets or Sets ParaphrasingStatus
        /// </summary>
        [DataMember(Name = "paraphrasingStatus", EmitDefaultValue = false)]
        public string ParaphrasingStatus { get; set; }

        /// <summary>
        /// Gets or Sets DetectorStatus
        /// </summary>
        [DataMember(Name = "detectorStatus", EmitDefaultValue = false)]
        public string DetectorStatus { get; set; }

        /// <summary>
        /// Gets or Sets SummarizationStatus
        /// </summary>
        [DataMember(Name = "summarizationStatus", EmitDefaultValue = false)]
        public string SummarizationStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HealthCheckInfo {\n");
            sb.Append("  FilesProcessorStatus: ").Append(FilesProcessorStatus).Append("\n");
            sb.Append("  ParaphrasingStatus: ").Append(ParaphrasingStatus).Append("\n");
            sb.Append("  DetectorStatus: ").Append(DetectorStatus).Append("\n");
            sb.Append("  SummarizationStatus: ").Append(SummarizationStatus).Append("\n");
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
            return this.Equals(input as HealthCheckInfo);
        }

        /// <summary>
        /// Returns true if HealthCheckInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of HealthCheckInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealthCheckInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FilesProcessorStatus == input.FilesProcessorStatus ||
                    (this.FilesProcessorStatus != null &&
                    this.FilesProcessorStatus.Equals(input.FilesProcessorStatus))
                ) && 
                (
                    this.ParaphrasingStatus == input.ParaphrasingStatus ||
                    (this.ParaphrasingStatus != null &&
                    this.ParaphrasingStatus.Equals(input.ParaphrasingStatus))
                ) && 
                (
                    this.DetectorStatus == input.DetectorStatus ||
                    (this.DetectorStatus != null &&
                    this.DetectorStatus.Equals(input.DetectorStatus))
                ) && 
                (
                    this.SummarizationStatus == input.SummarizationStatus ||
                    (this.SummarizationStatus != null &&
                    this.SummarizationStatus.Equals(input.SummarizationStatus))
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
                if (this.FilesProcessorStatus != null)
                {
                    hashCode = (hashCode * 59) + this.FilesProcessorStatus.GetHashCode();
                }
                if (this.ParaphrasingStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ParaphrasingStatus.GetHashCode();
                }
                if (this.DetectorStatus != null)
                {
                    hashCode = (hashCode * 59) + this.DetectorStatus.GetHashCode();
                }
                if (this.SummarizationStatus != null)
                {
                    hashCode = (hashCode * 59) + this.SummarizationStatus.GetHashCode();
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
