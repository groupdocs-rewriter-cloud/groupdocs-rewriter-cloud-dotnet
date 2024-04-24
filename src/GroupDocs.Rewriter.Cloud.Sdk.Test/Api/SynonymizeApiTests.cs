/*
 * GroupDocs.Rewriter API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 23.11.1
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
using GroupDocs.Rewriter.Cloud.Sdk.Model;

// uncomment below to import models
//using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace GroupDocs.Rewriter.Cloud.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing SynonymizeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SynonymizeApiTests : IDisposable
    {
        private SynonymizeApi instance;

        public SynonymizeApiTests()
        {
            instance = new SynonymizeApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SynonymizeApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SynonymizeApi
            //Assert.IsType<SynonymizeApi>(instance);
        }

        /// <summary>
        /// Test SynonymizeHcGet
        /// </summary>
        [Fact]
        public void SynonymizeHcGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SynonymizeHcGet();
            //Assert.IsType<HealthCheckResponse>(response);
        }

        /// <summary>
        /// Test SynonymizeTextPost
        /// </summary>
        [Fact]
        public void SynonymizeTextPostTest()
        {
            SynonymizeTextRequest synonymizeTextRequest = new SynonymizeTextRequest("en",
                text: "Watch over your little one at home on the 5.5-inch, 1080p Full High-Definition LCD Parent Viewer Display or remotely on your smartphone/tablet with the LeapFrog Baby Care+ App.",
                origin: "sdk-autotest",
                synonyms: SynonymizeTextRequest.SynonymsEnum.All);
            var response = instance.SynonymizeTextPost(synonymizeTextRequest);
            Assert.IsType<StatusResponse>(response);
            while (true)
            {
                var result = instance.SynonymizeTextRequestIdGet(response.Id);
                if (Enum.Parse<System.Net.HttpStatusCode>(result.Status?.ToString() ?? "400") == System.Net.HttpStatusCode.OK)
                {
                    Assert.NotEmpty(result.SynonymizerResults);
                    break;
                }
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Test SynonymizeTextRequestIdGet
        /// </summary>
        [Fact]
        public void SynonymizeTextRequestIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //var response = instance.SynonymizeTextRequestIdGet(requestId);
            //Assert.IsType<SynonymizeTextResponse>(response);
        }
    }
}