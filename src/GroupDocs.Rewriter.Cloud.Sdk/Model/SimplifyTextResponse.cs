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
    /// SimplifyTextResponse
    /// </summary>
    [DataContract(Name = "SimplifyTextResponse")]
    public partial class SimplifyTextResponse : IEquatable<SimplifyTextResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public HttpStatusCode? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimplifyTextResponse" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">Information about process.</param>
        /// <param name="simplifyReult">simplifyReult.</param>
        /// <param name="simplifyResults">simplifyResults.</param>
        public SimplifyTextResponse(HttpStatusCode? status = default(HttpStatusCode?), string message = default(string), string simplifyReult = default(string), List<string> simplifyResults = default(List<string>))
        {
            this.Status = status;
            this.Message = message;
            this.SimplifyReult = simplifyReult;
            this.SimplifyResults = simplifyResults;
        }

        /// <summary>
        /// Information about process
        /// </summary>
        /// <value>Information about process</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets SimplifyReult
        /// </summary>
        [DataMember(Name = "simplifyReult", EmitDefaultValue = true)]
        public string SimplifyReult { get; set; }

        /// <summary>
        /// Gets or Sets SimplifyResults
        /// </summary>
        [DataMember(Name = "simplifyResults", EmitDefaultValue = true)]
        public List<string> SimplifyResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SimplifyTextResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  SimplifyReult: ").Append(SimplifyReult).Append("\n");
            sb.Append("  SimplifyResults: ").Append(SimplifyResults).Append("\n");
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
            return this.Equals(input as SimplifyTextResponse);
        }

        /// <summary>
        /// Returns true if SimplifyTextResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SimplifyTextResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimplifyTextResponse input)
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
                    this.SimplifyReult == input.SimplifyReult ||
                    (this.SimplifyReult != null &&
                    this.SimplifyReult.Equals(input.SimplifyReult))
                ) && 
                (
                    this.SimplifyResults == input.SimplifyResults ||
                    this.SimplifyResults != null &&
                    input.SimplifyResults != null &&
                    this.SimplifyResults.SequenceEqual(input.SimplifyResults)
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
                if (this.SimplifyReult != null)
                {
                    hashCode = (hashCode * 59) + this.SimplifyReult.GetHashCode();
                }
                if (this.SimplifyResults != null)
                {
                    hashCode = (hashCode * 59) + this.SimplifyResults.GetHashCode();
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
