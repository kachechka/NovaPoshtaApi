namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос справочника улиц.
    /// </summary>
    public class CompanyStreetRequest
    {
        /// <summary>
        /// Get or set CityRef parameter of the request.
        /// </summary>
        /// <value>
        /// Идентификатор города.
        /// </value>
        public string? CityRef { get; set; }

        /// <summary>
        /// Get or set FindByString parameter of the request.
        /// </summary>
        /// <value>
        /// Поиск по строкам.
        /// </value>
        public string? FindByString { get; set; }

        /// <summary>
        /// Get or set Page parameter of the request.
        /// </summary>
        /// <value>
        /// Страница до 500 записей на странице.
        /// </value>
        public string? Page { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="CompanyStreetRequest"/> class.
        /// </summary>
        public CompanyStreetRequest()
        { }
    }
}