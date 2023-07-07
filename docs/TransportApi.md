# GroupDocs.Rewriter.Cloud.Sdk.Api.TransportApi

All URIs are relative to *https://api.groupdocs.cloud/v2.0/rewriter*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DetectDocumentPost**](TransportApi.md#detectdocumentpost) | **POST** /detect-document | Detect paraphrasing in the document |
| [**DetectDocumentRequestIdGet**](TransportApi.md#detectdocumentrequestidget) | **GET** /detect-document/{requestId} | Return document detection status.  Also return probability of paraphrasing for the whole document and per paragraph |
| [**DetectHcGet**](TransportApi.md#detecthcget) | **GET** /detect-hc | Health check for all services. |
| [**DetectTextPost**](TransportApi.md#detecttextpost) | **POST** /detect-text | Detect paraphrasing in text |
| [**DetectTextRequestIdGet**](TransportApi.md#detecttextrequestidget) | **GET** /detect-text/{requestId} | Return text detection status.  Also return probability of paraphrasing for the whole text |
| [**DocumentPost**](TransportApi.md#documentpost) | **POST** /document | Rewrite document |
| [**DocumentRequestIdGet**](TransportApi.md#documentrequestidget) | **GET** /document/{requestId} | Return document rewriting status.  Also return URLs for downloading of rewritten document if paraphrasig was successful |
| [**SummarizeDocumentPost**](TransportApi.md#summarizedocumentpost) | **POST** /summarize-document | Summarize document |
| [**SummarizeDocumentRequestIdGet**](TransportApi.md#summarizedocumentrequestidget) | **GET** /summarize-document/{requestId} | Return document summarizing status.  Also return URLs for downloading of summarized document if summarization was successful |
| [**SummarizeHcGet**](TransportApi.md#summarizehcget) | **GET** /summarize-hc | Health check for all services. |
| [**SummarizeTextPost**](TransportApi.md#summarizetextpost) | **POST** /summarize-text | Summarize text |
| [**SummarizeTextRequestIdGet**](TransportApi.md#summarizetextrequestidget) | **GET** /summarize-text/{requestId} | Return text summarizing status status.  Also return rewrited text if translation was successful |
| [**TextPost**](TransportApi.md#textpost) | **POST** /text | Rewrite text |
| [**TextRequestIdGet**](TransportApi.md#textrequestidget) | **GET** /text/{requestId} | Return text rewriting status.  Also return rewritten text if paraphrasing was successful |

<a id="detectdocumentpost"></a>
# **DetectDocumentPost**
> StatusResponse DetectDocumentPost (string outFormat, string language, System.IO.Stream file, string format = null, string url = null, string diversity = null, string origin = null, bool? formatting = null, int? minLength = null, string savingMode = null)

Detect paraphrasing in the document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class DetectDocumentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);
            var outFormat = "outFormat_example";  // string | output file format
            var language = "\"en\"";  // string | Language of original file (default to "en")
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var format = "Unknown";  // string | Input file format (optional)  (default to Unknown)
            var url = "url_example";  // string | Link to file for rewriting (optional) 
            var diversity = "diversity_example";  // string | Diversity of text (optional) 
            var origin = "origin_example";  // string | for analysis only (optional) 
            var formatting = true;  // bool? | If document's formatting should be preserved, default true (optional) 
            var minLength = 56;  // int? | Minimal number of characters in paragraph to detect paraphrasing (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Detect paraphrasing in the document
                StatusResponse result = apiInstance.DetectDocumentPost(outFormat, language, file, format, url, diversity, origin, formatting, minLength, savingMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.DetectDocumentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DetectDocumentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Detect paraphrasing in the document
    ApiResponse<StatusResponse> response = apiInstance.DetectDocumentPostWithHttpInfo(outFormat, language, file, format, url, diversity, origin, formatting, minLength, savingMode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.DetectDocumentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outFormat** | **string** | output file format |  |
| **language** | **string** | Language of original file | [default to &quot;en&quot;] |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **format** | **string** | Input file format | [optional] [default to Unknown] |
| **url** | **string** | Link to file for rewriting | [optional]  |
| **diversity** | **string** | Diversity of text | [optional]  |
| **origin** | **string** | for analysis only | [optional]  |
| **formatting** | **bool?** | If document&#39;s formatting should be preserved, default true | [optional]  |
| **minLength** | **int?** | Minimal number of characters in paragraph to detect paraphrasing | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |

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

<a id="detectdocumentrequestidget"></a>
# **DetectDocumentRequestIdGet**
> CloudDetectorResponse DetectDocumentRequestIdGet (string requestId)

Return document detection status.  Also return probability of paraphrasing for the whole document and per paragraph

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class DetectDocumentRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/document response

            try
            {
                // Return document detection status.  Also return probability of paraphrasing for the whole document and per paragraph
                CloudDetectorResponse result = apiInstance.DetectDocumentRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.DetectDocumentRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DetectDocumentRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return document detection status.  Also return probability of paraphrasing for the whole document and per paragraph
    ApiResponse<CloudDetectorResponse> response = apiInstance.DetectDocumentRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.DetectDocumentRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/document response |  |

### Return type

[**CloudDetectorResponse**](CloudDetectorResponse.md)

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

<a id="detecthcget"></a>
# **DetectHcGet**
> string DetectHcGet ()

Health check for all services.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class DetectHcGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);

            try
            {
                // Health check for all services.
                string result = apiInstance.DetectHcGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.DetectHcGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DetectHcGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Health check for all services.
    ApiResponse<string> response = apiInstance.DetectHcGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.DetectHcGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

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

<a id="detecttextpost"></a>
# **DetectTextPost**
> StatusResponse DetectTextPost (string language = null, string text = null, List<string> texts = null, int? suggestions = null, string diversity = null, bool? tokenize = null, string origin = null)

Detect paraphrasing in text

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class DetectTextPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);
            var language = "language_example";  // string | Language of original text (optional) 
            var text = "text_example";  // string | Text to rewrite (optional) 
            var texts = new List<string>(); // List<string> | Text array to rewrite (optional) 
            var suggestions = 56;  // int? | Number of suggested variants, 3 maximum (optional) 
            var diversity = "diversity_example";  // string | Diversity of text (optional) 
            var tokenize = true;  // bool? | Should source and target texts be returned in tokenized form (optional) 
            var origin = "origin_example";  // string | for analysis only (optional) 

            try
            {
                // Detect paraphrasing in text
                StatusResponse result = apiInstance.DetectTextPost(language, text, texts, suggestions, diversity, tokenize, origin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.DetectTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DetectTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Detect paraphrasing in text
    ApiResponse<StatusResponse> response = apiInstance.DetectTextPostWithHttpInfo(language, text, texts, suggestions, diversity, tokenize, origin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.DetectTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | Language of original text | [optional]  |
| **text** | **string** | Text to rewrite | [optional]  |
| **texts** | [**List&lt;string&gt;**](string.md) | Text array to rewrite | [optional]  |
| **suggestions** | **int?** | Number of suggested variants, 3 maximum | [optional]  |
| **diversity** | **string** | Diversity of text | [optional]  |
| **tokenize** | **bool?** | Should source and target texts be returned in tokenized form | [optional]  |
| **origin** | **string** | for analysis only | [optional]  |

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

<a id="detecttextrequestidget"></a>
# **DetectTextRequestIdGet**
> CloudDetectorResponse DetectTextRequestIdGet (string requestId)

Return text detection status.  Also return probability of paraphrasing for the whole text

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class DetectTextRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/document response

            try
            {
                // Return text detection status.  Also return probability of paraphrasing for the whole text
                CloudDetectorResponse result = apiInstance.DetectTextRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.DetectTextRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DetectTextRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return text detection status.  Also return probability of paraphrasing for the whole text
    ApiResponse<CloudDetectorResponse> response = apiInstance.DetectTextRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.DetectTextRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/document response |  |

### Return type

[**CloudDetectorResponse**](CloudDetectorResponse.md)

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

<a id="documentpost"></a>
# **DocumentPost**
> StatusResponse DocumentPost (string outFormat, string language, System.IO.Stream file, string format = null, string url = null, string diversity = null, string origin = null, bool? formatting = null, int? minLength = null, string savingMode = null)

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
    public class DocumentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);
            var outFormat = "outFormat_example";  // string | output file format
            var language = "\"en\"";  // string | Language of original file (default to "en")
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var format = "Unknown";  // string | Input file format (optional)  (default to Unknown)
            var url = "url_example";  // string | Link to file for rewriting (optional) 
            var diversity = "diversity_example";  // string | Diversity of text (optional) 
            var origin = "origin_example";  // string | for analysis only (optional) 
            var formatting = true;  // bool? | If document's formatting should be preserved, default true (optional) 
            var minLength = 56;  // int? | Minimal number of characters in paragraph to detect paraphrasing (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Rewrite document
                StatusResponse result = apiInstance.DocumentPost(outFormat, language, file, format, url, diversity, origin, formatting, minLength, savingMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.DocumentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rewrite document
    ApiResponse<StatusResponse> response = apiInstance.DocumentPostWithHttpInfo(outFormat, language, file, format, url, diversity, origin, formatting, minLength, savingMode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.DocumentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outFormat** | **string** | output file format |  |
| **language** | **string** | Language of original file | [default to &quot;en&quot;] |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **format** | **string** | Input file format | [optional] [default to Unknown] |
| **url** | **string** | Link to file for rewriting | [optional]  |
| **diversity** | **string** | Diversity of text | [optional]  |
| **origin** | **string** | for analysis only | [optional]  |
| **formatting** | **bool?** | If document&#39;s formatting should be preserved, default true | [optional]  |
| **minLength** | **int?** | Minimal number of characters in paragraph to detect paraphrasing | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |

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

<a id="documentrequestidget"></a>
# **DocumentRequestIdGet**
> CloudFileResponse DocumentRequestIdGet (string requestId)

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
    public class DocumentRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/document response

            try
            {
                // Return document rewriting status.  Also return URLs for downloading of rewritten document if paraphrasig was successful
                CloudFileResponse result = apiInstance.DocumentRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.DocumentRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumentRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return document rewriting status.  Also return URLs for downloading of rewritten document if paraphrasig was successful
    ApiResponse<CloudFileResponse> response = apiInstance.DocumentRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.DocumentRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/document response |  |

### Return type

[**CloudFileResponse**](CloudFileResponse.md)

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

<a id="summarizedocumentpost"></a>
# **SummarizeDocumentPost**
> StatusResponse SummarizeDocumentPost (string outFormat, string language, System.IO.Stream file, string format = null, string url = null, string diversity = null, string origin = null, bool? formatting = null, int? minLength = null, string savingMode = null)

Summarize document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SummarizeDocumentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);
            var outFormat = "outFormat_example";  // string | output file format
            var language = "\"en\"";  // string | Language of original file (default to "en")
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var format = "Unknown";  // string | Input file format (optional)  (default to Unknown)
            var url = "url_example";  // string | Link to file for rewriting (optional) 
            var diversity = "diversity_example";  // string | Diversity of text (optional) 
            var origin = "origin_example";  // string | for analysis only (optional) 
            var formatting = true;  // bool? | If document's formatting should be preserved, default true (optional) 
            var minLength = 56;  // int? | Minimal number of characters in paragraph to detect paraphrasing (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Summarize document
                StatusResponse result = apiInstance.SummarizeDocumentPost(outFormat, language, file, format, url, diversity, origin, formatting, minLength, savingMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.SummarizeDocumentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SummarizeDocumentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Summarize document
    ApiResponse<StatusResponse> response = apiInstance.SummarizeDocumentPostWithHttpInfo(outFormat, language, file, format, url, diversity, origin, formatting, minLength, savingMode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.SummarizeDocumentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outFormat** | **string** | output file format |  |
| **language** | **string** | Language of original file | [default to &quot;en&quot;] |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **format** | **string** | Input file format | [optional] [default to Unknown] |
| **url** | **string** | Link to file for rewriting | [optional]  |
| **diversity** | **string** | Diversity of text | [optional]  |
| **origin** | **string** | for analysis only | [optional]  |
| **formatting** | **bool?** | If document&#39;s formatting should be preserved, default true | [optional]  |
| **minLength** | **int?** | Minimal number of characters in paragraph to detect paraphrasing | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |

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

<a id="summarizedocumentrequestidget"></a>
# **SummarizeDocumentRequestIdGet**
> CloudFileResponse SummarizeDocumentRequestIdGet (string requestId)

Return document summarizing status.  Also return URLs for downloading of summarized document if summarization was successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SummarizeDocumentRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/document response

            try
            {
                // Return document summarizing status.  Also return URLs for downloading of summarized document if summarization was successful
                CloudFileResponse result = apiInstance.SummarizeDocumentRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.SummarizeDocumentRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SummarizeDocumentRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return document summarizing status.  Also return URLs for downloading of summarized document if summarization was successful
    ApiResponse<CloudFileResponse> response = apiInstance.SummarizeDocumentRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.SummarizeDocumentRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/document response |  |

### Return type

[**CloudFileResponse**](CloudFileResponse.md)

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

<a id="summarizehcget"></a>
# **SummarizeHcGet**
> string SummarizeHcGet ()

Health check for all services.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SummarizeHcGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);

            try
            {
                // Health check for all services.
                string result = apiInstance.SummarizeHcGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.SummarizeHcGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SummarizeHcGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Health check for all services.
    ApiResponse<string> response = apiInstance.SummarizeHcGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.SummarizeHcGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

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

<a id="summarizetextpost"></a>
# **SummarizeTextPost**
> StatusResponse SummarizeTextPost (string language = null, string text = null, List<string> texts = null, int? suggestions = null, string diversity = null, bool? tokenize = null, string origin = null)

Summarize text

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SummarizeTextPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);
            var language = "language_example";  // string | Language of original text (optional) 
            var text = "text_example";  // string | Text to rewrite (optional) 
            var texts = new List<string>(); // List<string> | Text array to rewrite (optional) 
            var suggestions = 56;  // int? | Number of suggested variants, 3 maximum (optional) 
            var diversity = "diversity_example";  // string | Diversity of text (optional) 
            var tokenize = true;  // bool? | Should source and target texts be returned in tokenized form (optional) 
            var origin = "origin_example";  // string | for analysis only (optional) 

            try
            {
                // Summarize text
                StatusResponse result = apiInstance.SummarizeTextPost(language, text, texts, suggestions, diversity, tokenize, origin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.SummarizeTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SummarizeTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Summarize text
    ApiResponse<StatusResponse> response = apiInstance.SummarizeTextPostWithHttpInfo(language, text, texts, suggestions, diversity, tokenize, origin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.SummarizeTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | Language of original text | [optional]  |
| **text** | **string** | Text to rewrite | [optional]  |
| **texts** | [**List&lt;string&gt;**](string.md) | Text array to rewrite | [optional]  |
| **suggestions** | **int?** | Number of suggested variants, 3 maximum | [optional]  |
| **diversity** | **string** | Diversity of text | [optional]  |
| **tokenize** | **bool?** | Should source and target texts be returned in tokenized form | [optional]  |
| **origin** | **string** | for analysis only | [optional]  |

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

<a id="summarizetextrequestidget"></a>
# **SummarizeTextRequestIdGet**
> CloudTextResponse SummarizeTextRequestIdGet (string requestId)

Return text summarizing status status.  Also return rewrited text if translation was successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SummarizeTextRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/text response

            try
            {
                // Return text summarizing status status.  Also return rewrited text if translation was successful
                CloudTextResponse result = apiInstance.SummarizeTextRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.SummarizeTextRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SummarizeTextRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return text summarizing status status.  Also return rewrited text if translation was successful
    ApiResponse<CloudTextResponse> response = apiInstance.SummarizeTextRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.SummarizeTextRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/text response |  |

### Return type

[**CloudTextResponse**](CloudTextResponse.md)

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

<a id="textpost"></a>
# **TextPost**
> StatusResponse TextPost (string language = null, string text = null, List<string> texts = null, int? suggestions = null, string diversity = null, bool? tokenize = null, string origin = null)

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
    public class TextPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);
            var language = "language_example";  // string | Language of original text (optional) 
            var text = "text_example";  // string | Text to rewrite (optional) 
            var texts = new List<string>(); // List<string> | Text array to rewrite (optional) 
            var suggestions = 56;  // int? | Number of suggested variants, 3 maximum (optional) 
            var diversity = "diversity_example";  // string | Diversity of text (optional) 
            var tokenize = true;  // bool? | Should source and target texts be returned in tokenized form (optional) 
            var origin = "origin_example";  // string | for analysis only (optional) 

            try
            {
                // Rewrite text
                StatusResponse result = apiInstance.TextPost(language, text, texts, suggestions, diversity, tokenize, origin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.TextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rewrite text
    ApiResponse<StatusResponse> response = apiInstance.TextPostWithHttpInfo(language, text, texts, suggestions, diversity, tokenize, origin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.TextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | Language of original text | [optional]  |
| **text** | **string** | Text to rewrite | [optional]  |
| **texts** | [**List&lt;string&gt;**](string.md) | Text array to rewrite | [optional]  |
| **suggestions** | **int?** | Number of suggested variants, 3 maximum | [optional]  |
| **diversity** | **string** | Diversity of text | [optional]  |
| **tokenize** | **bool?** | Should source and target texts be returned in tokenized form | [optional]  |
| **origin** | **string** | for analysis only | [optional]  |

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

<a id="textrequestidget"></a>
# **TextRequestIdGet**
> CloudTextResponse TextRequestIdGet (string requestId)

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
    public class TextRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new TransportApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/text response

            try
            {
                // Return text rewriting status.  Also return rewritten text if paraphrasing was successful
                CloudTextResponse result = apiInstance.TextRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.TextRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TextRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return text rewriting status.  Also return rewritten text if paraphrasing was successful
    ApiResponse<CloudTextResponse> response = apiInstance.TextRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.TextRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/text response |  |

### Return type

[**CloudTextResponse**](CloudTextResponse.md)

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

