
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
    public interface IItemCategoriesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>InlineResponse2017</returns>
        InlineResponse2017 CreateItemCategory (ItemCategoryForm itemCategoryForm, int? companyId, string include = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2017</returns>
        ApiResponse<InlineResponse2017> CreateItemCategoryWithHttpInfo (ItemCategoryForm itemCategoryForm, int? companyId, string include = null);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <returns>Object</returns>
        Object DeleteItemCategory (int? companyId, int? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DeleteItemCategoryWithHttpInfo (int? companyId, int? id);
        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCategoryType"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, name, category_type* (optional, default to id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 ListItemCategories (int? companyId, string filterName = null, string filterCategoryType = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null);

        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCategoryType"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, name, category_type* (optional, default to id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2008</returns>
        ApiResponse<InlineResponse2008> ListItemCategoriesWithHttpInfo (int? companyId, string filterName = null, string filterCategoryType = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null);
        /// <summary>
        /// Kategori bilgisini gösterir.
        /// </summary>
        /// <remarks>
        /// Ayrıntısını görmek istediğiniz kategorinin id&#39;sini göndererek gerekli bilgilere ulaşabilirsiniz.
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>InlineResponse2017</returns>
        InlineResponse2017 ShowItemCategory (int? companyId, int? id, string include = null);

        /// <summary>
        /// Kategori bilgisini gösterir.
        /// </summary>
        /// <remarks>
        /// Ayrıntısını görmek istediğiniz kategorinin id&#39;sini göndererek gerekli bilgilere ulaşabilirsiniz.
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2017</returns>
        ApiResponse<InlineResponse2017> ShowItemCategoryWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>InlineResponse2017</returns>
        InlineResponse2017 UpdateItemCategory (ItemCategoryForm1 itemCategoryForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2017</returns>
        ApiResponse<InlineResponse2017> UpdateItemCategoryWithHttpInfo (ItemCategoryForm1 itemCategoryForm, int? companyId, int? id, string include = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of InlineResponse2017</returns>
        System.Threading.Tasks.Task<InlineResponse2017> CreateItemCategoryAsync (ItemCategoryForm itemCategoryForm, int? companyId, string include = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2017)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2017>> CreateItemCategoryAsyncWithHttpInfo (ItemCategoryForm itemCategoryForm, int? companyId, string include = null);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DeleteItemCategoryAsync (int? companyId, int? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemCategoryAsyncWithHttpInfo (int? companyId, int? id);
        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCategoryType"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, name, category_type* (optional, default to id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of InlineResponse2008</returns>
        System.Threading.Tasks.Task<InlineResponse2008> ListItemCategoriesAsync (int? companyId, string filterName = null, string filterCategoryType = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null);

        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCategoryType"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, name, category_type* (optional, default to id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2008>> ListItemCategoriesAsyncWithHttpInfo (int? companyId, string filterName = null, string filterCategoryType = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null);
        /// <summary>
        /// Kategori bilgisini gösterir.
        /// </summary>
        /// <remarks>
        /// Ayrıntısını görmek istediğiniz kategorinin id&#39;sini göndererek gerekli bilgilere ulaşabilirsiniz.
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of InlineResponse2017</returns>
        System.Threading.Tasks.Task<InlineResponse2017> ShowItemCategoryAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Kategori bilgisini gösterir.
        /// </summary>
        /// <remarks>
        /// Ayrıntısını görmek istediğiniz kategorinin id&#39;sini göndererek gerekli bilgilere ulaşabilirsiniz.
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2017)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2017>> ShowItemCategoryAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of InlineResponse2017</returns>
        System.Threading.Tasks.Task<InlineResponse2017> UpdateItemCategoryAsync (ItemCategoryForm1 itemCategoryForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2017)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2017>> UpdateItemCategoryAsyncWithHttpInfo (ItemCategoryForm1 itemCategoryForm, int? companyId, int? id, string include = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ItemCategoriesApi : IItemCategoriesApi
    {
        private Edvido.Integrations.Parasut.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemCategoriesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ItemCategoriesApi(Configuration configuration = null)
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
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>InlineResponse2017</returns>
        public InlineResponse2017 CreateItemCategory (ItemCategoryForm itemCategoryForm, int? companyId, string include = null)
        {
             ApiResponse<InlineResponse2017> localVarResponse = CreateItemCategoryWithHttpInfo(itemCategoryForm, companyId, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2017</returns>
        public ApiResponse< InlineResponse2017 > CreateItemCategoryWithHttpInfo (ItemCategoryForm itemCategoryForm, int? companyId, string include = null)
        {
            // verify the required parameter 'itemCategoryForm' is set
            if (itemCategoryForm == null)
                throw new ApiException(400, "Missing required parameter 'itemCategoryForm' when calling ItemCategoriesApi->CreateItemCategory");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ItemCategoriesApi->CreateItemCategory");

            var localVarPath = "/{company_id}/item_categories";
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
            if (itemCategoryForm != null && itemCategoryForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(itemCategoryForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = itemCategoryForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateItemCategory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2017>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2017) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2017)));
            
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of InlineResponse2017</returns>
        public async System.Threading.Tasks.Task<InlineResponse2017> CreateItemCategoryAsync (ItemCategoryForm itemCategoryForm, int? companyId, string include = null)
        {
             ApiResponse<InlineResponse2017> localVarResponse = await CreateItemCategoryAsyncWithHttpInfo(itemCategoryForm, companyId, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2017)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2017>> CreateItemCategoryAsyncWithHttpInfo (ItemCategoryForm itemCategoryForm, int? companyId, string include = null)
        {
            // verify the required parameter 'itemCategoryForm' is set
            if (itemCategoryForm == null)
                throw new ApiException(400, "Missing required parameter 'itemCategoryForm' when calling ItemCategoriesApi->CreateItemCategory");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ItemCategoriesApi->CreateItemCategory");

            var localVarPath = "/{company_id}/item_categories";
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
            if (itemCategoryForm != null && itemCategoryForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(itemCategoryForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = itemCategoryForm; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateItemCategory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2017>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2017) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2017)));
            
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <returns>Object</returns>
        public Object DeleteItemCategory (int? companyId, int? id)
        {
             ApiResponse<Object> localVarResponse = DeleteItemCategoryWithHttpInfo(companyId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DeleteItemCategoryWithHttpInfo (int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ItemCategoriesApi->DeleteItemCategory");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ItemCategoriesApi->DeleteItemCategory");

            var localVarPath = "/{company_id}/item_categories/{id}";
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
                Exception exception = ExceptionFactory("DeleteItemCategory", localVarResponse);
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
        /// <param name="id">Kategori ID</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteItemCategoryAsync (int? companyId, int? id)
        {
             ApiResponse<Object> localVarResponse = await DeleteItemCategoryAsyncWithHttpInfo(companyId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemCategoryAsyncWithHttpInfo (int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ItemCategoriesApi->DeleteItemCategory");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ItemCategoriesApi->DeleteItemCategory");

            var localVarPath = "/{company_id}/item_categories/{id}";
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
                Exception exception = ExceptionFactory("DeleteItemCategory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCategoryType"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, name, category_type* (optional, default to id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>InlineResponse2008</returns>
        public InlineResponse2008 ListItemCategories (int? companyId, string filterName = null, string filterCategoryType = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null)
        {
             ApiResponse<InlineResponse2008> localVarResponse = ListItemCategoriesWithHttpInfo(companyId, filterName, filterCategoryType, sort, pageNumber, pageSize, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCategoryType"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, name, category_type* (optional, default to id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2008</returns>
        public ApiResponse< InlineResponse2008 > ListItemCategoriesWithHttpInfo (int? companyId, string filterName = null, string filterCategoryType = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ItemCategoriesApi->ListItemCategories");

            var localVarPath = "/{company_id}/item_categories";
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
            if (filterCategoryType != null) localVarQueryParams.Add("filter[category_type]", Configuration.ApiClient.ParameterToString(filterCategoryType)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("page[number]", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page[size]", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListItemCategories", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2008>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2008) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2008)));
            
        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCategoryType"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, name, category_type* (optional, default to id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of InlineResponse2008</returns>
        public async System.Threading.Tasks.Task<InlineResponse2008> ListItemCategoriesAsync (int? companyId, string filterName = null, string filterCategoryType = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null)
        {
             ApiResponse<InlineResponse2008> localVarResponse = await ListItemCategoriesAsyncWithHttpInfo(companyId, filterName, filterCategoryType, sort, pageNumber, pageSize, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterCategoryType"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, name, category_type* (optional, default to id)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2008>> ListItemCategoriesAsyncWithHttpInfo (int? companyId, string filterName = null, string filterCategoryType = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ItemCategoriesApi->ListItemCategories");

            var localVarPath = "/{company_id}/item_categories";
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
            if (filterCategoryType != null) localVarQueryParams.Add("filter[category_type]", Configuration.ApiClient.ParameterToString(filterCategoryType)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("page[number]", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page[size]", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

           

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListItemCategories", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2008>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2008) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2008)));
            
        }

        /// <summary>
        /// Kategori bilgisini gösterir. Ayrıntısını görmek istediğiniz kategorinin id&#39;sini göndererek gerekli bilgilere ulaşabilirsiniz.
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>InlineResponse2017</returns>
        public InlineResponse2017 ShowItemCategory (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2017> localVarResponse = ShowItemCategoryWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Kategori bilgisini gösterir. Ayrıntısını görmek istediğiniz kategorinin id&#39;sini göndererek gerekli bilgilere ulaşabilirsiniz.
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2017</returns>
        public ApiResponse< InlineResponse2017 > ShowItemCategoryWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ItemCategoriesApi->ShowItemCategory");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ItemCategoriesApi->ShowItemCategory");

            var localVarPath = "/{company_id}/item_categories/{id}";
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
                Exception exception = ExceptionFactory("ShowItemCategory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2017>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2017) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2017)));
            
        }

        /// <summary>
        /// Kategori bilgisini gösterir. Ayrıntısını görmek istediğiniz kategorinin id&#39;sini göndererek gerekli bilgilere ulaşabilirsiniz.
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of InlineResponse2017</returns>
        public async System.Threading.Tasks.Task<InlineResponse2017> ShowItemCategoryAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2017> localVarResponse = await ShowItemCategoryAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Kategori bilgisini gösterir. Ayrıntısını görmek istediğiniz kategorinin id&#39;sini göndererek gerekli bilgilere ulaşabilirsiniz.
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2017)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2017>> ShowItemCategoryAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ItemCategoriesApi->ShowItemCategory");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ItemCategoriesApi->ShowItemCategory");

            var localVarPath = "/{company_id}/item_categories/{id}";
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
                Exception exception = ExceptionFactory("ShowItemCategory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2017>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2017) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2017)));
            
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>InlineResponse2017</returns>
        public InlineResponse2017 UpdateItemCategory (ItemCategoryForm1 itemCategoryForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2017> localVarResponse = UpdateItemCategoryWithHttpInfo(itemCategoryForm, companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2017</returns>
        public ApiResponse< InlineResponse2017 > UpdateItemCategoryWithHttpInfo (ItemCategoryForm1 itemCategoryForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'itemCategoryForm' is set
            if (itemCategoryForm == null)
                throw new ApiException(400, "Missing required parameter 'itemCategoryForm' when calling ItemCategoriesApi->UpdateItemCategory");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ItemCategoriesApi->UpdateItemCategory");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ItemCategoriesApi->UpdateItemCategory");

            var localVarPath = "/{company_id}/item_categories/{id}";
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
            if (itemCategoryForm != null && itemCategoryForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(itemCategoryForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = itemCategoryForm; // byte array
            }

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateItemCategory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2017>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2017) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2017)));
            
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of InlineResponse2017</returns>
        public async System.Threading.Tasks.Task<InlineResponse2017> UpdateItemCategoryAsync (ItemCategoryForm1 itemCategoryForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2017> localVarResponse = await UpdateItemCategoryAsyncWithHttpInfo(itemCategoryForm, companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemCategoryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Kategori ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: parent_category, subcategories* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2017)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2017>> UpdateItemCategoryAsyncWithHttpInfo (ItemCategoryForm1 itemCategoryForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'itemCategoryForm' is set
            if (itemCategoryForm == null)
                throw new ApiException(400, "Missing required parameter 'itemCategoryForm' when calling ItemCategoriesApi->UpdateItemCategory");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ItemCategoriesApi->UpdateItemCategory");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ItemCategoriesApi->UpdateItemCategory");

            var localVarPath = "/{company_id}/item_categories/{id}";
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
            if (itemCategoryForm != null && itemCategoryForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(itemCategoryForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = itemCategoryForm; // byte array
            }

           

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateItemCategory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2017>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2017) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2017)));
            
        }

    }
}
