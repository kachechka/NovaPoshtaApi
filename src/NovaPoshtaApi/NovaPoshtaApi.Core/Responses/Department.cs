using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="DepartmentRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{DescriptionRu} №{Number}")]
#endif
    public class Department
    {
        /// <summary>
        /// Get or set sity key.
        /// </summary>
        /// <value>
        /// Код отделения.
        /// </value>
        public string? SiteKey { get; set; }

        /// <summary>
        /// Get or set department description.
        /// </summary>
        /// <value>
        /// Название отделения на Украинском.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set department description on Russian.
        /// </summary>
        /// <value>
        /// Название отделения на русском.
        /// </value>
        public string? DescriptionRu { get; set; }

        /// <summary>
        /// Get or set department phone.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMENT
        public string? Phone { get; set; }

        /// <summary>
        /// Get or set type of department.
        /// </summary>
        /// <value>
        /// Тип отделения
        /// </value>
        public string? TypeOfWarehouse { get; set; }

        /// <summary>
        /// Get or set department address ref.
        /// </summary>
        /// <value>
        /// Идентификатор адреса.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Get or set department number.
        /// </summary>
        /// <value>
        /// Номер отделения.
        /// </value>
        public string? Number { get; set; }

        /// <summary>
        /// Get or set department city ref.
        /// </summary>
        /// <value>
        /// Идентификатор населенного пункта.
        /// </value>
        public string? CityRef { get; set; }

        /// <summary>
        /// Get or set department city description.
        /// </summary>
        /// <value>
        /// Название населенного пункта на Украинском.
        /// </value>
        public string? CityDescription { get; set; }

        /// <summary>
        /// Get or set department city description on Russian.
        /// </summary>
        /// <value>
        /// Название населенного пункта на русском.
        /// </value>
        public string? CityDescriptionRu { get; set; }

        /// <summary>
        /// Get or set department longitude.
        /// </summary>
        /// <value>
        /// Долгота.
        /// </value>
        public string? Longitude { get; set; }

        /// <summary>
        /// Get or set department latitude.
        /// </summary>
        /// <value>
        /// Широта.
        /// </value>
        public string? Latitude { get; set; }

        /// <summary>
        /// Get or set is in the department post finance terminal.
        /// </summary>
        /// <value>
        /// (1/0) Наличие кассы Пост-Финанс.
        /// </value>
        public string? PostFinance { get; set; }

        /// <summary>
        /// Get or set is in the department bicycle parking.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMENT
        public string? BicycleParking { get; set; }

        /// <summary>
        /// Get or set is in the department post terminal.
        /// </summary>
        /// <value>
        /// (1/0) Наличие пос-терминала на отделении.
        /// </value>
        public string? POSTerminal { get; set; }

        /// <summary>
        /// Get or set is in the department possibility 
        /// of registration of international shipment.
        /// </summary>
        /// <value>
        /// (1/0) Возможность оформления Международного отправления.
        /// </value>
        public string? InternationalShipping { get; set; }

        /// <summary>
        /// Get or set value max allowed weight.
        /// </summary>
        /// <value>
        /// Максимальный вес отправления.
        /// </value>
        public int TotalMaxWeightAllowed { get; set; }

        /// <summary>
        /// Get or set value max allowed weight for one place.
        /// </summary>
        /// <value>
        /// Максимальный вес одного места отправления.
        /// </value>
        public int PlaceMaxWeightAllowed { get; set; }

        /// <summary>
        /// Get or set reception schedule.
        /// </summary>
        /// <value>
        /// График приема отправлений.
        /// </value>
        public Schedule? Reception { get; set; }

        /// <summary>
        /// Get or set delivery schedule.
        /// </summary>
        /// <value>
        /// График отправки день в день.
        /// </value>
        public Schedule? Delivery { get; set; }

        /// <summary>
        /// Get or set schedult.
        /// </summary>
        /// <value>
        /// График работы.
        /// </value>
        public Schedule? Schedule { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="Department"/> class.
        /// </summary>
        public Department()
        { }
    }
}
