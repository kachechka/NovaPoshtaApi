using System.Diagnostics;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос видов шин и дисков.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{DescriptionRu}")]
#endif
    public class WheelDiskType
    {
        /// <summary>
        /// Get or set wheel or disk ref.
        /// </summary>
        /// <value>
        /// Идентификатор.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Get or set wheel or disk description.
        /// </summary>
        /// <value>
        /// Описание на Украинском.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set wheel or disk description on Russian.
        /// </summary>
        /// <value>
        /// Описание на Русском.
        /// </value>
        public string? DescriptionRu { get; set; }

        /// <summary>
        /// Get or set wheel or disk weight.
        /// </summary>
        /// <value>
        /// Вес.
        /// </value>
        public string? Weight { get; set; }

        /// <summary>
        /// Get or set wheel or disk description type.
        /// </summary>
        /// <value>
        /// Описание типа позиции.
        /// </value>
        public string? DescriptionType { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="WheelDiskType"/> class.
        /// </summary>
        public WheelDiskType()
        { }
    }
}
