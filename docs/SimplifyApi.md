# GroupDocs.Rewriter.Cloud.Sdk.Api.SimplifyApi

All URIs are relative to *https://api.groupdocs.cloud/v2.0/rewriter*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SimplifyDocumentPost**](SimplifyApi.md#simplifydocumentpost) | **POST** /simplify/document | Simplify document |
| [**SimplifyDocumentRequestIdGet**](SimplifyApi.md#simplifydocumentrequestidget) | **GET** /simplify/document/{requestId} | Return document simplifying status.  Also return URLs for downloading of simplified document if paraphrasig was successful |
| [**SimplifyDocumentTrialPost**](SimplifyApi.md#simplifydocumenttrialpost) | **POST** /simplify/document/trial | Trial simplify document |
| [**SimplifyHcGet**](SimplifyApi.md#simplifyhcget) | **GET** /simplify/hc | Health check for all simplify services. |
| [**SimplifySupportedConversionsGet**](SimplifyApi.md#simplifysupportedconversionsget) | **GET** /simplify/supportedConversions |  |
| [**SimplifyTextPost**](SimplifyApi.md#simplifytextpost) | **POST** /simplify/text | Simplify text |
| [**SimplifyTextRequestIdGet**](SimplifyApi.md#simplifytextrequestidget) | **GET** /simplify/text/{requestId} | Return text simplifying status.  Also return simplified text if paraphrasing was successful |
| [**SimplifyTextTrialPost**](SimplifyApi.md#simplifytexttrialpost) | **POST** /simplify/text/trial | Trial simplify text |

<a id="simplifydocumentpost"></a>
# **SimplifyDocumentPost**
> StatusResponse SimplifyDocumentPost (SimplifyFileRequest simplifyFileRequest = null)

Simplify document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SimplifyDocumentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SimplifyApi(config);
            var simplifyFileRequest = new SimplifyFileRequest(); // SimplifyFileRequest | String in body of request, containing JSON with parameters for simplifying. (optional) 

            try
            {
                // Simplify document
                StatusResponse result = apiInstance.SimplifyDocumentPost(simplifyFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimplifyApi.SimplifyDocumentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SimplifyDocumentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Simplify document
    ApiResponse<StatusResponse> response = apiInstance.SimplifyDocumentPostWithHttpInfo(simplifyFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SimplifyApi.SimplifyDocumentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **simplifyFileRequest** | [**SimplifyFileRequest**](SimplifyFileRequest.md) | String in body of request, containing JSON with parameters for simplifying. | [optional]  |

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

<a id="simplifydocumentrequestidget"></a>
# **SimplifyDocumentRequestIdGet**
> SimplifyFileResponse SimplifyDocumentRequestIdGet (string requestId)

Return document simplifying status.  Also return URLs for downloading of simplified document if paraphrasig was successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SimplifyDocumentRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SimplifyApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/document response

            try
            {
                // Return document simplifying status.  Also return URLs for downloading of simplified document if paraphrasig was successful
                SimplifyFileResponse result = apiInstance.SimplifyDocumentRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimplifyApi.SimplifyDocumentRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SimplifyDocumentRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return document simplifying status.  Also return URLs for downloading of simplified document if paraphrasig was successful
    ApiResponse<SimplifyFileResponse> response = apiInstance.SimplifyDocumentRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SimplifyApi.SimplifyDocumentRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/document response |  |

### Return type

[**SimplifyFileResponse**](SimplifyFileResponse.md)

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

<a id="simplifydocumenttrialpost"></a>
# **SimplifyDocumentTrialPost**
> StatusResponse SimplifyDocumentTrialPost (SimplifyTrialFileRequest simplifyTrialFileRequest = null)

Trial simplify document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SimplifyDocumentTrialPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SimplifyApi(config);
            var simplifyTrialFileRequest = new SimplifyTrialFileRequest(); // SimplifyTrialFileRequest | String in body of request, containing JSON with parameters for simplifying. (optional) 

            try
            {
                // Trial simplify document
                StatusResponse result = apiInstance.SimplifyDocumentTrialPost(simplifyTrialFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimplifyApi.SimplifyDocumentTrialPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SimplifyDocumentTrialPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trial simplify document
    ApiResponse<StatusResponse> response = apiInstance.SimplifyDocumentTrialPostWithHttpInfo(simplifyTrialFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SimplifyApi.SimplifyDocumentTrialPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **simplifyTrialFileRequest** | [**SimplifyTrialFileRequest**](SimplifyTrialFileRequest.md) | String in body of request, containing JSON with parameters for simplifying. | [optional]  |

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

<a id="simplifyhcget"></a>
# **SimplifyHcGet**
> HealthCheckResponse SimplifyHcGet ()

Health check for all simplify services.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SimplifyHcGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SimplifyApi(config);

            try
            {
                // Health check for all simplify services.
                HealthCheckResponse result = apiInstance.SimplifyHcGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimplifyApi.SimplifyHcGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SimplifyHcGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Health check for all simplify services.
    ApiResponse<HealthCheckResponse> response = apiInstance.SimplifyHcGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SimplifyApi.SimplifyHcGetWithHttpInfo: " + e.Message);
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

<a id="simplifysupportedconversionsget"></a>
# **SimplifySupportedConversionsGet**
> List&lt;string&gt; SimplifySupportedConversionsGet (string format = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SimplifySupportedConversionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SimplifyApi(config);
            var format = "Unknown";  // string |  (optional) 

            try
            {
                List<string> result = apiInstance.SimplifySupportedConversionsGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimplifyApi.SimplifySupportedConversionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SimplifySupportedConversionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<string>> response = apiInstance.SimplifySupportedConversionsGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SimplifyApi.SimplifySupportedConversionsGetWithHttpInfo: " + e.Message);
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

<a id="simplifytextpost"></a>
# **SimplifyTextPost**
> StatusResponse SimplifyTextPost (BaseTextRequest baseTextRequest = null)

Simplify text

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SimplifyTextPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SimplifyApi(config);
            var baseTextRequest = new BaseTextRequest(); // BaseTextRequest | String in body of request, containing JSON with parameters for simplifying. (optional) 

            try
            {
                // Simplify text
                StatusResponse result = apiInstance.SimplifyTextPost(baseTextRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimplifyApi.SimplifyTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SimplifyTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Simplify text
    ApiResponse<StatusResponse> response = apiInstance.SimplifyTextPostWithHttpInfo(baseTextRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SimplifyApi.SimplifyTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseTextRequest** | [**BaseTextRequest**](BaseTextRequest.md) | String in body of request, containing JSON with parameters for simplifying. | [optional]  |

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

<a id="simplifytextrequestidget"></a>
# **SimplifyTextRequestIdGet**
> SimplifyTextResponse SimplifyTextRequestIdGet (string requestId)

Return text simplifying status.  Also return simplified text if paraphrasing was successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SimplifyTextRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SimplifyApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/text response

            try
            {
                // Return text simplifying status.  Also return simplified text if paraphrasing was successful
                SimplifyTextResponse result = apiInstance.SimplifyTextRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimplifyApi.SimplifyTextRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SimplifyTextRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return text simplifying status.  Also return simplified text if paraphrasing was successful
    ApiResponse<SimplifyTextResponse> response = apiInstance.SimplifyTextRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SimplifyApi.SimplifyTextRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/text response |  |

### Return type

[**SimplifyTextResponse**](SimplifyTextResponse.md)

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

<a id="simplifytexttrialpost"></a>
# **SimplifyTextTrialPost**
> StatusResponse SimplifyTextTrialPost (BaseTextRequest baseTextRequest = null)

Trial simplify text

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SimplifyTextTrialPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SimplifyApi(config);
            var baseTextRequest = new BaseTextRequest(); // BaseTextRequest | String in body of request, containing JSON with parameters for simplifying. Maximum 1000 characters (optional) 

            try
            {
                // Trial simplify text
                StatusResponse result = apiInstance.SimplifyTextTrialPost(baseTextRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimplifyApi.SimplifyTextTrialPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SimplifyTextTrialPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trial simplify text
    ApiResponse<StatusResponse> response = apiInstance.SimplifyTextTrialPostWithHttpInfo(baseTextRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SimplifyApi.SimplifyTextTrialPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseTextRequest** | [**BaseTextRequest**](BaseTextRequest.md) | String in body of request, containing JSON with parameters for simplifying. Maximum 1000 characters | [optional]  |

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

