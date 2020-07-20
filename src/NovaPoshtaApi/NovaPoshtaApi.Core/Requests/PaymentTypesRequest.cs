namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос справочника форм оплаты.
    /// </summary>
    public class PaymentTypesRequest
    {
        /// <summary>
        /// Get or set Lanuage parameter of the request.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMENT
        public string? Language { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="PaymentTypesRequest"/> class.
        /// </summary>
        public PaymentTypesRequest()
        { }
    }
}