using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="CargoDescriptionsRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{DescriptionRu}")]
#endif
    public class CargoDescription
    {
        /// <summary>
        /// Get or set cargo description.
        /// </summary>
        /// <value>
        /// Описание на Украинском.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set cargo description on Russian.
        /// </summary>
        /// <value>
        /// Описание на Русском.
        /// </value>
        public string? DescriptionRu { get; set; }

        /// <summary>
        /// Get or set cargo description ref.
        /// </summary>
        /// <value>
        /// Идентификатор.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="CargoDescription"/> class.
        /// </summary>
        public CargoDescription()
        { }
    }
}
