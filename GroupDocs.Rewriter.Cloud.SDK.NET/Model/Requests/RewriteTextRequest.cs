﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RewriteTextRequest.cs">
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

namespace GroupDocs.Rewriter.Cloud.SDK.NET.Model.Requests
{
    /// <summary>
    /// Request model for rewrite text operation.
    /// </summary>  
    public class RewriteTextRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RewriteTextRequest"/> class.
        /// </summary> 
        public RewriteTextRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RewriteTextRequest"/> class.
        /// </summary>
        /// <param name="userRequest">String containing request to rewrite document</param>
        public RewriteTextRequest(string userRequest)
        {
            this.UserRequest = userRequest;
        }

        /// <summary>
        /// Name of the file to rewrite.
        /// </summary>  
        public string UserRequest { get; set; }
    }
}
