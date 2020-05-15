namespace Edvido.Integrations.Parasut.Client
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Represents a set of configuration settings.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration"/> class.
        /// </summary>
        /// <param name="apiClient">The apiClient<see cref="ApiClient"/>.</param>
        /// <param name="defaultHeader">Dictionary of default HTTP header.</param>
        /// <param name="apiKey">Dictionary of API key.</param>
        /// <param name="apiKeyPrefix">Dictionary of API key prefix.</param>
        /// <param name="tempFolderPath">Temp folder path.</param>
        /// <param name="dateTimeFormat">DateTime format string.</param>
        /// <param name="timeout">HTTP connection timeout (in milliseconds).</param>
        public Configuration(ApiClient apiClient,
                             Dictionary<String, String> defaultHeader = null,
                             Dictionary<String, String> apiKey = null,
                             Dictionary<String, String> apiKeyPrefix = null,
                             string tempFolderPath = null,
                             string dateTimeFormat = null,
                             int timeout = 100000
                            )
        {
            ApiClient = apiClient;
            if (defaultHeader != null)
                DefaultHeader = defaultHeader;
            if (apiKey != null)
                ApiKey = apiKey;
            if (apiKeyPrefix != null)
                ApiKeyPrefix = apiKeyPrefix;

            TempFolderPath = tempFolderPath;
            DateTimeFormat = dateTimeFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration"/> class.
        /// </summary>
        /// <param name="apiClient">Api client.</param>
        public Configuration(ApiClient apiClient)
        {
            ApiClient = apiClient;
        }

        /// <summary>
        /// Defines the ApiClient.
        /// </summary>
        public ApiClient ApiClient;

        /// <summary>
        /// Version of the package..
        /// </summary>
        public const string Version = "1.0.0";

        /// <summary>
        /// Default creation of exceptions for a given method name and response object.
        /// </summary>
        public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
        {
            int status = (int)response.StatusCode;
            if (status >= 400) return new ApiException(status, String.Format("Error calling {0}: {1}", methodName, response.Content), response.Content);
            if (status == 0) return new ApiException(status, String.Format("Error calling {0}: {1}", methodName, response.ErrorMessage), response.ErrorMessage);
            return null;
        };

        /// <summary>
        /// Defines the _defaultHeaderMap.
        /// </summary>
        private Dictionary<String, String> _defaultHeaderMap = new Dictionary<String, String>();

        /// <summary>
        /// Gets or sets the default header..
        /// </summary>
        public Dictionary<String, String> DefaultHeader
        {
            get { return _defaultHeaderMap; }

            set
            {
                _defaultHeaderMap = value;
            }
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        public void AddDefaultHeader(string key, string value)
        {
            _defaultHeaderMap[key] = value;
        }

        /// <summary>
        /// Add Api Key Header.
        /// </summary>
        /// <param name="key">Api Key name.</param>
        /// <param name="value">Api Key value.</param>
        public void AddApiKey(string key, string value)
        {
            ApiKey[key] = value;
        }

        /// <summary>
        /// Sets the API key prefix.
        /// </summary>
        /// <param name="key">Api Key name.</param>
        /// <param name="value">Api Key value.</param>
        public void AddApiKeyPrefix(string key, string value)
        {
            ApiKeyPrefix[key] = value;
        }

        /// <summary>
        /// Gets or sets the HTTP user agent..
        /// </summary>
        public String UserAgent { get; set; }

        /// <summary>
        /// Gets or sets the API key based on the authentication name..
        /// </summary>
        public Dictionary<String, String> ApiKey = new Dictionary<String, String>();

        /// <summary>
        /// Gets or sets the prefix (e.g. Token) of the API key based on the authentication name..
        /// </summary>
        public Dictionary<String, String> ApiKeyPrefix = new Dictionary<String, String>();

        /// <summary>
        /// Get the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        public string GetApiKeyWithPrefix(string apiKeyIdentifier)
        {
            var apiKeyValue = "";
            ApiKey.TryGetValue(apiKeyIdentifier, out apiKeyValue);
            var apiKeyPrefix = "";
            if (ApiKeyPrefix.TryGetValue(apiKeyIdentifier, out apiKeyPrefix))
                return apiKeyPrefix + " " + apiKeyValue;
            else
                return apiKeyValue;
        }

        /// <summary>
        /// Defines the _tempFolderPath.
        /// </summary>
        private string _tempFolderPath;

        /// <summary>
        /// Gets or sets the temporary folder path to store the files downloaded from the server..
        /// </summary>
        public String TempFolderPath
        {
            get
            {
                // default to Path.GetTempPath() if _tempFolderPath is not set
                if (String.IsNullOrEmpty(_tempFolderPath))
                {
                    _tempFolderPath = Path.GetTempPath();
                }
                return _tempFolderPath;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _tempFolderPath = value;
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                    Directory.CreateDirectory(value);

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                    _tempFolderPath = value;
                else
                    _tempFolderPath = value + Path.DirectorySeparatorChar;
            }
        }

        /// <summary>
        /// Defines the ISO8601_DATETIME_FORMAT.
        /// </summary>
        private const string ISO8601_DATETIME_FORMAT = "o";

        /// <summary>
        /// Defines the _dateTimeFormat.
        /// </summary>
        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;

        /// <summary>
        /// Gets or sets the the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid.
        /// </summary>
        public String DateTimeFormat
        {
            get
            {
                return _dateTimeFormat;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }

        /// <summary>
        /// Returns a string with essential information for debugging.
        /// </summary>
        /// <returns>The <see cref="String"/>.</returns>
        public static String ToDebugReport()
        {
            String report = "C# SDK (Edvido.Integrations.Parasut) Debug Report:\n";
            report += "    OS: " + Environment.OSVersion + "\n";
            report += "    .NET Framework Version: " + Assembly
                     .GetExecutingAssembly()
                     .GetReferencedAssemblies()
                     .Where(x => x.Name == "System.Core").First().Version.ToString() + "\n";
            report += "    Version of the API: 4.0.0\n";
            report += "    SDK Package Version: 1.0.0\n";

            return report;
        }
    }
}
