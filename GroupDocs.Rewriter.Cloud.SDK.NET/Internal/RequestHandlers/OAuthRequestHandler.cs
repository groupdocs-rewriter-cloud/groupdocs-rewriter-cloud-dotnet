﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OAuthRequestHandler.cs">
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

namespace GroupDocs.Rewriter.Cloud.SDK.NET.RequestHandlers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net;

    using Newtonsoft.Json;

    internal class OAuthRequestHandler : IRequestHandler
    {
        private readonly Configuration configuration;
        private readonly ApiInvoker apiInvoker;

        private string accessToken;
        private string refreshToken;

        public OAuthRequestHandler(Configuration configuration)
        {
            this.configuration = configuration;

            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }

        public string ProcessUrl(string url)
        {
            if (this.configuration.AuthType != AuthType.OAuth2)
            {
                return url;
            }

            if (string.IsNullOrEmpty(this.accessToken))
            {
                this.RequestToken();
            }

            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
            if (this.configuration.AuthType != AuthType.OAuth2)
            {
                return;
            }

            request.Headers.Add("Authorization", "Bearer " + this.accessToken);
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (this.configuration.AuthType != AuthType.OAuth2)
            {
                return;
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                this.RefreshToken();

                throw new NeedRepeatRequestException();

                
            }
            
        }

        private void RefreshToken()
        {
            var requestUrl = this.configuration.ApiBaseUrl + "/oauth2/token";

            var postData = "grant_type=refresh_token";
            postData += "&refresh_token=" + this.refreshToken;

            var responseString = this.apiInvoker.InvokeApi(
                requestUrl,
                "POST",
                postData,
                contentType: "application/x-www-form-urlencoded");

            var result =
                (GetAccessTokenResult)SerializationHelper.Deserialize(responseString, typeof(GetAccessTokenResult));

            this.accessToken = result.AccessToken;
            this.refreshToken = result.RefreshToken;
        }

        private void RequestToken()
        {
            var requestUrl = this.configuration.ApiBaseUrl + "/oauth2/token";

            var postData = "grant_type=client_credentials";
            postData += "&client_id=" + this.configuration.ClientId;
            postData += "&client_secret=" + this.configuration.ClientSecret;

            var responseString = this.apiInvoker.InvokeApi(
                requestUrl,
                "POST",
                postData,
                contentType: "application/x-www-form-urlencoded");

            var result =
                (GetAccessTokenResult)SerializationHelper.Deserialize(responseString, typeof(GetAccessTokenResult));

            this.accessToken = result.AccessToken;
            this.refreshToken = result.RefreshToken;
        }

        private class GetAccessTokenResult
        {
            [JsonProperty(PropertyName = "access_token")]
            public string AccessToken { get; set; }

            [JsonProperty(PropertyName = "refresh_token")]
            public string RefreshToken { get; set; }
        }
    }
}
