namespace NovaPoshtaApi.Configurations
{
    public class ApiConfig : IApiConfig
    {
        public string ApiKey { get; set; }

        public ApiConfig(string apikey)
            => ApiKey = apikey;

        public ApiConfig()
            : this(string.Empty)
        { }
    }
}