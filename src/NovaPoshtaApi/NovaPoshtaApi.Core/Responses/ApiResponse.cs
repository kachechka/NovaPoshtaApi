using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NovaPoshtaApi.Core.Responses
{
    /// <inheritdoc/>
    /// <typeparam name="T">
    /// Response item type.
    /// </typeparam>
    public class ApiResponse<T> : Response
    {
        /// <summary>
        /// Get or set response data.
        /// </summary>
        /// <value>
        /// API response items.
        /// </value>
        [JsonPropertyName("data")]
        public List<T>? Data { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="ApiResponse{T}"/> class.
        /// </summary>
        public ApiResponse()
        { }
    }
}