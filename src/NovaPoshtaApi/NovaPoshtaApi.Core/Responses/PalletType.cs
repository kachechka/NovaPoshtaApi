using System.Diagnostics;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрс получения справочника типа палет.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{DescriptionRu}")]
#endif
    public class PalletType
    {
        /// <summary>
        /// Get or set pallet type ref.
        /// </summary>
        /// <value>
        /// Идентификатор паллеты.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Get or set pallet type description.
        /// </summary>
        /// <value>
        /// Описание паллеты на Украинском.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set pallet type description on Russian.
        /// </summary>
        /// <value>
        /// Описание паллеты на русском.
        /// </value>
        public string? DescriptionRu { get; set; }

        /// <summary>
        /// Get or set pallet type weight.
        /// </summary>
        /// <value>
        /// Вес.
        /// </value>
        public string? Weight { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="TimeInterval"/> class.
        /// </summary>
        public PalletType()
        { }
    }
}
