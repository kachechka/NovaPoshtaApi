using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="PackTypesRequest"/>
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{DescriptionRu}")]
#endif
    public class PackType
    {
        /// <summary>
        /// Get or set pack type ref.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMENT
        public string? Ref { get; set; }

        /// <summary>
        /// Get or set pack type description.
        /// </summary>
        /// <value>
        /// Описание ну Украинском языке.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set pack type ref on Russian.
        /// </summary>
        /// <value>
        /// Описание ну русском языке.
        /// </value>
        public string? DescriptionRu { get; set; }

        /// <summary>
        /// Get or set pack type length.
        /// </summary>
        /// <value>
        /// Длинна упаковки.
        /// </value>
        public string? Length { get; set; }

        /// <summary>
        /// Get or set pack type width.
        /// </summary>
        /// <value>
        /// Вес упаковки.
        /// </value>
        public string? Width { get; set; }

        /// <summary>
        /// Get or set pack type height.
        /// </summary>
        /// <value>
        /// Высота упаковки.
        /// </value>
        public string? Height { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="PayerType"/> class.
        /// </summary>
        public PackType()
        { }
    }
}
