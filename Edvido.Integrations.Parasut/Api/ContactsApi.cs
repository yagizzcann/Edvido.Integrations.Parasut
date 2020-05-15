
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
    public interface IContactsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Tahsilat
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>InlineResponse2014</returns>
        InlineResponse2014 CollectFromContact(TransactionForm transactionForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Tahsilat
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2014</returns>
        ApiResponse<InlineResponse2014> CollectFromContactWithHttpInfo(TransactionForm transactionForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>InlineResponse2013</returns>
        InlineResponse2013 CreateContact(ContactForm contactForm, int? companyId, string include = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2013</returns>
        ApiResponse<InlineResponse2013> CreateContactWithHttpInfo(ContactForm contactForm, int? companyId, string include = null);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <returns>Object</returns>
        Object DeleteContact(int? companyId, int? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DeleteContactWithHttpInfo(int? companyId, int? id);
        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterEmail"> (optional)</param>
        /// <param name="filterTaxNumber"> (optional)</param>
        /// <param name="filterTaxOffice"> (optional)</param>
        /// <param name="filterCity"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, name, email* (optional, default to -balance)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 ListContacts(int? companyId, string filterName = null, string filterEmail = null, string filterTaxNumber = null, string filterTaxOffice = null, string filterCity = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null);

        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterEmail"> (optional)</param>
        /// <param name="filterTaxNumber"> (optional)</param>
        /// <param name="filterTaxOffice"> (optional)</param>
        /// <param name="filterCity"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, name, email* (optional, default to -balance)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> ListContactsWithHttpInfo(int? companyId, string filterName = null, string filterEmail = null, string filterTaxNumber = null, string filterTaxOffice = null, string filterCity = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null);
        /// <summary>
        /// Ödeme
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>InlineResponse2014</returns>
        InlineResponse2014 PayToContact(TransactionForm1 transactionForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Ödeme
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2014</returns>
        ApiResponse<InlineResponse2014> PayToContactWithHttpInfo(TransactionForm1 transactionForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>InlineResponse2013</returns>
        InlineResponse2013 ShowContact(int? companyId, int? id, string include = null);

        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2013</returns>
        ApiResponse<InlineResponse2013> ShowContactWithHttpInfo(int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>InlineResponse2013</returns>
        InlineResponse2013 UpdateContact(ContactForm1 contactForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2013</returns>
        ApiResponse<InlineResponse2013> UpdateContactWithHttpInfo(ContactForm1 contactForm, int? companyId, int? id, string include = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Tahsilat
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>Task of InlineResponse2014</returns>
        System.Threading.Tasks.Task<InlineResponse2014> CollectFromContactAsync(TransactionForm transactionForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Tahsilat
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2014)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2014>> CollectFromContactAsyncWithHttpInfo(TransactionForm transactionForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of InlineResponse2013</returns>
        System.Threading.Tasks.Task<InlineResponse2013> CreateContactAsync(ContactForm contactForm, int? companyId, string include = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2013)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2013>> CreateContactAsyncWithHttpInfo(ContactForm contactForm, int? companyId, string include = null);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DeleteContactAsync(int? companyId, int? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteContactAsyncWithHttpInfo(int? companyId, int? id);
        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterEmail"> (optional)</param>
        /// <param name="filterTaxNumber"> (optional)</param>
        /// <param name="filterTaxOffice"> (optional)</param>
        /// <param name="filterCity"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, name, email* (optional, default to -balance)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> ListContactsAsync(int? companyId, string filterName = null, string filterEmail = null, string filterTaxNumber = null, string filterTaxOffice = null, string filterCity = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null);

        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterEmail"> (optional)</param>
        /// <param name="filterTaxNumber"> (optional)</param>
        /// <param name="filterTaxOffice"> (optional)</param>
        /// <param name="filterCity"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, name, email* (optional, default to -balance)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> ListContactsAsyncWithHttpInfo(int? companyId, string filterName = null, string filterEmail = null, string filterTaxNumber = null, string filterTaxOffice = null, string filterCity = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null);
        /// <summary>
        /// Ödeme
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>Task of InlineResponse2014</returns>
        System.Threading.Tasks.Task<InlineResponse2014> PayToContactAsync(TransactionForm1 transactionForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Ödeme
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2014)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2014>> PayToContactAsyncWithHttpInfo(TransactionForm1 transactionForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of InlineResponse2013</returns>
        System.Threading.Tasks.Task<InlineResponse2013> ShowContactAsync(int? companyId, int? id, string include = null);

        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2013)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2013>> ShowContactAsyncWithHttpInfo(int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of InlineResponse2013</returns>
        System.Threading.Tasks.Task<InlineResponse2013> UpdateContactAsync(ContactForm1 contactForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2013)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2013>> UpdateContactAsyncWithHttpInfo(ContactForm1 contactForm, int? companyId, int? id, string include = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ContactsApi : IContactsApi
    {
        private Edvido.Integrations.Parasut.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

      

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContactsApi(Configuration configuration = null)
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
        /// Tahsilat 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>InlineResponse2014</returns>
        public InlineResponse2014 CollectFromContact(TransactionForm transactionForm, int? companyId, int? id, string include = null)
        {
            ApiResponse<InlineResponse2014> localVarResponse = CollectFromContactWithHttpInfo(transactionForm, companyId, id, include);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Tahsilat 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2014</returns>
        public ApiResponse<InlineResponse2014> CollectFromContactWithHttpInfo(TransactionForm transactionForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'transactionForm' is set
            if (transactionForm == null)
                throw new ApiException(400, "Missing required parameter 'transactionForm' when calling ContactsApi->CollectFromContact");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->CollectFromContact");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContactsApi->CollectFromContact");

            var localVarPath = "/{company_id}/contacts/{id}/contact_debit_transactions";
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
            if (transactionForm != null && transactionForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transactionForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactionForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CollectFromContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2014>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2014)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2014)));

        }

        /// <summary>
        /// Tahsilat 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>Task of InlineResponse2014</returns>
        public async System.Threading.Tasks.Task<InlineResponse2014> CollectFromContactAsync(TransactionForm transactionForm, int? companyId, int? id, string include = null)
        {
            ApiResponse<InlineResponse2014> localVarResponse = await CollectFromContactAsyncWithHttpInfo(transactionForm, companyId, id, include);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Tahsilat 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2014)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2014>> CollectFromContactAsyncWithHttpInfo(TransactionForm transactionForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'transactionForm' is set
            if (transactionForm == null)
                throw new ApiException(400, "Missing required parameter 'transactionForm' when calling ContactsApi->CollectFromContact");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->CollectFromContact");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContactsApi->CollectFromContact");

            var localVarPath = "/{company_id}/contacts/{id}/contact_debit_transactions";
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
            if (transactionForm != null && transactionForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transactionForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactionForm; // byte array
            }

           

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CollectFromContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2014>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2014)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2014)));

        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>InlineResponse2013</returns>
        public InlineResponse2013 CreateContact(ContactForm contactForm, int? companyId, string include = null)
        {
            ApiResponse<InlineResponse2013> localVarResponse = CreateContactWithHttpInfo(contactForm, companyId, include);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2013</returns>
        public ApiResponse<InlineResponse2013> CreateContactWithHttpInfo(ContactForm contactForm, int? companyId, string include = null)
        {
            // verify the required parameter 'contactForm' is set
            if (contactForm == null)
                throw new ApiException(400, "Missing required parameter 'contactForm' when calling ContactsApi->CreateContact");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->CreateContact");

            var localVarPath = "/{company_id}/contacts";
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
            if (contactForm != null && contactForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contactForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2013>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2013)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2013)));

        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of InlineResponse2013</returns>
        public async System.Threading.Tasks.Task<InlineResponse2013> CreateContactAsync(ContactForm contactForm, int? companyId, string include = null)
        {
            ApiResponse<InlineResponse2013> localVarResponse = await CreateContactAsyncWithHttpInfo(contactForm, companyId, include);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2013)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2013>> CreateContactAsyncWithHttpInfo(ContactForm contactForm, int? companyId, string include = null)
        {
            // verify the required parameter 'contactForm' is set
            if (contactForm == null)
                throw new ApiException(400, "Missing required parameter 'contactForm' when calling ContactsApi->CreateContact");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->CreateContact");

            var localVarPath = "/{company_id}/contacts";
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
            if (contactForm != null && contactForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contactForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2013>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2013)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2013)));

        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <returns>Object</returns>
        public Object DeleteContact(int? companyId, int? id)
        {
            ApiResponse<Object> localVarResponse = DeleteContactWithHttpInfo(companyId, id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<Object> DeleteContactWithHttpInfo(int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->DeleteContact");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContactsApi->DeleteContact");

            var localVarPath = "/{company_id}/contacts/{id}";
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
                Exception exception = ExceptionFactory("DeleteContact", localVarResponse);
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
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteContactAsync(int? companyId, int? id)
        {
            ApiResponse<Object> localVarResponse = await DeleteContactAsyncWithHttpInfo(companyId, id);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteContactAsyncWithHttpInfo(int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->DeleteContact");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContactsApi->DeleteContact");

            var localVarPath = "/{company_id}/contacts/{id}";
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
                Exception exception = ExceptionFactory("DeleteContact", localVarResponse);
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
        /// <param name="filterEmail"> (optional)</param>
        /// <param name="filterTaxNumber"> (optional)</param>
        /// <param name="filterTaxOffice"> (optional)</param>
        /// <param name="filterCity"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, name, email* (optional, default to -balance)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 ListContacts(int? companyId, string filterName = null, string filterEmail = null, string filterTaxNumber = null, string filterTaxOffice = null, string filterCity = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null)
        {
            ApiResponse<InlineResponse2002> localVarResponse = ListContactsWithHttpInfo(companyId, filterName, filterEmail, filterTaxNumber, filterTaxOffice, filterCity, sort, pageNumber, pageSize, include);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterEmail"> (optional)</param>
        /// <param name="filterTaxNumber"> (optional)</param>
        /// <param name="filterTaxOffice"> (optional)</param>
        /// <param name="filterCity"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, name, email* (optional, default to -balance)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse<InlineResponse2002> ListContactsWithHttpInfo(int? companyId, string filterName = null, string filterEmail = null, string filterTaxNumber = null, string filterTaxOffice = null, string filterCity = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->ListContacts");

            var localVarPath = "/{company_id}/contacts";
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
            if (filterEmail != null) localVarQueryParams.Add("filter[email]", Configuration.ApiClient.ParameterToString(filterEmail)); // query parameter
            if (filterTaxNumber != null) localVarQueryParams.Add("filter[tax_number]", Configuration.ApiClient.ParameterToString(filterTaxNumber)); // query parameter
            if (filterTaxOffice != null) localVarQueryParams.Add("filter[tax_office]", Configuration.ApiClient.ParameterToString(filterTaxOffice)); // query parameter
            if (filterCity != null) localVarQueryParams.Add("filter[city]", Configuration.ApiClient.ParameterToString(filterCity)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("page[number]", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page[size]", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

         
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2002>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2002)));

        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterEmail"> (optional)</param>
        /// <param name="filterTaxNumber"> (optional)</param>
        /// <param name="filterTaxOffice"> (optional)</param>
        /// <param name="filterCity"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, name, email* (optional, default to -balance)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> ListContactsAsync(int? companyId, string filterName = null, string filterEmail = null, string filterTaxNumber = null, string filterTaxOffice = null, string filterCity = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null)
        {
            ApiResponse<InlineResponse2002> localVarResponse = await ListContactsAsyncWithHttpInfo(companyId, filterName, filterEmail, filterTaxNumber, filterTaxOffice, filterCity, sort, pageNumber, pageSize, include);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="filterName"> (optional)</param>
        /// <param name="filterEmail"> (optional)</param>
        /// <param name="filterTaxNumber"> (optional)</param>
        /// <param name="filterTaxOffice"> (optional)</param>
        /// <param name="filterCity"> (optional)</param>
        /// <param name="sort">Sortable parameters - *Available: id, balance, name, email* (optional, default to -balance)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> ListContactsAsyncWithHttpInfo(int? companyId, string filterName = null, string filterEmail = null, string filterTaxNumber = null, string filterTaxOffice = null, string filterCity = null, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->ListContacts");

            var localVarPath = "/{company_id}/contacts";
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
            if (filterEmail != null) localVarQueryParams.Add("filter[email]", Configuration.ApiClient.ParameterToString(filterEmail)); // query parameter
            if (filterTaxNumber != null) localVarQueryParams.Add("filter[tax_number]", Configuration.ApiClient.ParameterToString(filterTaxNumber)); // query parameter
            if (filterTaxOffice != null) localVarQueryParams.Add("filter[tax_office]", Configuration.ApiClient.ParameterToString(filterTaxOffice)); // query parameter
            if (filterCity != null) localVarQueryParams.Add("filter[city]", Configuration.ApiClient.ParameterToString(filterCity)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("page[number]", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page[size]", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2002>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2002)));

        }

        /// <summary>
        /// Ödeme 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>InlineResponse2014</returns>
        public InlineResponse2014 PayToContact(TransactionForm1 transactionForm, int? companyId, int? id, string include = null)
        {
            ApiResponse<InlineResponse2014> localVarResponse = PayToContactWithHttpInfo(transactionForm, companyId, id, include);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Ödeme 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2014</returns>
        public ApiResponse<InlineResponse2014> PayToContactWithHttpInfo(TransactionForm1 transactionForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'transactionForm' is set
            if (transactionForm == null)
                throw new ApiException(400, "Missing required parameter 'transactionForm' when calling ContactsApi->PayToContact");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->PayToContact");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContactsApi->PayToContact");

            var localVarPath = "/{company_id}/contacts/{id}/contact_credit_transactions";
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
            if (transactionForm != null && transactionForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transactionForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactionForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PayToContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2014>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2014)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2014)));

        }

        /// <summary>
        /// Ödeme 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>Task of InlineResponse2014</returns>
        public async System.Threading.Tasks.Task<InlineResponse2014> PayToContactAsync(TransactionForm1 transactionForm, int? companyId, int? id, string include = null)
        {
            ApiResponse<InlineResponse2014> localVarResponse = await PayToContactAsyncWithHttpInfo(transactionForm, companyId, id, include);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Ödeme 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: debit_account, credit_account, payments* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2014)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2014>> PayToContactAsyncWithHttpInfo(TransactionForm1 transactionForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'transactionForm' is set
            if (transactionForm == null)
                throw new ApiException(400, "Missing required parameter 'transactionForm' when calling ContactsApi->PayToContact");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->PayToContact");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContactsApi->PayToContact");

            var localVarPath = "/{company_id}/contacts/{id}/contact_credit_transactions";
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
            if (transactionForm != null && transactionForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transactionForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactionForm; // byte array
            }

           

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PayToContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2014>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2014)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2014)));

        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>InlineResponse2013</returns>
        public InlineResponse2013 ShowContact(int? companyId, int? id, string include = null)
        {
            ApiResponse<InlineResponse2013> localVarResponse = ShowContactWithHttpInfo(companyId, id, include);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2013</returns>
        public ApiResponse<InlineResponse2013> ShowContactWithHttpInfo(int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->ShowContact");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContactsApi->ShowContact");

            var localVarPath = "/{company_id}/contacts/{id}";
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
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ShowContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2013>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2013)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2013)));

        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of InlineResponse2013</returns>
        public async System.Threading.Tasks.Task<InlineResponse2013> ShowContactAsync(int? companyId, int? id, string include = null)
        {
            ApiResponse<InlineResponse2013> localVarResponse = await ShowContactAsyncWithHttpInfo(companyId, id, include);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2013)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2013>> ShowContactAsyncWithHttpInfo(int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->ShowContact");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContactsApi->ShowContact");

            var localVarPath = "/{company_id}/contacts/{id}";
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
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ShowContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2013>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2013)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2013)));

        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>InlineResponse2013</returns>
        public InlineResponse2013 UpdateContact(ContactForm1 contactForm, int? companyId, int? id, string include = null)
        {
            ApiResponse<InlineResponse2013> localVarResponse = UpdateContactWithHttpInfo(contactForm, companyId, id, include);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2013</returns>
        public ApiResponse<InlineResponse2013> UpdateContactWithHttpInfo(ContactForm1 contactForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'contactForm' is set
            if (contactForm == null)
                throw new ApiException(400, "Missing required parameter 'contactForm' when calling ContactsApi->UpdateContact");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->UpdateContact");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContactsApi->UpdateContact");

            var localVarPath = "/{company_id}/contacts/{id}";
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
            if (contactForm != null && contactForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contactForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactForm; // byte array
            }

           

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2013>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2013)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2013)));

        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of InlineResponse2013</returns>
        public async System.Threading.Tasks.Task<InlineResponse2013> UpdateContactAsync(ContactForm1 contactForm, int? companyId, int? id, string include = null)
        {
            ApiResponse<InlineResponse2013> localVarResponse = await UpdateContactAsyncWithHttpInfo(contactForm, companyId, id, include);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Müşteri/Tedarikçi ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact_portal, contact_people* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2013)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2013>> UpdateContactAsyncWithHttpInfo(ContactForm1 contactForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'contactForm' is set
            if (contactForm == null)
                throw new ApiException(400, "Missing required parameter 'contactForm' when calling ContactsApi->UpdateContact");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ContactsApi->UpdateContact");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContactsApi->UpdateContact");

            var localVarPath = "/{company_id}/contacts/{id}";
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
            if (contactForm != null && contactForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contactForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactForm; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2013>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2013)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2013)));

        }

    }
}
