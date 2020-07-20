namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос списка технологий доставки.
    /// </summary>
    public class DeliveryTypesRequest
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
        /// Initialize a new instance of the <see cref="DeliveryTypesRequest"/> class.
        /// </summary>
        public DeliveryTypesRequest()
        { }
    }
}