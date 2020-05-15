namespace Edvido.Integrations.Parasut
{
    using Edvido.Integrations.Parasut.Client;
    using System.IO;

    /// <summary>
    /// Defines the <see cref="ParasutProvider" />.
    /// </summary>
    public class ParasutProvider
    {
        /// <summary>
        /// Gets or sets the Client.
        /// </summary>
        public ParasutClient Client { get; protected set; }

        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParasutProvider"/> class.
        /// </summary>
        /// <param name="url">The url<see cref="string"/>.</param>
        /// <param name="version">The version<see cref="string"/>.</param>
        /// <param name="companyId">The companyId<see cref="string"/>.</param>
        /// <param name="clientId">The clientId<see cref="string"/>.</param>
        /// <param name="clientSecret">The clientSecret<see cref="string"/>.</param>
        /// <param name="username">The username<see cref="string"/>.</param>
        /// <param name="password">The password<see cref="string"/>.</param>
        public ParasutProvider(string url = "https://api.parasut.com",
                               string version = "v4",
                               string companyId = null,
                               string clientId = null,
                               string clientSecret = null,
                               string username = null,
                               string password = null)
        {

            Client = new ParasutClient(url,
                                      version,
                                      companyId,
                                      clientId,
                                      clientSecret,
                                      username,
                                      password);
            Url = url;
        }



    }
}
