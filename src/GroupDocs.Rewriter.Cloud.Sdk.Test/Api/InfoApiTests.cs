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
using RestSharp;
using Xunit;

using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client.Auth;

// uncomment below to import models
//using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace GroupDocs.Rewriter.Cloud.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing InfoApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InfoApiTests : IDisposable
    {
        private InfoApi instance;

        public InfoApiTests()
        {
            var config = new Configuration()
            {
                OAuthClientId = Fixture.ClientId,
                OAuthClientSecret = Fixture.ClientSecret,
                OAuthFlow = OAuthFlow.APPLICATION,
                BasePath = Fixture.ApiUrl
            };
            instance = new InfoApi(config);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InfoApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InfoApi
            //Assert.IsType<InfoApi>(instance);
        }

        /// <summary>
        /// Test InfoAvailableLanguagesGet
        /// </summary>
        [Fact]
        public void InfoAvailableLanguagesGetTest()
        {
            var response = instance.InfoAvailableLanguagesGet();
            Assert.NotNull(response);
        }
    }
}
