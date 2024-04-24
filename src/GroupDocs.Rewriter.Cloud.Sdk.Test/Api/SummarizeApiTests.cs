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
    ///  Class for testing SummarizeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SummarizeApiTests : IDisposable
    {
        private SummarizeApi instance;
        private FileApi _fileApi;
        public SummarizeApiTests()
        {
            var config = new Configuration();
            config.OAuthClientId = Fixture.ClientId;
            config.OAuthClientSecret = Fixture.ClientSecret;
            config.OAuthFlow = OAuthFlow.APPLICATION;
            config.BasePath = Fixture.ApiUrl;
            instance = new SummarizeApi(config);
            _fileApi = new FileApi(config);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SummarizeApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SummarizeApi
            //Assert.IsType<SummarizeApi>(instance);
        }

        /// <summary>
        /// Test SummarizeDocumentPost
        /// </summary>
        [Fact]
        public void SummarizeDocumentPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            var file = File.OpenRead("TestData/rewriter_test.pdf");
            var url = _fileApi.FileUploadPost("pdf", file);
            var request = new SummarizationFileRequest("en");
            request.Format = SummarizationSupportedFormats.Pdf;
            request.OutputFormat = SupportedConversionsFormats.Pdf;
            request.Url = url;
            request.SummarizationDegree = DegreeEnum.Medium;
            request.SavingMode = FileSavingMode.Files;
            request.Origin = "test";
            request.OriginalName = "rewriter_test.pdf";
            var resp = instance.SummarizeDocumentPostWithHttpInfo(request);
            var response = resp.Data;
            Assert.IsType<StatusResponse>(response);
            while (true)
            {
                var result = instance.SummarizeDocumentRequestIdGet(response.Id);
                if (Enum.Parse<System.Net.HttpStatusCode>(result.Status?.ToString() ?? "400") == System.Net.HttpStatusCode.OK)
                {
                    Assert.NotEmpty(result.Url);
                    break;
                }
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Test SummarizeDocumentRequestIdGet
        /// </summary>
        [Fact]
        public void SummarizeDocumentRequestIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //var response = instance.SummarizeDocumentRequestIdGet(requestId);
            //Assert.IsType<CloudFileResponse>(response);
        }

        /// <summary>
        /// Test SummarizeHcGet
        /// </summary>
        [Fact]
        public void SummarizeHcGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SummarizeHcGet();
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test SummarizeTextPost
        /// </summary>
        [Fact]
        public void SummarizeTextPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            var textRequest = new SummarizationTextRequest("en");
            textRequest.Text = "The \"directory where postgresql will keep all databases\" (and configuration) is called \"data directory\" and corresponds to what PostgreSQL calls (a little confusingly) a \"database cluster\", which is not related to distributed computing, it just means a group of databases and related objects managed by a PostgreSQL server.";
            textRequest.Texts = new List<string>()
            {
                "The \"directory where postgresql will keep all databases\" (and configuration) is called \"data directory\" and corresponds to what PostgreSQL calls (a little confusingly) a \"database cluster\", which is not related to distributed computing, it just means a group of databases and related objects managed by a PostgreSQL server."
            };
            textRequest.SummarizationDegree = DegreeEnum.Medium;
            textRequest.Origin = "test";
            var response = instance.SummarizeTextPost(textRequest);
            Assert.IsType<StatusResponse>(response);
            while (true)
            {
                var result = instance.SummarizeTextRequestIdGet(response.Id);
                if (Enum.Parse<System.Net.HttpStatusCode>(result.Status?.ToString() ?? "400") == System.Net.HttpStatusCode.OK)
                {
                    Assert.NotEmpty(result.SummarizationResult);
                    break;
                }
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Test SummarizeTextRequestIdGet
        /// </summary>
        [Fact]
        public void SummarizeTextRequestIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //var response = instance.SummarizeTextRequestIdGet(requestId);
            //Assert.IsType<CloudTextResponse>(response);
        }
    }
}
