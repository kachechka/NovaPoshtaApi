namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Расписание.
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// Get or set schedule for Monday.
        /// </summary>
        /// <value>
        /// Время работы в понедельник.
        /// </value>
        public string? Monday { get; set; }

        /// <summary>
        /// Get or set schedule for Tuesday.
        /// </summary>
        /// <value>
        /// Время работы во вторник.
        /// </value>
        public string? Tuesday { get; set; }

        /// <summary>
        /// Get or set schedule for Wednesday.
        /// </summary>
        /// <value>
        /// Время работы в среду.
        /// </value>
        public string? Wednesday { get; set; }

        /// <summary>
        /// Get or set schedule for Thursday.
        /// </summary>
        /// <value>
        /// Время работы в четверг.
        /// </value>
        public string? Thursday { get; set; }

        /// <summary>
        /// Get or set schedule for Friday.
        /// </summary>
        /// <value>
        /// Время работы в пятницу.
        /// </value>
        public string? Friday { get; set; }

        /// <summary>
        /// Get or set schedule for Saturday.
        /// </summary>
        /// <value>
        /// Время работы в субботу.
        /// </value>
        public string? Saturday { get; set; }

        /// <summary>
        /// Get or set schedule for Sunday.
        /// </summary>
        /// <value>
        /// Время работы в воскресенье.
        /// </value>
        public string? Sunday { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="Schedule"/> class.
        /// </summary>
        public Schedule()
        { }
    }
}
