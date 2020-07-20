using NovaPoshtaApi.Core.Requests;
using NovaPoshtaApi.Core.Responses;
using System.Threading.Tasks;

namespace NovaPoshtaApi.ApiClients
{
    /// <summary>
    /// Api client.
    /// </summary>
    public interface IApiHttpClient
    {
        /// <summary>
        /// Send <paramref name="request"/> to the API.
        /// </summary>
        /// <typeparam name="T">
        /// Reponse type.
        /// </typeparam>
        /// <param name="request">
        /// Request to the API.
        /// </param>
        /// <returns>
        /// Reponse from API.
        /// </returns>
        Task<T> RequestAsync<T>(IApiRequest request);

        /// <summary>
        /// Send <paramref name="request"/> to the API.
        /// </summary>
        /// <typeparam name="T">
        /// Reponse item type.
        /// </typeparam>
        /// <param name="request">
        /// Request to the API.
        /// </param>
        /// <returns>
        /// Reponse from API.
        /// </returns>
        Task<ApiResponse<T>> RequestForResponseAsync<T>(IApiRequest request);
    }
}
