using NovaPoshtaApi.Core.Requests;
using System.Runtime.CompilerServices;

namespace NovaPoshtaApi.RequestCreators
{
    /// <summary>
    /// Directory requests creator.
    /// </summary>
    public class DirectoryRequestCreator : RequestCreator
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="DirectoryRequestCreator"/> class.
        /// </summary>
        public DirectoryRequestCreator()
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ApiRequest CreateCommonRequest(string apiKey, string calledMethod, object? properties)
            => CreateRequest(apiKey, "Common", calledMethod, properties);

        /// <summary>Create request for getting time intervals.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetTimeIntervals(string apiKey, TimeIntervalsRequest properties)
            => CreateCommonRequest(apiKey, "getTimeIntervals", properties);

        /// <summary>Create request for getting cargo types.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetCargoTypes(string apiKey, CargoTypesRequest? properties = null)
            => CreateCommonRequest(apiKey, "getCargoTypes", properties);

        /// <summary>Create request for getting backward cargo types.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetBackwardCargoTypes(string apiKey, CargoTypesRequest? properties = null)
            => CreateCommonRequest(apiKey, "getBackwardDeliveryCargoTypes", properties);

        /// <summary>Create request for getting pallet types.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetPalletTypes(string apiKey)
            => CreateCommonRequest(apiKey, "getPalletsList", null);

        /// <summary>Create request for getting payer types.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetPayerTypes(string apiKey, PayerTypesRequest? properties = null)
            => CreateCommonRequest(apiKey, "getTypesOfPayers", properties);

        /// <summary>Create request for getting backward payer types.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetBackwardPayerTypes(string apiKey, PayerTypesRequest? properties = null)
            => CreateCommonRequest(apiKey, "getTypesOfPayersForRedelivery", properties);

        /// <summary>Create request for getting pack types.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetPackTypes(string apiKey, PackTypesRequest? properties = null)
            => CreateCommonRequest(apiKey, "getPackList", properties);

        /// <summary>Create request for getting wheel & disk types.
        /// </summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetWheelTypes(string apiKey)
            => CreateCommonRequest(apiKey, "getTiresWheelsList", null);

        /// <summary>Create request for getting delivery types.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetDeliveryTypes(string apiKey, DeliveryTypesRequest? properties = null)
            => CreateCommonRequest(apiKey, "getServiceTypes", properties);

        /// <summary>Create request for getting counterparty types.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetCounterpartyTypes(string apiKey, CounterpartyTypesRequest? properties = null)
            => CreateCommonRequest(apiKey, "getTypesOfCounterparties", properties);

        /// <summary>Create request for getting payment types.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetPaymentTypes(string apiKey, PaymentTypesRequest? properties = null)
            => CreateCommonRequest(apiKey, "getPaymentForms", properties);

        /// <summary>Create request for getting ownership types.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetOwnershipTypes(string apiKey, OwnershipTypesRequest? properties = null)
            => CreateCommonRequest(apiKey, "getOwnershipFormsList", properties);

        /// <summary>Create request for getting cargo description.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetCargoDescriptions(string apiKey, CargoDescriptionsRequest properties)
            => CreateCommonRequest(apiKey, "getCargoDescriptionList", properties);

        /// <summary>Create request for getting error messages.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetErrorMessages(string apiKey)
            => CreateRequest(apiKey, "CommonGeneral", "getMessageCodeText", null);
    }
}
