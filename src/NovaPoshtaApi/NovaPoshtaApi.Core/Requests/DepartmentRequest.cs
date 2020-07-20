namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос справочника отделений и типов отделений.
    /// </summary>
    public class DepartmentRequest
    {
        /// <summary>
        /// Get or set CityName parameter of the request.
        /// </summary>
        /// <value>
        /// Дополнительный фильтр по имени города.
        /// </value>
        public string? CityName { get; set; }

        /// <summary>
        /// Get or set CityRef parameter of the request.
        /// </summary>
        /// <value>
        /// Дополнительный фильтр по идентификатору города.
        /// </value>
        public string? CityRef { get; set; }

        /// <summary>
        /// Get or set Page parameter of the request.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMENT
        public int Page { get; set; }

        /// <summary>
        /// Get or set Limit parameter of the request.
        /// </summary>
        /// <value>
        /// Страница, максимум 500 записей на странице. Работает в связке с параметром Limit.
        /// </value>
        public int Limit { get; set; }

        /// <summary>
        /// Get or set Language parameter of the request.
        /// </summary>
        /// <value>
        /// Вывод описания на Украинском или русском языках - ru. 
        /// По умолчанию всегда выводиться на Украинском языке.
        /// </value>
        public string? Language { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="DepartmentRequest"/> class.
        /// </summary>
        public DepartmentRequest()
        { }
    }
}