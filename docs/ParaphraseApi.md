# GroupDocs.Rewriter.Cloud.Sdk.Api.ParaphraseApi

All URIs are relative to *https://api.groupdocs.cloud/v2.0/rewriter*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ParaphraseDocumentPost**](ParaphraseApi.md#paraphrasedocumentpost) | **POST** /paraphrase/document | Rewrite document |
| [**ParaphraseDocumentRequestIdGet**](ParaphraseApi.md#paraphrasedocumentrequestidget) | **GET** /paraphrase/document/{requestId} | Return document rewriting status.  Also return URLs for downloading of rewritten document if paraphrasig was successful |
| [**ParaphraseHcGet**](ParaphraseApi.md#paraphrasehcget) | **GET** /paraphrase/hc | Health check for all paraphrase services. |
| [**ParaphraseTextPost**](ParaphraseApi.md#paraphrasetextpost) | **POST** /paraphrase/text | Rewrite text |
| [**ParaphraseTextRequestIdGet**](ParaphraseApi.md#paraphrasetextrequestidget) | **GET** /paraphrase/text/{requestId} | Return text rewriting status.  Also return rewritten text if paraphrasing was successful |

<a id="paraphrasedocumentpost"></a>
# **ParaphraseDocumentPost**
> StatusResponse ParaphraseDocumentPost (string outputFormat, string language, string format, string diversityDegree = null, System.IO.Stream file = null, string url = null, string origin = null, string savingMode = null)

Rewrite document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class ParaphraseDocumentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new ParaphraseApi(config);
            var outputFormat = "outputFormat_example";  // string | Target file format
            var language = "language_example";  // string | Set language of text
            var format = "Unknown";  // string | Source file format
            var diversityDegree = "Off";  // string | Sets the degree of text modification (optional)  (default to Medium)
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var url = "url_example";  // string |  (optional) 
            var origin = "origin_example";  // string | Information about SDK user, like a User-Agent (optional) 
            var savingMode = "Files";  // string | Mode of saving. By default is SavingMode.Files (optional) 

            try
            {
                // Rewrite document
                StatusResponse result = apiInstance.ParaphraseDocumentPost(outputFormat, language, format, diversityDegree, file, url, origin, savingMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParaphraseApi.ParaphraseDocumentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ParaphraseDocumentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rewrite document
    ApiResponse<StatusResponse> response = apiInstance.ParaphraseDocumentPostWithHttpInfo(outputFormat, language, format, diversityDegree, file, url, origin, savingMode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ParaphraseApi.ParaphraseDocumentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outputFormat** | **string** | Target file format |  |
| **language** | **string** | Set language of text |  |
| **format** | **string** | Source file format |  |
| **diversityDegree** | **string** | Sets the degree of text modification | [optional] [default to Medium] |
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |
| **url** | **string** |  | [optional]  |
| **origin** | **string** | Information about SDK user, like a User-Agent | [optional]  |
| **savingMode** | **string** | Mode of saving. By default is SavingMode.Files | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="paraphrasedocumentrequestidget"></a>
# **ParaphraseDocumentRequestIdGet**
> RewriterFileResponse ParaphraseDocumentRequestIdGet (string requestId)

Return document rewriting status.  Also return URLs for downloading of rewritten document if paraphrasig was successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class ParaphraseDocumentRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new ParaphraseApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/document response

            try
            {
                // Return document rewriting status.  Also return URLs for downloading of rewritten document if paraphrasig was successful
                RewriterFileResponse result = apiInstance.ParaphraseDocumentRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParaphraseApi.ParaphraseDocumentRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ParaphraseDocumentRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return document rewriting status.  Also return URLs for downloading of rewritten document if paraphrasig was successful
    ApiResponse<RewriterFileResponse> response = apiInstance.ParaphraseDocumentRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ParaphraseApi.ParaphraseDocumentRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/document response |  |

### Return type

[**RewriterFileResponse**](RewriterFileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="paraphrasehcget"></a>
# **ParaphraseHcGet**
> HealthCheckResponse ParaphraseHcGet ()

Health check for all paraphrase services.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class ParaphraseHcGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new ParaphraseApi(config);

            try
            {
                // Health check for all paraphrase services.
                HealthCheckResponse result = apiInstance.ParaphraseHcGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParaphraseApi.ParaphraseHcGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ParaphraseHcGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Health check for all paraphrase services.
    ApiResponse<HealthCheckResponse> response = apiInstance.ParaphraseHcGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ParaphraseApi.ParaphraseHcGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**HealthCheckResponse**](HealthCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="paraphrasetextpost"></a>
# **ParaphraseTextPost**
> StatusResponse ParaphraseTextPost (TextRequest textRequest = null)

Rewrite text

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class ParaphraseTextPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new ParaphraseApi(config);
            var textRequest = new TextRequest(); // TextRequest | String in body of request, containing JSON with parameters for rewriting. (optional) 

            try
            {
                // Rewrite text
                StatusResponse result = apiInstance.ParaphraseTextPost(textRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParaphraseApi.ParaphraseTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ParaphraseTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rewrite text
    ApiResponse<StatusResponse> response = apiInstance.ParaphraseTextPostWithHttpInfo(textRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ParaphraseApi.ParaphraseTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **textRequest** | [**TextRequest**](TextRequest.md) | String in body of request, containing JSON with parameters for rewriting. | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="paraphrasetextrequestidget"></a>
# **ParaphraseTextRequestIdGet**
> RewriterTextResponse ParaphraseTextRequestIdGet (string requestId)

Return text rewriting status.  Also return rewritten text if paraphrasing was successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class ParaphraseTextRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new ParaphraseApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/text response

            try
            {
                // Return text rewriting status.  Also return rewritten text if paraphrasing was successful
                RewriterTextResponse result = apiInstance.ParaphraseTextRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParaphraseApi.ParaphraseTextRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ParaphraseTextRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return text rewriting status.  Also return rewritten text if paraphrasing was successful
    ApiResponse<RewriterTextResponse> response = apiInstance.ParaphraseTextRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ParaphraseApi.ParaphraseTextRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/text response |  |

### Return type

[**RewriterTextResponse**](RewriterTextResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

