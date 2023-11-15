/*
 * GroupDocs.Rewriter API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 23.8.0
 * Contact: anton.perhunov@aspose.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Threading;
using RestSharp;
using Xunit;

using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client.Auth;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

// uncomment below to import models
//using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace GroupDocs.Rewriter.Cloud.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing ParaphraseApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ParaphraseApiTests : IDisposable
    {
        private ParaphraseApi instance;

        public ParaphraseApiTests()
        {
            var config = new Configuration();
            config.OAuthClientId = "rewriter.cloud";
            config.OAuthClientSecret = "f692c7d4b2817c3112c126519b993577";
            config.OAuthFlow = OAuthFlow.APPLICATION;
            //config.BasePath = "http://localhost:5000";
            instance = new ParaphraseApi(config);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ParaphraseApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ParaphraseApi
            //Assert.IsType<ParaphraseApi>(instance);
        }

        /// <summary>
        /// Test ParaphraseDocumentPost
        /// </summary>
        [Fact]
        public void ParaphraseDocumentPostTest()
        {
            var file = File.OpenRead("TestData/rewriter_test.docx");
            var bytes = new byte[file.Length];
            file.Read(bytes, 0, bytes.Length);
            var request = new ParaphraseFileRequest("en");
            request.Format = ParaphraseFileRequest.FormatEnum.Docx;
            request.OutputFormat = SupportedConversionsFormats.Docx;
            request.File = bytes;
            request.DiversityDegree = DegreeEnum.Medium;
            request.SavingMode = FileSavingMode.Files;
            request.Origin = "test";
            request.OriginalName = "rewriter_test.docx";
            var response = instance.ParaphraseDocumentPost(request);
            Assert.IsType<StatusResponse>(response);
            while (true)
            {
                var result = instance.ParaphraseDocumentRequestIdGet(response.Id);
                if (Enum.Parse<System.Net.HttpStatusCode>(result.StatusCode?.ToString() ?? "400") == System.Net.HttpStatusCode.OK)
                {
                    Assert.NotEmpty(result.Url);
                    break;
                }
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Test ParaphraseDocumentRequestIdGet
        /// </summary>
        [Fact]
        public void ParaphraseDocumentRequestIdGetTest()
        {
            //string requestId = null;
            //var response = instance.ParaphraseDocumentRequestIdGet(requestId);
            //Assert.IsType<CloudFileResponse>(response);
        }

        /// <summary>
        /// Test ParaphraseHcGet
        /// </summary>
        [Fact]
        public void ParaphraseHcGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ParaphraseHcGet();
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test ParaphraseTextPost
        /// </summary>
        [Fact]
        public void ParaphraseTextPostTest()
        {
            var textRequest = new ParaphraseTextRequest("en");
            textRequest.Text = "The \"directory where postgresql will keep all databases\" (and configuration) is called \"data directory\" and corresponds to what PostgreSQL calls (a little confusingly) a \"database cluster\", which is not related to distributed computing, it just means a group of databases and related objects managed by a PostgreSQL server.";
            textRequest.Texts = new List<string>()
            {
                "The \"directory where postgresql will keep all databases\" (and configuration) is called \"data directory\" and corresponds to what PostgreSQL calls (a little confusingly) a \"database cluster\", which is not related to distributed computing, it just means a group of databases and related objects managed by a PostgreSQL server."
            };
            textRequest.DiversityDegree = DegreeEnum.Medium;
            textRequest.Suggestions = ParaphraseTextRequest.SuggestionsEnum.Two;
            textRequest.Tokenize = false;
            textRequest.Origin = "test";
            var response = instance.ParaphraseTextPost(textRequest);
            Assert.IsType<StatusResponse>(response);
            while (true)
            {
                var result = instance.ParaphraseTextRequestIdGet(response.Id);
                if (Enum.Parse<System.Net.HttpStatusCode>(result.StatusCode?.ToString() ?? "400") == System.Net.HttpStatusCode.OK)
                {
                    Assert.NotEmpty(result.ParaphraseResults);
                    break;
                }
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Test ParaphraseTextRequestIdGet
        /// </summary>
        [Fact]
        public void ParaphraseTextRequestIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //var response = instance.ParaphraseTextRequestIdGet(requestId);
            //Assert.IsType<CloudTextResponse>(response);
        }
    }
}
