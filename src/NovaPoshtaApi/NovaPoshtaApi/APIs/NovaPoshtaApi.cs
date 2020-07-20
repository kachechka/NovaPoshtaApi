using NovaPoshtaApi.ApiClients;
using NovaPoshtaApi.Configurations;
using NovaPoshtaApi.Core.Requests;
using NovaPoshtaApi.Helpers;
using System.Threading.Tasks;

namespace NovaPoshtaApi.APIs
{
    public class NovaPoshtaApi
    {
        private readonly IApiConfig _config;
        private readonly IApiHttpClient _client;

        public AddressApi Address { get; }
        public DirectoryApi Directory { get; }
        public ExpressWaybillApi ExpressWaybill { get; }

        public NovaPoshtaApi(
            IApiConfig config, 
            IApiHttpClient client, 
            RequestHelper requestHelper)
        {
            ThrowHelper.ThrowIfApiConfigInvalid(config);
            ThrowHelper.ThrowIfNull(client, nameof(client));
            ThrowHelper.ThrowIfNull(requestHelper, nameof(requestHelper));

            _config = config;
            _client = client;

            Address = new AddressApi(client, config, requestHelper.AddressRequestCreator);
            Directory = new DirectoryApi(client, config, requestHelper.DirectoryRequestCreator);
            ExpressWaybill = new ExpressWaybillApi(client, config, requestHelper.ExpressWaybillRequest);
        }

        /// <summary>Send request to nova poshta API.</summary>
        /// <typeparam name="T">Api response type.</typeparam>
        /// <param name="request">Request to nova poshta API.</param>
        /// <returns>Response from nova poshta API to request <paramref name="request"/>.</returns>
        public Task<T> SendRequestAsync<T>(IApiRequest request)
            => _client.RequestAsync<T>(request);
    }
}
