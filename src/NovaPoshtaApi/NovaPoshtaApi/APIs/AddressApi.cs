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
    /// Address Nova Poshta API.
    /// </summary>
    public class AddressApi
    {
        private readonly IApiHttpClient _client;
        private readonly IApiConfig _config;
        private readonly AddressRequestCreator _creator;

        /// <summary>
        /// Initialize a new instance of the <see cref="AddressApi"/> class.
        /// </summary>
        /// <param name="client"><see cref="IApiHttpClient"/> for sending requests</param>
        /// <param name="config">Api configuration</param>
        /// <param name="creator">Request creator</param>
        internal AddressApi(
            IApiHttpClient client,
            IApiConfig config,
            AddressRequestCreator creator)
        {
            ThrowHelper.ThrowIfNull(client, nameof(client));
            ThrowHelper.ThrowIfNull(config, nameof(config));
            ThrowHelper.ThrowIfNull(creator, nameof(creator));

            _client = client;
            _config = config;
            _creator = creator;
        }

        private Task<ApiResponse<AddressResponse<T>>> SendAddressApiRequest<T>(IApiRequest request)
            => _client.RequestAsync<ApiResponse<AddressResponse<T>>>(request);

        /// <summary>
        /// Метод необходим для ОНЛАЙН ПОИСКА населенных пунктов.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<AddressResponse<City>>> FindCityAsync(CityRequest properties)
        {
            var request = _creator.CreateSearchCity(_config.ApiKey, properties);

            return SendAddressApiRequest<City>(request);
        }

        // TEST
        /// <summary>
        /// Метод необходим для ОНЛАЙН ПОИСКА улиц в выбранном населенном пункте.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<AddressResponse<Street>>> FindStreetAsync(StreetRequest properties)
        {
            var request = _creator.CreateSearchStreet(_config.ApiKey, properties);

            return SendAddressApiRequest<Street>(request);
        }

        // TEST
        /// <summary>
        /// Метод необходим для обновления адреса контрагента отправителя/получателя.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<UpdatedAddress>> UpdateAddressAsync(UpdateAddressRequest properties)
        {
            var request = _creator.CreateUpdateAddress(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<UpdatedAddress>(request);
        }

        // TEST
        /// <summary>
        /// Метод сохраняет адреса контрагента отправителя/получателя.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<CreatedAddress>> CreateAddressAsync(CreateAddressRequest properties)
        {
            var request = _creator.CreateAddress(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<CreatedAddress>(request);
        }

        /// <summary>
        /// Метод необходим для скачивания справочника 
        /// географических областей Украины, компании «Новая Почта».
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<Area>> GetAreasAsync(AreaRequest? properties = null)
        {
            var request = _creator.CreateGetAreas(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<Area>(request);
        }

        /// <summary>
        /// Метод загружает справочник населенных пунктов Украины. Стоит учитывать, 
        /// справочник выгружается только с населенными пунктами где есть отделения "Нова Пошта" 
        /// и можно оформить доставку на отделение, а также на доставку по адресу.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<CompanyCity>> GetCitiesAsync(CompanyCityRequest? properties = null)
        {
            var request = _creator.CreateGetCities(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<CompanyCity>(request);
        }

        /// <summary>
        /// Метод  позволяет загрузить справочников городов Украины (на Украинском или Русском), 
        /// в которые осуществляется доставка груза компанией «Новая Почта».
        /// Стоит учитывать, что этот метод для каждого населенного пункта возвращает область, и район.
        /// Метод отдает не более 150 записей на страницу. Для просмотра более 150 записей, 
        /// необходимо использовать параметр <see cref="LocalityRequest.Page"> = "1",
        /// Также в методе доступен поиск по строке, для него нужно указать параметр <see cref="LocalityRequest.FindByString"/>.
        /// Важно! Поиск возможен только на Украинском языке.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<Locality>> GetLocalitiesAsync(LocalityRequest? properties = null)
        {
            var request = _creator.CreateGetLocalities(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<Locality>(request);
        }

        /// <summary>
        /// Метод загружает справочник отделений «Новая Почта» в рамках населенных пунктов Украины.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<Department>> GetDepartmentsAsync(DepartmentRequest? properties = null)
        {
            var request = _creator.CreateGetDepartments(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<Department>(request);
        }

        // TEST
        /// <summary>
        /// Метод получает справочник типов отделений «Новая Почта.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<Department>> GetDepartmentTypesAsync(DepartmentRequest? properties = null)
        {
            var request = _creator.CreateGetDepartments(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<Department>(request);
        }

        // TEST
        /// <summary>
        /// Метод необходим для удаления адреса контрагента отправителя/получателя.
        /// Редактировать данные контрагента можно только с момента его создания до момента создания ИД с ним.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<DeletedCounterparty>> DeleteCounterpartyAddressAsync(DeleteCounterpartyAddressRequest properties)
        {
            var request = _creator.CreateDeleteCounterpartyAddress(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<DeletedCounterparty>(request);
        }

        /// <summary>
        /// Метод загружает справочник улиц в рамках населенных пунктов Украины куда осуществляет 
        /// доставку компания «Новая Почта». Справочник используется при создании отправлений с т
        /// ипом доставки от/до адреса клиента. 
        /// Если в этот запрос добавить параметр «FindByString» (поиск по строкам) и в его 
        /// свойствах прописать название улицы(Броварський), который нужно найти, то получим 
        /// запрос с помощью которого в справочнике находится проспект или улица.
        /// </summary>
        /// <param name="properties">Свойства метода.</param>
        /// <returns>Ответ от API новой почты.</returns>
        public Task<ApiResponse<CompanyStreet>> GetCompanyStreetAsync(CompanyStreetRequest properties)
        {
            var request = _creator.CreateGetCompanyStreet(_config.ApiKey, properties);

            return _client.RequestForResponseAsync<CompanyStreet>(request);
        }
    }
}
