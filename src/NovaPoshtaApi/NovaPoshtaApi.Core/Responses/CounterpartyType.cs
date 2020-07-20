using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="CounterpartyTypesRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{Description}")]
#endif
    public class CounterpartyType
    {
        /// <summary>
        /// Get or set counterparty type description.
        /// </summary>
        /// <value>
        /// Описание на Украинском.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set counterpary ref.
        /// </summary>
        /// <value>
        /// Идентификатор.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="CounterpartyType"/> class.
        /// </summary>
        public CounterpartyType()
        { }
    }
}
