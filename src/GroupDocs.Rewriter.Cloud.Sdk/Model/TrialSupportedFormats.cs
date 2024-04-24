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
    /// Defines TrialSupportedFormats
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrialSupportedFormats
    {
        /// <summary>
        /// Enum Docx for value: Docx
        /// </summary>
        [EnumMember(Value = "Docx")]
        Docx = 1,

        /// <summary>
        /// Enum Pdf for value: Pdf
        /// </summary>
        [EnumMember(Value = "Pdf")]
        Pdf = 2

    }

}