using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Request to Nova Poshta API.
    /// </summary>
    public class ApiRequest : IApiRequest
    {
        public static readonly string DefaultContentType = "application/json";
        public static readonly Encoding DefaultEncoding = Encoding.UTF8;

        /// <summary>
        /// Get or set content type of the request.
        /// </summary>
        /// <value>
        /// String with content type.
        /// </value>
        [JsonIgnore]
        public string? ContentType { get; set; }

        /// <summary>
        /// Get or set encoding of the request.
        /// </summary>
        /// <value>
        /// Encoding.
        /// </value>
        [JsonIgnore]
        public Encoding? Encoding { get; set; }

        /// <summary>
        /// Get or set apiKey parameter of the request.
        /// </summary>
        /// <value>
        /// Key to the Nova Poshta API.
        /// </value>
        [JsonPropertyName("apiKey")]
        public string ApiKey { get; set; }

        /// <summary>
        /// Get or set modelName parameter of the request.
        /// </summary>
        /// <value>
        /// Model name of the Nova Poshta API.
        /// </value>
        [JsonPropertyName("modelName")]
        public string ModelName { get; set; }

        /// <summary>
        /// Get or set calledMethod parameter of the request.
        /// </summary>
        /// <value>
        /// Called method of the Nova Poshta API.
        /// </value>
        [JsonPropertyName("calledMethod")]
        public string CalledMethod { get; set; }

        /// <summary>
        /// Get or set methodProperties parameter of the request.
        /// </summary>
        /// <value>
        /// Method properties of the Nova Poshta API.
        /// </value>
        [JsonPropertyName("methodProperties")]
        public object? MethodProperties { get; set; }

        /// <summary>
        /// Get request in <see cref="HttpContent"/> format.
        /// </summary>
        /// <value>
        /// Request.
        /// </value>
        [JsonIgnore]
        public HttpContent Content
        {
            get
            {
                var json = JsonSerializer.Serialize(this);

                return new StringContent(
                    json,
                    Encoding ?? DefaultEncoding,
                    ContentType ?? DefaultContentType);
            }
        }

        /// <summary>
        /// Initialize a new instance of the <see cref="ApiRequest"/> class.
        /// </summary>
        public ApiRequest()
        {
            ApiKey = string.Empty;
            CalledMethod = string.Empty;
            ModelName = string.Empty;
        }
    }
}
