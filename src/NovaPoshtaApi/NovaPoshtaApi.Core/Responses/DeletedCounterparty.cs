using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответа на запрос <see cref="DeleteCounterpartyAddressRequest"/>.
    /// </summary>
    public class DeletedCounterparty
    {
        /// <summary>
        /// Get or set deleted counterparty ref.
        /// </summary>
        /// <value>
        /// Идентификатор адреса.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="DeletedCounterparty"/> class.
        /// </summary>
        public DeletedCounterparty()
        { }
    }
}
