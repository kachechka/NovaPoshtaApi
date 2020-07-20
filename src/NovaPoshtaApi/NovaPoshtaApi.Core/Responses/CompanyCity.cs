using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="CompanyCityRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{DescriptionRu}")]
#endif
    public class CompanyCity
    {
        /// <summary>
        /// Get or set company city description.
        /// </summary>
        /// <value>
        /// Город на Украинском языке.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set company city description on Russian.
        /// </summary>
        /// <value>
        /// Город на русском языке.
        /// </value>
        public string? DescriptionRu { get; set; }

        /// <summary>
        /// Get or set company city ref.
        /// </summary>
        /// <value>
        /// Идентификатор города.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Get or set availability of delivery on Monday.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления в понедельник.
        /// </value>
        public string? Delivery1 { get; set; }

        /// <summary>
        /// Get or set availability of delivery on Tuesday.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления во вторник.
        /// </value>
        public string? Delivery2 { get; set; }

        /// <summary>
        /// Get or set availability of delivery on Wednesday.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления в среду.
        /// </value>
        public string? Delivery3 { get; set; }

        /// <summary>
        /// Get or set availability of delivery on Thursday.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления в четверг.
        /// </value>
        public string? Delivery4 { get; set; }

        /// <summary>
        /// Get or set availability of delivery on Friday.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления в пятницу.
        /// </value>
        public string? Delivery5 { get; set; }

        /// <summary>
        /// Get or set availability of delivery on Saturday.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления в субботу.
        /// </value>
        public string? Delivery6 { get; set; }

        /// <summary>
        /// Get or set availability of delivery on Sunday.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления в воскресенье.
        /// </value>
        public string? Delivery7 { get; set; }

        /// <summary>
        /// Get or set area.
        /// </summary>
        /// <value>
        /// Область.
        /// </value>
        public string? Area { get; set; }

        /// <summary>
        /// Get or set ref of the settlement type.
        /// </summary>
        /// <value>
        /// Идентификатор (REF) типа населенного пункта.
        /// </value>
        public string? SettlementType { get; set; }

        /// <summary>
        /// Get or set is branch.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMNET
        public string? IsBranch { get; set; }

        /// <summary>
        /// Get or set prevent entry new streets user.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMNET
        public object? PreventEntryNewStreetsUser { get; set; }

        /// <summary>
        /// Get or set conglomerates.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // WILL_DELETE
        public object? Conglomerates { get; set; }

        /// <summary>
        /// Get or set code of city.
        /// </summary>
        /// <value>
        /// Код населенного пункта.
        /// </value>
        public string? CityID { get; set; }

        /// <summary>
        /// Get or set description of settlement type on Russian.
        /// </summary>
        /// <value>
        /// Описание типа населенного пункта на Русском языке.
        /// </value>
        public string? SettlementTypeDescriptionRu { get; set; }

        /// <summary>
        /// Get or set description of settlement type.
        /// </summary>
        /// <value>
        /// Описание типа населенного пункта на Украинском языке.
        /// </value>
        public string? SettlementTypeDescription { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="CompanyCity"/> class.
        /// </summary>
        public CompanyCity()
        { }
    }
}
