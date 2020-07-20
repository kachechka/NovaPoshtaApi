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
    /// Directory Nova Poshta API.
    /// </summary>
    public class DirectoryApi
    {
        private readonly IApiHttpClient _client;
        private readonly IApiConfig _config;
        private readonly DirectoryRequestCreator _creator;

        internal DirectoryApi(
            IApiHttpClient client,
            IApiConfig config,
            DirectoryRequestCreator creator)
        {
            ThrowHelper.ThrowIfNull(client, nameof(client));
            ThrowHelper.ThrowIfNull(config, nameof(config));
            ThrowHelper.ThrowIfNull(creator, nameof(creator));

            _client = client;
            _config = config;
            _creator = creator;
        }

        /// <summary>
        /// Метод необходим для получения списка временных интервалов 
        /// (для заказа услуги "Временные интервалы"). 
        /// Для обновления данных, справочник необходимо загружать один раз в месяц
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<TimeInterval>> GetTimeIntervalsAsync(TimeIntervalsRequest properties)
        {
            var request = _creator.CreateGetTimeIntervals(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<TimeInterval>(request);
        }

        /// <summary>
        /// Метод необходим для скачивания списка типов груза на Украинском языке.
        /// Для обновления данных, справочник необходимо загружать один раз в месяц.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<CargoType>> GetCargoTypesAsync(CargoTypesRequest? properties = null)
        {
            var request = _creator.CreateGetCargoTypes(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<CargoType>(request);
        }

        /// <summary>
        /// Метод необходим для отображения списка видов обратной 
        /// доставки груза на украинском и на русском языках. 
        /// Для обновления данных, справочник необходимо загружать один раз в месяц.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<CargoType>> GetBackwardCargoTypesAsync(CargoTypesRequest? properties = null)
        {
            var request = _creator.CreateGetBackwardCargoTypes(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<CargoType>(request);
        }

        /// <summary>
        /// Метод необходим для получения списка видов паллет. 
        /// Для обновления данных, справочник необходимо загружать один раз в месяц.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<PalletType>> GetPalletTypesAsync()
        {
            var request = _creator.CreateGetPalletTypes(_config.ApiKey);

            return _client.RequestForResponseAsync<PalletType>(request);
        }

        /// <summary>
        /// Метод необходим для загрузки списка видов плательщиков услуги доставки 
        /// на украинском и на русском языках: Отправитель, Получатель, Третье лицо. 
        /// Вид плательщика "Третье лицо" возможно заказать 
        /// только после заключения договора с компанией "Новая Почта".
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<PayerType>> GetPayerTypesAsync(PayerTypesRequest? properties = null)
        {
            var request = _creator.CreateGetPayerTypes(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<PayerType>(request);
        }

        /// <summary>
        /// Метод необходим для загрузки списка видов плательщиков услуги обратной 
        /// доставки на Украинском и Английском языках: Sender, Recipient.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<PayerType>> GetBackwardPayerTypesAsync(PayerTypesRequest? properties = null)
        {
            var request = _creator.CreateGetBackwardPayerTypes(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<PayerType>(request);
        }

        /// <summary>
        /// Метод необходим для скачивания видов упаковки груза на Украинском или русском языках.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<PackType>> GetPackTypesAsync(PackTypesRequest? properties = null)
        {
            var request = _creator.CreateGetPackTypes(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<PackType>(request);
        }

        /// <summary>
        /// Метод позволяет загрузить список шин и дисков 
        /// (используется, если вид груза «шины-диски») на Украинском и Русском языках. 
        /// Необходимо сохранять копию справочников на стороне клиента 
        /// и поддерживать ее в актуальном состоянии.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<WheelDiskType>> GetWheelTypesAsync()
        {
            var request = _creator.CreateGetWheelTypes(_config.ApiKey);

            return _client.RequestForResponseAsync<WheelDiskType>(request);
        }

        /// <summary>
        /// Метод позволяет отдать описание груза на украинском и на русском языках.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<CargoDescription>> GetCargoDescriptionsAsync(CargoDescriptionsRequest properties)
        {
            var request = _creator.CreateGetCargoDescriptions(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<CargoDescription>(request);
        }

        /// <summary>
        /// Метод необходим для скачивания справочника с описанием перечня ошибок.
        /// Метод постоянно пополняется новым описанием на трех языках.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<ErrorMessage>> GetErrorMessagesAsync()
        {
            var request = _creator.CreateGetErrorMessages(_config.ApiKey);

            return _client.RequestForResponseAsync<ErrorMessage>(request);
        }

        /// <summary>
        /// Метод позволяет загрузить список типов технологий доставки: «склад-склад», 
        /// «двери-двери», «склад-двери», «двери-склад» на украинском и на русском языках.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<DeliveryType>> GetDeliveryTypesAsync(DeliveryTypesRequest? properties = null)
        {
            var request = _creator.CreateGetDeliveryTypes(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<DeliveryType>(request);
        }

        /// <summary>
        /// Метод позволяет загрузить список типов контрагентов на украинском и на русском языках.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<CounterpartyType>> GetCounterpartyTypesAsync(CounterpartyTypesRequest? properties = null)
        {
            var request = _creator.CreateGetCounterpartyTypes(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<CounterpartyType>(request);
        }

        /// <summary>
        /// Метод позволяет загрузить список форм оплат на украинском и на русском языках. 
        /// Оплачивать услуги доставки с помощью безналичного расчета могут 
        /// Клиенты, которые заключили договор с компанией "Новая Почта".
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<PaymentType>> GetPaymentTypesAsync(PaymentTypesRequest? properties = null)
        {
            var request = _creator.CreateGetPaymentTypes(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<PaymentType>(request);
        }

        /// <summary>
        /// Метод позволяет загрузить список форм собственности на Украинском языке.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<OwnershipType>> GetOwnershipTypesAsync(OwnershipTypesRequest? properties = null)
        {
            var request = _creator.CreateGetOwnershipTypes(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<OwnershipType>(request);
        }
    }
}
