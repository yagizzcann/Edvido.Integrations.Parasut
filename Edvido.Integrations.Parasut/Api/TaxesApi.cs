
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Edvido.Integrations.Parasut.Client;
using Edvido.Integrations.Parasut.Model;

namespace Edvido.Integrations.Parasut.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaxesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Archive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>InlineResponse20113</returns>
        InlineResponse20113 ArchiveTax (int? companyId, int? id, string include = null);

        /// <summary>
        /// Archive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20113</returns>
        ApiResponse<InlineResponse20113> ArchiveTaxWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>InlineResponse20113</returns>
        InlineResponse20113 CreateTax (TaxForm taxForm, int? companyId, string include = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20113</returns>
        ApiResponse<InlineResponse20113> CreateTaxWithHttpInfo (TaxForm taxForm, int? companyId, string include = null);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <returns>Object</returns>
        Object DeleteTax (int? companyId, int? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DeleteTaxWithHttpInfo (int? companyId, int? id);
        /// <summary>
        /// Pay
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>InlineResponse2012</returns>
        InlineResponse2012 PayTax (PaymentForm4 paymentForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Pay
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2012</returns>
        ApiResponse<InlineResponse2012> PayTaxWithHttpInfo (PaymentForm4 paymentForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>InlineResponse20113</returns>
        InlineResponse20113 ShowTax (int? companyId, int? id, string include = null);

        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20113</returns>
        ApiResponse<InlineResponse20113> ShowTaxWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>InlineResponse20113</returns>
        InlineResponse20113 UnarchiveTax (int? companyId, int? id, string include = null);

        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20113</returns>
        ApiResponse<InlineResponse20113> UnarchiveTaxWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>InlineResponse20113</returns>
        InlineResponse20113 UpdateTax (TaxForm1 taxForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20113</returns>
        ApiResponse<InlineResponse20113> UpdateTaxWithHttpInfo (TaxForm1 taxForm, int? companyId, int? id, string include = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Archive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20113</returns>
        System.Threading.Tasks.Task<InlineResponse20113> ArchiveTaxAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Archive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20113)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20113>> ArchiveTaxAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20113</returns>
        System.Threading.Tasks.Task<InlineResponse20113> CreateTaxAsync (TaxForm taxForm, int? companyId, string include = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20113)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20113>> CreateTaxAsyncWithHttpInfo (TaxForm taxForm, int? companyId, string include = null);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DeleteTaxAsync (int? companyId, int? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTaxAsyncWithHttpInfo (int? companyId, int? id);
        /// <summary>
        /// Pay
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>Task of InlineResponse2012</returns>
        System.Threading.Tasks.Task<InlineResponse2012> PayTaxAsync (PaymentForm4 paymentForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Pay
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2012)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2012>> PayTaxAsyncWithHttpInfo (PaymentForm4 paymentForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20113</returns>
        System.Threading.Tasks.Task<InlineResponse20113> ShowTaxAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20113)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20113>> ShowTaxAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20113</returns>
        System.Threading.Tasks.Task<InlineResponse20113> UnarchiveTaxAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20113)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20113>> UnarchiveTaxAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20113</returns>
        System.Threading.Tasks.Task<InlineResponse20113> UpdateTaxAsync (TaxForm1 taxForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20113)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20113>> UpdateTaxAsyncWithHttpInfo (TaxForm1 taxForm, int? companyId, int? id, string include = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TaxesApi : ITaxesApi
    {
        private Edvido.Integrations.Parasut.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

       
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TaxesApi(Configuration configuration = null)
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
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
        /// <returns>Dictionary of HTTP header</returns>
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
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>InlineResponse20113</returns>
        public InlineResponse20113 ArchiveTax (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20113> localVarResponse = ArchiveTaxWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20113</returns>
        public ApiResponse< InlineResponse20113 > ArchiveTaxWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->ArchiveTax");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaxesApi->ArchiveTax");

            var localVarPath = "/{company_id}/taxes/{id}/archive";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ArchiveTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20113>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20113) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20113)));
            
        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20113</returns>
        public async System.Threading.Tasks.Task<InlineResponse20113> ArchiveTaxAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20113> localVarResponse = await ArchiveTaxAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20113)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20113>> ArchiveTaxAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->ArchiveTax");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaxesApi->ArchiveTax");

            var localVarPath = "/{company_id}/taxes/{id}/archive";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

           

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ArchiveTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20113>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20113) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20113)));
            
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>InlineResponse20113</returns>
        public InlineResponse20113 CreateTax (TaxForm taxForm, int? companyId, string include = null)
        {
             ApiResponse<InlineResponse20113> localVarResponse = CreateTaxWithHttpInfo(taxForm, companyId, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20113</returns>
        public ApiResponse< InlineResponse20113 > CreateTaxWithHttpInfo (TaxForm taxForm, int? companyId, string include = null)
        {
            // verify the required parameter 'taxForm' is set
            if (taxForm == null)
                throw new ApiException(400, "Missing required parameter 'taxForm' when calling TaxesApi->CreateTax");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->CreateTax");

            var localVarPath = "/{company_id}/taxes";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (taxForm != null && taxForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(taxForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = taxForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20113>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20113) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20113)));
            
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20113</returns>
        public async System.Threading.Tasks.Task<InlineResponse20113> CreateTaxAsync (TaxForm taxForm, int? companyId, string include = null)
        {
             ApiResponse<InlineResponse20113> localVarResponse = await CreateTaxAsyncWithHttpInfo(taxForm, companyId, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20113)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20113>> CreateTaxAsyncWithHttpInfo (TaxForm taxForm, int? companyId, string include = null)
        {
            // verify the required parameter 'taxForm' is set
            if (taxForm == null)
                throw new ApiException(400, "Missing required parameter 'taxForm' when calling TaxesApi->CreateTax");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->CreateTax");

            var localVarPath = "/{company_id}/taxes";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (taxForm != null && taxForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(taxForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = taxForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20113>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20113) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20113)));
            
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <returns>Object</returns>
        public Object DeleteTax (int? companyId, int? id)
        {
             ApiResponse<Object> localVarResponse = DeleteTaxWithHttpInfo(companyId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DeleteTaxWithHttpInfo (int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->DeleteTax");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaxesApi->DeleteTax");

            var localVarPath = "/{company_id}/taxes/{id}";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

           

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteTaxAsync (int? companyId, int? id)
        {
             ApiResponse<Object> localVarResponse = await DeleteTaxAsyncWithHttpInfo(companyId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTaxAsyncWithHttpInfo (int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->DeleteTax");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaxesApi->DeleteTax");

            var localVarPath = "/{company_id}/taxes/{id}";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Pay 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>InlineResponse2012</returns>
        public InlineResponse2012 PayTax (PaymentForm4 paymentForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2012> localVarResponse = PayTaxWithHttpInfo(paymentForm, companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Pay 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2012</returns>
        public ApiResponse< InlineResponse2012 > PayTaxWithHttpInfo (PaymentForm4 paymentForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'paymentForm' is set
            if (paymentForm == null)
                throw new ApiException(400, "Missing required parameter 'paymentForm' when calling TaxesApi->PayTax");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->PayTax");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaxesApi->PayTax");

            var localVarPath = "/{company_id}/taxes/{id}/payments";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (paymentForm != null && paymentForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(paymentForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = paymentForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PayTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2012>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2012) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2012)));
            
        }

        /// <summary>
        /// Pay 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>Task of InlineResponse2012</returns>
        public async System.Threading.Tasks.Task<InlineResponse2012> PayTaxAsync (PaymentForm4 paymentForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2012> localVarResponse = await PayTaxAsyncWithHttpInfo(paymentForm, companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Pay 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2012)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2012>> PayTaxAsyncWithHttpInfo (PaymentForm4 paymentForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'paymentForm' is set
            if (paymentForm == null)
                throw new ApiException(400, "Missing required parameter 'paymentForm' when calling TaxesApi->PayTax");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->PayTax");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaxesApi->PayTax");

            var localVarPath = "/{company_id}/taxes/{id}/payments";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (paymentForm != null && paymentForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(paymentForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = paymentForm; // byte array
            }

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PayTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2012>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2012) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2012)));
            
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>InlineResponse20113</returns>
        public InlineResponse20113 ShowTax (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20113> localVarResponse = ShowTaxWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20113</returns>
        public ApiResponse< InlineResponse20113 > ShowTaxWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->ShowTax");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaxesApi->ShowTax");

            var localVarPath = "/{company_id}/taxes/{id}";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

       
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ShowTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20113>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20113) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20113)));
            
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20113</returns>
        public async System.Threading.Tasks.Task<InlineResponse20113> ShowTaxAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20113> localVarResponse = await ShowTaxAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20113)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20113>> ShowTaxAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->ShowTax");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaxesApi->ShowTax");

            var localVarPath = "/{company_id}/taxes/{id}";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

        

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ShowTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20113>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20113) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20113)));
            
        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>InlineResponse20113</returns>
        public InlineResponse20113 UnarchiveTax (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20113> localVarResponse = UnarchiveTaxWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20113</returns>
        public ApiResponse< InlineResponse20113 > UnarchiveTaxWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->UnarchiveTax");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaxesApi->UnarchiveTax");

            var localVarPath = "/{company_id}/taxes/{id}/unarchive";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UnarchiveTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20113>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20113) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20113)));
            
        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20113</returns>
        public async System.Threading.Tasks.Task<InlineResponse20113> UnarchiveTaxAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20113> localVarResponse = await UnarchiveTaxAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20113)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20113>> UnarchiveTaxAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->UnarchiveTax");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaxesApi->UnarchiveTax");

            var localVarPath = "/{company_id}/taxes/{id}/unarchive";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UnarchiveTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20113>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20113) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20113)));
            
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>InlineResponse20113</returns>
        public InlineResponse20113 UpdateTax (TaxForm1 taxForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20113> localVarResponse = UpdateTaxWithHttpInfo(taxForm, companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20113</returns>
        public ApiResponse< InlineResponse20113 > UpdateTaxWithHttpInfo (TaxForm1 taxForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'taxForm' is set
            if (taxForm == null)
                throw new ApiException(400, "Missing required parameter 'taxForm' when calling TaxesApi->UpdateTax");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->UpdateTax");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaxesApi->UpdateTax");

            var localVarPath = "/{company_id}/taxes/{id}";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (taxForm != null && taxForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(taxForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = taxForm; // byte array
            }

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20113>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20113) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20113)));
            
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20113</returns>
        public async System.Threading.Tasks.Task<InlineResponse20113> UpdateTaxAsync (TaxForm1 taxForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20113> localVarResponse = await UpdateTaxAsyncWithHttpInfo(taxForm, companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taxForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Vergi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20113)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20113>> UpdateTaxAsyncWithHttpInfo (TaxForm1 taxForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'taxForm' is set
            if (taxForm == null)
                throw new ApiException(400, "Missing required parameter 'taxForm' when calling TaxesApi->UpdateTax");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling TaxesApi->UpdateTax");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaxesApi->UpdateTax");

            var localVarPath = "/{company_id}/taxes/{id}";
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
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (taxForm != null && taxForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(taxForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = taxForm; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateTax", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20113>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20113) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20113)));
            
        }

    }
}
