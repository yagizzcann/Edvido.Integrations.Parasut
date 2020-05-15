namespace Edvido.Integrations.Parasut.Terminal
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Defines the clientId.
        /// </summary>
        private static readonly string clientId = "";

        /// <summary>
        /// Defines the clientSecret.
        /// </summary>
        private static readonly string clientSecret = "";

        /// <summary>
        /// Defines the userName.
        /// </summary>
        private static readonly string userName = "";

        /// <summary>
        /// Defines the password.
        /// </summary>
        private static readonly string password = "";

        /// <summary>
        /// Defines the companyId.
        /// </summary>
        private static readonly string companyId = "";

        /// <summary>
        /// Defines the url.
        /// </summary>
        private static readonly string url = "https://api.parasut.com";

        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
            try
            {
                var provider = new ParasutProvider(url, "v4", companyId, clientId, clientSecret, userName, password);
                var me = provider.Client.Home.ShowMe();

                Console.WriteLine(JsonConvert.SerializeObject(me));
            }
            catch (Exception ex)
            {
            }



            Console.WriteLine("Hello World!");


            Console.ReadLine();
        }
    }
}
