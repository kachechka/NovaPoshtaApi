using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="CreateAddressRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{Description}")]
#endif
    public class CreatedAddress
    {
        /// <summary>
        /// Get or set created address ref.
        /// </summary>
        /// <value>
        /// Идентификатор адреса.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Get or set created address description.
        /// </summary>
        /// <value>
        /// Адрес.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="CreatedAddress"/> class.
        /// </summary>
        public CreatedAddress()
        { }
    }
}
