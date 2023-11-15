# GroupDocs.Rewriter.Cloud.Sdk.Api.SynonymizeApi

All URIs are relative to *https://api.groupdocs.cloud/v2.0/rewriter*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SynonymizeHcGet**](SynonymizeApi.md#synonymizehcget) | **GET** /synonymize/hc | Health check for all synonymizer services. |
| [**SynonymizeTextPost**](SynonymizeApi.md#synonymizetextpost) | **POST** /synonymize/text | Synonymize word |
| [**SynonymizeTextRequestIdGet**](SynonymizeApi.md#synonymizetextrequestidget) | **GET** /synonymize/text/{requestId} | Return text synonymizing status.  Also return list of synonyms if it was successful |

<a id="synonymizehcget"></a>
# **SynonymizeHcGet**
> HealthCheckResponse SynonymizeHcGet ()

Health check for all synonymizer services.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SynonymizeHcGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SynonymizeApi(config);

            try
            {
                // Health check for all synonymizer services.
                HealthCheckResponse result = apiInstance.SynonymizeHcGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SynonymizeApi.SynonymizeHcGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SynonymizeHcGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Health check for all synonymizer services.
    ApiResponse<HealthCheckResponse> response = apiInstance.SynonymizeHcGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SynonymizeApi.SynonymizeHcGetWithHttpInfo: " + e.Message);
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

<a id="synonymizetextpost"></a>
# **SynonymizeTextPost**
> StatusResponse SynonymizeTextPost (SynonymizeTextRequest synonymizeTextRequest = null)

Synonymize word

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SynonymizeTextPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SynonymizeApi(config);
            var synonymizeTextRequest = new SynonymizeTextRequest(); // SynonymizeTextRequest | String in body of request, containing JSON with parameters for synonymizing. (optional) 

            try
            {
                // Synonymize word
                StatusResponse result = apiInstance.SynonymizeTextPost(synonymizeTextRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SynonymizeApi.SynonymizeTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SynonymizeTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Synonymize word
    ApiResponse<StatusResponse> response = apiInstance.SynonymizeTextPostWithHttpInfo(synonymizeTextRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SynonymizeApi.SynonymizeTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **synonymizeTextRequest** | [**SynonymizeTextRequest**](SynonymizeTextRequest.md) | String in body of request, containing JSON with parameters for synonymizing. | [optional]  |

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

<a id="synonymizetextrequestidget"></a>
# **SynonymizeTextRequestIdGet**
> SynonymizeTextResponse SynonymizeTextRequestIdGet (string requestId)

Return text synonymizing status.  Also return list of synonyms if it was successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Rewriter.Cloud.Sdk.Api;
using GroupDocs.Rewriter.Cloud.Sdk.Client;
using GroupDocs.Rewriter.Cloud.Sdk.Model;

namespace Example
{
    public class SynonymizeTextRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/rewriter";
            var apiInstance = new SynonymizeApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/rewriter/text response

            try
            {
                // Return text synonymizing status.  Also return list of synonyms if it was successful
                SynonymizeTextResponse result = apiInstance.SynonymizeTextRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SynonymizeApi.SynonymizeTextRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SynonymizeTextRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return text synonymizing status.  Also return list of synonyms if it was successful
    ApiResponse<SynonymizeTextResponse> response = apiInstance.SynonymizeTextRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SynonymizeApi.SynonymizeTextRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/rewriter/text response |  |

### Return type

[**SynonymizeTextResponse**](SynonymizeTextResponse.md)

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

