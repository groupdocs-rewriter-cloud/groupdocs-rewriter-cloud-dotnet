// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RewriterApi.cs">
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

namespace GroupDocs.Rewriter.Cloud.SDK.NET
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;
    using GroupDocs.Rewriter.Cloud.SDK.NET.Model;
    using GroupDocs.Rewriter.Cloud.SDK.NET.Model.Requests;
    using GroupDocs.Rewriter.Cloud.SDK.NET.RequestHandlers;

    /// <summary>
    /// GroupDocs.Rewriter for Cloud API
    /// </summary>
    public class RewriterApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="RewriterApi"/> class
        /// </summary>
        /// <param name="apiKey">
        /// The api Key
        /// </param>
        /// <param name="appSid">
        /// The app Sid
        /// </param>
        public RewriterApi(string apiKey, string appSid)
            : this(new Configuration { ClientSecret = apiKey, ClientId = appSid })
        {
        }

        public RewriterApi(string jwtToken)
            : this(new Configuration { JwtToken = jwtToken, ApiVersion = ApiVersion.V1, AuthType = AuthType.JWT })
        {
        }

        /// <summary>
        /// initializes a new instance of the <see cref="RewriterApi"/> class
        /// </summary>
        public RewriterApi(Configuration configuration)
        {
            this.configuration = configuration;
            var requestHandlers = new List<IRequestHandler>();

            switch (this.configuration.AuthType)
            {
                case AuthType.JWT:
                    requestHandlers.Add(new JwtRequestHandler(this.configuration));
                    break;
            }

            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }

        /// <summary>
        /// Create request for document translation
        /// </summary>
        /// <param name="name"></param>
        /// <param name="folder"></param>
        /// <param name="language"></param>
        /// <param name="format"></param>
        /// <param name="storage"></param>
        /// <param name="savefile"></param>
        /// <param name="savepath"></param>
        /// <returns></returns>
        public RewriteDocumentRequest CreateDocumentRequest(string name,
                                                                       string folder,
                                                                       string language,
                                                                       string format,
                                                                       string outformat,
                                                                       string storage,
                                                                       string savefile,
                                                                       string savepath,
                                                                       string diversity = "off",
                                                                       bool details = false,
                                                                       string origin = ".NET")
        {
            Model.FileInfo fileInfo = new Model.FileInfo
            {
                Folder = folder,
                Format = format,
                OutFormat = outformat,
                Name = name,
                Language = language,
                SaveFile = savefile,
                SavePath = savepath,
                Storage = storage,
                Details = details,
                Origin = origin,
                Diversity = diversity
            };
            string userRequest = String.Format("'[{0}]'", JsonConvert.SerializeObject(fileInfo));
            RewriteDocumentRequest request = new RewriteDocumentRequest(userRequest);
            return request;
        }

        /// <summary>
        /// Create request for text translation
        /// </summary>
        /// <param name="pair"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public RewriteTextRequest CreateTextRequest(string language, string text, string diversity = "off", int suggestions = 1, bool tokenize = false, bool details = false, string origin = ".NET")
        {
            TextInfo textInfo = new TextInfo();
            textInfo.Language = language;
            textInfo.Text = text;
            textInfo.Details = details;
            textInfo.Origin = origin;
            textInfo.Tokenize = tokenize;
            textInfo.Diversity = diversity;
            textInfo.Suggestions = suggestions;
            string userRequest = String.Format("'[{0}]'", JsonConvert.SerializeObject(textInfo,
                                                                                      Formatting.None,
                                                                                      new JsonSerializerSettings { StringEscapeHandling = StringEscapeHandling.EscapeHtml }));
            RewriteTextRequest request = new RewriteTextRequest(userRequest);
            return request;
        }

        /// <summary>
        /// Rewrite document
        /// </summary>
        /// <param name="request">Request.  <see cref="RewriteDocumentRequest"/> </param>
        /// <returns><see cref="FileResponse"/></returns>
        public FileResponse RunRewriteTask(RewriteDocumentRequest request)
        {
            if (request.UserRequest == null)
            {
                throw new ApiException(400, "Empty request");
            }

            var resourcePath = this.configuration.GetApiRootUrl() + "/document";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    request.UserRequest,
                    null,
                    null);
                if (response != null)
                {
                    return (FileResponse)SerializationHelper.Deserialize(response, typeof(FileResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Summarize document
        /// </summary>
        /// <param name="request">Request.  <see cref="RewriteDocumentRequest"/> </param>
        /// <returns><see cref="FileResponse"/></returns>
        public FileResponse RunSummarizeTask(RewriteDocumentRequest request)
        {
            if (request.UserRequest == null)
            {
                throw new ApiException(400, "Empty request");
            }

            var resourcePath = this.configuration.GetApiRootUrl() + "/summarize-document";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    request.UserRequest,
                    null,
                    null);
                if (response != null)
                {
                    return (FileResponse)SerializationHelper.Deserialize(response, typeof(FileResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Rewrite text
        /// </summary>
        /// <param name="request">Request.  <see cref="RewriteTextRequest"/> </param>
        /// <returns><see cref="TextResponse"/></returns>
        public TextResponse RunRewriteTextTask(RewriteTextRequest request)
        {
            if (request.UserRequest == null)
            {
                throw new ApiException(400, "Empty request");
            }

            var resourcePath = this.configuration.GetApiRootUrl() + "/text";


            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    request.UserRequest,
                    null,
                    null);
                if (response != null)
                {
                    return (TextResponse)SerializationHelper.Deserialize(response, typeof(TextResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Summarize text
        /// </summary>
        /// <param name="request">Request.  <see cref="RewriteTextRequest"/> </param>
        /// <returns><see cref="TextResponse"/></returns>
        public TextResponse RunSummarizeTextTask(RewriteTextRequest request)
        {
            if (request.UserRequest == null)
            {
                throw new ApiException(400, "Empty request");
            }

            var resourcePath = this.configuration.GetApiRootUrl() + "/summaroze-text";


            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    request.UserRequest,
                    null,
                    null);
                if (response != null)
                {
                    return (TextResponse)SerializationHelper.Deserialize(response, typeof(TextResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }


        /// <summary>
        /// Health check of GroupDocs.Rewriter
        /// </summary>
        /// <returns><see cref="FileResponse"/></returns>
        public FileResponse RunHealthCheck()
        {
            var resourcePath = this.configuration.GetApiRootUrl() + "/hc";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");


            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (FileResponse)SerializationHelper.Deserialize(response, typeof(FileResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Summarizer health check of GroupDocs.Rewriter
        /// </summary>
        /// <returns><see cref="FileResponse"/></returns>
        public FileResponse RunSummarizerHealthCheck()
        {
            var resourcePath = this.configuration.GetApiRootUrl() + "/hc-summarizer";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");


            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (FileResponse)SerializationHelper.Deserialize(response, typeof(FileResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Returns structure of request for document translation
        /// </summary>
        /// <returns><see cref="FileInfo"/></returns>
        public Model.FileInfo GetDocumentRequestStructure()
        {
            var resourcePath = this.configuration.GetApiRootUrl() + "/info/document";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");


            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (Model.FileInfo)SerializationHelper.Deserialize(response, typeof(Model.FileInfo));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Returns structure of request for text translation
        /// </summary>
        /// <returns><see cref="TextInfo"/></returns>
        public TextInfo GetTextRequestStructure()
        {
            var resourcePath = this.configuration.GetApiRootUrl() + "/info/text";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (TextInfo)SerializationHelper.Deserialize(response, typeof(TextInfo));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Returns structure of request for text translation
        /// </summary>
        /// <returns><see cref="string[]"/></returns>
        public string[] GetLanguages()
        {
            var resourcePath = this.configuration.GetApiRootUrl() + "/info/languages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (string[])SerializationHelper.Deserialize(response, typeof(string[]));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }
    }
}
