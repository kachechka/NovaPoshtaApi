using NovaPoshtaApi.Core.Requests;
using System.Runtime.CompilerServices;

namespace NovaPoshtaApi.RequestCreators
{
    /// <summary>
    /// Express waybill requests creator.
    /// </summary>
    public class ExpressWaybillRequestCreator : RequestCreator
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="ExpressWaybillRequestCreator"/> class.
        /// </summary>
        public ExpressWaybillRequestCreator()
        { }

        /// <summary>
        /// Create request for getting tracking info about documents.
        /// </summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="properties">Method properties for the request.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateGetTrackings(string apiKey, TrackingRequest properties)
            => CreateRequest(apiKey, "TrackingDocument", "getStatusDocuments", properties);

        // TODO: add creating express waybill requests
    }
}
