using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="PayerTypesRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{Description}")]
#endif
    public class PaymentType
    {
        /// <summary>
        /// Get or set payment type description.
        /// </summary>
        /// <value>
        /// Описание на Украинском.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set payment type ref.
        /// </summary>
        /// <value>
        /// Идентификатор.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="PaymentType"/> class.
        /// </summary>
        public PaymentType()
        { }
    }
}
