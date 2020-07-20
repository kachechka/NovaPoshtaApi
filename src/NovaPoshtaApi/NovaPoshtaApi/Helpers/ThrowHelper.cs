using NovaPoshtaApi.Configurations;
using System;
using System.Runtime.CompilerServices;

namespace NovaPoshtaApi.Helpers
{
    class ThrowHelper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfInvalidApiUrl(string apiUrl, string? paramName = null)
        {
            try
            {
                new Uri(apiUrl);
            }
            catch
            {
                throw new ArgumentException(
                    "Invalid API url format",
                    paramName ?? nameof(apiUrl));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfNull(object obj, string paramName = "")
        {
            if (obj is null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfApiConfigInvalid(IApiConfig config, string? paramName = null)
        {
            ThrowIfNull(config, nameof(config));

            if (string.IsNullOrWhiteSpace(config.ApiKey))
            {
                throw new ArgumentException(
                    "Invalid API key format", 
                    paramName ?? nameof(config.ApiKey));
            }
        }
    }
}
