using System.Diagnostics;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос списка ошибок.
    /// </summary>
    [DebuggerDisplay("{MessageDescriptionRU}")]
    public class ErrorMessage
    {
        /// <summary>
        /// Get or set error message code.
        /// </summary>
        /// <value>
        /// Код ошибки.
        /// </value>
        public string? MessageCode { get; set; }

        /// <summary>
        /// Get or set error message text on English.
        /// </summary>
        /// <value>
        /// Описание на Английском языке.
        /// </value>
        public string? MessageText { get; set; }

        /// <summary>
        /// Get or set error message text on Russian.
        /// </summary>
        /// <value>
        /// Описание на русском языке.
        /// </value>
        public string? MessageDescriptionRU { get; set; }

        /// <summary>
        /// Get or set error message text on Ukrainian.
        /// </summary>
        /// <value>
        /// Описание на Украинском языке.
        /// </value>
        public string? MessageDescriptionUA { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="ErrorMessage"/> class.
        /// </summary>
        public ErrorMessage()
        { }
    }
}
