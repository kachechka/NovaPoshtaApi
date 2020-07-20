namespace NovaPoshtaApi.Core.Requests
{
    /// <summary>
    /// Запрос временных интервалов.
    /// </summary>
    public class TimeIntervalsRequest
    {
        /// <summary>
        /// Get or set RecipientCityRef request parameter.
        /// </summary>
        /// <value>
        /// Город для которого будут получены часовые интервалы.
        /// </value>
        public string? RecipientCityRef { get; set; }

        /// <summary>
        /// Get or set DateTime request parameter.
        /// </summary>
        /// <value>
        /// Дата на которую будут получены часовые интервалы, необязательный 
        /// параметр, по умолчанию равен текущей дате, формат dd.mm.YYYY.
        /// </value>
        public string? DateTime { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="TimeIntervalsRequest"/> class.
        /// </summary>
        public TimeIntervalsRequest()
        { }
    }
}