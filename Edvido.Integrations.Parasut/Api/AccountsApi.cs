
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
    public interface IAccountsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <returns>InlineResponse201</returns>
        InlineResponse201 CreateAccount(AccountForm accountForm, int? companyId);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <returns>ApiResponse of InlineResponse201</returns>
        ApiResponse<InlineResponse201> CreateAccountWithHttpInfo(AccountForm accountForm, int? companyId);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Object</returns>
        Object DeleteAccount(int? companyId, int? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DeleteAccountWithHttpInfo(int? companyId, int? id);
        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCurrency"> (optional)</param>
        /// <param name="filterBankName"> (optional)</param>
        /// <param name="filterBankBranch"> (optional)</param>
        /// <param name="filterAccountType"> (optional)</param>
        /// <param name="filterIban"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, balance_in_trl* (optional, default to -id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 ListAccounts(int? companyId, string filterName = null, string filterCurrency = null, string filterBankName = null, string filterBankBranch = null, string filterAccountType = null, string filterIban = null, string sort = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCurrency"> (optional)</param>
        /// <param name="filterBankName"> (optional)</param>
        /// <param name="filterBankBranch"> (optional)</param>
        /// <param name="filterAccountType"> (optional)</param>
        /// <param name="filterIban"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, balance_in_trl* (optional, default to -id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> ListAccountsWithHttpInfo(int? companyId, string filterName = null, string filterCurrency = null, string filterBankName = null, string filterBankBranch = null, string filterAccountType = null, string filterIban = null, string sort = null, int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>InlineResponse201</returns>
        InlineResponse201 ShowAccount(int? companyId, int? id);

        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>ApiResponse of InlineResponse201</returns>
        ApiResponse<InlineResponse201> ShowAccountWithHttpInfo(int? companyId, int? id);
        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>InlineResponse201</returns>
        InlineResponse201 UpdateAccount(AccountForm1 accountForm, int? companyId, int? id);

        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>ApiResponse of InlineResponse201</returns>
        ApiResponse<InlineResponse201> UpdateAccountWithHttpInfo(AccountForm1 accountForm, int? companyId, int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <returns>Task of InlineResponse201</returns>
        System.Threading.Tasks.Task<InlineResponse201> CreateAccountAsync(AccountForm accountForm, int? companyId);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <returns>Task of ApiResponse (InlineResponse201)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse201>> CreateAccountAsyncWithHttpInfo(AccountForm accountForm, int? companyId);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DeleteAccountAsync(int? companyId, int? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAccountAsyncWithHttpInfo(int? companyId, int? id);
        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCurrency"> (optional)</param>
        /// <param name="filterBankName"> (optional)</param>
        /// <param name="filterBankBranch"> (optional)</param>
        /// <param name="filterAccountType"> (optional)</param>
        /// <param name="filterIban"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, balance_in_trl* (optional, default to -id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> ListAccountsAsync(int? companyId, string filterName = null, string filterCurrency = null, string filterBankName = null, string filterBankBranch = null, string filterAccountType = null, string filterIban = null, string sort = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCurrency"> (optional)</param>
        /// <param name="filterBankName"> (optional)</param>
        /// <param name="filterBankBranch"> (optional)</param>
        /// <param name="filterAccountType"> (optional)</param>
        /// <param name="filterIban"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, balance_in_trl* (optional, default to -id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> ListAccountsAsyncWithHttpInfo(int? companyId, string filterName = null, string filterCurrency = null, string filterBankName = null, string filterBankBranch = null, string filterAccountType = null, string filterIban = null, string sort = null, int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Task of InlineResponse201</returns>
        System.Threading.Tasks.Task<InlineResponse201> ShowAccountAsync(int? companyId, int? id);

        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Task of ApiResponse (InlineResponse201)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse201>> ShowAccountAsyncWithHttpInfo(int? companyId, int? id);
        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Task of InlineResponse201</returns>
        System.Threading.Tasks.Task<InlineResponse201> UpdateAccountAsync(AccountForm1 accountForm, int? companyId, int? id);

        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Task of ApiResponse (InlineResponse201)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse201>> UpdateAccountAsyncWithHttpInfo(AccountForm1 accountForm, int? companyId, int? id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountsApi : IAccountsApi
    {
        private Edvido.Integrations.Parasut.Client.ExceptionFactory _exceptionFactory = (name, response) => null;



        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountsApi(Configuration configuration = null)
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
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return string.Empty;
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
        public Configuration Configuration { get; set; }

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
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <returns>InlineResponse201</returns>
        public InlineResponse201 CreateAccount(AccountForm accountForm, int? companyId)
        {
            ApiResponse<InlineResponse201> localVarResponse = CreateAccountWithHttpInfo(accountForm, companyId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <returns>ApiResponse of InlineResponse201</returns>
        public ApiResponse<InlineResponse201> CreateAccountWithHttpInfo(AccountForm accountForm, int? companyId)
        {
            // verify the required parameter 'accountForm' is set
            if (accountForm == null)
                throw new ApiException(400, "Missing required parameter 'accountForm' when calling AccountsApi->CreateAccount");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling AccountsApi->CreateAccount");

            var localVarPath = "/{company_id}/accounts";
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
            if (accountForm != null && accountForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(accountForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = accountForm; // byte array
            }



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse201>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse201)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse201)));

        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <returns>Task of InlineResponse201</returns>
        public async System.Threading.Tasks.Task<InlineResponse201> CreateAccountAsync(AccountForm accountForm, int? companyId)
        {
            ApiResponse<InlineResponse201> localVarResponse = await CreateAccountAsyncWithHttpInfo(accountForm, companyId);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <returns>Task of ApiResponse (InlineResponse201)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse201>> CreateAccountAsyncWithHttpInfo(AccountForm accountForm, int? companyId)
        {
            // verify the required parameter 'accountForm' is set
            if (accountForm == null)
                throw new ApiException(400, "Missing required parameter 'accountForm' when calling AccountsApi->CreateAccount");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling AccountsApi->CreateAccount");

            var localVarPath = "/{company_id}/accounts";
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
            if (accountForm != null && accountForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(accountForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = accountForm; // byte array
            }



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse201>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse201)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse201)));

        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Object</returns>
        public Object DeleteAccount(int? companyId, int? id)
        {
            ApiResponse<Object> localVarResponse = DeleteAccountWithHttpInfo(companyId, id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<Object> DeleteAccountWithHttpInfo(int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling AccountsApi->DeleteAccount");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountsApi->DeleteAccount");

            var localVarPath = "/{company_id}/accounts/{id}";
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
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));

        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteAccountAsync(int? companyId, int? id)
        {
            ApiResponse<Object> localVarResponse = await DeleteAccountAsyncWithHttpInfo(companyId, id);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAccountAsyncWithHttpInfo(int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling AccountsApi->DeleteAccount");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountsApi->DeleteAccount");

            var localVarPath = "/{company_id}/accounts/{id}";
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
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));

        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCurrency"> (optional)</param>
        /// <param name="filterBankName"> (optional)</param>
        /// <param name="filterBankBranch"> (optional)</param>
        /// <param name="filterAccountType"> (optional)</param>
        /// <param name="filterIban"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, balance_in_trl* (optional, default to -id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 ListAccounts(int? companyId, string filterName = null, string filterCurrency = null, string filterBankName = null, string filterBankBranch = null, string filterAccountType = null, string filterIban = null, string sort = null, int? pageNumber = null, int? pageSize = null)
        {
            ApiResponse<InlineResponse200> localVarResponse = ListAccountsWithHttpInfo(companyId, filterName, filterCurrency, filterBankName, filterBankBranch, filterAccountType, filterIban, sort, pageNumber, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCurrency"> (optional)</param>
        /// <param name="filterBankName"> (optional)</param>
        /// <param name="filterBankBranch"> (optional)</param>
        /// <param name="filterAccountType"> (optional)</param>
        /// <param name="filterIban"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, balance_in_trl* (optional, default to -id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse<InlineResponse200> ListAccountsWithHttpInfo(int? companyId, string filterName = null, string filterCurrency = null, string filterBankName = null, string filterBankBranch = null, string filterAccountType = null, string filterIban = null, string sort = null, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling AccountsApi->ListAccounts");

            var localVarPath = "/{company_id}/accounts";
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
            if (filterName != null) localVarQueryParams.Add("filter[name]", Configuration.ApiClient.ParameterToString(filterName)); // query parameter
            if (filterCurrency != null) localVarQueryParams.Add("filter[currency]", Configuration.ApiClient.ParameterToString(filterCurrency)); // query parameter
            if (filterBankName != null) localVarQueryParams.Add("filter[bank_name]", Configuration.ApiClient.ParameterToString(filterBankName)); // query parameter
            if (filterBankBranch != null) localVarQueryParams.Add("filter[bank_branch]", Configuration.ApiClient.ParameterToString(filterBankBranch)); // query parameter
            if (filterAccountType != null) localVarQueryParams.Add("filter[account_type]", Configuration.ApiClient.ParameterToString(filterAccountType)); // query parameter
            if (filterIban != null) localVarQueryParams.Add("filter[iban]", Configuration.ApiClient.ParameterToString(filterIban)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("page[number]", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page[size]", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListAccounts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));

        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCurrency"> (optional)</param>
        /// <param name="filterBankName"> (optional)</param>
        /// <param name="filterBankBranch"> (optional)</param>
        /// <param name="filterAccountType"> (optional)</param>
        /// <param name="filterIban"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, balance_in_trl* (optional, default to -id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> ListAccountsAsync(int? companyId, string filterName = null, string filterCurrency = null, string filterBankName = null, string filterBankBranch = null, string filterAccountType = null, string filterIban = null, string sort = null, int? pageNumber = null, int? pageSize = null)
        {
            ApiResponse<InlineResponse200> localVarResponse = await ListAccountsAsyncWithHttpInfo(companyId, filterName, filterCurrency, filterBankName, filterBankBranch, filterAccountType, filterIban, sort, pageNumber, pageSize);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCurrency"> (optional)</param>
        /// <param name="filterBankName"> (optional)</param>
        /// <param name="filterBankBranch"> (optional)</param>
        /// <param name="filterAccountType"> (optional)</param>
        /// <param name="filterIban"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, balance_in_trl* (optional, default to -id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> ListAccountsAsyncWithHttpInfo(int? companyId, string filterName = null, string filterCurrency = null, string filterBankName = null, string filterBankBranch = null, string filterAccountType = null, string filterIban = null, string sort = null, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling AccountsApi->ListAccounts");

            var localVarPath = "/{company_id}/accounts";
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
            if (filterName != null) localVarQueryParams.Add("filter[name]", Configuration.ApiClient.ParameterToString(filterName)); // query parameter
            if (filterCurrency != null) localVarQueryParams.Add("filter[currency]", Configuration.ApiClient.ParameterToString(filterCurrency)); // query parameter
            if (filterBankName != null) localVarQueryParams.Add("filter[bank_name]", Configuration.ApiClient.ParameterToString(filterBankName)); // query parameter
            if (filterBankBranch != null) localVarQueryParams.Add("filter[bank_branch]", Configuration.ApiClient.ParameterToString(filterBankBranch)); // query parameter
            if (filterAccountType != null) localVarQueryParams.Add("filter[account_type]", Configuration.ApiClient.ParameterToString(filterAccountType)); // query parameter
            if (filterIban != null) localVarQueryParams.Add("filter[iban]", Configuration.ApiClient.ParameterToString(filterIban)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("page[number]", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page[size]", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListAccounts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));

        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>InlineResponse201</returns>
        public InlineResponse201 ShowAccount(int? companyId, int? id)
        {
            ApiResponse<InlineResponse201> localVarResponse = ShowAccountWithHttpInfo(companyId, id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>ApiResponse of InlineResponse201</returns>
        public ApiResponse<InlineResponse201> ShowAccountWithHttpInfo(int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling AccountsApi->ShowAccount");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountsApi->ShowAccount");

            var localVarPath = "/{company_id}/accounts/{id}";
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
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ShowAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse201>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse201)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse201)));

        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Task of InlineResponse201</returns>
        public async System.Threading.Tasks.Task<InlineResponse201> ShowAccountAsync(int? companyId, int? id)
        {
            ApiResponse<InlineResponse201> localVarResponse = await ShowAccountAsyncWithHttpInfo(companyId, id);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Task of ApiResponse (InlineResponse201)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse201>> ShowAccountAsyncWithHttpInfo(int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling AccountsApi->ShowAccount");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountsApi->ShowAccount");

            var localVarPath = "/{company_id}/accounts/{id}";
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
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ShowAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse201>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse201)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse201)));

        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>InlineResponse201</returns>
        public InlineResponse201 UpdateAccount(AccountForm1 accountForm, int? companyId, int? id)
        {
            ApiResponse<InlineResponse201> localVarResponse = UpdateAccountWithHttpInfo(accountForm, companyId, id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>ApiResponse of InlineResponse201</returns>
        public ApiResponse<InlineResponse201> UpdateAccountWithHttpInfo(AccountForm1 accountForm, int? companyId, int? id)
        {
            // verify the required parameter 'accountForm' is set
            if (accountForm == null)
                throw new ApiException(400, "Missing required parameter 'accountForm' when calling AccountsApi->UpdateAccount");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling AccountsApi->UpdateAccount");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountsApi->UpdateAccount");

            var localVarPath = "/{company_id}/accounts/{id}";
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
            if (accountForm != null && accountForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(accountForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = accountForm; // byte array
            }



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse201>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse201)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse201)));

        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Task of InlineResponse201</returns>
        public async System.Threading.Tasks.Task<InlineResponse201> UpdateAccountAsync(AccountForm1 accountForm, int? companyId, int? id)
        {
            ApiResponse<InlineResponse201> localVarResponse = await UpdateAccountAsyncWithHttpInfo(accountForm, companyId, id);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Hesap ID</param>
        /// <returns>Task of ApiResponse (InlineResponse201)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse201>> UpdateAccountAsyncWithHttpInfo(AccountForm1 accountForm, int? companyId, int? id)
        {
            // verify the required parameter 'accountForm' is set
            if (accountForm == null)
                throw new ApiException(400, "Missing required parameter 'accountForm' when calling AccountsApi->UpdateAccount");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling AccountsApi->UpdateAccount");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountsApi->UpdateAccount");

            var localVarPath = "/{company_id}/accounts/{id}";
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
            if (accountForm != null && accountForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(accountForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = accountForm; // byte array
            }



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse201>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse201)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse201)));

        }

    }
}
