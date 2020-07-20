using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="OwnershipTypesRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{FullName}")]
#endif
    public class OwnershipType
    {
        /// <summary>
        /// Get or set ownership type ref.
        /// </summary>
        /// <value>
        /// Идентификатор.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Get or set ownership type description.
        /// </summary>
        /// <value>
        /// Описание на Украинском.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set ownership type full name.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMENT
        public string? FullName { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="OwnershipType"/> class.
        /// </summary>
        public OwnershipType()
        { }
    }
}
