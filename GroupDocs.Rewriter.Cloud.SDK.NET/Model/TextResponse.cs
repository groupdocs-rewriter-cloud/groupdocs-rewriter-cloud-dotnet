// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextResponse.cs">
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

    public class TextResponse
    {
        /// <summary>
        /// Status of rewriting task
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Message if rewriting was successful or text of error
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Rewrited text
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// Source text split into sentences
        /// </summary>
        public List<string> SourceList { get; set; }

        /// <summary>
        /// Rewrited text split into sentences
        /// </summary>
        public List<string> TargetList { get; set; }


        /// <summary>
        /// For development purposes
        /// </summary>
        public Dictionary<string, long> Details { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextResponse {\n");
            sb.Append("  Status: ").Append(this.Status).Append("\n");
            sb.Append("  Message: ").Append(this.Message).Append("\n");
            sb.Append("  Result: ").Append(this.Result).Append("\n");
            sb.Append("  SourceList: ").Append(this.SourceList).Append("\n");
            sb.Append("  TargetList: ").Append(this.TargetList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
