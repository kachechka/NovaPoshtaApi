namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос поиска в справочнике населенных пунктов.
    /// </summary>
    public class CityRequest
    {
        /// <summary>
        /// Get or set CityName parameter of the request.
        /// </summary>
        /// <value>
        /// Название населенного пункта или ИНДКЕС населенного пункта.
        /// </value>
        public string? CityName { get; set; }

        /// <summary>
        /// Get or set Limit parameter of the request.
        /// </summary>
        /// <value>
        /// Количество ответов.
        /// </value>
        public int Limit { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="CityRequest"/> class.
        /// </summary>
        public CityRequest()
        { }
    }
}