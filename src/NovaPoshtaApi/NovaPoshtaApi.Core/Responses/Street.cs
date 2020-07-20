using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="StreetRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{Present}")]
#endif
    public class Street
    {

        /// <summary>
        /// Get or set settlement ref.
        /// </summary>
        /// <value>
        /// REF населенного пункта.
        /// </value>
        public string? SettlementRef { get; set; }

        /// <summary>
        /// Get or set street ref.
        /// </summary>
        /// <value>
        /// REF улицы.
        /// </value>
        public string? SettlementStreetRef { get; set; }

        /// <summary>
        /// Get or set street description.
        /// </summary>
        /// <value>
        /// Описание улицы
        /// </value>
        public string? SettlementStreetDescription { get; set; }

        /// <summary>
        /// Get or set street full description.
        /// </summary>
        /// <value>
        /// Полное описание улицы.
        /// </value>
        public string? Present { get; set; }

        /// <summary>
        /// Get or set street type ref.
        /// </summary>
        /// <value>
        /// REF типа улицы.
        /// </value>
        public string? StreetsType { get; set; }

        /// <summary>
        /// Get or set street type description.
        /// </summary>
        /// <value>
        /// Описание типа улицы.
        /// </value>
        public string? StreetsTypeDescription { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="Street"/> class.
        /// </summary>
        public Street()
        { }
    }
}
