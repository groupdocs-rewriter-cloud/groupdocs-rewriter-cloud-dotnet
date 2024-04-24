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
    /// Defines DetectionSupportedFormats
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DetectionSupportedFormats
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum Doc for value: Doc
        /// </summary>
        [EnumMember(Value = "Doc")]
        Doc = 2,

        /// <summary>
        /// Enum Docx for value: Docx
        /// </summary>
        [EnumMember(Value = "Docx")]
        Docx = 3,

        /// <summary>
        /// Enum Docm for value: Docm
        /// </summary>
        [EnumMember(Value = "Docm")]
        Docm = 4,

        /// <summary>
        /// Enum Rtf for value: Rtf
        /// </summary>
        [EnumMember(Value = "Rtf")]
        Rtf = 5,

        /// <summary>
        /// Enum Odt for value: Odt
        /// </summary>
        [EnumMember(Value = "Odt")]
        Odt = 6,

        /// <summary>
        /// Enum Txt for value: Txt
        /// </summary>
        [EnumMember(Value = "Txt")]
        Txt = 7,

        /// <summary>
        /// Enum Pdf for value: Pdf
        /// </summary>
        [EnumMember(Value = "Pdf")]
        Pdf = 8

    }

}
