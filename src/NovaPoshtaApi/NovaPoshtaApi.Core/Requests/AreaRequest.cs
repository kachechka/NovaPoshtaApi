namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос справочника областей.
    /// </summary>
    public class AreaRequest
    {
        /// <summary>
        /// Get or set Language parameter of the request.
        /// </summary>
        /// <value>
        /// Язык.
        /// </value>
        public string? Language { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="AreaRequest"/> class.
        /// </summary>
        public AreaRequest()
        { }
    }
}