using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="TimeIntervalsRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{Start} - {End}")]
#endif
    public class TimeInterval
    {
        /// <summary>
        /// Get or set time interval number.
        /// </summary>
        /// <value>
        /// Идентификатор.
        /// </value>
        public string? Number { get; set; }

        /// <summary>
        /// Get or set start of the time interval.
        /// </summary>
        /// <value>
        /// Время начала интервала.
        /// </value>
        public string? Start { get; set; }

        /// <summary>
        /// Get or set end of the time interval.
        /// </summary>
        /// <value>
        /// Время окончания интервала.
        /// </value>
        public string? End { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="TimeInterval"/> class.
        /// </summary>
        public TimeInterval()
        { }
    }
}
