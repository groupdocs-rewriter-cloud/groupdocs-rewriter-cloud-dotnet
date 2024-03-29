﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiExceptionRequestHandler.cs">
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

using GroupDocs.Rewriter.Cloud.SDK.NET.Model;

namespace GroupDocs.Rewriter.Cloud.SDK.NET.RequestHandlers
{
    using System;
    using System.IO;
    using System.Net;

    internal class ApiExceptionRequestHandler : IRequestHandler
    {
        public string ProcessUrl(string url)
        {
            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                this.ThrowApiException(response, resultStream);                
            }            
        }

        private void ThrowApiException(HttpWebResponse webResponse, Stream resultStream)
        {
            Exception resutException;
            try
            {
                resultStream.Position = 0;
                using (var responseReader = new StreamReader(resultStream))
                {
                    var responseData = responseReader.ReadToEnd();
                    Console.WriteLine(responseData);
                    var errorResponse = (RewriterErrorResponse)SerializationHelper.Deserialize(responseData, typeof(RewriterErrorResponse));
                    if (string.IsNullOrEmpty(errorResponse.Status))
                    {
                        errorResponse.Message = responseData;
                    }

                    resutException = new ApiException((int)webResponse.StatusCode, errorResponse.Message);
                }
            }
            catch (Exception)
            {
                throw new ApiException((int)webResponse.StatusCode, webResponse.StatusDescription);
            }

            throw resutException;
        }
    }
}
