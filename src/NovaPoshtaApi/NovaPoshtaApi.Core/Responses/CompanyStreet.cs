using System.Diagnostics;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="CompanyStreet"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{StreetsType} {Description}")]
#endif
    public class CompanyStreet
    {
        /// <summary>
        /// Get or set street ref.
        /// </summary>
        /// <value>
        /// Идентификатор улицы.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Get or set street description.
        /// </summary>
        /// <value>
        /// Название улицы на украинском языке.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set street type ref.
        /// </summary>
        /// <value>
        /// Название типа улицы на украинском языке.
        /// </value>
        public string? StreettsTypeRef { get; set; }

        /// <summary>
        /// Get or set street type.
        /// </summary>
        /// <value>
        /// Тип улицы.
        /// </value>
        public string? StreetsType { get; set; }

        /// <summary>
        /// Inialize a new instance of the <see cref="CompanyStreet"/> class.
        /// </summary>
        public CompanyStreet()
        { }
    }
}
