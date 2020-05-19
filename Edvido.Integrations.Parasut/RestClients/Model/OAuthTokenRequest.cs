using System;
using System.Collections.Generic;
using System.Text;

namespace Edvido.Integrations.Parasut.RestClients.Model
{
    public class OAuthTokenRequest
    {
        public OAuthTokenRequest(string _client_id, string _client_secret, string _username, string _password)
        {
            client_id = _client_id;
            client_secret = _client_secret;
            username = _username;
            password = _password;
            grant_type = "password";
            redirect_uri = "urn:ietf:wg:oauth:2.0:oob";
        }
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string grant_type { get; set; }
        public string redirect_uri { get; set; }
    }
}
