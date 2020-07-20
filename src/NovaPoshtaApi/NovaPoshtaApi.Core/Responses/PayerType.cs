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
    public class PayerType
    {
        /// <summary>
        /// Get or set payer type description.
        /// </summary>
        /// <value>
        /// Описание.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set payer type ref
        /// </summary>
        /// <value>
        /// Идентификатор.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="PayerType"/> class.
        /// </summary>
        public PayerType()
        { }
    }
}
