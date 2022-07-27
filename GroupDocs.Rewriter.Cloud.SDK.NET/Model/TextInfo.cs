// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextInfo.cs">
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
    using Newtonsoft.Json;
    /// <summary>
    /// Represents information about plain text.
    /// </summary>
    public class TextInfo
    {
        /// <summary>
        /// Language  to rewrite
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Text to rewrite
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// For analysis purposes
        /// </summary>
        [JsonProperty("details")]
        public bool Details { get; set; } = false;

        /// <summary>
        /// For development
        /// </summary>
        [JsonProperty("origin")]
        public string Origin { get; set; } = ".NET";

        /// <summary>
        /// Should source and target texts be returned in tokenized form
        /// </summary>
        [JsonProperty("tokenize")]
        public bool Tokenize { get; set; } = false;


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummarizeTextInfo {\n");
            sb.Append("  Pair: ").Append(this.Language).Append("\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
            sb.Append("  Details: ").Append(this.Details).Append("\n");
            sb.Append("  Origin: ").Append(this.Origin).Append("\n");
            sb.Append("  Tokenize: ").Append(this.Tokenize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
