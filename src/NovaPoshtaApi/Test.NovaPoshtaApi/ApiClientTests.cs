using NovaPoshtaApi.ApiClients;
using NovaPoshtaApi.Core.Requests;
using NovaPoshtaApi.Core.Responses;
using NovaPoshtaApi.RequestCreators;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Test.NovaPoshtaApi
{
    public class ApiClientTests
    {
        [Theory]
        [MemberData(nameof(InvalidDataForApiClientConnection))]
        public void InitializeInstance_WithInvalidParameters_ThrowsException(string apiUrl, HttpClient client)
        {
            // Arrange

            // Act
            void creating() => new ApiHttpClient(apiUrl, client);

            // Assert
            Assert.ThrowsAny<ArgumentException>(creating);
        }

        [Theory]
        [MemberData(nameof(ValidDataForApiClientConnection))]
        public void InitializerInstance_WithValidParameters_InitiateNewInstace(string apiUrl, HttpClient client)
        {
            // Arrange

            // Act
            var apiClient = new ApiHttpClient(apiUrl, client);

            // Assert
            Assert.NotNull(apiClient);
        }

        [Theory]
        [MemberData(nameof(ValidRequests))]
        public async Task SendRequest_WithValidParamaters_ReturnsSuccessResponse(IApiRequest request)
        {
            // Arrange
            var httpClient = new HttpClient();
            var client = new ApiHttpClient(ApiUrl, httpClient);

            // Act
            var leftResponse = await client.RequestForResponseAsync<TimeInterval>(request);

            // Assert
            Assert.True(leftResponse.Success);
        }

        [Theory]
        [MemberData(nameof(InvalidRequests))]
        public async Task SendRequest_WithInvalidParameters_ReturnsFailResponse(IApiRequest request)
        {
            // Arrange
            var httpClient = new HttpClient();
            var client = new ApiHttpClient(ApiUrl, httpClient);

            // Act
            var leftResponse = await client.RequestForResponseAsync<TimeInterval>(request);

            // Assert
            Assert.False(leftResponse.Success);
        }

        #region Test data
        public static readonly string ApiUrl = "https://api.novaposhta.ua/v2.0/json/";
        public static readonly string ApiKey = "edf648c81ce20d4748489c8fad8995c2";

        public static IEnumerable<object[]> InvalidDataForApiClientConnection
            => new List<object[]>
            {
                new object[] { null!, null! },
                new object[] { "", null! },
                new object[] { "some.invalid&url@", null! },
                new object[] { "https://github.com/", null! }
            };

        public static IEnumerable<object[]> ValidDataForApiClientConnection
            => new List<object[]>
            {
                new object[] { "https://github.com/", new HttpClient() },
                new object[] { "https://api.novaposhta.ua/v2.0/json/", new HttpClient() }
            };

        public static IEnumerable<object[]> ValidRequests
        {
            get
            {
                var creator = new DirectoryRequestCreator();

                return new List<object[]>
                {
                    new object[] { creator.CreateGetCargoTypes(ApiKey) },
                    new object[] { creator.CreateGetBackwardPayerTypes(ApiKey) }
                };
            }
        }

        public static IEnumerable<object[]> InvalidRequests
        {
            get
            {
                var creator = new RequestCreator();

                return new List<object[]>
                {
                    new object[] { creator.CreateRequest(ApiKey, "invalid_model", "", null) },
                    new object[] { creator.CreateRequest(ApiKey, "Common", "invalid_calledMethod", null) },
                    new object[] { creator.CreateRequest("invalid_key", "Common", "invalid_calledMethod", null) },
                    new object[] { creator.CreateRequest("invalid_key", "Common", "getCargoTypes", null) }

                };
            }
        }
        #endregion
    }
}