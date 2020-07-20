using NovaPoshtaApi.Core.Requests;
using NovaPoshtaApi.Core.Responses;
using NovaPoshtaApi.Exceptions;
using NovaPoshtaApi.Helpers;
using System.Collections.Specialized;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace NovaPoshtaApi.ApiClients
{
    /// <summary>
    /// Nova poshta API client
    /// </summary>
    public class ApiHttpClient : IApiHttpClient
    {
        private readonly string _apiUrl;

        private readonly HttpClient _client;

        /// <summary>
        /// Initialize a new instance of the <see cref="ApiHttpClient"/> class
        /// </summary>
        /// <param name="client">
        /// <see cref="HttpClient"/> for making requsts to the Nova Poshta API
        /// </param>
        public ApiHttpClient(string apiUrl, HttpClient client)
        {
            ThrowHelper.ThrowIfInvalidApiUrl(apiUrl);
            ThrowHelper.ThrowIfNull(client, nameof(client));

            _apiUrl = apiUrl;
            _client = client;
        }

        /// <inheritdoc/>
        public async Task<T> RequestAsync<T>(IApiRequest request)
        {
            ThrowHelper.ThrowIfNull(request, nameof(request));

            try
            {
                using var response = await _client.PostAsync(_apiUrl, request.Content);

                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<T>(json);
            }
            catch (JsonException ex)
            {
                throw new ApiResponseFormatException(ex);
            }
        }

        /// <inheritdoc/>
        public Task<ApiResponse<T>> RequestForResponseAsync<T>(IApiRequest request)
            => RequestAsync<ApiResponse<T>>(request);
    }
}
