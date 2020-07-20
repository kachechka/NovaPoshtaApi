using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запро <see cref="CargoTypesRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{Description}")]
#endif
    public class CargoType
    {
        /// <summary>
        /// Get or set cargo type description.
        /// </summary>
        /// <value>
        /// Описание.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set cargo type ref.
        /// </summary>
        /// <value>
        /// Идентификатор.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="TimeInterval"/> class.
        /// </summary>
        public CargoType()
        { }
    }
}
