# GroupDocs.Rewriter.Cloud.Sdk.Api.DetectApi

All URIs are relative to *https://api.groupdocs.cloud/v2.0/rewriter*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DetectDocumentPost**](DetectApi.md#detectdocumentpost) | **POST** /detect/document | Detect paraphrasing in the document |
| [**DetectDocumentRequestIdGet**](DetectApi.md#detectdocumentrequestidget) | **GET** /detect/document/{requestId} | Return document detection status.  Also return probability of paraphrasing for the whole document and per paragraph |
| [**DetectDocumentTrialPost**](DetectApi.md#detectdocumenttrialpost) | **POST** /detect/document/trial | Trial detect paraphrasing in the document |
| [**DetectHcGet**](DetectApi.md#detecthcget) | **GET** /detect/hc | Health check for detect all services. |
| [**DetectTextPost**](DetectApi.md#detecttextpost) | **POST** /detect/text | Detect paraphrasing in text |
| [**DetectTextRequestIdGet**](DetectApi.md#detecttextrequestidget) | **GET** /detect/text/{requestId} | Return text detection status.  Also return probability of paraphrasing for the whole text |
| [**DetectTextTrialPost**](DetectApi.md#detecttexttrialpost) | **POST** /detect/text/trial | Trial detect paraphrasing in text |

<a id="detectdocumentpost"></a>
# **DetectDocumentPost**
> StatusResponse DetectDocumentPost (DetectionFileRequest detectionFileRequest = null)

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
            var apiInstance = new DetectApi(config);
            var detectionFileRequest = new DetectionFileRequest(); // DetectionFileRequest | String in body of request, containing JSON with parameters for detecting. (optional) 

            try
            {
                // Detect paraphrasing in the document
                StatusResponse result = apiInstance.DetectDocumentPost(detectionFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DetectApi.DetectDocumentPost: " + e.Message);
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
    ApiResponse<StatusResponse> response = apiInstance.DetectDocumentPostWithHttpInfo(detectionFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DetectApi.DetectDocumentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **detectionFileRequest** | [**DetectionFileRequest**](DetectionFileRequest.md) | String in body of request, containing JSON with parameters for detecting. | [optional]  |

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

<a id="detectdocumentrequestidget"></a>
# **DetectDocumentRequestIdGet**
> DetectionFileResponse DetectDocumentRequestIdGet (string requestId)

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
            var apiInstance = new DetectApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/document response

            try
            {
                // Return document detection status.  Also return probability of paraphrasing for the whole document and per paragraph
                DetectionFileResponse result = apiInstance.DetectDocumentRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DetectApi.DetectDocumentRequestIdGet: " + e.Message);
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
    ApiResponse<DetectionFileResponse> response = apiInstance.DetectDocumentRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DetectApi.DetectDocumentRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/document response |  |

### Return type

[**DetectionFileResponse**](DetectionFileResponse.md)

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

<a id="detectdocumenttrialpost"></a>
# **DetectDocumentTrialPost**
> StatusResponse DetectDocumentTrialPost (DetectionTrialFileRequest detectionTrialFileRequest = null)

Trial detect paraphrasing in the document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class DetectDocumentTrialPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new DetectApi(config);
            var detectionTrialFileRequest = new DetectionTrialFileRequest(); // DetectionTrialFileRequest | String in body of request, containing JSON with parameters for detecting. (optional) 

            try
            {
                // Trial detect paraphrasing in the document
                StatusResponse result = apiInstance.DetectDocumentTrialPost(detectionTrialFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DetectApi.DetectDocumentTrialPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DetectDocumentTrialPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trial detect paraphrasing in the document
    ApiResponse<StatusResponse> response = apiInstance.DetectDocumentTrialPostWithHttpInfo(detectionTrialFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DetectApi.DetectDocumentTrialPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **detectionTrialFileRequest** | [**DetectionTrialFileRequest**](DetectionTrialFileRequest.md) | String in body of request, containing JSON with parameters for detecting. | [optional]  |

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

<a id="detecthcget"></a>
# **DetectHcGet**
> HealthCheckResponse DetectHcGet ()

Health check for detect all services.

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
            var apiInstance = new DetectApi(config);

            try
            {
                // Health check for detect all services.
                HealthCheckResponse result = apiInstance.DetectHcGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DetectApi.DetectHcGet: " + e.Message);
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
    // Health check for detect all services.
    ApiResponse<HealthCheckResponse> response = apiInstance.DetectHcGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DetectApi.DetectHcGetWithHttpInfo: " + e.Message);
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

<a id="detecttextpost"></a>
# **DetectTextPost**
> StatusResponse DetectTextPost (DetectionTextRequest detectionTextRequest = null)

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
            var apiInstance = new DetectApi(config);
            var detectionTextRequest = new DetectionTextRequest(); // DetectionTextRequest | String in body of request, containing JSON with parameters for detection. (optional) 

            try
            {
                // Detect paraphrasing in text
                StatusResponse result = apiInstance.DetectTextPost(detectionTextRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DetectApi.DetectTextPost: " + e.Message);
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
    ApiResponse<StatusResponse> response = apiInstance.DetectTextPostWithHttpInfo(detectionTextRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DetectApi.DetectTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **detectionTextRequest** | [**DetectionTextRequest**](DetectionTextRequest.md) | String in body of request, containing JSON with parameters for detection. | [optional]  |

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

<a id="detecttextrequestidget"></a>
# **DetectTextRequestIdGet**
> DetectionTextResponse DetectTextRequestIdGet (string requestId)

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
            var apiInstance = new DetectApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/document response

            try
            {
                // Return text detection status.  Also return probability of paraphrasing for the whole text
                DetectionTextResponse result = apiInstance.DetectTextRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DetectApi.DetectTextRequestIdGet: " + e.Message);
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
    ApiResponse<DetectionTextResponse> response = apiInstance.DetectTextRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DetectApi.DetectTextRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/document response |  |

### Return type

[**DetectionTextResponse**](DetectionTextResponse.md)

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

<a id="detecttexttrialpost"></a>
# **DetectTextTrialPost**
> StatusResponse DetectTextTrialPost (DetectionTextRequest detectionTextRequest = null)

Trial detect paraphrasing in text

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class DetectTextTrialPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new DetectApi(config);
            var detectionTextRequest = new DetectionTextRequest(); // DetectionTextRequest | String in body of request, containing JSON with parameters for detection. Maximum 1000 characters (optional) 

            try
            {
                // Trial detect paraphrasing in text
                StatusResponse result = apiInstance.DetectTextTrialPost(detectionTextRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DetectApi.DetectTextTrialPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DetectTextTrialPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trial detect paraphrasing in text
    ApiResponse<StatusResponse> response = apiInstance.DetectTextTrialPostWithHttpInfo(detectionTextRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DetectApi.DetectTextTrialPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **detectionTextRequest** | [**DetectionTextRequest**](DetectionTextRequest.md) | String in body of request, containing JSON with parameters for detection. Maximum 1000 characters | [optional]  |

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

