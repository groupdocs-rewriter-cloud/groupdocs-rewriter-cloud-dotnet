// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FileInfo.cs">
//   Copyright (c) 2021 GroupDocs.Rewriter for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Rewriter.Cloud.SDK.NET.Model
{
    using System.Text;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    /// <summary>
    /// Represents information about file.
    /// </summary>

    public class FileInfo
    {
        /// <summary>
        /// Name of the file
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Path to folder containing file
        /// </summary>
        [JsonProperty("folder")]
        public string Folder { get; set; }

        /// <summary>
        /// Storage where file is uploaded
        /// </summary>
        [JsonProperty("storage")]
        public string Storage { get; set; }

        /// <summary>
        /// "docx" if Word document, "pdf" if PDF
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// format of rewrited document
        /// </summary>
        [JsonProperty("outformat")]
        public string OutFormat { get; set; }

        /// <summary>
        /// Path to save rewrited file
        /// </summary>
        [JsonProperty("savepath")]
        public string SavePath { get; set; }

        /// <summary>
        /// Path to save rewrited file
        /// </summary>
        [JsonProperty("savefile")]
        public string SaveFile { get; set; }

        /// <summary>
        /// Language to rewrite
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }


        /// <summary>
        /// Diversity of text, choose "medium" or "high" to increase, default value "off"
        /// </summary>
        [JsonProperty("diversity")]
        public string Diversity { get; set; } = "off";


        /// <summary>
        /// For development purposes
        /// </summary>
        [JsonProperty("details")]
        public bool Details { get; set; } = false;

        ///<summary>
        /// For analysis purposes
        /// </summary>
        [JsonProperty("origin")]
        public string Origin { get; set; } = ".NET";

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummarizeFileInfo {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Folder: ").Append(this.Folder).Append("\n");
            sb.Append("  Storage: ").Append(this.Storage).Append("\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  OutFormat: ").Append(this.OutFormat).Append("\n");
            sb.Append("  SavePath: ").Append(this.SavePath).Append("\n");
            sb.Append("  SaveFile: ").Append(this.SaveFile).Append("\n");
            sb.Append("  Language: ").Append(this.Language).Append("\n");
            sb.Append("  Details: ").Append(this.Details).Append("\n");
            sb.Append("  Origin: ").Append(this.Origin).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
