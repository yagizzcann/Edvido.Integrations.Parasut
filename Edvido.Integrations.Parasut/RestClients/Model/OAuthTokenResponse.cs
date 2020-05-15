namespace Edvido.Integrations.Parasut.RestClients.Model
{
    using RestSharp.Deserializers;

    /// <summary>
    /// Defines the <see cref="OAuthTokenResponse" />.
    /// </summary>
    public class OAuthTokenResponse
    {
        /// <summary>
        /// Gets or sets the AccessToken.
        /// </summary>
        [DeserializeAs(Name = "access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the TokenType.
        /// </summary>
        [DeserializeAs(Name = "token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// Gets or sets the ExpiresIn.
        /// </summary>
        [DeserializeAs(Name = "expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Gets or sets the RefreshToken.
        /// </summary>
        [DeserializeAs(Name = "refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets the TokenUrl.
        /// </summary>
        [DeserializeAs(Name = "token_url")]
        public string TokenUrl { get; set; }
    }
}
