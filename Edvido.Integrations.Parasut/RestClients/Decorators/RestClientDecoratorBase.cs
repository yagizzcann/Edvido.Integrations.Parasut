namespace Edvido.Integrations.Parasut.RestClients.Decorators
{
    using RestSharp;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="RestClientDecoratorBase" />.
    /// </summary>
    public abstract class RestClientDecoratorBase : RestSharp.RestClient
    {
        /// <summary>
        /// Defines the DecoratedClient.
        /// </summary>
        protected RestSharp.RestClient DecoratedClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="RestClientDecoratorBase"/> class.
        /// </summary>
        /// <param name="decoratedClient">The decoratedClient<see cref="RestSharp.RestClient"/>.</param>
        protected RestClientDecoratorBase(RestSharp.RestClient decoratedClient)
        {
            DecoratedClient = decoratedClient;
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
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="callback">The callback<see cref="Action{IRestResponse, RestRequestAsyncHandle}"/>.</param>
        /// <returns>The <see cref="RestRequestAsyncHandle"/>.</returns>
        public override RestRequestAsyncHandle ExecuteAsync(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
        {
            return DecoratedClient.ExecuteAsync(request, callback);
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
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="token">The token<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse{T}}"/>.</returns>
        public override Task<IRestResponse<T>> ExecuteGetTaskAsync<T>(IRestRequest request, CancellationToken token)
        {
            return DecoratedClient.ExecuteGetTaskAsync<T>(request, token);
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
    }
}
