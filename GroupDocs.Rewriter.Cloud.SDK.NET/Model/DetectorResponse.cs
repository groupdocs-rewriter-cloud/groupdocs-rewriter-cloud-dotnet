using System;
using System.Collections.Generic;
using System.Text;

namespace GroupDocs.Rewriter.Cloud.SDK.NET.Model
{
    public class DetectorResponse
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
        /// Probability that text or document is paraphrased
        /// </summary>
        public float Probability { get; set; }

        /// <summary>
        /// If text or document is paraphrased
        /// </summary>
        public bool IsParaphrased { get; set; }

        /// <summary>
        /// Dictionary of paraphrasing probabilities for paragraphs 
        /// </summary>
        public Dictionary<int, float> PerParagraphProbability { get; set; }

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
            sb.Append("  Probability: ").Append(this.Probability).Append("\n");
            sb.Append("  IsParaphrased: ").Append(this.IsParaphrased).Append("\n");
            sb.Append("  PerParagraphProbabilitz: ").Append(this.PerParagraphProbability).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}

