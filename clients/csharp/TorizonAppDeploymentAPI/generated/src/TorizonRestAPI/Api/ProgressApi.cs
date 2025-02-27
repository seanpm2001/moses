/*
 * Torizon IDE-backend API
 *
 * Toradex API to build and deploy applications running as containers on Torizon
 *
 * The version of the OpenAPI document: 1.1.6
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using TorizonRestAPI.Client;
using TorizonRestAPI.Model;

namespace TorizonRestAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProgressApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a progress cookie
        /// </summary>
        /// <remarks>
        /// Creates a progress object that could be used to monitor and abort operations. A progress cookie must be used only for one operation and deleted when the operation is completed/terminated. Passing cookies to different operations may lead to unpredictable results.
        /// </remarks>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Progress</returns>
        Progress ProgressCreate ();

        /// <summary>
        /// Create a progress cookie
        /// </summary>
        /// <remarks>
        /// Creates a progress object that could be used to monitor and abort operations. A progress cookie must be used only for one operation and deleted when the operation is completed/terminated. Passing cookies to different operations may lead to unpredictable results.
        /// </remarks>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Progress</returns>
        ApiResponse<Progress> ProgressCreateWithHttpInfo ();
        /// <summary>
        /// Releases a progress cookie
        /// </summary>
        /// <remarks>
        /// Delete the cookie. If the operation is pending this will cause an abort. Abort may not be immediate. After the delete operation is called the progress cookie id is no longer valid and further calls to progress_status will fail.
        /// </remarks>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <returns></returns>
        void ProgressDelete (string progressId = default(string));

        /// <summary>
        /// Releases a progress cookie
        /// </summary>
        /// <remarks>
        /// Delete the cookie. If the operation is pending this will cause an abort. Abort may not be immediate. After the delete operation is called the progress cookie id is no longer valid and further calls to progress_status will fail.
        /// </remarks>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProgressDeleteWithHttpInfo (string progressId = default(string));
        /// <summary>
        /// Retrieves progress status of an operation
        /// </summary>
        /// <remarks>
        /// Return the operation status, progress and messages, it's blocking until status changes or the operation is completed/terminated. Not all operations can return detailed progress information (it may not be possible to estimate it before starting the actual operation), it's anyway granted that an operation will report its completition/failure.
        /// </remarks>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <returns>Progress</returns>
        Progress ProgressStatus (string progressId = default(string));

        /// <summary>
        /// Retrieves progress status of an operation
        /// </summary>
        /// <remarks>
        /// Return the operation status, progress and messages, it's blocking until status changes or the operation is completed/terminated. Not all operations can return detailed progress information (it may not be possible to estimate it before starting the actual operation), it's anyway granted that an operation will report its completition/failure.
        /// </remarks>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <returns>ApiResponse of Progress</returns>
        ApiResponse<Progress> ProgressStatusWithHttpInfo (string progressId = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a progress cookie
        /// </summary>
        /// <remarks>
        /// Creates a progress object that could be used to monitor and abort operations. A progress cookie must be used only for one operation and deleted when the operation is completed/terminated. Passing cookies to different operations may lead to unpredictable results.
        /// </remarks>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Progress</returns>
        System.Threading.Tasks.Task<Progress> ProgressCreateAsync (CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a progress cookie
        /// </summary>
        /// <remarks>
        /// Creates a progress object that could be used to monitor and abort operations. A progress cookie must be used only for one operation and deleted when the operation is completed/terminated. Passing cookies to different operations may lead to unpredictable results.
        /// </remarks>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Progress)</returns>
        System.Threading.Tasks.Task<ApiResponse<Progress>> ProgressCreateWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Releases a progress cookie
        /// </summary>
        /// <remarks>
        /// Delete the cookie. If the operation is pending this will cause an abort. Abort may not be immediate. After the delete operation is called the progress cookie id is no longer valid and further calls to progress_status will fail.
        /// </remarks>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProgressDeleteAsync (string progressId = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Releases a progress cookie
        /// </summary>
        /// <remarks>
        /// Delete the cookie. If the operation is pending this will cause an abort. Abort may not be immediate. After the delete operation is called the progress cookie id is no longer valid and further calls to progress_status will fail.
        /// </remarks>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ProgressDeleteWithHttpInfoAsync (string progressId = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves progress status of an operation
        /// </summary>
        /// <remarks>
        /// Return the operation status, progress and messages, it's blocking until status changes or the operation is completed/terminated. Not all operations can return detailed progress information (it may not be possible to estimate it before starting the actual operation), it's anyway granted that an operation will report its completition/failure.
        /// </remarks>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Progress</returns>
        System.Threading.Tasks.Task<Progress> ProgressStatusAsync (string progressId = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieves progress status of an operation
        /// </summary>
        /// <remarks>
        /// Return the operation status, progress and messages, it's blocking until status changes or the operation is completed/terminated. Not all operations can return detailed progress information (it may not be possible to estimate it before starting the actual operation), it's anyway granted that an operation will report its completition/failure.
        /// </remarks>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Progress)</returns>
        System.Threading.Tasks.Task<ApiResponse<Progress>> ProgressStatusWithHttpInfoAsync (string progressId = default(string), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProgressApi : IProgressApi
    {
        private TorizonRestAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProgressApi(String basePath)
        {
            this.Configuration = new TorizonRestAPI.Client.Configuration { BasePath = basePath };

            ExceptionFactory = TorizonRestAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProgressApi()
        {
            this.Configuration = TorizonRestAPI.Client.Configuration.Default;

            ExceptionFactory = TorizonRestAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProgressApi(TorizonRestAPI.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = TorizonRestAPI.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = TorizonRestAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public TorizonRestAPI.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public TorizonRestAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create a progress cookie Creates a progress object that could be used to monitor and abort operations. A progress cookie must be used only for one operation and deleted when the operation is completed/terminated. Passing cookies to different operations may lead to unpredictable results.
        /// </summary>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Progress</returns>
        public Progress ProgressCreate ()
        {
             ApiResponse<Progress> localVarResponse = ProgressCreateWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a progress cookie Creates a progress object that could be used to monitor and abort operations. A progress cookie must be used only for one operation and deleted when the operation is completed/terminated. Passing cookies to different operations may lead to unpredictable results.
        /// </summary>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Progress</returns>
        public ApiResponse<Progress> ProgressCreateWithHttpInfo ()
        {

            var localVarPath = "/progress/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProgressCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Progress>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Progress) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Progress)));
        }

        /// <summary>
        /// Create a progress cookie Creates a progress object that could be used to monitor and abort operations. A progress cookie must be used only for one operation and deleted when the operation is completed/terminated. Passing cookies to different operations may lead to unpredictable results.
        /// </summary>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Progress</returns>
        public async System.Threading.Tasks.Task<Progress> ProgressCreateAsync (CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Progress> localVarResponse = await ProgressCreateWithHttpInfoAsync(cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a progress cookie Creates a progress object that could be used to monitor and abort operations. A progress cookie must be used only for one operation and deleted when the operation is completed/terminated. Passing cookies to different operations may lead to unpredictable results.
        /// </summary>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Progress)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Progress>> ProgressCreateWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/progress/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProgressCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Progress>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Progress) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Progress)));
        }

        /// <summary>
        /// Releases a progress cookie Delete the cookie. If the operation is pending this will cause an abort. Abort may not be immediate. After the delete operation is called the progress cookie id is no longer valid and further calls to progress_status will fail.
        /// </summary>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <returns></returns>
        public void ProgressDelete (string progressId = default(string))
        {
             ProgressDeleteWithHttpInfo(progressId);
        }

        /// <summary>
        /// Releases a progress cookie Delete the cookie. If the operation is pending this will cause an abort. Abort may not be immediate. After the delete operation is called the progress cookie id is no longer valid and further calls to progress_status will fail.
        /// </summary>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProgressDeleteWithHttpInfo (string progressId = default(string))
        {

            var localVarPath = "/progress/delete";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (progressId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "progress_id", progressId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProgressDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Releases a progress cookie Delete the cookie. If the operation is pending this will cause an abort. Abort may not be immediate. After the delete operation is called the progress cookie id is no longer valid and further calls to progress_status will fail.
        /// </summary>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProgressDeleteAsync (string progressId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             await ProgressDeleteWithHttpInfoAsync(progressId, cancellationToken);

        }

        /// <summary>
        /// Releases a progress cookie Delete the cookie. If the operation is pending this will cause an abort. Abort may not be immediate. After the delete operation is called the progress cookie id is no longer valid and further calls to progress_status will fail.
        /// </summary>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ProgressDeleteWithHttpInfoAsync (string progressId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/progress/delete";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (progressId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "progress_id", progressId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProgressDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Retrieves progress status of an operation Return the operation status, progress and messages, it's blocking until status changes or the operation is completed/terminated. Not all operations can return detailed progress information (it may not be possible to estimate it before starting the actual operation), it's anyway granted that an operation will report its completition/failure.
        /// </summary>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <returns>Progress</returns>
        public Progress ProgressStatus (string progressId = default(string))
        {
             ApiResponse<Progress> localVarResponse = ProgressStatusWithHttpInfo(progressId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves progress status of an operation Return the operation status, progress and messages, it's blocking until status changes or the operation is completed/terminated. Not all operations can return detailed progress information (it may not be possible to estimate it before starting the actual operation), it's anyway granted that an operation will report its completition/failure.
        /// </summary>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <returns>ApiResponse of Progress</returns>
        public ApiResponse<Progress> ProgressStatusWithHttpInfo (string progressId = default(string))
        {

            var localVarPath = "/progress/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (progressId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "progress_id", progressId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProgressStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Progress>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Progress) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Progress)));
        }

        /// <summary>
        /// Retrieves progress status of an operation Return the operation status, progress and messages, it's blocking until status changes or the operation is completed/terminated. Not all operations can return detailed progress information (it may not be possible to estimate it before starting the actual operation), it's anyway granted that an operation will report its completition/failure.
        /// </summary>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Progress</returns>
        public async System.Threading.Tasks.Task<Progress> ProgressStatusAsync (string progressId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Progress> localVarResponse = await ProgressStatusWithHttpInfoAsync(progressId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves progress status of an operation Return the operation status, progress and messages, it's blocking until status changes or the operation is completed/terminated. Not all operations can return detailed progress information (it may not be possible to estimate it before starting the actual operation), it's anyway granted that an operation will report its completition/failure.
        /// </summary>
        /// <exception cref="TorizonRestAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="progressId">Id of a progress cookie (uuid) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Progress)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Progress>> ProgressStatusWithHttpInfoAsync (string progressId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/progress/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (progressId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "progress_id", progressId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProgressStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Progress>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Progress) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Progress)));
        }

    }
}
