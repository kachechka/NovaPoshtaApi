namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос справочника городов компании.
    /// </summary>
    public class CompanyCityRequest
    {
        /// <summary>
        /// Get or set Ref parameter of the request.
        /// </summary>
        /// <value>
        /// Идентификатор города.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Get or set Page parameter of the request.
        /// </summary>
        /// <value>
        /// Номер страницы для отображения.
        /// </value>
        public int Page { get; set; }

        /// <summary>
        /// Get or set FindByString parameter of the request.
        /// </summary>
        /// <value>
        /// Поиск по названию города.
        /// </value>
        public string? FindByString { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="CompanyCityRequest"/> class.
        /// </summary>
        public CompanyCityRequest()
        { }
    }
}