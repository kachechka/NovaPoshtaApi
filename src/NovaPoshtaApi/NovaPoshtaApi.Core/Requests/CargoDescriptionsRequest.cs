namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос описания груза.
    /// </summary>
    public class CargoDescriptionsRequest
    {
        /// <summary>
        /// Get or set FindByString parameter of the request.
        /// </summary>
        /// <value>
        /// Поиск по строкам.
        /// </value>
        public string? FindByString { get; set; }

        /// <summary>
        /// Get or set Page parameter of the request
        /// </summary>
        /// <value>
        /// страница (до 500 записей на странице).
        /// </value>
        public int Page { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="CargoDescriptionsRequest"/> class.
        /// </summary>
        public CargoDescriptionsRequest()
        { }
    }
}