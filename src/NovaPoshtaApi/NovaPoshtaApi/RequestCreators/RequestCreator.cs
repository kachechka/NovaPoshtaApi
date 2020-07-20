using NovaPoshtaApi.Core.Requests;
using System.Runtime.CompilerServices;

namespace NovaPoshtaApi.RequestCreators
{
    /// <summary>
    /// Request creator.
    /// </summary>
    public class RequestCreator
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="RequestCreator"/> class.
        /// </summary>
        public RequestCreator()
        { }

        /// <summary>Create request by arguments.</summary>
        /// <param name="apiKey">Key to the Nova Poshta API.</param>
        /// <param name="modelName">Model name parameter.</param>
        /// <param name="calledMethod">Called method parameter.</param>
        /// <param name="properties">Method properties parameter.</param>
        /// <returns>Created request.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ApiRequest CreateRequest(string apiKey, string modelName, string calledMethod, object? properties)
        {
            return new ApiRequest
            {
                ApiKey = apiKey,
                ModelName = modelName,
                CalledMethod = calledMethod,
                MethodProperties = properties
            };
        }
    }
}
