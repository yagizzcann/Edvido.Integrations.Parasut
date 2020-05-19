namespace Edvido.Integrations.Parasut.RestClients.Decorators
{
    using Edvido.Integrations.Parasut.RestClients.Model;
    using IdentityModel.Client;
    using RestSharp;
    using System;
    using System.Linq;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="OAuth2Decorator" />.
    /// </summary>
    public class OAuth2Decorator : RestClientDecoratorBase
    {
        /// <summary>
        /// Defines the _syncLock.
        /// </summary>
        private readonly object _syncLock = new object();

        /// <summary>
        /// Defines the _clientId.
        /// </summary>
        private readonly string _clientId;

        /// <summary>
        /// Defines the _clientSecret.
        /// </summary>
        private readonly string _clientSecret;

        /// <summary>
        /// Defines the _userName.
        /// </summary>
        private readonly string _userName;

        /// <summary>
        /// Defines the _password.
        /// </summary>
        private readonly string _password;

        /// <summary>
        /// Defines the _baseUrl.
        /// </summary>
        private readonly string _baseUrl;

        /// <summary>
        /// Defines the _tokenUrl.
        /// </summary>
        private readonly string _tokenUrl;

        /// <summary>
        /// Defines the _accessToken.
        /// </summary>
        private string _accessToken = null;



        /// <summary>
        /// Defines the _isExpired.
        /// </summary>
        private bool _isExpired = false;

        /// <summary>
        /// Defines the _tokenClient.
        /// </summary>
        private TokenClient _tokenClient;

        /// <summary>
        /// Gets the TokenClient.
        /// </summary>
        public TokenClient TokenClient
        {
            get
            {
                if (_tokenClient == null)
                {
                    lock (_syncLock)
                    {
                        if (_tokenClient == null)
                        {
                            _tokenClient = new TokenClient($"{_baseUrl}/{_tokenUrl}", _clientId, _clientSecret);
                        }
                    }
                }

                return _tokenClient;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2Decorator"/> class.
        /// </summary>
        /// <param name="decoratedClient">The decoratedClient<see cref="RestSharp.RestClient"/>.</param>
        /// <param name="baseUrl">The baseUrl<see cref="string"/>.</param>
        /// <param name="clientId">The clientId<see cref="string"/>.</param>
        /// <param name="clientSecret">The clientSecret<see cref="string"/>.</param>
        /// <param name="tokenUrl">The tokenUrl<see cref="string"/>.</param>
        /// <param name="username">The username<see cref="string"/>.</param>
        /// <param name="password">The password<see cref="string"/>.</param>
        public OAuth2Decorator(RestClient decoratedClient,
                              string baseUrl,
                              string clientId,
                              string clientSecret,
                              string tokenUrl,
                              string username,
                              string password) :
            base(decoratedClient)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _tokenUrl = tokenUrl;
            _userName = username;
            _password = password;
            _baseUrl = baseUrl;
        }

        /// <summary>
        /// The Execute.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        public override IRestResponse Execute(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse response = DecoratedClient.Execute(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = DecoratedClient.Execute(request);
            }

            return response;
        }

        /// <summary>
        /// The Execute.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="IRestResponse{T}"/>.</returns>
        public override IRestResponse<T> Execute<T>(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = DecoratedClient.Execute<T>(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = DecoratedClient.Execute<T>(request);
            }

            return response;
        }

        /// <summary>
        /// The ExecuteGetTaskAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse}"/>.</returns>
        public override async Task<IRestResponse> ExecuteGetTaskAsync(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse response = await DecoratedClient.ExecuteGetTaskAsync(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteGetTaskAsync(request);
            }

            return response;
        }

        /// <summary>
        /// The ExecuteGetTaskAsync.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="token">The token<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse{T}}"/>.</returns>
        public override async Task<IRestResponse<T>> ExecuteGetTaskAsync<T>(IRestRequest request, CancellationToken token)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = await DecoratedClient.ExecuteGetTaskAsync<T>(request, token);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteGetTaskAsync<T>(request, token);
            }

            return response;
        }

        /// <summary>
        /// The ExecuteGetTaskAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="token">The token<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse}"/>.</returns>
        public override async Task<IRestResponse> ExecuteGetTaskAsync(IRestRequest request, CancellationToken token)
        {
            InjectAccessToken(request);
            IRestResponse response = await DecoratedClient.ExecuteGetTaskAsync(request, token);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteGetTaskAsync(request, token);
            }

            return response;
        }

        /// <summary>
        /// The ExecuteGetTaskAsync.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse{T}}"/>.</returns>
        public override async Task<IRestResponse<T>> ExecuteGetTaskAsync<T>(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = await DecoratedClient.ExecuteGetTaskAsync<T>(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteGetTaskAsync<T>(request);
            }

            return response;
        }

        /// <summary>
        /// The ExecutePostTaskAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse}"/>.</returns>
        public override async Task<IRestResponse> ExecutePostTaskAsync(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse response = await DecoratedClient.ExecutePostTaskAsync(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecutePostTaskAsync(request);
            }

            return response;
        }

        /// <summary>
        /// The ExecutePostTaskAsync.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse{T}}"/>.</returns>
        public override async Task<IRestResponse<T>> ExecutePostTaskAsync<T>(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = await DecoratedClient.ExecutePostTaskAsync<T>(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecutePostTaskAsync<T>(request);
            }

            return response;
        }

        /// <summary>
        /// The ExecutePostTaskAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="token">The token<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse}"/>.</returns>
        public override async Task<IRestResponse> ExecutePostTaskAsync(IRestRequest request, CancellationToken token)
        {
            InjectAccessToken(request);
            IRestResponse response = await DecoratedClient.ExecutePostTaskAsync(request, token);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecutePostTaskAsync(request, token);
            }

            return response;
        }

        /// <summary>
        /// The ExecutePostTaskAsync.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="token">The token<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse{T}}"/>.</returns>
        public override async Task<IRestResponse<T>> ExecutePostTaskAsync<T>(IRestRequest request, CancellationToken token)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = await DecoratedClient.ExecutePostTaskAsync<T>(request, token);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecutePostTaskAsync<T>(request, token);
            }

            return response;
        }

        /// <summary>
        /// The ExecuteTaskAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse}"/>.</returns>
        public override async Task<IRestResponse> ExecuteTaskAsync(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse response = await DecoratedClient.ExecuteTaskAsync(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteTaskAsync(request);
            }

            return response;
        }

        /// <summary>
        /// The ExecuteTaskAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="token">The token<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse}"/>.</returns>
        public override async Task<IRestResponse> ExecuteTaskAsync(IRestRequest request, CancellationToken token)
        {
            InjectAccessToken(request);
            IRestResponse response = await DecoratedClient.ExecuteTaskAsync(request, token);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteTaskAsync(request, token);
            }

            return response;
        }

        /// <summary>
        /// The ExecuteTaskAsync.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse{T}}"/>.</returns>
        public override async Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = await DecoratedClient.ExecuteTaskAsync<T>(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteTaskAsync<T>(request);
            }

            return response;
        }

        /// <summary>
        /// The ExecuteTaskAsync.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="token">The token<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse{T}}"/>.</returns>
        public override async Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request, CancellationToken token)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = await DecoratedClient.ExecuteTaskAsync<T>(request, token);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteTaskAsync<T>(request, token);
            }

            return response;
        }

        /// <summary>
        /// The ExecuteAsync.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        /// <param name="callback">The callback<see cref="Action{IRestResponse, RestRequestAsyncHandle}"/>.</param>
        /// <returns>The <see cref="RestRequestAsyncHandle"/>.</returns>
        public override RestRequestAsyncHandle ExecuteAsync(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
        {
            throw new NotSupportedException("Async methods which return RestRequestAsyncHandle is not supported in OAuth2 decorator.");
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
            throw new NotSupportedException("Async methods which return RestRequestAsyncHandle is not supported in OAuth2 decorator.");
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
            throw new NotSupportedException("Async methods which return RestRequestAsyncHandle is not supported in OAuth2 decorator.");
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
            throw new NotSupportedException("Async methods which return RestRequestAsyncHandle is not supported in OAuth2 decorator.");
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
            throw new NotSupportedException("Async methods which return RestRequestAsyncHandle is not supported in OAuth2 decorator.");
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
            throw new NotSupportedException("Async methods which return RestRequestAsyncHandle is not supported in OAuth2 decorator.");
        }

        /// <summary>
        /// The InjectAccessToken.
        /// </summary>
        /// <param name="request">The request<see cref="IRestRequest"/>.</param>
        private void InjectAccessToken(IRestRequest request)
        {
            InitAccessToken();

            Parameter authHeader = request.Parameters.FirstOrDefault(p => p.Type == ParameterType.HttpHeader && p.Name == "Authorization");

            if (authHeader != null)
            {
                authHeader.Value = $"Bearer {_accessToken}";
            }
            else
            {
                request.AddHeader("Authorization", $"Bearer {_accessToken}");
            }
        }

        /// <summary>
        /// The InitAccessToken.
        /// </summary>
        private void InitAccessToken()
        {
            if (_accessToken == null)
            {
                lock (_syncLock)
                {
                    if (_accessToken == null)
                    {
                        GenerateNewAccessToken().Wait();
                    }
                }
            }
        }

        /// <summary>
        /// The RefreshAccessToken.
        /// </summary>
        private void RefreshAccessToken()
        {
            _isExpired = true;

            if (_isExpired)
            {
                lock (_syncLock)
                {
                    if (_isExpired)
                    {
                        GenerateNewAccessToken().Wait();
                        _isExpired = false;
                    }
                }
            }
        }

        /// <summary>
        /// The GenerateNewAccessToken.
        /// </summary>
        /// <returns>The <see cref="Task"/>.</returns>
        private async Task GenerateNewAccessToken()
        {
            TokenResponse tokenResult = await TokenClient.RequestCustomAsync(new OAuthTokenRequest(_clientId,
                                                                                                   _clientSecret,
                                                                                                   _userName,
                                                                                                   _password)
                                                                             ).ConfigureAwait(false);

            if (tokenResult.HttpStatusCode == HttpStatusCode.OK)
            {
                _accessToken = tokenResult.AccessToken;
            }
        }
    }
}
