namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос получения списка населенных пунктов.
    /// </summary>
    public class LocalityRequest
    {
        /// <summary>
        /// Get or set Locality parameter of the request.
        /// </summary>
        /// <value>
        /// Идентификатор адреса.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Get or set RegionRef parameter of the request.
        /// </summary>
        /// <value>
        /// Фильтр по идентификатору района.
        /// </value>
        public string? RegionRef { get; set; }

        /// <summary>
        /// Get or set FindByString parameter of the request.
        /// </summary>
        /// <value>
        /// Поиск по строкам, только на Украинском языке.
        /// </value>
        public string? FindByString { get; set; }

        /// <summary>
        /// Get or set Page parameter of the request.
        /// </summary>
        /// <value>
        /// Номер страницы.
        /// </value>
        public string? Page { get; set; }

        /// <summary>
        /// Get or set Warehouse parameter of the request.
        /// </summary>
        /// <value>
        /// Фильтр наличия отделений.
        /// </value>
        public string? Warehouse { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="LocalityRequest"/> class.
        /// </summary>
        public LocalityRequest()
        { }
    }
}