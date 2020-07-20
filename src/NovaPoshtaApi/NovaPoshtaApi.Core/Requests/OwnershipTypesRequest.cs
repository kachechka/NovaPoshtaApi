namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос справочника форм собственности.
    /// </summary>
    public class OwnershipTypesRequest
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
        /// Initialize a new instance of the <see cref="OwnershipTypesRequest"/> class.
        /// </summary>
        public OwnershipTypesRequest()
        { }
    }
}