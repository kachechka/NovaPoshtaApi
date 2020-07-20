using NovaPoshtaApi.Core.Requests;
using System.Runtime.CompilerServices;

namespace NovaPoshtaApi.RequestCreators
{
    /// <summary>
    /// Address requests creator.
    /// </summary>
    public class AddressRequestCreator : RequestCreator
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="AddressRequestCreator"/> class.
        /// </summary>
        public AddressRequestCreator()
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ApiRequest CreateAddress(string apiKey, string calledMethod, object? properties)
            => CreateRequest(apiKey, "Address", calledMethod, properties);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ApiRequest CreateAddressGeneral(string apiKey, string calledMethod, object? properties)
            => CreateRequest(apiKey, "AddressGeneral", calledMethod, properties);

        /// <summary>Create request for searching city.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateSearchCity(string apiKey, CityRequest properties)
            => CreateAddress(apiKey, "searchSettlements", properties);

        /// <summary>Create request for searching street.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateSearchStreet(string apiKey, StreetRequest properties)
            => CreateAddress(apiKey, "searchSettlementStreets", properties);

        /// <summary>Create request for updating address.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateUpdateAddress(string apiKey, UpdateAddressRequest properties)
            => CreateAddress(apiKey, "update", properties);

        /// <summary>Create request for creating address.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateAddress(string apiKey, CreateAddressRequest properties)
            => CreateAddress(apiKey, "save", properties);

        /// <summary>Create request for getting areas.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetAreas(string apiKey, AreaRequest? properties)
            => CreateAddress(apiKey, "getAreas", properties);

        /// <summary>Create request for getting cities.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetCities(string apiKey, CompanyCityRequest? properties)
            => CreateAddress(apiKey, "getCities", properties);

        /// <summary>Create request for getting localities.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetLocalities(string apiKey, LocalityRequest? properties)
            => CreateAddressGeneral(apiKey, "getSettlements", properties);

        /// <summary>Create request for getting departments.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetDepartments(string apiKey, DepartmentRequest? properties)
            => CreateAddressGeneral(apiKey, "getWarehouses", properties);

        /// <summary>Create request for delete counterparty address.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateDeleteCounterpartyAddress(
            string apiKey, 
            DeleteCounterpartyAddressRequest properties)
            => CreateAddress(apiKey, "delete", properties);

        /// <summary>Create request for getting company streets.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetCompanyStreet(string apiKey, CompanyStreetRequest properties)
            => CreateAddress(apiKey, "getStreet", properties);

        /// <summary>Create request for getting department types.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetDepartmentTypes(string apiKey, DepartmentRequest properties)
            => CreateAddressGeneral(apiKey, "getWarehouseTypes", properties);
    }
}
