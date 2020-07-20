namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос поиска в справочнике населенных пунктов.
    /// </summary>
    public class StreetRequest
    {
        /// <summary>
        /// Get or set StreetName parameter of the request.
        /// </summary>
        /// <value>
        /// Название улицы.
        /// </value>
        public string? StreetName { get; set; }

        /// <summary>
        /// Get or set SettlementRef parameter of the request.
        /// </summary>
        /// <value>
        /// REF населенного пункта из справочника населенных пунктов Украины.
        /// </value>
        public string? SettlementRef { get; set; }

        /// <summary>
        /// Get or set Limit parameter of the request.
        /// </summary>
        /// <value>
        /// Количество ответов.
        /// </value>
        public int Limit { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="StreetRequest"/> class.
        /// </summary>
        public StreetRequest()
        { }
    }
}