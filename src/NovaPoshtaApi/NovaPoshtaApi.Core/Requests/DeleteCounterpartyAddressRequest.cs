namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос удаления адреса контрагента.
    /// </summary>
    public class DeleteCounterpartyAddressRequest
    {
        /// <summary>
        /// Get or set Ref request parameter.
        /// </summary>
        /// <value>
        /// Идентификатор адреса.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="DeleteCounterpartyAddressRequest"/> class.
        /// </summary>
        public DeleteCounterpartyAddressRequest()
        { }
    }
}