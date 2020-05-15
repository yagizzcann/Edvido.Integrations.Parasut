
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
    public interface ISalesInvoicesApi : IApiAccessor
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
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        InlineResponse20111 ArchiveSalesInvoice (int? companyId, int? id, string include = null);

        /// <summary>
        /// Archive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        ApiResponse<InlineResponse20111> ArchiveSalesInvoiceWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Cancel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        InlineResponse20111 CancelSalesInvoice (int? companyId, int? id, string include = null);

        /// <summary>
        /// Cancel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        ApiResponse<InlineResponse20111> CancelSalesInvoiceWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Convert estimate to invoice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        InlineResponse20111 ConvertEstimateToInvoice (SalesInvoiceForm2 salesInvoiceForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Convert estimate to invoice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        ApiResponse<InlineResponse20111> ConvertEstimateToInvoiceWithHttpInfo (SalesInvoiceForm2 salesInvoiceForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        InlineResponse20111 CreateSalesInvoice (SalesInvoiceForm salesInvoiceForm, int? companyId, string include = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        ApiResponse<InlineResponse20111> CreateSalesInvoiceWithHttpInfo (SalesInvoiceForm salesInvoiceForm, int? companyId, string include = null);
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
        Object DeleteSalesInvoice (int? companyId, int? id);

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
        ApiResponse<Object> DeleteSalesInvoiceWithHttpInfo (int? companyId, int? id);
        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="sort">Sortable parameters - *Available: id, issue_date, due_date, remaining, remaining_in_trl* (optional, default to -remaining_in_trl)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 ListSalesInvoices (int? companyId, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null);

        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="sort">Sortable parameters - *Available: id, issue_date, due_date, remaining, remaining_in_trl* (optional, default to -remaining_in_trl)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20010</returns>
        ApiResponse<InlineResponse20010> ListSalesInvoicesWithHttpInfo (int? companyId, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null);
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
        InlineResponse2012 PaySalesInvoice (PaymentForm3 paymentForm, int? companyId, int? id, string include = null);

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
        ApiResponse<InlineResponse2012> PaySalesInvoiceWithHttpInfo (PaymentForm3 paymentForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Recover
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        InlineResponse20111 RecoverSalesInvoice (int? companyId, int? id, string include = null);

        /// <summary>
        /// Recover
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        ApiResponse<InlineResponse20111> RecoverSalesInvoiceWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        InlineResponse20111 ShowSalesInvoice (int? companyId, int? id, string include = null);

        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        ApiResponse<InlineResponse20111> ShowSalesInvoiceWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        InlineResponse20111 UnarchiveSalesInvoice (int? companyId, int? id, string include = null);

        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        ApiResponse<InlineResponse20111> UnarchiveSalesInvoiceWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        InlineResponse20111 UpdateSalesInvoice (SalesInvoiceForm1 salesInvoiceForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        ApiResponse<InlineResponse20111> UpdateSalesInvoiceWithHttpInfo (SalesInvoiceForm1 salesInvoiceForm, int? companyId, int? id, string include = null);
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
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        System.Threading.Tasks.Task<InlineResponse20111> ArchiveSalesInvoiceAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Archive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> ArchiveSalesInvoiceAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Cancel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        System.Threading.Tasks.Task<InlineResponse20111> CancelSalesInvoiceAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Cancel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> CancelSalesInvoiceAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Convert estimate to invoice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        System.Threading.Tasks.Task<InlineResponse20111> ConvertEstimateToInvoiceAsync (SalesInvoiceForm2 salesInvoiceForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Convert estimate to invoice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> ConvertEstimateToInvoiceAsyncWithHttpInfo (SalesInvoiceForm2 salesInvoiceForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        System.Threading.Tasks.Task<InlineResponse20111> CreateSalesInvoiceAsync (SalesInvoiceForm salesInvoiceForm, int? companyId, string include = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> CreateSalesInvoiceAsyncWithHttpInfo (SalesInvoiceForm salesInvoiceForm, int? companyId, string include = null);
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
        System.Threading.Tasks.Task<Object> DeleteSalesInvoiceAsync (int? companyId, int? id);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSalesInvoiceAsyncWithHttpInfo (int? companyId, int? id);
        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="sort">Sortable parameters - *Available: id, issue_date, due_date, remaining, remaining_in_trl* (optional, default to -remaining_in_trl)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20010</returns>
        System.Threading.Tasks.Task<InlineResponse20010> ListSalesInvoicesAsync (int? companyId, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null);

        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="sort">Sortable parameters - *Available: id, issue_date, due_date, remaining, remaining_in_trl* (optional, default to -remaining_in_trl)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20010)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20010>> ListSalesInvoicesAsyncWithHttpInfo (int? companyId, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null);
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
        System.Threading.Tasks.Task<InlineResponse2012> PaySalesInvoiceAsync (PaymentForm3 paymentForm, int? companyId, int? id, string include = null);

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
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2012>> PaySalesInvoiceAsyncWithHttpInfo (PaymentForm3 paymentForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Recover
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        System.Threading.Tasks.Task<InlineResponse20111> RecoverSalesInvoiceAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Recover
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> RecoverSalesInvoiceAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        System.Threading.Tasks.Task<InlineResponse20111> ShowSalesInvoiceAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> ShowSalesInvoiceAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        System.Threading.Tasks.Task<InlineResponse20111> UnarchiveSalesInvoiceAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> UnarchiveSalesInvoiceAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        System.Threading.Tasks.Task<InlineResponse20111> UpdateSalesInvoiceAsync (SalesInvoiceForm1 salesInvoiceForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> UpdateSalesInvoiceAsyncWithHttpInfo (SalesInvoiceForm1 salesInvoiceForm, int? companyId, int? id, string include = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SalesInvoicesApi : ISalesInvoicesApi
    {
        private Edvido.Integrations.Parasut.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesInvoicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SalesInvoicesApi(Configuration configuration = null)
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
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        public InlineResponse20111 ArchiveSalesInvoice (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = ArchiveSalesInvoiceWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        public ApiResponse< InlineResponse20111 > ArchiveSalesInvoiceWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->ArchiveSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->ArchiveSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}/archive";
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
                Exception exception = ExceptionFactory("ArchiveSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        public async System.Threading.Tasks.Task<InlineResponse20111> ArchiveSalesInvoiceAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = await ArchiveSalesInvoiceAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> ArchiveSalesInvoiceAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->ArchiveSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->ArchiveSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}/archive";
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
                Exception exception = ExceptionFactory("ArchiveSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Cancel 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        public InlineResponse20111 CancelSalesInvoice (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = CancelSalesInvoiceWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        public ApiResponse< InlineResponse20111 > CancelSalesInvoiceWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->CancelSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->CancelSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}/cancel";
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
                Exception exception = ExceptionFactory("CancelSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Cancel 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        public async System.Threading.Tasks.Task<InlineResponse20111> CancelSalesInvoiceAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = await CancelSalesInvoiceAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancel 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> CancelSalesInvoiceAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->CancelSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->CancelSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}/cancel";
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
                Exception exception = ExceptionFactory("CancelSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Convert estimate to invoice 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        public InlineResponse20111 ConvertEstimateToInvoice (SalesInvoiceForm2 salesInvoiceForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = ConvertEstimateToInvoiceWithHttpInfo(salesInvoiceForm, companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Convert estimate to invoice 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        public ApiResponse< InlineResponse20111 > ConvertEstimateToInvoiceWithHttpInfo (SalesInvoiceForm2 salesInvoiceForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'salesInvoiceForm' is set
            if (salesInvoiceForm == null)
                throw new ApiException(400, "Missing required parameter 'salesInvoiceForm' when calling SalesInvoicesApi->ConvertEstimateToInvoice");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->ConvertEstimateToInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->ConvertEstimateToInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}/convert_to_invoice";
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
            if (salesInvoiceForm != null && salesInvoiceForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(salesInvoiceForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = salesInvoiceForm; // byte array
            }

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ConvertEstimateToInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Convert estimate to invoice 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        public async System.Threading.Tasks.Task<InlineResponse20111> ConvertEstimateToInvoiceAsync (SalesInvoiceForm2 salesInvoiceForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = await ConvertEstimateToInvoiceAsyncWithHttpInfo(salesInvoiceForm, companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Convert estimate to invoice 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> ConvertEstimateToInvoiceAsyncWithHttpInfo (SalesInvoiceForm2 salesInvoiceForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'salesInvoiceForm' is set
            if (salesInvoiceForm == null)
                throw new ApiException(400, "Missing required parameter 'salesInvoiceForm' when calling SalesInvoicesApi->ConvertEstimateToInvoice");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->ConvertEstimateToInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->ConvertEstimateToInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}/convert_to_invoice";
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
            if (salesInvoiceForm != null && salesInvoiceForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(salesInvoiceForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = salesInvoiceForm; // byte array
            }

        

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ConvertEstimateToInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        public InlineResponse20111 CreateSalesInvoice (SalesInvoiceForm salesInvoiceForm, int? companyId, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = CreateSalesInvoiceWithHttpInfo(salesInvoiceForm, companyId, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        public ApiResponse< InlineResponse20111 > CreateSalesInvoiceWithHttpInfo (SalesInvoiceForm salesInvoiceForm, int? companyId, string include = null)
        {
            // verify the required parameter 'salesInvoiceForm' is set
            if (salesInvoiceForm == null)
                throw new ApiException(400, "Missing required parameter 'salesInvoiceForm' when calling SalesInvoicesApi->CreateSalesInvoice");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->CreateSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices";
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
            if (salesInvoiceForm != null && salesInvoiceForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(salesInvoiceForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = salesInvoiceForm; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        public async System.Threading.Tasks.Task<InlineResponse20111> CreateSalesInvoiceAsync (SalesInvoiceForm salesInvoiceForm, int? companyId, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = await CreateSalesInvoiceAsyncWithHttpInfo(salesInvoiceForm, companyId, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> CreateSalesInvoiceAsyncWithHttpInfo (SalesInvoiceForm salesInvoiceForm, int? companyId, string include = null)
        {
            // verify the required parameter 'salesInvoiceForm' is set
            if (salesInvoiceForm == null)
                throw new ApiException(400, "Missing required parameter 'salesInvoiceForm' when calling SalesInvoicesApi->CreateSalesInvoice");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->CreateSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices";
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
            if (salesInvoiceForm != null && salesInvoiceForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(salesInvoiceForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = salesInvoiceForm; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <returns>Object</returns>
        public Object DeleteSalesInvoice (int? companyId, int? id)
        {
             ApiResponse<Object> localVarResponse = DeleteSalesInvoiceWithHttpInfo(companyId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DeleteSalesInvoiceWithHttpInfo (int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->DeleteSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->DeleteSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}";
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
                Exception exception = ExceptionFactory("DeleteSalesInvoice", localVarResponse);
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
        public async System.Threading.Tasks.Task<Object> DeleteSalesInvoiceAsync (int? companyId, int? id)
        {
             ApiResponse<Object> localVarResponse = await DeleteSalesInvoiceAsyncWithHttpInfo(companyId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSalesInvoiceAsyncWithHttpInfo (int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->DeleteSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->DeleteSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}";
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
                Exception exception = ExceptionFactory("DeleteSalesInvoice", localVarResponse);
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
        /// <param name="sort">Sortable parameters - *Available: id, issue_date, due_date, remaining, remaining_in_trl* (optional, default to -remaining_in_trl)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20010</returns>
        public InlineResponse20010 ListSalesInvoices (int? companyId, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null)
        {
             ApiResponse<InlineResponse20010> localVarResponse = ListSalesInvoicesWithHttpInfo(companyId, sort, pageNumber, pageSize, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="sort">Sortable parameters - *Available: id, issue_date, due_date, remaining, remaining_in_trl* (optional, default to -remaining_in_trl)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20010</returns>
        public ApiResponse< InlineResponse20010 > ListSalesInvoicesWithHttpInfo (int? companyId, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->ListSalesInvoices");

            var localVarPath = "/{company_id}/sales_invoices";
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
                Exception exception = ExceptionFactory("ListSalesInvoices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20010>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20010) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20010)));
            
        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="sort">Sortable parameters - *Available: id, issue_date, due_date, remaining, remaining_in_trl* (optional, default to -remaining_in_trl)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20010</returns>
        public async System.Threading.Tasks.Task<InlineResponse20010> ListSalesInvoicesAsync (int? companyId, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null)
        {
             ApiResponse<InlineResponse20010> localVarResponse = await ListSalesInvoicesAsyncWithHttpInfo(companyId, sort, pageNumber, pageSize, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="sort">Sortable parameters - *Available: id, issue_date, due_date, remaining, remaining_in_trl* (optional, default to -remaining_in_trl)</param>
        /// <param name="pageNumber">Page Number (optional, default to 1)</param>
        /// <param name="pageSize">Page Size (optional, default to 15)</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20010)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20010>> ListSalesInvoicesAsyncWithHttpInfo (int? companyId, string sort = null, int? pageNumber = null, int? pageSize = null, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->ListSalesInvoices");

            var localVarPath = "/{company_id}/sales_invoices";
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
                Exception exception = ExceptionFactory("ListSalesInvoices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20010>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20010) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20010)));
            
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
        public InlineResponse2012 PaySalesInvoice (PaymentForm3 paymentForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2012> localVarResponse = PaySalesInvoiceWithHttpInfo(paymentForm, companyId, id, include);
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
        public ApiResponse< InlineResponse2012 > PaySalesInvoiceWithHttpInfo (PaymentForm3 paymentForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'paymentForm' is set
            if (paymentForm == null)
                throw new ApiException(400, "Missing required parameter 'paymentForm' when calling SalesInvoicesApi->PaySalesInvoice");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->PaySalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->PaySalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}/payments";
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
                Exception exception = ExceptionFactory("PaySalesInvoice", localVarResponse);
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
        public async System.Threading.Tasks.Task<InlineResponse2012> PaySalesInvoiceAsync (PaymentForm3 paymentForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2012> localVarResponse = await PaySalesInvoiceAsyncWithHttpInfo(paymentForm, companyId, id, include);
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
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2012>> PaySalesInvoiceAsyncWithHttpInfo (PaymentForm3 paymentForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'paymentForm' is set
            if (paymentForm == null)
                throw new ApiException(400, "Missing required parameter 'paymentForm' when calling SalesInvoicesApi->PaySalesInvoice");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->PaySalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->PaySalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}/payments";
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
                Exception exception = ExceptionFactory("PaySalesInvoice", localVarResponse);
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
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        public InlineResponse20111 RecoverSalesInvoice (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = RecoverSalesInvoiceWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Recover 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        public ApiResponse< InlineResponse20111 > RecoverSalesInvoiceWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->RecoverSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->RecoverSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}/recover";
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
                Exception exception = ExceptionFactory("RecoverSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Recover 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        public async System.Threading.Tasks.Task<InlineResponse20111> RecoverSalesInvoiceAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = await RecoverSalesInvoiceAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Recover 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> RecoverSalesInvoiceAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->RecoverSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->RecoverSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}/recover";
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
                Exception exception = ExceptionFactory("RecoverSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        public InlineResponse20111 ShowSalesInvoice (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = ShowSalesInvoiceWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        public ApiResponse< InlineResponse20111 > ShowSalesInvoiceWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->ShowSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->ShowSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}";
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
                Exception exception = ExceptionFactory("ShowSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        public async System.Threading.Tasks.Task<InlineResponse20111> ShowSalesInvoiceAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = await ShowSalesInvoiceAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> ShowSalesInvoiceAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->ShowSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->ShowSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}";
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
                Exception exception = ExceptionFactory("ShowSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        public InlineResponse20111 UnarchiveSalesInvoice (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = UnarchiveSalesInvoiceWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        public ApiResponse< InlineResponse20111 > UnarchiveSalesInvoiceWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->UnarchiveSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->UnarchiveSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}/unarchive";
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
                Exception exception = ExceptionFactory("UnarchiveSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        public async System.Threading.Tasks.Task<InlineResponse20111> UnarchiveSalesInvoiceAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = await UnarchiveSalesInvoiceAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> UnarchiveSalesInvoiceAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->UnarchiveSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->UnarchiveSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}/unarchive";
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
                Exception exception = ExceptionFactory("UnarchiveSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>InlineResponse20111</returns>
        public InlineResponse20111 UpdateSalesInvoice (SalesInvoiceForm1 salesInvoiceForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = UpdateSalesInvoiceWithHttpInfo(salesInvoiceForm, companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20111</returns>
        public ApiResponse< InlineResponse20111 > UpdateSalesInvoiceWithHttpInfo (SalesInvoiceForm1 salesInvoiceForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'salesInvoiceForm' is set
            if (salesInvoiceForm == null)
                throw new ApiException(400, "Missing required parameter 'salesInvoiceForm' when calling SalesInvoicesApi->UpdateSalesInvoice");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->UpdateSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->UpdateSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}";
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
            if (salesInvoiceForm != null && salesInvoiceForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(salesInvoiceForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = salesInvoiceForm; // byte array
            }

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of InlineResponse20111</returns>
        public async System.Threading.Tasks.Task<InlineResponse20111> UpdateSalesInvoiceAsync (SalesInvoiceForm1 salesInvoiceForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20111> localVarResponse = await UpdateSalesInvoiceAsyncWithHttpInfo(salesInvoiceForm, companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesInvoiceForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Fatura ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: category, contact, details, payments, payments.tx, tags, sharings, recurrence_plan, active_e_document* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20111)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20111>> UpdateSalesInvoiceAsyncWithHttpInfo (SalesInvoiceForm1 salesInvoiceForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'salesInvoiceForm' is set
            if (salesInvoiceForm == null)
                throw new ApiException(400, "Missing required parameter 'salesInvoiceForm' when calling SalesInvoicesApi->UpdateSalesInvoice");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalesInvoicesApi->UpdateSalesInvoice");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalesInvoicesApi->UpdateSalesInvoice");

            var localVarPath = "/{company_id}/sales_invoices/{id}";
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
            if (salesInvoiceForm != null && salesInvoiceForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(salesInvoiceForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = salesInvoiceForm; // byte array
            }

          
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateSalesInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20111>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20111) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20111)));
            
        }

    }
}
