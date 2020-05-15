namespace Edvido.Integrations.Parasut.Api
{
    using Edvido.Integrations.Parasut.Client;
    using Edvido.Integrations.Parasut.Model;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints.
    /// </summary>
    public interface IApiHomeApi : IApiAccessor
    {
        /// <summary>
        /// Show.
        /// </summary>
        /// <returns>InlineResponse2001.</returns>
        InlineResponse2001 ShowMe();

        /// <summary>
        /// Show.
        /// </summary>
        /// <returns>ApiResponse of InlineResponse2001.</returns>
        ApiResponse<InlineResponse2001> ShowMeWithHttpInfo();

        /// <summary>
        /// Show.
        /// </summary>
        /// <returns>Task of InlineResponse2001.</returns>
        System.Threading.Tasks.Task<InlineResponse2001> ShowMeAsync();

        /// <summary>
        /// Show.
        /// </summary>
        /// <returns>Task of ApiResponse (InlineResponse2001).</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> ShowMeAsyncWithHttpInfo();
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints.
    /// </summary>
    public partial class ApiHomeApi : IApiHomeApi
    {
        /// <summary>
        /// Defines the _exceptionFactory.
        /// </summary>
        private Edvido.Integrations.Parasut.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiHomeApi"/> class.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        public ApiHomeApi(Configuration configuration = null)
        {

            this.Configuration = configuration;

            ExceptionFactory = Edvido.Integrations.Parasut.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// The GetBasePath.
        /// </summary>
        /// <returns>The <see cref="String"/>.</returns>
        public String GetBasePath()
        {
            return string.Empty;
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The basePath<see cref="String"/>.</param>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
        }

        /// <summary>
        /// Gets or sets the configuration object.
        /// </summary>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Gets or sets the ExceptionFactory
        /// Provides a factory method hook for the creation of exceptions..
        /// </summary>
        public Edvido.Integrations.Parasut.Client.ExceptionFactory ExceptionFactory
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
        /// <returns>Dictionary of HTTP header.</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Show.
        /// </summary>
        /// <returns>InlineResponse2001.</returns>
        public InlineResponse2001 ShowMe()
        {
            ApiResponse<InlineResponse2001> localVarResponse = ShowMeWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Show.
        /// </summary>
        /// <returns>ApiResponse of InlineResponse2001.</returns>
        public ApiResponse<InlineResponse2001> ShowMeWithHttpInfo()
        {

            var localVarPath = "/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ShowMe", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Show.
        /// </summary>
        /// <returns>Task of InlineResponse2001.</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> ShowMeAsync()
        {
            ApiResponse<InlineResponse2001> localVarResponse = await ShowMeAsyncWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Show.
        /// </summary>
        /// <returns>Task of ApiResponse (InlineResponse2001).</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> ShowMeAsyncWithHttpInfo()
        {

            var localVarPath = "/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ShowMe", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }
    }
}
