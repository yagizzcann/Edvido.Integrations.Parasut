namespace Edvido.Integrations.Parasut.Client
{
    using Edvido.Integrations.Parasut.Api;
    using Edvido.Integrations.Parasut.RestClients;

    /// <summary>
    /// Defines the <see cref="ParasutClient" />.
    /// </summary>
    public class ParasutClient
    {
        /// <summary>
        /// Defines the _syncLock.
        /// </summary>
        private static readonly object _syncLock = new object();

        /// <summary>
        /// Defines the _edvidoRestClient.
        /// </summary>
        private static EdvidoRestClient _edvidoRestClient = null;

        /// <summary>
        /// Defines the _configuration.
        /// </summary>
        private static Configuration _configuration = null;

        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        public static string Url { get; set; }

        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        public static string Version { get; set; }

        /// <summary>
        /// Gets or sets the CompanyId.
        /// </summary>
        public static string CompanyId { get; set; }

        /// <summary>
        /// Gets or sets the ClientId.
        /// </summary>
        protected static string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the ClientSecret.
        /// </summary>
        protected static string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the Username.
        /// </summary>
        protected static string Username { get; set; }

        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        protected static string Password { get; set; }

        /// <summary>
        /// Gets the Configuration.
        /// </summary>
        public static Configuration Configuration
        {
            get
            {
                GenerateConfiguration();
                return _configuration;
            }
        }

        /// <summary>
        /// Gets the EdvidoRestClient.
        /// </summary>
        public static EdvidoRestClient EdvidoRestClient
        {
            get
            {
                GenerateEdvidoRestClient();
                return _edvidoRestClient;
            }
        }

        /// <summary>
        /// The GenerateEdvidoRestClient.
        /// </summary>
        public static void GenerateEdvidoRestClient()
        {
            if (string.IsNullOrWhiteSpace(Url))
                return;

            if (_edvidoRestClient == null)
            {
                lock (_syncLock)
                {
                    if (_edvidoRestClient == null)
                    {
                        _edvidoRestClient = new EdvidoRestClient(baseUrl: Url, version: Version, clientId: ClientId,
                                                                clientSecret: ClientSecret, tokenUrl: "oauth/token",
                                                                username: Username, password: Password);
                    }
                }
            }
        }

        /// <summary>
        /// The GenerateConfiguration.
        /// </summary>
        public static void GenerateConfiguration()
        {
            if (EdvidoRestClient == null)
                GenerateEdvidoRestClient();
            
            if (EdvidoRestClient == null)
                return;


            if (_configuration == null)
            {
                lock (_syncLock)
                {
                    if (_configuration == null)
                    {
                        _configuration = new Configuration(new ApiClient(EdvidoRestClient));
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets the Home.
        /// </summary>
        public ApiHomeApi Home { get; set; }

        /// <summary>
        /// Gets or sets the Accounts.
        /// </summary>
        public AccountsApi Accounts { get; set; }

        /// <summary>
        /// Gets or sets the BankFees.
        /// </summary>
        public BankFeesApi BankFees { get; set; }

        /// <summary>
        /// Gets or sets the Contacts.
        /// </summary>
        public ContactsApi Contacts { get; set; }

        /// <summary>
        /// Gets or sets the EArchives.
        /// </summary>
        public EArchivesApi EArchives { get; set; }

        /// <summary>
        /// Gets or sets the EInvoiceInboxes.
        /// </summary>
        public EInvoiceInboxesApi EInvoiceInboxes { get; set; }

        /// <summary>
        /// Gets or sets the EInvoices.
        /// </summary>
        public EInvoicesApi EInvoices { get; set; }

        /// <summary>
        /// Gets or sets the Employees.
        /// </summary>
        public EmployeesApi Employees { get; set; }

        /// <summary>
        /// Gets or sets the ItemCategories.
        /// </summary>
        public ItemCategoriesApi ItemCategories { get; set; }

        /// <summary>
        /// Gets or sets the Products.
        /// </summary>
        public ProductsApi Products { get; set; }

        /// <summary>
        /// Gets or sets the PurchaseBills.
        /// </summary>
        public PurchaseBillsApi PurchaseBills { get; set; }

        /// <summary>
        /// Gets or sets the Salaries.
        /// </summary>
        public SalariesApi Salaries { get; set; }

        /// <summary>
        /// Gets or sets the SalesInvoices.
        /// </summary>
        public SalesInvoicesApi SalesInvoices { get; set; }

        /// <summary>
        /// Gets or sets the Tags.
        /// </summary>
        public TagsApi Tags { get; set; }

        /// <summary>
        /// Gets or sets the Taxes.
        /// </summary>
        public TaxesApi Taxes { get; set; }

        /// <summary>
        /// Gets or sets the TrackableJobs.
        /// </summary>
        public TrackableJobsApi TrackableJobs { get; set; }

        /// <summary>
        /// Gets or sets the Transactions.
        /// </summary>
        public TransactionsApi Transactions { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParasutClient"/> class.
        /// </summary>
        /// <param name="url">The url<see cref="string"/>.</param>
        /// <param name="version">The version<see cref="string"/>.</param>
        /// <param name="companyId">The companyId<see cref="string"/>.</param>
        /// <param name="clientId">The clientId<see cref="string"/>.</param>
        /// <param name="clientSecret">The clientSecret<see cref="string"/>.</param>
        /// <param name="username">The username<see cref="string"/>.</param>
        /// <param name="password">The password<see cref="string"/>.</param>
        public ParasutClient(string url = null,
                             string version = null,
                             string companyId = null,
                             string clientId = null,
                             string clientSecret = null,
                             string username = null,
                             string password = null) : base()
        {
            Url = ParasutApiSettings.Url(url);
            Version = ParasutApiSettings.Version(version);
            CompanyId = ParasutApiSettings.CompanyId(companyId);
            ClientId = ParasutApiSettings.ClientId(clientId);
            ClientSecret = ParasutApiSettings.ClientSecret(clientSecret);
            Username = ParasutApiSettings.Username(username);
            Password = ParasutApiSettings.Password(password);
            
            GenerateConfiguration();



            Home = new ApiHomeApi(Configuration);
            ItemCategories = new ItemCategoriesApi(Configuration);
            Accounts = new AccountsApi(Configuration);
            BankFees = new BankFeesApi(Configuration);
            Contacts = new ContactsApi(Configuration);
            EArchives = new EArchivesApi(Configuration);
            EInvoiceInboxes = new EInvoiceInboxesApi(Configuration);
            EInvoices = new EInvoicesApi(Configuration);
            Employees = new EmployeesApi(Configuration);
            Products = new ProductsApi(Configuration);
            PurchaseBills = new PurchaseBillsApi(Configuration);
            Salaries = new SalariesApi(Configuration);
            SalesInvoices = new SalesInvoicesApi(Configuration);
            Tags = new TagsApi(Configuration);
            Taxes = new TaxesApi(Configuration);
            TrackableJobs = new TrackableJobsApi(Configuration);
            Transactions = new TransactionsApi(Configuration);
        }
    }
}
