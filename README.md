# GroupDocs.Rewriter.Cloud.Sdk (.NET)

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

- API version: 24.4.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://products.groupdocs.cloud/rewriter/](https://products.groupdocs.cloud/rewriter/)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new DetectApi(config);
            var detectionFileRequest = new DetectionFileRequest(); // DetectionFileRequest | String in body of request, containing JSON with parameters for detecting. (optional) 

            try
            {
                // Detect paraphrasing in the document
                StatusResponse result = apiInstance.DetectDocumentPost(detectionFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DetectApi.DetectDocumentPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.groupdocs.cloud/v2.0/rewriter*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DetectApi* | [**DetectDocumentPost**](docs\DetectApi.md#detectdocumentpost) | **POST** /detect/document | Detect paraphrasing in the document
*DetectApi* | [**DetectDocumentRequestIdGet**](docs\DetectApi.md#detectdocumentrequestidget) | **GET** /detect/document/{requestId} | Return document detection status.  Also return probability of paraphrasing for the whole document and per paragraph
*DetectApi* | [**DetectDocumentTrialPost**](docs\DetectApi.md#detectdocumenttrialpost) | **POST** /detect/document/trial | Trial detect paraphrasing in the document
*DetectApi* | [**DetectHcGet**](docs\DetectApi.md#detecthcget) | **GET** /detect/hc | Health check for detect all services.
*DetectApi* | [**DetectTextPost**](docs\DetectApi.md#detecttextpost) | **POST** /detect/text | Detect paraphrasing in text
*DetectApi* | [**DetectTextRequestIdGet**](docs\DetectApi.md#detecttextrequestidget) | **GET** /detect/text/{requestId} | Return text detection status.  Also return probability of paraphrasing for the whole text
*DetectApi* | [**DetectTextTrialPost**](docs\DetectApi.md#detecttexttrialpost) | **POST** /detect/text/trial | Trial detect paraphrasing in text
*FileApi* | [**FileUploadPost**](docs\FileApi.md#fileuploadpost) | **POST** /file/upload | 
*InfoApi* | [**InfoAvailableLanguagesGet**](docs\InfoApi.md#infoavailablelanguagesget) | **GET** /info/availableLanguages | 
*ParaphraseApi* | [**ParaphraseDocumentPost**](docs\ParaphraseApi.md#paraphrasedocumentpost) | **POST** /paraphrase/document | Paraphrase document
*ParaphraseApi* | [**ParaphraseDocumentRequestIdGet**](docs\ParaphraseApi.md#paraphrasedocumentrequestidget) | **GET** /paraphrase/document/{requestId} | Return document rewriting status.  Also return URLs for downloading of rewritten document if paraphrasig was successful
*ParaphraseApi* | [**ParaphraseDocumentTrialPost**](docs\ParaphraseApi.md#paraphrasedocumenttrialpost) | **POST** /paraphrase/document/trial | Trial paraphrase document
*ParaphraseApi* | [**ParaphraseHcGet**](docs\ParaphraseApi.md#paraphrasehcget) | **GET** /paraphrase/hc | Health check for all paraphrase services.
*ParaphraseApi* | [**ParaphraseSupportedConversionsGet**](docs\ParaphraseApi.md#paraphrasesupportedconversionsget) | **GET** /paraphrase/supportedConversions | 
*ParaphraseApi* | [**ParaphraseTextPost**](docs\ParaphraseApi.md#paraphrasetextpost) | **POST** /paraphrase/text | Rewrite text
*ParaphraseApi* | [**ParaphraseTextRequestIdGet**](docs\ParaphraseApi.md#paraphrasetextrequestidget) | **GET** /paraphrase/text/{requestId} | Return text rewriting status.  Also return rewritten text if paraphrasing was successful
*ParaphraseApi* | [**ParaphraseTextTrialPost**](docs\ParaphraseApi.md#paraphrasetexttrialpost) | **POST** /paraphrase/text/trial | Trial rewrite text
*SimplifyApi* | [**SimplifyDocumentPost**](docs\SimplifyApi.md#simplifydocumentpost) | **POST** /simplify/document | Simplify document
*SimplifyApi* | [**SimplifyDocumentRequestIdGet**](docs\SimplifyApi.md#simplifydocumentrequestidget) | **GET** /simplify/document/{requestId} | Return document simplifying status.  Also return URLs for downloading of simplified document if paraphrasig was successful
*SimplifyApi* | [**SimplifyDocumentTrialPost**](docs\SimplifyApi.md#simplifydocumenttrialpost) | **POST** /simplify/document/trial | Trial simplify document
*SimplifyApi* | [**SimplifyHcGet**](docs\SimplifyApi.md#simplifyhcget) | **GET** /simplify/hc | Health check for all simplify services.
*SimplifyApi* | [**SimplifySupportedConversionsGet**](docs\SimplifyApi.md#simplifysupportedconversionsget) | **GET** /simplify/supportedConversions | 
*SimplifyApi* | [**SimplifyTextPost**](docs\SimplifyApi.md#simplifytextpost) | **POST** /simplify/text | Simplify text
*SimplifyApi* | [**SimplifyTextRequestIdGet**](docs\SimplifyApi.md#simplifytextrequestidget) | **GET** /simplify/text/{requestId} | Return text simplifying status.  Also return simplified text if paraphrasing was successful
*SimplifyApi* | [**SimplifyTextTrialPost**](docs\SimplifyApi.md#simplifytexttrialpost) | **POST** /simplify/text/trial | Trial simplify text
*SummarizeApi* | [**SummarizeDocumentPost**](docs\SummarizeApi.md#summarizedocumentpost) | **POST** /summarize/document | Summarize document
*SummarizeApi* | [**SummarizeDocumentRequestIdGet**](docs\SummarizeApi.md#summarizedocumentrequestidget) | **GET** /summarize/document/{requestId} | Return document summarizing status.  Also return URLs for downloading of summarized document if summarization was successful
*SummarizeApi* | [**SummarizeDocumentTrialPost**](docs\SummarizeApi.md#summarizedocumenttrialpost) | **POST** /summarize/document/trial | Trial summarize document
*SummarizeApi* | [**SummarizeHcGet**](docs\SummarizeApi.md#summarizehcget) | **GET** /summarize/hc | Health check for all summarize services.
*SummarizeApi* | [**SummarizeSupportedConversionsGet**](docs\SummarizeApi.md#summarizesupportedconversionsget) | **GET** /summarize/supportedConversions | 
*SummarizeApi* | [**SummarizeTextPost**](docs\SummarizeApi.md#summarizetextpost) | **POST** /summarize/text | Summarize text
*SummarizeApi* | [**SummarizeTextRequestIdGet**](docs\SummarizeApi.md#summarizetextrequestidget) | **GET** /summarize/text/{requestId} | Return text summarizing status status.  Also return rewrote text if translation was successful
*SummarizeApi* | [**SummarizeTextTrialPost**](docs\SummarizeApi.md#summarizetexttrialpost) | **POST** /summarize/text/trial | Trial summarize text
*SwaggerApi* | [**SwaggerSpecGet**](docs\SwaggerApi.md#swaggerspecget) | **GET** /swagger/spec | 
*SynonymizeApi* | [**SynonymizeHcGet**](docs\SynonymizeApi.md#synonymizehcget) | **GET** /synonymize/hc | Health check for all synonymizer services.
*SynonymizeApi* | [**SynonymizeTextPost**](docs\SynonymizeApi.md#synonymizetextpost) | **POST** /synonymize/text | Synonymize word
*SynonymizeApi* | [**SynonymizeTextRequestIdGet**](docs\SynonymizeApi.md#synonymizetextrequestidget) | **GET** /synonymize/text/{requestId} | Return text synonymizing status.  Also return list of synonyms if it was successful
*SynonymizeApi* | [**SynonymizeTextTrialPost**](docs\SynonymizeApi.md#synonymizetexttrialpost) | **POST** /synonymize/text/trial | Trial synonymize word


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BaseTextRequest](docs\BaseTextRequest.md)
 - [Model.CloudTextRequest](docs\CloudTextRequest.md)
 - [Model.DegreeEnum](docs\DegreeEnum.md)
 - [Model.DetectionFileRequest](docs\DetectionFileRequest.md)
 - [Model.DetectionFileResponse](docs\DetectionFileResponse.md)
 - [Model.DetectionSupportedFormats](docs\DetectionSupportedFormats.md)
 - [Model.DetectionTextRequest](docs\DetectionTextRequest.md)
 - [Model.DetectionTextResponse](docs\DetectionTextResponse.md)
 - [Model.DetectionTrialFileRequest](docs\DetectionTrialFileRequest.md)
 - [Model.FileSavingMode](docs\FileSavingMode.md)
 - [Model.HealthCheckInfo](docs\HealthCheckInfo.md)
 - [Model.HealthCheckResponse](docs\HealthCheckResponse.md)
 - [Model.HttpStatusCode](docs\HttpStatusCode.md)
 - [Model.LanguageInfo](docs\LanguageInfo.md)
 - [Model.Model](docs\Model.md)
 - [Model.Opt](docs\Opt.md)
 - [Model.ParaphraseFileRequest](docs\ParaphraseFileRequest.md)
 - [Model.ParaphraseFileResponse](docs\ParaphraseFileResponse.md)
 - [Model.ParaphraseSupportedFormats](docs\ParaphraseSupportedFormats.md)
 - [Model.ParaphraseTextRequest](docs\ParaphraseTextRequest.md)
 - [Model.ParaphraseTextResponse](docs\ParaphraseTextResponse.md)
 - [Model.ParaphraseTrialFileRequest](docs\ParaphraseTrialFileRequest.md)
 - [Model.SimplifyFileRequest](docs\SimplifyFileRequest.md)
 - [Model.SimplifyFileResponse](docs\SimplifyFileResponse.md)
 - [Model.SimplifySupportedFromats](docs\SimplifySupportedFromats.md)
 - [Model.SimplifyTextResponse](docs\SimplifyTextResponse.md)
 - [Model.SimplifyTrialFileRequest](docs\SimplifyTrialFileRequest.md)
 - [Model.StatusResponse](docs\StatusResponse.md)
 - [Model.SummarizationFileRequest](docs\SummarizationFileRequest.md)
 - [Model.SummarizationFileResponse](docs\SummarizationFileResponse.md)
 - [Model.SummarizationSupportedFormats](docs\SummarizationSupportedFormats.md)
 - [Model.SummarizationTextRequest](docs\SummarizationTextRequest.md)
 - [Model.SummarizationTextResponse](docs\SummarizationTextResponse.md)
 - [Model.SummarizationTrialFileRequest](docs\SummarizationTrialFileRequest.md)
 - [Model.SupportedConversionsFormats](docs\SupportedConversionsFormats.md)
 - [Model.SynonymizeTextRequest](docs\SynonymizeTextRequest.md)
 - [Model.SynonymizeTextResponse](docs\SynonymizeTextResponse.md)
 - [Model.Tokenizer](docs\Tokenizer.md)
 - [Model.TrialSupportedFormats](docs\TrialSupportedFormats.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="JWT"></a>
### JWT

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: N/A

