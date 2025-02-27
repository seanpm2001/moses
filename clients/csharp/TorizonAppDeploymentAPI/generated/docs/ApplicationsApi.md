# TorizonRestAPI.Api.ApplicationsApi

All URIs are relative to *http://localhost:5000/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplicationBuild**](ApplicationsApi.md#applicationbuild) | **GET** /applications/{application_id}/build | Build container image
[**ApplicationDelete**](ApplicationsApi.md#applicationdelete) | **DELETE** /applications/{application_id} | Remove an application
[**ApplicationDeploy**](ApplicationsApi.md#applicationdeploy) | **GET** /applications/{application_id}/deploy | Deploy container image
[**ApplicationGet**](ApplicationsApi.md#applicationget) | **GET** /applications/{application_id} | Get application
[**ApplicationGetcontainer**](ApplicationsApi.md#applicationgetcontainer) | **GET** /applications/{application_id}/container | Get container information
[**ApplicationGetcontainerLogs**](ApplicationsApi.md#applicationgetcontainerlogs) | **GET** /applications/{application_id}/container_logs | Get one of more lines from container logs
[**ApplicationGetdockerCommandline**](ApplicationsApi.md#applicationgetdockercommandline) | **GET** /applications/{application_id}/docker_commandline | Get docker command line to run the application/json
[**ApplicationGetdockerComposefile**](ApplicationsApi.md#applicationgetdockercomposefile) | **GET** /applications/{application_id}/docker_composefile | Get docker compose file
[**ApplicationGetprivatekey**](ApplicationsApi.md#applicationgetprivatekey) | **GET** /applications/{application_id}/privatekey | Get the path of the RSA private key
[**ApplicationModify**](ApplicationsApi.md#applicationmodify) | **PUT** /applications/{application_id} | Change application properties
[**ApplicationPushToRegistry**](ApplicationsApi.md#applicationpushtoregistry) | **GET** /applications/{application_id}/push_to_registry | Push application to docker registry
[**ApplicationReseal**](ApplicationsApi.md#applicationreseal) | **GET** /applications/{application_id}/reseal | Clean id and keys from application configuration
[**ApplicationRun**](ApplicationsApi.md#applicationrun) | **GET** /applications/{application_id}/run | Run container image
[**ApplicationRunsdk**](ApplicationsApi.md#applicationrunsdk) | **GET** /applications/{application_id}/sdk/run | Run SDK containers
[**ApplicationSdkContainer**](ApplicationsApi.md#applicationsdkcontainer) | **GET** /applications/{application_id}/sdk/container | Get SDK container
[**ApplicationStop**](ApplicationsApi.md#applicationstop) | **GET** /applications/{application_id}/stop | Stop running container image
[**ApplicationSyncfolders**](ApplicationsApi.md#applicationsyncfolders) | **GET** /applications/{application_id}/syncfolders | Synchronize folders
[**ApplicationUpdated**](ApplicationsApi.md#applicationupdated) | **GET** /applications/{application_id}/updated | Check if container image is up to date
[**ApplicationUpdatesdk**](ApplicationsApi.md#applicationupdatesdk) | **GET** /applications/{application_id}/sdk/update | Update SDK container
[**ApplicationsCreate**](ApplicationsApi.md#applicationscreate) | **GET** /applications/create | Create an application configuration
[**ApplicationsLoad**](ApplicationsApi.md#applicationsload) | **GET** /applications/load | Load an application configuration



## ApplicationBuild

> void ApplicationBuild (string applicationId, string configuration, string progressId = null)

Build container image

Build application release or debug container

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationBuildExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var configuration = "configuration_example";  // string | 
            var progressId = "progressId_example";  // string | Id of a progress cookie (uuid) (optional) 

            try
            {
                // Build container image
                apiInstance.ApplicationBuild(applicationId, configuration, progressId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationBuild: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **configuration** | **string**|  | 
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
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **530** | Local docker exception. |  -  |
| **551** | Operation has been aborted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationDelete

> void ApplicationDelete (string applicationId)

Remove an application

Remove an application and all the associated data and containers

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)

            try
            {
                // Remove an application
                apiInstance.ApplicationDelete(applicationId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationDelete: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 

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
| **204** | OK |  -  |
| **404** | Application no found |  -  |
| **500** | Unexpected exception. |  -  |
| **530** | Local docker exception. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationDeploy

> void ApplicationDeploy (string applicationId, string configuration, string deviceId, string progressId = null)

Deploy container image

Deploy application container to target

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationDeployExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var configuration = "configuration_example";  // string | 
            var deviceId = "deviceId_example";  // string | Target device serial number
            var progressId = "progressId_example";  // string | Id of a progress cookie (uuid) (optional) 

            try
            {
                // Deploy container image
                apiInstance.ApplicationDeploy(applicationId, configuration, deviceId, progressId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationDeploy: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **configuration** | **string**|  | 
 **deviceId** | **string**| Target device serial number | 
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
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **520** | Container image not found on local host. |  -  |
| **525** | Remote docker exception. |  -  |
| **530** | Local docker exception. |  -  |
| **533** | SSH error. |  -  |
| **539** | SSH tunnel error. |  -  |
| **551** | Operation has been aborted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationGet

> Application ApplicationGet (string applicationId)

Get application

Returns a specified application, knowing its id

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)

            try
            {
                // Get application
                Application result = apiInstance.ApplicationGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationGet: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 

### Return type

[**Application**](Application.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns application |  -  |
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationGetcontainer

> DockerContainer ApplicationGetcontainer (string applicationId, string configuration, string deviceId)

Get container information

Get detailed informations about container

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationGetcontainerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var configuration = "configuration_example";  // string | 
            var deviceId = "deviceId_example";  // string | Target device serial number

            try
            {
                // Get container information
                DockerContainer result = apiInstance.ApplicationGetcontainer(applicationId, configuration, deviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationGetcontainer: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **configuration** | **string**|  | 
 **deviceId** | **string**| Target device serial number | 

### Return type

[**DockerContainer**](DockerContainer.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Container information |  -  |
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **520** | Container image not found on local host. |  -  |
| **525** | Remote docker exception. |  -  |
| **530** | Local docker exception. |  -  |
| **533** | SSH error. |  -  |
| **539** | SSH tunnel error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationGetcontainerLogs

> string ApplicationGetcontainerLogs (string applicationId, string configuration, string deviceId, bool? restart = null)

Get one of more lines from container logs

Return one chunk of log (one or more lines), blocking if no data is available

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationGetcontainerLogsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var configuration = "configuration_example";  // string | 
            var deviceId = "deviceId_example";  // string | Target device serial number
            var restart = false;  // bool? | when true reads the lock back from beginning (optional)  (default to false)

            try
            {
                // Get one of more lines from container logs
                string result = apiInstance.ApplicationGetcontainerLogs(applicationId, configuration, deviceId, restart);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationGetcontainerLogs: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **configuration** | **string**|  | 
 **deviceId** | **string**| Target device serial number | 
 **restart** | **bool?**| when true reads the lock back from beginning | [optional] [default to false]

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Log entries as text |  -  |
| **204** | No content |  -  |
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **525** | Remote docker exception. |  -  |
| **539** | SSH tunnel error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationGetdockerCommandline

> string ApplicationGetdockerCommandline (string applicationId, string configuration)

Get docker command line to run the application/json

Return the full docker command line that can be used to run the application container

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationGetdockerCommandlineExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var configuration = "configuration_example";  // string | 

            try
            {
                // Get docker command line to run the application/json
                string result = apiInstance.ApplicationGetdockerCommandline(applicationId, configuration);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationGetdockerCommandline: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **configuration** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Command line |  -  |
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **525** | Remote docker exception. |  -  |
| **539** | SSH tunnel error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationGetdockerComposefile

> string ApplicationGetdockerComposefile (string applicationId, string configuration)

Get docker compose file

Return docker-compose file that can be used to run the application container and its dependencies

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationGetdockerComposefileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var configuration = "configuration_example";  // string | 

            try
            {
                // Get docker compose file
                string result = apiInstance.ApplicationGetdockerComposefile(applicationId, configuration);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationGetdockerComposefile: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **configuration** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Docker-compose file (string with *nix line endings) |  -  |
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **525** | Remote docker exception. |  -  |
| **539** | SSH tunnel error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationGetprivatekey

> string ApplicationGetprivatekey (string applicationId)

Get the path of the RSA private key

Retrieve the path of the private key that allows passwordless connection to the container. The application stores the public key inside the container if ssh is enabled (usually for debug builds only)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationGetprivatekeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)

            try
            {
                // Get the path of the RSA private key
                string result = apiInstance.ApplicationGetprivatekey(applicationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationGetprivatekey: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Key path |  -  |
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationModify

> Application ApplicationModify (string applicationId, Application application = null)

Change application properties

Changes specified properties on an application

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationModifyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var application = new Application(); // Application |  (optional) 

            try
            {
                // Change application properties
                Application result = apiInstance.ApplicationModify(applicationId, application);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationModify: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **application** | [**Application**](Application.md)|  | [optional] 

### Return type

[**Application**](Application.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Application information |  -  |
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **531** | Object Does not have a valid id. |  -  |
| **532** | Object cannot be saved because it&#39;s in an invalid state. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationPushToRegistry

> void ApplicationPushToRegistry (string applicationId, string configuration, string username, string password, string progressId = null)

Push application to docker registry

Push application's container to a docker registry, using authentication

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationPushToRegistryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var configuration = "configuration_example";  // string | 
            var username = "username_example";  // string | 
            var password = "password_example";  // string | 
            var progressId = "progressId_example";  // string | Id of a progress cookie (uuid) (optional) 

            try
            {
                // Push application to docker registry
                apiInstance.ApplicationPushToRegistry(applicationId, configuration, username, password, progressId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationPushToRegistry: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **configuration** | **string**|  | 
 **username** | **string**|  | 
 **password** | **string**|  | 
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
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **520** | Container image not found on local host. |  -  |
| **530** | Local docker exception. |  -  |
| **550** | No tag has been set for the image |  -  |
| **551** | Operation has been aborted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationReseal

> void ApplicationReseal (string applicationId)

Clean id and keys from application configuration

This operation make the application no longer valid, but allow you to upload it to a git repo from where it can be cloned/forked. Id and keys will be re-generated on next re-opening of the application, leading to different names for the images etc.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationResealExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)

            try
            {
                // Clean id and keys from application configuration
                apiInstance.ApplicationReseal(applicationId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationReseal: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Application not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationRun

> DockerContainer ApplicationRun (string applicationId, string configuration, string deviceId, string progressId = null)

Run container image

Run the application release or debug container on target, if the application is already running, restarts it

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationRunExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var configuration = "configuration_example";  // string | 
            var deviceId = "deviceId_example";  // string | Target device serial number
            var progressId = "progressId_example";  // string | Id of a progress cookie (uuid) (optional) 

            try
            {
                // Run container image
                DockerContainer result = apiInstance.ApplicationRun(applicationId, configuration, deviceId, progressId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationRun: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **configuration** | **string**|  | 
 **deviceId** | **string**| Target device serial number | 
 **progressId** | **string**| Id of a progress cookie (uuid) | [optional] 

### Return type

[**DockerContainer**](DockerContainer.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Container information |  -  |
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **520** | Container image not found on local host. |  -  |
| **525** | Remote docker exception. |  -  |
| **530** | Local docker exception. |  -  |
| **533** | SSH error. |  -  |
| **539** | SSH tunnel error. |  -  |
| **551** | Operation has been aborted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationRunsdk

> ApplicationRunsdk200Response ApplicationRunsdk (string applicationId, string configuration, bool? build = null, string progressId = null)

Run SDK containers

Run SDK container and return its IP and SSH port

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationRunsdkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var configuration = "configuration_example";  // string | 
            var build = true;  // bool? |  (optional)  (default to true)
            var progressId = "progressId_example";  // string | Id of a progress cookie (uuid) (optional) 

            try
            {
                // Run SDK containers
                ApplicationRunsdk200Response result = apiInstance.ApplicationRunsdk(applicationId, configuration, build, progressId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationRunsdk: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **configuration** | **string**|  | 
 **build** | **bool?**|  | [optional] [default to true]
 **progressId** | **string**| Id of a progress cookie (uuid) | [optional] 

### Return type

[**ApplicationRunsdk200Response**](ApplicationRunsdk200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | IP and port of the SSH port exposed by container (if any) |  -  |
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **520** | Container image not found on local host. |  -  |
| **530** | Local docker exception. |  -  |
| **551** | Operation has been aborted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationSdkContainer

> DockerContainer ApplicationSdkContainer (string applicationId, string configuration)

Get SDK container

Get SDK container information (can be used to check if it's running)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationSdkContainerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var configuration = "configuration_example";  // string | 

            try
            {
                // Get SDK container
                DockerContainer result = apiInstance.ApplicationSdkContainer(applicationId, configuration);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationSdkContainer: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **configuration** | **string**|  | 

### Return type

[**DockerContainer**](DockerContainer.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Container information |  -  |
| **204** | No content |  -  |
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **520** | Container image not found on local host. |  -  |
| **530** | Local docker exception. |  -  |
| **533** | SSH error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationStop

> void ApplicationStop (string applicationId, string configuration, string deviceId)

Stop running container image

Stop application release or debug container currently running on target, operation succeeds even if the container is not running

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationStopExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var configuration = "configuration_example";  // string | 
            var deviceId = "deviceId_example";  // string | Target device serial number

            try
            {
                // Stop running container image
                apiInstance.ApplicationStop(applicationId, configuration, deviceId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationStop: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **configuration** | **string**|  | 
 **deviceId** | **string**| Target device serial number | 

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
| **525** | Remote docker exception. |  -  |
| **533** | SSH error. |  -  |
| **539** | SSH tunnel error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationSyncfolders

> void ApplicationSyncfolders (string applicationId, string sourcefolder, string configuration, string deviceId, string destfolder, bool? sourceIsSdk = null, string progressId = null)

Synchronize folders

Synchronizes folders between host/SDK container and the application container

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationSyncfoldersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var sourcefolder = "sourcefolder_example";  // string | 
            var configuration = "configuration_example";  // string | 
            var deviceId = "deviceId_example";  // string | Target device serial number
            var destfolder = "destfolder_example";  // string | 
            var sourceIsSdk = true;  // bool? |  (optional) 
            var progressId = "progressId_example";  // string | Id of a progress cookie (uuid) (optional) 

            try
            {
                // Synchronize folders
                apiInstance.ApplicationSyncfolders(applicationId, sourcefolder, configuration, deviceId, destfolder, sourceIsSdk, progressId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationSyncfolders: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **sourcefolder** | **string**|  | 
 **configuration** | **string**|  | 
 **deviceId** | **string**| Target device serial number | 
 **destfolder** | **string**|  | 
 **sourceIsSdk** | **bool?**|  | [optional] 
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
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **520** | Container image not found on local host. |  -  |
| **523** | Container is not running. |  -  |
| **525** | Remote docker exception. |  -  |
| **529** | Remote command execution failed. |  -  |
| **530** | Local docker exception. |  -  |
| **533** | SSH error. |  -  |
| **541** | SDK container is not running. |  -  |
| **549** | Container does not support SSH |  -  |
| **551** | Operation has been aborted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationUpdated

> bool ApplicationUpdated (string applicationId, string configuration)

Check if container image is up to date

Check if some properties have been changed after the last build of the configuration-specific container image

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationUpdatedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var configuration = "configuration_example";  // string | 

            try
            {
                // Check if container image is up to date
                bool result = apiInstance.ApplicationUpdated(applicationId, configuration);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationUpdated: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **configuration** | **string**|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | true if container image is up to date |  -  |
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **530** | Local docker exception. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationUpdatesdk

> void ApplicationUpdatesdk (string applicationId, string configuration, string progressId = null)

Update SDK container

Update the SDK container by adding new dev libraries or synchronizing sysroots

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationUpdatesdkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var applicationId = "applicationId_example";  // string | Id of an application (uuid)
            var configuration = "configuration_example";  // string | 
            var progressId = "progressId_example";  // string | Id of a progress cookie (uuid) (optional) 

            try
            {
                // Update SDK container
                apiInstance.ApplicationUpdatesdk(applicationId, configuration, progressId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationUpdatesdk: " + e.Message );
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
 **applicationId** | **string**| Id of an application (uuid) | 
 **configuration** | **string**|  | 
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
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **520** | Container image not found on local host. |  -  |
| **530** | Local docker exception. |  -  |
| **533** | SSH error. |  -  |
| **551** | Operation has been aborted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationsCreate

> Application ApplicationsCreate (string platformId, string path, string username = null)

Create an application configuration

Create a new application configuration

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationsCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var platformId = "platformId_example";  // string | 
            var path = "path_example";  // string | 
            var username = "username_example";  // string |  (optional) 

            try
            {
                // Create an application configuration
                Application result = apiInstance.ApplicationsCreate(platformId, path, username);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationsCreate: " + e.Message );
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
 **platformId** | **string**|  | 
 **path** | **string**|  | 
 **username** | **string**|  | [optional] 

### Return type

[**Application**](Application.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Application information |  -  |
| **404** | Platform not found |  -  |
| **500** | Unexpected exception. |  -  |
| **531** | Object Does not have a valid id. |  -  |
| **532** | Object cannot be saved because it&#39;s in an invalid state. |  -  |
| **540** | Invalid path. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApplicationsLoad

> Application ApplicationsLoad (string path)

Load an application configuration

Load an application configuration from the local filesystem

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TorizonRestAPI.Api;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace Example
{
    public class ApplicationsLoadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:5000/api";
            var apiInstance = new ApplicationsApi(Configuration.Default);
            var path = "path_example";  // string | 

            try
            {
                // Load an application configuration
                Application result = apiInstance.ApplicationsLoad(path);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ApplicationsLoad: " + e.Message );
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
 **path** | **string**|  | 

### Return type

[**Application**](Application.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an application |  -  |
| **404** | Application not found |  -  |
| **500** | Unexpected exception. |  -  |
| **531** | Object Does not have a valid id. |  -  |
| **532** | Object cannot be saved because it&#39;s in an invalid state. |  -  |
| **540** | Invalid path. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

