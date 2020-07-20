using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="AreaRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{Description}")]
#endif
    public class Area
    {
        /// <summary>
        /// Get or set area description.
        /// </summary>
        /// <value>
        /// Описание на украинском языке.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set area ref.
        /// </summary>
        /// <value>
        /// Идентификатор Области.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Get or set area center city ref.
        /// </summary>
        /// <value>
        /// Идентификатор города, который является областным центром.
        /// </value>
        public string? AreasCenter { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="Area"/> class.
        /// </summary>
        public Area()
        { }
    }
}
