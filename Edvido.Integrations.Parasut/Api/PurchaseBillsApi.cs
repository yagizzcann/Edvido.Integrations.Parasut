
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
    public interface IPurchaseBillsApi : IApiAccessor
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
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        InlineResponse2019 ArchivePurchaseBill (int? companyId, int? id, string include = null);

        /// <summary>
        /// Archive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        ApiResponse<InlineResponse2019> ArchivePurchaseBillWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Cancel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        InlineResponse2019 CancelPurchaseBill (int? companyId, int? id, string include = null);

        /// <summary>
        /// Cancel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        ApiResponse<InlineResponse2019> CancelPurchaseBillWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Create Basic PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        InlineResponse2019 CreatePurchaseBillBasic (PurchaseBillForm purchaseBillForm, int? companyId, string include = null);

        /// <summary>
        /// Create Basic PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        ApiResponse<InlineResponse2019> CreatePurchaseBillBasicWithHttpInfo (PurchaseBillForm purchaseBillForm, int? companyId, string include = null);
        /// <summary>
        /// Create Detailed PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        InlineResponse2019 CreatePurchaseBillDetailed (PurchaseBillForm1 purchaseBillForm, int? companyId, string include = null);

        /// <summary>
        /// Create Detailed PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        ApiResponse<InlineResponse2019> CreatePurchaseBillDetailedWithHttpInfo (PurchaseBillForm1 purchaseBillForm, int? companyId, string include = null);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <returns>Object</returns>
        Object DeletePurchaseBill (int? companyId, int? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DeletePurchaseBillWithHttpInfo (int? companyId, int? id);
        /// <summary>
        /// Pay
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>InlineResponse2012</returns>
        InlineResponse2012 PayPurchaseBill (PaymentForm1 paymentForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Pay
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2012</returns>
        ApiResponse<InlineResponse2012> PayPurchaseBillWithHttpInfo (PaymentForm1 paymentForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Recover
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        InlineResponse2019 RecoverPurchaseBill (int? companyId, int? id, string include = null);

        /// <summary>
        /// Recover
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        ApiResponse<InlineResponse2019> RecoverPurchaseBillWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        InlineResponse2019 ShowPurchaseBill (int? companyId, int? id, string include = null);

        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        ApiResponse<InlineResponse2019> ShowPurchaseBillWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        InlineResponse2019 UnarchivePurchaseBill (int? companyId, int? id, string include = null);

        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        ApiResponse<InlineResponse2019> UnarchivePurchaseBillWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit Basic PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        InlineResponse2019 UpdatePurchaseBillBasic (PurchaseBillForm2 purchaseBillForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit Basic PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        ApiResponse<InlineResponse2019> UpdatePurchaseBillBasicWithHttpInfo (PurchaseBillForm2 purchaseBillForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit Detailed PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        InlineResponse2019 UpdatePurchaseBillDetailed (PurchaseBillForm3 purchaseBillForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit Detailed PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        ApiResponse<InlineResponse2019> UpdatePurchaseBillDetailedWithHttpInfo (PurchaseBillForm3 purchaseBillForm, int? companyId, int? id, string include = null);
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
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        System.Threading.Tasks.Task<InlineResponse2019> ArchivePurchaseBillAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Archive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> ArchivePurchaseBillAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Cancel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        System.Threading.Tasks.Task<InlineResponse2019> CancelPurchaseBillAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Cancel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> CancelPurchaseBillAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Create Basic PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        System.Threading.Tasks.Task<InlineResponse2019> CreatePurchaseBillBasicAsync (PurchaseBillForm purchaseBillForm, int? companyId, string include = null);

        /// <summary>
        /// Create Basic PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> CreatePurchaseBillBasicAsyncWithHttpInfo (PurchaseBillForm purchaseBillForm, int? companyId, string include = null);
        /// <summary>
        /// Create Detailed PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        System.Threading.Tasks.Task<InlineResponse2019> CreatePurchaseBillDetailedAsync (PurchaseBillForm1 purchaseBillForm, int? companyId, string include = null);

        /// <summary>
        /// Create Detailed PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> CreatePurchaseBillDetailedAsyncWithHttpInfo (PurchaseBillForm1 purchaseBillForm, int? companyId, string include = null);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DeletePurchaseBillAsync (int? companyId, int? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePurchaseBillAsyncWithHttpInfo (int? companyId, int? id);
        /// <summary>
        /// Pay
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>Task of InlineResponse2012</returns>
        System.Threading.Tasks.Task<InlineResponse2012> PayPurchaseBillAsync (PaymentForm1 paymentForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Pay
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2012)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2012>> PayPurchaseBillAsyncWithHttpInfo (PaymentForm1 paymentForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Recover
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        System.Threading.Tasks.Task<InlineResponse2019> RecoverPurchaseBillAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Recover
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> RecoverPurchaseBillAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        System.Threading.Tasks.Task<InlineResponse2019> ShowPurchaseBillAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> ShowPurchaseBillAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        System.Threading.Tasks.Task<InlineResponse2019> UnarchivePurchaseBillAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> UnarchivePurchaseBillAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit Basic PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        System.Threading.Tasks.Task<InlineResponse2019> UpdatePurchaseBillBasicAsync (PurchaseBillForm2 purchaseBillForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit Basic PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> UpdatePurchaseBillBasicAsyncWithHttpInfo (PurchaseBillForm2 purchaseBillForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit Detailed PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        System.Threading.Tasks.Task<InlineResponse2019> UpdatePurchaseBillDetailedAsync (PurchaseBillForm3 purchaseBillForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit Detailed PurchaseBill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> UpdatePurchaseBillDetailedAsyncWithHttpInfo (PurchaseBillForm3 purchaseBillForm, int? companyId, int? id, string include = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PurchaseBillsApi : IPurchaseBillsApi
    {
        private Edvido.Integrations.Parasut.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseBillsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PurchaseBillsApi(Configuration configuration = null)
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
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        public InlineResponse2019 ArchivePurchaseBill (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = ArchivePurchaseBillWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        public ApiResponse< InlineResponse2019 > ArchivePurchaseBillWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->ArchivePurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->ArchivePurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}/archive";
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
                Exception exception = ExceptionFactory("ArchivePurchaseBill", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        public async System.Threading.Tasks.Task<InlineResponse2019> ArchivePurchaseBillAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = await ArchivePurchaseBillAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> ArchivePurchaseBillAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->ArchivePurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->ArchivePurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}/archive";
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
                Exception exception = ExceptionFactory("ArchivePurchaseBill", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Cancel 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        public InlineResponse2019 CancelPurchaseBill (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = CancelPurchaseBillWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        public ApiResponse< InlineResponse2019 > CancelPurchaseBillWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->CancelPurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->CancelPurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}/cancel";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelPurchaseBill", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Cancel 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        public async System.Threading.Tasks.Task<InlineResponse2019> CancelPurchaseBillAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = await CancelPurchaseBillAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancel 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> CancelPurchaseBillAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->CancelPurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->CancelPurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}/cancel";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelPurchaseBill", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Create Basic PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        public InlineResponse2019 CreatePurchaseBillBasic (PurchaseBillForm purchaseBillForm, int? companyId, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = CreatePurchaseBillBasicWithHttpInfo(purchaseBillForm, companyId, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Basic PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        public ApiResponse< InlineResponse2019 > CreatePurchaseBillBasicWithHttpInfo (PurchaseBillForm purchaseBillForm, int? companyId, string include = null)
        {
            // verify the required parameter 'purchaseBillForm' is set
            if (purchaseBillForm == null)
                throw new ApiException(400, "Missing required parameter 'purchaseBillForm' when calling PurchaseBillsApi->CreatePurchaseBillBasic");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->CreatePurchaseBillBasic");

            var localVarPath = "/{company_id}/purchase_bills#basic";
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
            if (purchaseBillForm != null && purchaseBillForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(purchaseBillForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = purchaseBillForm; // byte array
            }

           

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePurchaseBillBasic", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Create Basic PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        public async System.Threading.Tasks.Task<InlineResponse2019> CreatePurchaseBillBasicAsync (PurchaseBillForm purchaseBillForm, int? companyId, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = await CreatePurchaseBillBasicAsyncWithHttpInfo(purchaseBillForm, companyId, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Basic PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> CreatePurchaseBillBasicAsyncWithHttpInfo (PurchaseBillForm purchaseBillForm, int? companyId, string include = null)
        {
            // verify the required parameter 'purchaseBillForm' is set
            if (purchaseBillForm == null)
                throw new ApiException(400, "Missing required parameter 'purchaseBillForm' when calling PurchaseBillsApi->CreatePurchaseBillBasic");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->CreatePurchaseBillBasic");

            var localVarPath = "/{company_id}/purchase_bills#basic";
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
            if (purchaseBillForm != null && purchaseBillForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(purchaseBillForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = purchaseBillForm; // byte array
            }

           
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePurchaseBillBasic", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Create Detailed PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        public InlineResponse2019 CreatePurchaseBillDetailed (PurchaseBillForm1 purchaseBillForm, int? companyId, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = CreatePurchaseBillDetailedWithHttpInfo(purchaseBillForm, companyId, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Detailed PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        public ApiResponse< InlineResponse2019 > CreatePurchaseBillDetailedWithHttpInfo (PurchaseBillForm1 purchaseBillForm, int? companyId, string include = null)
        {
            // verify the required parameter 'purchaseBillForm' is set
            if (purchaseBillForm == null)
                throw new ApiException(400, "Missing required parameter 'purchaseBillForm' when calling PurchaseBillsApi->CreatePurchaseBillDetailed");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->CreatePurchaseBillDetailed");

            var localVarPath = "/{company_id}/purchase_bills#detailed";
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
            if (purchaseBillForm != null && purchaseBillForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(purchaseBillForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = purchaseBillForm; // byte array
            }

          
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePurchaseBillDetailed", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Create Detailed PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        public async System.Threading.Tasks.Task<InlineResponse2019> CreatePurchaseBillDetailedAsync (PurchaseBillForm1 purchaseBillForm, int? companyId, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = await CreatePurchaseBillDetailedAsyncWithHttpInfo(purchaseBillForm, companyId, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Detailed PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> CreatePurchaseBillDetailedAsyncWithHttpInfo (PurchaseBillForm1 purchaseBillForm, int? companyId, string include = null)
        {
            // verify the required parameter 'purchaseBillForm' is set
            if (purchaseBillForm == null)
                throw new ApiException(400, "Missing required parameter 'purchaseBillForm' when calling PurchaseBillsApi->CreatePurchaseBillDetailed");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->CreatePurchaseBillDetailed");

            var localVarPath = "/{company_id}/purchase_bills#detailed";
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
            if (purchaseBillForm != null && purchaseBillForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(purchaseBillForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = purchaseBillForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePurchaseBillDetailed", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <returns>Object</returns>
        public Object DeletePurchaseBill (int? companyId, int? id)
        {
             ApiResponse<Object> localVarResponse = DeletePurchaseBillWithHttpInfo(companyId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DeletePurchaseBillWithHttpInfo (int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->DeletePurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->DeletePurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}";
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
                Exception exception = ExceptionFactory("DeletePurchaseBill", localVarResponse);
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
        /// <param name="id">Fatura ID</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DeletePurchaseBillAsync (int? companyId, int? id)
        {
             ApiResponse<Object> localVarResponse = await DeletePurchaseBillAsyncWithHttpInfo(companyId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePurchaseBillAsyncWithHttpInfo (int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->DeletePurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->DeletePurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}";
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
                Exception exception = ExceptionFactory("DeletePurchaseBill", localVarResponse);
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
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>InlineResponse2012</returns>
        public InlineResponse2012 PayPurchaseBill (PaymentForm1 paymentForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2012> localVarResponse = PayPurchaseBillWithHttpInfo(paymentForm, companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Pay 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2012</returns>
        public ApiResponse< InlineResponse2012 > PayPurchaseBillWithHttpInfo (PaymentForm1 paymentForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'paymentForm' is set
            if (paymentForm == null)
                throw new ApiException(400, "Missing required parameter 'paymentForm' when calling PurchaseBillsApi->PayPurchaseBill");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->PayPurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->PayPurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}/payments";
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
                Exception exception = ExceptionFactory("PayPurchaseBill", localVarResponse);
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
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>Task of InlineResponse2012</returns>
        public async System.Threading.Tasks.Task<InlineResponse2012> PayPurchaseBillAsync (PaymentForm1 paymentForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2012> localVarResponse = await PayPurchaseBillAsyncWithHttpInfo(paymentForm, companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Pay 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2012)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2012>> PayPurchaseBillAsyncWithHttpInfo (PaymentForm1 paymentForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'paymentForm' is set
            if (paymentForm == null)
                throw new ApiException(400, "Missing required parameter 'paymentForm' when calling PurchaseBillsApi->PayPurchaseBill");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->PayPurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->PayPurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}/payments";
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
                Exception exception = ExceptionFactory("PayPurchaseBill", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2012>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2012) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2012)));
            
        }

        /// <summary>
        /// Recover 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        public InlineResponse2019 RecoverPurchaseBill (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = RecoverPurchaseBillWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Recover 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        public ApiResponse< InlineResponse2019 > RecoverPurchaseBillWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->RecoverPurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->RecoverPurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}/recover";
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
                Exception exception = ExceptionFactory("RecoverPurchaseBill", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Recover 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        public async System.Threading.Tasks.Task<InlineResponse2019> RecoverPurchaseBillAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = await RecoverPurchaseBillAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Recover 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> RecoverPurchaseBillAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->RecoverPurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->RecoverPurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}/recover";
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
                Exception exception = ExceptionFactory("RecoverPurchaseBill", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        public InlineResponse2019 ShowPurchaseBill (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = ShowPurchaseBillWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        public ApiResponse< InlineResponse2019 > ShowPurchaseBillWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->ShowPurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->ShowPurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}";
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
                Exception exception = ExceptionFactory("ShowPurchaseBill", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        public async System.Threading.Tasks.Task<InlineResponse2019> ShowPurchaseBillAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = await ShowPurchaseBillAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> ShowPurchaseBillAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->ShowPurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->ShowPurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}";
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
                Exception exception = ExceptionFactory("ShowPurchaseBill", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        public InlineResponse2019 UnarchivePurchaseBill (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = UnarchivePurchaseBillWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        public ApiResponse< InlineResponse2019 > UnarchivePurchaseBillWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->UnarchivePurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->UnarchivePurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}/unarchive";
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
                Exception exception = ExceptionFactory("UnarchivePurchaseBill", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        public async System.Threading.Tasks.Task<InlineResponse2019> UnarchivePurchaseBillAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = await UnarchivePurchaseBillAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> UnarchivePurchaseBillAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->UnarchivePurchaseBill");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->UnarchivePurchaseBill");

            var localVarPath = "/{company_id}/purchase_bills/{id}/unarchive";
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
                Exception exception = ExceptionFactory("UnarchivePurchaseBill", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Edit Basic PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        public InlineResponse2019 UpdatePurchaseBillBasic (PurchaseBillForm2 purchaseBillForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = UpdatePurchaseBillBasicWithHttpInfo(purchaseBillForm, companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Edit Basic PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        public ApiResponse< InlineResponse2019 > UpdatePurchaseBillBasicWithHttpInfo (PurchaseBillForm2 purchaseBillForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'purchaseBillForm' is set
            if (purchaseBillForm == null)
                throw new ApiException(400, "Missing required parameter 'purchaseBillForm' when calling PurchaseBillsApi->UpdatePurchaseBillBasic");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->UpdatePurchaseBillBasic");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->UpdatePurchaseBillBasic");

            var localVarPath = "/{company_id}/purchase_bills/{id}#basic";
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
            if (purchaseBillForm != null && purchaseBillForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(purchaseBillForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = purchaseBillForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdatePurchaseBillBasic", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Edit Basic PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        public async System.Threading.Tasks.Task<InlineResponse2019> UpdatePurchaseBillBasicAsync (PurchaseBillForm2 purchaseBillForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = await UpdatePurchaseBillBasicAsyncWithHttpInfo(purchaseBillForm, companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Edit Basic PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> UpdatePurchaseBillBasicAsyncWithHttpInfo (PurchaseBillForm2 purchaseBillForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'purchaseBillForm' is set
            if (purchaseBillForm == null)
                throw new ApiException(400, "Missing required parameter 'purchaseBillForm' when calling PurchaseBillsApi->UpdatePurchaseBillBasic");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->UpdatePurchaseBillBasic");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->UpdatePurchaseBillBasic");

            var localVarPath = "/{company_id}/purchase_bills/{id}#basic";
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
            if (purchaseBillForm != null && purchaseBillForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(purchaseBillForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = purchaseBillForm; // byte array
            }

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdatePurchaseBillBasic", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Edit Detailed PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse2019</returns>
        public InlineResponse2019 UpdatePurchaseBillDetailed (PurchaseBillForm3 purchaseBillForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = UpdatePurchaseBillDetailedWithHttpInfo(purchaseBillForm, companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Edit Detailed PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2019</returns>
        public ApiResponse< InlineResponse2019 > UpdatePurchaseBillDetailedWithHttpInfo (PurchaseBillForm3 purchaseBillForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'purchaseBillForm' is set
            if (purchaseBillForm == null)
                throw new ApiException(400, "Missing required parameter 'purchaseBillForm' when calling PurchaseBillsApi->UpdatePurchaseBillDetailed");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->UpdatePurchaseBillDetailed");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->UpdatePurchaseBillDetailed");

            var localVarPath = "/{company_id}/purchase_bills/{id}#detailed";
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
            if (purchaseBillForm != null && purchaseBillForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(purchaseBillForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = purchaseBillForm; // byte array
            }

           

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdatePurchaseBillDetailed", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

        /// <summary>
        /// Edit Detailed PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse2019</returns>
        public async System.Threading.Tasks.Task<InlineResponse2019> UpdatePurchaseBillDetailedAsync (PurchaseBillForm3 purchaseBillForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2019> localVarResponse = await UpdatePurchaseBillDetailedAsyncWithHttpInfo(purchaseBillForm, companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Edit Detailed PurchaseBill 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseBillForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, spender, supplier, payments, tags, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2019)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2019>> UpdatePurchaseBillDetailedAsyncWithHttpInfo (PurchaseBillForm3 purchaseBillForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'purchaseBillForm' is set
            if (purchaseBillForm == null)
                throw new ApiException(400, "Missing required parameter 'purchaseBillForm' when calling PurchaseBillsApi->UpdatePurchaseBillDetailed");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling PurchaseBillsApi->UpdatePurchaseBillDetailed");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PurchaseBillsApi->UpdatePurchaseBillDetailed");

            var localVarPath = "/{company_id}/purchase_bills/{id}#detailed";
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
            if (purchaseBillForm != null && purchaseBillForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(purchaseBillForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = purchaseBillForm; // byte array
            }

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdatePurchaseBillDetailed", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2019>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2019) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2019)));
            
        }

    }
}
