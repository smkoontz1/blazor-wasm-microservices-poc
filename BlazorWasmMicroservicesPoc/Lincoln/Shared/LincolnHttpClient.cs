namespace Lincoln.Shared
{
    public class LincolnHttpClient
    {
        public HttpClient Client { get; set; }

        public LincolnHttpClient(HttpClient client)
        {
            this.Client = client;
        }
    }
}
