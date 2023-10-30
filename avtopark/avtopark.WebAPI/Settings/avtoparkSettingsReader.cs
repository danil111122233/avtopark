namespace avtopark.WebAPI.Settings
{
    public static class avtoparkSettingsReader
    {
        public static avtoparkSettings Read(IConfiguration configuration)
        {
            //здесь будет чтение настроек приложения из конфига
            return new avtoparkSettings();
        }
    }
}
