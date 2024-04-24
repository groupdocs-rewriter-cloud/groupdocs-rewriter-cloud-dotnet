# GroupDocs.Rewriter.Cloud.Sdk.Api.SummarizeApi

All URIs are relative to *https://api.groupdocs.cloud/v2.0/rewriter*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SummarizeDocumentPost**](SummarizeApi.md#summarizedocumentpost) | **POST** /summarize/document | Summarize document |
| [**SummarizeDocumentRequestIdGet**](SummarizeApi.md#summarizedocumentrequestidget) | **GET** /summarize/document/{requestId} | Return document summarizing status.  Also return URLs for downloading of summarized document if summarization was successful |
| [**SummarizeDocumentTrialPost**](SummarizeApi.md#summarizedocumenttrialpost) | **POST** /summarize/document/trial | Trial summarize document |
| [**SummarizeHcGet**](SummarizeApi.md#summarizehcget) | **GET** /summarize/hc | Health check for all summarize services. |
| [**SummarizeSupportedConversionsGet**](SummarizeApi.md#summarizesupportedconversionsget) | **GET** /summarize/supportedConversions |  |
| [**SummarizeTextPost**](SummarizeApi.md#summarizetextpost) | **POST** /summarize/text | Summarize text |
| [**SummarizeTextRequestIdGet**](SummarizeApi.md#summarizetextrequestidget) | **GET** /summarize/text/{requestId} | Return text summarizing status status.  Also return rewrote text if translation was successful |
| [**SummarizeTextTrialPost**](SummarizeApi.md#summarizetexttrialpost) | **POST** /summarize/text/trial | Trial summarize text |

<a id="summarizedocumentpost"></a>
# **SummarizeDocumentPost**
> StatusResponse SummarizeDocumentPost (SummarizationFileRequest summarizationFileRequest = null)

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
            var apiInstance = new SummarizeApi(config);
            var summarizationFileRequest = new SummarizationFileRequest(); // SummarizationFileRequest | String in body of request, containing JSON with parameters for summarizing. (optional) 

            try
            {
                // Summarize document
                StatusResponse result = apiInstance.SummarizeDocumentPost(summarizationFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummarizeApi.SummarizeDocumentPost: " + e.Message);
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
    ApiResponse<StatusResponse> response = apiInstance.SummarizeDocumentPostWithHttpInfo(summarizationFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummarizeApi.SummarizeDocumentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **summarizationFileRequest** | [**SummarizationFileRequest**](SummarizationFileRequest.md) | String in body of request, containing JSON with parameters for summarizing. | [optional]  |

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

<a id="summarizedocumentrequestidget"></a>
# **SummarizeDocumentRequestIdGet**
> SummarizationFileResponse SummarizeDocumentRequestIdGet (string requestId)

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
            var apiInstance = new SummarizeApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/document response

            try
            {
                // Return document summarizing status.  Also return URLs for downloading of summarized document if summarization was successful
                SummarizationFileResponse result = apiInstance.SummarizeDocumentRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummarizeApi.SummarizeDocumentRequestIdGet: " + e.Message);
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
    ApiResponse<SummarizationFileResponse> response = apiInstance.SummarizeDocumentRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummarizeApi.SummarizeDocumentRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/document response |  |

### Return type

[**SummarizationFileResponse**](SummarizationFileResponse.md)

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

<a id="summarizedocumenttrialpost"></a>
# **SummarizeDocumentTrialPost**
> StatusResponse SummarizeDocumentTrialPost (SummarizationTrialFileRequest summarizationTrialFileRequest = null)

Trial summarize document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SummarizeDocumentTrialPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SummarizeApi(config);
            var summarizationTrialFileRequest = new SummarizationTrialFileRequest(); // SummarizationTrialFileRequest | String in body of request, containing JSON with parameters for summarizing. (optional) 

            try
            {
                // Trial summarize document
                StatusResponse result = apiInstance.SummarizeDocumentTrialPost(summarizationTrialFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummarizeApi.SummarizeDocumentTrialPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SummarizeDocumentTrialPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trial summarize document
    ApiResponse<StatusResponse> response = apiInstance.SummarizeDocumentTrialPostWithHttpInfo(summarizationTrialFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummarizeApi.SummarizeDocumentTrialPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **summarizationTrialFileRequest** | [**SummarizationTrialFileRequest**](SummarizationTrialFileRequest.md) | String in body of request, containing JSON with parameters for summarizing. | [optional]  |

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

<a id="summarizehcget"></a>
# **SummarizeHcGet**
> HealthCheckResponse SummarizeHcGet ()

Health check for all summarize services.

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
            var apiInstance = new SummarizeApi(config);

            try
            {
                // Health check for all summarize services.
                HealthCheckResponse result = apiInstance.SummarizeHcGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummarizeApi.SummarizeHcGet: " + e.Message);
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
    // Health check for all summarize services.
    ApiResponse<HealthCheckResponse> response = apiInstance.SummarizeHcGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummarizeApi.SummarizeHcGetWithHttpInfo: " + e.Message);
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

<a id="summarizesupportedconversionsget"></a>
# **SummarizeSupportedConversionsGet**
> List&lt;string&gt; SummarizeSupportedConversionsGet (string format = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SummarizeSupportedConversionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SummarizeApi(config);
            var format = "Unknown";  // string |  (optional) 

            try
            {
                List<string> result = apiInstance.SummarizeSupportedConversionsGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummarizeApi.SummarizeSupportedConversionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SummarizeSupportedConversionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<string>> response = apiInstance.SummarizeSupportedConversionsGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummarizeApi.SummarizeSupportedConversionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string** |  | [optional]  |

### Return type

**List<string>**

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
> StatusResponse SummarizeTextPost (SummarizationTextRequest summarizationTextRequest = null)

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
            var apiInstance = new SummarizeApi(config);
            var summarizationTextRequest = new SummarizationTextRequest(); // SummarizationTextRequest |  (optional) 

            try
            {
                // Summarize text
                StatusResponse result = apiInstance.SummarizeTextPost(summarizationTextRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummarizeApi.SummarizeTextPost: " + e.Message);
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
    ApiResponse<StatusResponse> response = apiInstance.SummarizeTextPostWithHttpInfo(summarizationTextRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummarizeApi.SummarizeTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **summarizationTextRequest** | [**SummarizationTextRequest**](SummarizationTextRequest.md) |  | [optional]  |

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

<a id="summarizetextrequestidget"></a>
# **SummarizeTextRequestIdGet**
> SummarizationTextResponse SummarizeTextRequestIdGet (string requestId)

Return text summarizing status status.  Also return rewrote text if translation was successful

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
            var apiInstance = new SummarizeApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/text response

            try
            {
                // Return text summarizing status status.  Also return rewrote text if translation was successful
                SummarizationTextResponse result = apiInstance.SummarizeTextRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummarizeApi.SummarizeTextRequestIdGet: " + e.Message);
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
    // Return text summarizing status status.  Also return rewrote text if translation was successful
    ApiResponse<SummarizationTextResponse> response = apiInstance.SummarizeTextRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummarizeApi.SummarizeTextRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/text response |  |

### Return type

[**SummarizationTextResponse**](SummarizationTextResponse.md)

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

<a id="summarizetexttrialpost"></a>
# **SummarizeTextTrialPost**
> StatusResponse SummarizeTextTrialPost (SummarizationTextRequest summarizationTextRequest = null)

Trial summarize text

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SummarizeTextTrialPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SummarizeApi(config);
            var summarizationTextRequest = new SummarizationTextRequest(); // SummarizationTextRequest | String in body of request, containing JSON with parameters for summarizing. Maximum 1000 characters (optional) 

            try
            {
                // Trial summarize text
                StatusResponse result = apiInstance.SummarizeTextTrialPost(summarizationTextRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummarizeApi.SummarizeTextTrialPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SummarizeTextTrialPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trial summarize text
    ApiResponse<StatusResponse> response = apiInstance.SummarizeTextTrialPostWithHttpInfo(summarizationTextRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummarizeApi.SummarizeTextTrialPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **summarizationTextRequest** | [**SummarizationTextRequest**](SummarizationTextRequest.md) | String in body of request, containing JSON with parameters for summarizing. Maximum 1000 characters | [optional]  |

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

