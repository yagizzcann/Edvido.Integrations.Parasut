namespace Edvido.Integrations.Parasut.Helper
{
    using Newtonsoft.Json;
    using RestSharp;
    using System;
    using System.Net;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="RestResponseHelper" />.
    /// </summary>
    public static class RestResponseHelper
    {
        /// <summary>
        /// The ParseReponse.
        /// </summary>
        /// <param name="response">The response<see cref="Task{IRestResponse}"/>.</param>
        /// <param name="client">The client<see cref="IRestClient"/>.</param>
        /// <returns>The <see cref="Task{IRestResponse}"/>.</returns>
        async public static Task<IRestResponse> ParseReponse(this Task<IRestResponse> response, IRestClient client)
        {
            if (response == null) throw new ArgumentNullException("response");

            await response.ContinueWith(t =>
        {
            if (t.IsFaulted || t.IsCanceled)
                throw new ArgumentException(t.Exception.Message);

            if (response.Result.IsSuccessful) return;

            if (response.Result.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException(response.Result.StatusDescription); //this is a custom exception
            }

            throw new ArgumentException(response.Result.StatusDescription);
        });

            return JsonConvert.DeserializeObject<IRestResponse>(response.Result.Content);
        }
    }
}
