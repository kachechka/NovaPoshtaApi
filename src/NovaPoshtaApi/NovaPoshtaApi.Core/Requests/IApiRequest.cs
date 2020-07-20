using System.Net.Http;

namespace NovaPoshtaApi.Core.Requests
{
    public interface IApiRequest
    {
        HttpContent Content { get; }
    }
}
