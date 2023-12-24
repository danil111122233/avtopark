namespace Avtopark.WebApi.Settings
{
    public static class AvtoparkSettingsReader
    {
        public static AvtoparkSettings Read(IConfiguration configuration)
        {
            return new AvtoparkSettings()
            {
                ServiceUri = configuration.GetValue<Uri>("Uri"),
                AvtoparkDbContextConnectionString = configuration.GetValue<string>("AvtoparkDbContext"),
                IdentityServerUri = configuration.GetValue<string>("IdentityServerSettings:Uri"),
                ClientId = configuration.GetValue<string>("IdentityServerSettings:ClientId"),
                ClientSecret = configuration.GetValue<string>("IdentityServerSettings:ClientSecret"),
            };
        }
    }
}
