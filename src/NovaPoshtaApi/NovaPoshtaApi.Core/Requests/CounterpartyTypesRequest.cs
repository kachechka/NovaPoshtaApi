namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос справочника типов контрагентов.
    /// </summary>
    public class CounterpartyTypesRequest
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
        /// Initialize a new instance of the <see cref="CounterpartyTypesRequest"/> class.
        /// </summary>
        public CounterpartyTypesRequest()
        { }
    }
}