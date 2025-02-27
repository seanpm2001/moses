# TorizonRestAPI.Api.SetupApi

All URIs are relative to *http://localhost:5000/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SetupEnableemulation**](SetupApi.md#setupenableemulation) | **GET** /setup/enableemulation | Enable ARM emulation using binfmt/qemu
[**SetupPullcontainers**](SetupApi.md#setuppullcontainers) | **GET** /setup/pullcontainers | Pulls container from docker repo



## SetupEnableemulation

> void SetupEnableemulation (string progressId = null)

Enable ARM emulation using binfmt/qemu

Uses an externa container that leverages binfmt and qemu to enable ARM32 and ARM64 emulation on non-ARM devices

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class SetupEnableemulationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new SetupApi(Configuration.Default);
            var progressId = "progressId_example";  // string | Id of a progress cookie (uuid) (optional) 

            try
            {
                // Enable ARM emulation using binfmt/qemu
                apiInstance.SetupEnableemulation(progressId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SetupApi.SetupEnableemulation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **progressId** | **string**| Id of a progress cookie (uuid) | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Unexpected exception. |  -  |
| **530** | Local docker exception. |  -  |
| **551** | Operation has been aborted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SetupPullcontainers

> void SetupPullcontainers (string progressId = null)

Pulls container from docker repo

Pulls all base and SDK base container for the configured platforms. This can also be used to update them.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class SetupPullcontainersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new SetupApi(Configuration.Default);
            var progressId = "progressId_example";  // string | Id of a progress cookie (uuid) (optional) 

            try
            {
                // Pulls container from docker repo
                apiInstance.SetupPullcontainers(progressId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SetupApi.SetupPullcontainers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **progressId** | **string**| Id of a progress cookie (uuid) | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Unexpected exception. |  -  |
| **530** | Local docker exception. |  -  |
| **542** | Error pulling images from docker registry. |  -  |
| **551** | Operation has been aborted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

