namespace Avtopark.WebApi.Settings
{
    public class AvtoparkSettings
    {
        public Uri ServiceUri { get; set; }
        public string AvtoparkDbContextConnectionString { get; set; }
        public string IdentityServerUri { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
