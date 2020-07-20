using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Nova Poshta API response.
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Get or set is success response status.
        /// </summary>
        /// <value>
        /// true - success status, false - othrewise.
        /// </value>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Get or set errors.
        /// </summary>
        /// <value>
        /// Errors.
        /// </value>
        [JsonPropertyName("errors")]
        public List<string>? Errors { get; set; }

        /// <summary>
        /// Get or set warnings.
        /// </summary>
        /// <value>
        /// Warnings.
        /// </value>
        [JsonPropertyName("warnings")]
        public List<object>? Warnings { get; set; }

        /// <summary>
        /// Get or set info.
        /// </summary>
        /// <value>
        /// Info.
        /// </value>
        [JsonPropertyName("info")]
        public object? Info { get; set; }

        /// <summary>
        /// Get or set message codes.
        /// </summary>
        /// <value>
        /// Message codes.
        /// </value>
        [JsonPropertyName("messageCodes")]
        public List<object>? MessageCodes { get; set; }

        /// <summary>
        /// Get or set error codes.
        /// </summary>
        /// <value>
        /// Error codes.
        /// </value>
        [JsonPropertyName("errorCodes")]
        public List<object>? ErrorCodes { get; set; }

        /// <summary>
        /// Get or set warning codes.
        /// </summary>
        /// <value>
        /// Warning codes.
        /// </value>
        [JsonPropertyName("warningCodes")]
        public List<object>? WarningCodes { get; set; }

        /// <summary>
        /// Get or set info codes.
        /// </summary>
        /// <value>
        /// Info codes.
        /// </value>
        [JsonPropertyName("InfoCodes")]
        public List<object>? InfoCodes { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="Response"/> class.
        /// </summary>
        public Response()
        { }
    }
}