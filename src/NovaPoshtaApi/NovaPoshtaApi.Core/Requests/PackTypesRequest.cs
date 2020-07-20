namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос видов упаковки.
    /// </summary>
    public class PackTypesRequest
    {
        /// <summary>
        /// Get or set Length parameter of the request.
        /// </summary>
        /// <value>
        /// Длинна (не обязательный параметр).
        /// </value>
        public string? Length { get; set; }

        /// <summary>
        /// Get or set Width parameter of the request.
        /// </summary>
        /// <value>
        /// Вес (не обязательный параметр).
        /// </value>
        public string? Width { get; set; }

        /// <summary>
        /// Get or set Height parameter of the request.
        /// </summary>
        /// <value>
        /// Высота (не обязательный параметр).
        /// </value>
        public string? Height { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="PayerType"/> class.
        /// </summary>
        public PackTypesRequest()
        { }
    }
}