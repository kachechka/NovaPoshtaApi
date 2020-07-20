using System.Collections.Generic;

namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запроса для отслеживания поссылок.
    /// </summary>
    public class TrackingRequest
    {
        /// <summary>
        /// Get or set documents for tracking.
        /// </summary>
        /// <value>
        /// Массив.
        /// </value>
        public List<TrackingDocument>? Documents { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="TimeInterval"/> class.
        /// </summary>
        public TrackingRequest()
        { }
    }
}