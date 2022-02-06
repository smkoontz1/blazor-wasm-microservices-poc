namespace Omaha.Shared
{
    public class OmahaHttpClient
    {
        public HttpClient Client { get; set; }

        public OmahaHttpClient(HttpClient client)
        {
            this.Client = client;
        }
    }
}
