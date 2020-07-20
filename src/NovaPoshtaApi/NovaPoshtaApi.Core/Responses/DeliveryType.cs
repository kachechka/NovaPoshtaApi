﻿using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="DeliveryTypesRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{Description}")]
#endif
    public class DeliveryType
    {
        /// <summary>
        /// Get or set delivery type description.
        /// </summary>
        /// <value>
        /// Описание на Украинском.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set delivery type ref.
        /// </summary>
        /// <value>
        /// Идентификатор.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="DeliveryType"/> class.
        /// </summary>
        public DeliveryType()
        { }
    }
}
