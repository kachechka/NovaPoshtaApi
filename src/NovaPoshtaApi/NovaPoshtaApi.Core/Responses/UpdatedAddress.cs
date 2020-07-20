using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="UpdateAddressRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("Description")]
#endif
    public class UpdatedAddress
    {
        /// <summary>
        /// Get or set ref of the updated address.
        /// </summary>
        /// <value>
        /// Название улицы.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Get or set description of the updated address.
        /// </summary>
        /// <value>
        /// Название улицы.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="UpdatedAddress"/> class.
        /// </summary>
        public UpdatedAddress()
        { }
    }
}
