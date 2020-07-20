namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос создания адреса контрагента.
    /// </summary>
    public class CreateAddressRequest
    {
        /// <summary>
        /// Get or set ConterpartyRef parameter of the request.
        /// </summary>
        /// <value>
        /// Идентификатор контрагента.
        /// </value>
        public string? CounterpartyRef { get; set; }

        /// <summary>
        /// Get or set StreetRef parameter of the request.
        /// </summary>
        /// <value>
        /// Идентификатор улицы.
        /// </value>
        public string? StreetRef { get; set; }

        /// <summary>
        /// Get or set BuildingNumber parameter of the request.
        /// </summary>
        /// <value>
        /// Номер дома.
        /// </value>
        public string? BuildingNumber { get; set; }

        /// <summary>
        /// Get or set Flat parameter of the request.
        /// </summary>
        /// <value>
        /// Квартира.
        /// </value>
        public string? Flat { get; set; }

        /// <summary>
        /// Get or set Note parameter of the request.
        /// </summary>
        /// <value>
        /// Комментарий.
        /// </value>
        public string? Note { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="CreateAddressRequest"/> class.
        /// </summary>
        public CreateAddressRequest()
        { }
    }
}