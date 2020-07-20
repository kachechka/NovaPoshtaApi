using NovaPoshtaApi.ApiClients;
using NovaPoshtaApi.Configurations;
using NovaPoshtaApi.Core.Requests;
using NovaPoshtaApi.Core.Responses;
using NovaPoshtaApi.Helpers;
using NovaPoshtaApi.RequestCreators;
using System.Threading.Tasks;

namespace NovaPoshtaApi.APIs
{
    /// <summary>
    /// Express waybill api
    /// </summary>
    public class ExpressWaybillApi
    {
        private readonly IApiHttpClient _client;
        private readonly IApiConfig _config;
        private readonly ExpressWaybillRequestCreator _creator;

        /// <summary>
        /// Initialize a new instance of the <see cref="ExpressWaybillApi"/> class.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="config"></param>
        /// <param name="creator"></param>
        public ExpressWaybillApi(
            IApiHttpClient client,
            IApiConfig config,
            ExpressWaybillRequestCreator creator)
        {
            ThrowHelper.ThrowIfNull(client, nameof(client));
            ThrowHelper.ThrowIfNull(config, nameof(config));
            ThrowHelper.ThrowIfNull(creator, nameof(creator));

            _client = client;
            _config = config;
            _creator = creator;
        }

        /// <summary>
        /// Метод позволяет просматривать более расширенную информацию по статусу отправления. 
        /// При введенном номере телефона можно получить следующую информацию: 
        /// данные отправителя или получателя, номер телефона. 
        /// Метод позволяет просматривать одновременно до 100 отправлений.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<Tracking>> GetTrackingDocumentsAsync(TrackingRequest properties)
        {
            var request = _creator.CreateGetTrackings(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<Tracking>(request);
        }

        // TODO: add express waybill requests
    }
}
