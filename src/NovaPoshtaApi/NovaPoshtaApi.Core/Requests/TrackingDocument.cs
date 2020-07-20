namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Документа запроса для отслеживания поссылки.
    /// </summary>
    public class TrackingDocument
    {
        /// <summary>
        /// Get or set <see cref="TrackingRequest.Documents"/>:DocumentNumber request parameter.
        /// </summary>
        /// <value>
        /// Номер электронной накладной.
        /// </value>
        public string? DocumentNumber { get; set; }

        /// <summary>
        /// Get or set <see cref="TrackingRequest.Documents"/>:Phone request parameter.
        /// </summary>
        /// <value>
        /// Номер телефона (получатель или отправитель). 
        /// Позволяет получить расширенную информацию.
        /// </value>
        public string? Phone { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="TimeInterval"/> class.
        /// </summary>
        public TrackingDocument()
        { }
    }
}