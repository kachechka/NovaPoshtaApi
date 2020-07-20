using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="CityRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{SettlementTypeCode}{MainDescription} ({Area})")]
#endif
    public class City
    {
        /// <summary>
        /// Get or set is there a department in the city.
        /// </summary>
        /// <value>
        /// Количество отделений.
        /// </value>
        public int Warehouses { get; set; }

        /// <summary>
        /// Get or set city name.
        /// </summary>
        /// <value>
        /// Название населенных пунктов.
        /// </value>
        public string? MainDescription { get; set; }

        /// <summary>
        /// Get or set city area.
        /// </summary>
        /// <value>
        /// Обозначение области.
        /// </value>
        public string? Area { get; set; }

        /// <summary>
        /// Get or set city region.
        /// </summary>
        /// <value>
        /// Обозначение района.
        /// </value>
        public string? Region { get; set; }

        /// <summary>
        /// Get or set settlement type code.
        /// </summary>
        /// <value>
        /// Аббревиатура типа населенного пункта.
        /// </value>
        public string? SettlementTypeCode { get; set; }

        /// <summary>
        /// Get or set city ref.
        /// </summary>
        /// <value>
        /// REF города из справочника getSettlements.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Get or set delivery city ref.
        /// </summary>
        /// <value>
        /// REF города из справочника getCities, из которого осуществляется доставка.
        /// </value>
        public string? DeliveryCity { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="City"/> class.
        /// </summary>
        public City()
        { }
    }
}
