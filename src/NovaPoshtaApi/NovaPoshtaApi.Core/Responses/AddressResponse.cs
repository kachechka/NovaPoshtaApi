using System.Collections.Generic;
using System.Diagnostics;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ от API новой почты на запрос Address.
    /// </summary>
    /// <typeparam name="T">
    /// Елемент ответа на запрос Address.
    /// </typeparam>
#if DEBUG
    [DebuggerDisplay("TotalCount = {TotalCount}")]
#endif
    public class AddressResponse<T>
    {
        /// <summary>
        /// Get or set total count of items in response.
        /// </summary>
        /// <value>
        /// Количество элементов в ответе
        /// </value>
        public int TotalCount { get; set; }

        /// <summary>
        /// Get or set address data list in response.
        /// </summary>
        /// <value>
        /// Список элементов ответа.
        /// </value>
        public List<T>? Addresses { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="AddressResponse{T}"/> class.
        /// </summary>
        public AddressResponse()
        { }
    }
}
