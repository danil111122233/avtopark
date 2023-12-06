namespace Avtopark.WebAPI.Settings
{
    public static class AvtoparkSettingsReader
    {
        public static AvtoparkSettings Read(IConfiguration configuration)
        {
            //здесь будет чтение настроек приложения из конфига
            return new AvtoparkSettings();
        }
    }
}
