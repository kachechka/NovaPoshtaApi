namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос списка платильщиков.
    /// </summary>
    public class PayerTypesRequest
    {
        /// <summary>
        /// Get or set Language paramenter of the request.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMENT
        public string? Language { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="PayerTypesRequest"/> class.
        /// </summary>
        public PayerTypesRequest()
        { }
    }
}