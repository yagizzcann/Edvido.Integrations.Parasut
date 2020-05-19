namespace Edvido.Integrations.Parasut.RestClients
{
    using Edvido.Integrations.Parasut.RestClients.Decorators;
    using RestSharp;
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using IRestRequest = RestSharp.IRestRequest;
    using IRestResponse = RestSharp.IRestResponse;
    using RestRequestAsyncHandle = RestSharp.RestRequestAsyncHandle;

    /// <summary>
    /// Defines the <see cref="EdvidoRestClient" />.
    /// </summary>
    public class EdvidoRestClient : RestSharp.RestClient
    {
        /// <summary>
        /// Defines the DecoratedClient.
        /// </summary>
        public RestSharp.RestClient DecoratedClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="EdvidoRestClient"/> class.
        /// </summary>
        /// <param name="baseUrl">The baseUrl<see cref="string"/>.</param>
        public EdvidoRestClient(string baseUrl)
        {
            InitializeDefaults(baseUrl);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdvidoRestClient"/> class.
        /// </summary>
        /// <param name="baseUrl">The baseUrl<see cref="string"/>.</param>
        /// <param name="version">The version<see cref="string"/>.</param>
        /// <param name="clientId">The clientId<see cref="string"/>.</param>
        /// <param name="clientSecret">The clientSecret<see cref="string"/>.</param>
        /// <param name="tokenUrl">The tokenUrl<see cref="string"/>.</param>
        /// <param name="username">The username<see cref="string"/>.</param>
        /// <param name="password">The password<see cref="string"/>.</param>
        public EdvidoRestClient(string baseUrl, string version, string clientId, string clientSecret, string tokenUrl, string username, string password)
        {
            InitializeDefaults($"{baseUrl}/{version}");

            DecoratedClient = new OAuth2Decorator(DecoratedClient, baseUrl, clientId, clientSecret, tokenUrl, username, password);
        }

        /// <summary>
        /// The Execute.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        public override IRestResponse Execute(IRestRequest request)
        {
            return DecoratedClient.Execute(request);
        }

        /// <summary>
        /// The ExecuteAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="callback">The callback<see cref="Action{IRestResponse, RestRequestAsyncHandle}"/>.</param>
        /// <returns>The <see cref="RestRequestAsyncHandle"/>.</returns>
        public override RestRequestAsyncHandle ExecuteAsync(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
        {
            return DecoratedClient.ExecuteAsync(request, callback);
        }

        /// <summary>
        /// The Execute.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="IRestResponse{T}"/>.</returns>
        public override IRestResponse<T> Execute<T>(IRestRequest request)
        {
            return DecoratedClient.Execute<T>(request);
        }

        /// <summary>
        /// The ExecuteAsync.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="callback">The callback<see cref="Action{IRestResponse{T}, RestRequestAsyncHandle}"/>.</param>
        /// <returns>The <see cref="RestRequestAsyncHandle"/>.</returns>
        public override RestRequestAsyncHandle ExecuteAsync<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback)
        {
            return DecoratedClient.ExecuteAsync(request, callback);
        }

        /// <summary>
        /// The ExecuteAsyncGet.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="callback">The callback<see cref="Action{IRestResponse, RestRequestAsyncHandle}"/>.</param>
        /// <param name="httpMethod">The httpMethod<see cref="string"/>.</param>
        /// <returns>The <see cref="RestRequestAsyncHandle"/>.</returns>
        public override RestRequestAsyncHandle ExecuteAsyncGet(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback, string httpMethod)
        {
            return DecoratedClient.ExecuteAsyncGet(request, callback, httpMethod);
        }

        /// <summary>
        /// The ExecuteAsyncGet.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="callback">The callback<see cref="Action{IRestResponse{T}, RestRequestAsyncHandle}"/>.</param>
        /// <param name="httpMethod">The httpMethod<see cref="string"/>.</param>
        /// <returns>The <see cref="RestRequestAsyncHandle"/>.</returns>
        public override RestRequestAsyncHandle ExecuteAsyncGet<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback, string httpMethod)
        {
            return DecoratedClient.ExecuteAsyncGet(request, callback, httpMethod);
        }

        /// <summary>
        /// The ExecuteAsyncPost.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="callback">The callback<see cref="Action{IRestResponse, RestRequestAsyncHandle}"/>.</param>
        /// <param name="httpMethod">The httpMethod<see cref="string"/>.</param>
        /// <returns>The <see cref="RestRequestAsyncHandle"/>.</returns>
        public override RestRequestAsyncHandle ExecuteAsyncPost(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback, string httpMethod)
        {
            return DecoratedClient.ExecuteAsyncPost(request, callback, httpMethod);
        }

        /// <summary>
        /// The ExecuteAsyncPost.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="callback">The callback<see cref="Action{IRestResponse{T}, RestRequestAsyncHandle}"/>.</param>
        /// <param name="httpMethod">The httpMethod<see cref="string"/>.</param>
        /// <returns>The <see cref="RestRequestAsyncHandle"/>.</returns>
        public override RestRequestAsyncHandle ExecuteAsyncPost<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback, string httpMethod)
        {
            return DecoratedClient.ExecuteAsyncPost(request, callback, httpMethod);
        }

        /// <summary>
        /// The ExecuteGetTaskAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse}"/>.</returns>
        public override Task<IRestResponse> ExecuteGetTaskAsync(IRestRequest request)
        {
            return DecoratedClient.ExecuteGetTaskAsync(request);
        }

        /// <summary>
        /// The ExecuteGetTaskAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="token">The token<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse}"/>.</returns>
        public override Task<IRestResponse> ExecuteGetTaskAsync(IRestRequest request, CancellationToken token)
        {
            return DecoratedClient.ExecuteGetTaskAsync(request, token);
        }

        /// <summary>
        /// The ExecuteGetTaskAsync.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse{T}}"/>.</returns>
        public override Task<IRestResponse<T>> ExecuteGetTaskAsync<T>(IRestRequest request)
        {
            return DecoratedClient.ExecuteGetTaskAsync<T>(request);
        }

        /// <summary>
        /// The ExecuteGetTaskAsync.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="token">The token<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse{T}}"/>.</returns>
        public override Task<IRestResponse<T>> ExecuteGetTaskAsync<T>(IRestRequest request, CancellationToken token)
        {
            return DecoratedClient.ExecuteGetTaskAsync<T>(request, token);
        }

        /// <summary>
        /// The ExecutePostTaskAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse}"/>.</returns>
        public override Task<IRestResponse> ExecutePostTaskAsync(IRestRequest request)
        {
            return DecoratedClient.ExecutePostTaskAsync(request);
        }

        /// <summary>
        /// The ExecutePostTaskAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="token">The token<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse}"/>.</returns>
        public override Task<IRestResponse> ExecutePostTaskAsync(IRestRequest request, CancellationToken token)
        {
            return DecoratedClient.ExecutePostTaskAsync(request, token);
        }

        /// <summary>
        /// The ExecutePostTaskAsync.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse{T}}"/>.</returns>
        public override Task<IRestResponse<T>> ExecutePostTaskAsync<T>(IRestRequest request)
        {
            return DecoratedClient.ExecutePostTaskAsync<T>(request);
        }

        /// <summary>
        /// The ExecutePostTaskAsync.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="token">The token<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse{T}}"/>.</returns>
        public override Task<IRestResponse<T>> ExecutePostTaskAsync<T>(IRestRequest request, CancellationToken token)
        {
            return DecoratedClient.ExecutePostTaskAsync<T>(request, token);
        }

        /// <summary>
        /// The ExecuteTaskAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse}"/>.</returns>
        public override Task<IRestResponse> ExecuteTaskAsync(IRestRequest request)
        {
            return DecoratedClient.ExecuteTaskAsync(request);
        }

        /// <summary>
        /// The ExecuteTaskAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="token">The token<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse}"/>.</returns>
        public override Task<IRestResponse> ExecuteTaskAsync(IRestRequest request, CancellationToken token)
        {
            return DecoratedClient.ExecuteTaskAsync(request, token);
        }

        /// <summary>
        /// The ExecuteTaskAsync.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse{T}}"/>.</returns>
        public override Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request)
        {
            return DecoratedClient.ExecuteTaskAsync<T>(request);
        }

        /// <summary>
        /// The ExecuteTaskAsync.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="token">The token<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse{T}}"/>.</returns>
        public override Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request, CancellationToken token)
        {
            return DecoratedClient.ExecuteTaskAsync<T>(request, token);
        }

        /// <summary>
        /// The InitializeDefaults.
        /// </summary>
        /// <param name="baseUrl">The baseUrl<see cref="string"/>.</param>
        private void InitializeDefaults(string baseUrl)
        {
            DecoratedClient = new RestSharp.RestClient(baseUrl);
            DecoratedClient.UserAgent = "Edvido.RestClient";
        }
    }
}
