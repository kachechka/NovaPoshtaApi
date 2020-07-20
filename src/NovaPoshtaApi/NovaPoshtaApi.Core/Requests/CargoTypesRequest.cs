namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос справочника видов груза.
    /// </summary>
    public class CargoTypesRequest
    {
        /// <summary>
        /// Get or set Language parameter of the request.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMENT
        public string? Language { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="TimeInterval"/> class.
        /// </summary>
        public CargoTypesRequest()
        { }
    }
}