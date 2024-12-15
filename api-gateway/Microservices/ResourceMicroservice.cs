using System.Text.Json;
using api_gateway.DTOs.Resources;
using api_gateway.Microservices.Interfaces;

namespace api_gateway.Microservices
{
    public class ResourceMicroservice : IResourceMicroservice
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "http://localhost:80/api/Resources";
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public ResourceMicroservice(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<SubjectResourceDto>> GetAllSubjectResources()
        {
            return await SendRequestAsync<List<SubjectResourceDto>>($"{_baseUrl}");
        }

        public async Task<List<ResourceDto>> GetSubjectResourceById(int id)
        {
            return await SendRequestAsync<List<ResourceDto>>($"{_baseUrl}/{id}");
        }

        private async Task<T> SendRequestAsync<T>(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<T>(content, _jsonOptions) ?? Activator.CreateInstance<T>();
                }

                HandleErrorResponse(response.StatusCode);
            }
            catch (HttpRequestException ex)
            {
                // Log the exception or rethrow for higher-level handling
                throw new Exception($"Error occurred while making HTTP request: {ex.Message}");
            }

            return Activator.CreateInstance<T>();
        }

        private void HandleErrorResponse(System.Net.HttpStatusCode statusCode)
        {
            switch (statusCode)
            {
                case System.Net.HttpStatusCode.Unauthorized:
                    throw new UnauthorizedAccessException("Unauthorized access to resource.");
                case System.Net.HttpStatusCode.NotFound:
                    throw new Exception("Resource not found.");
                default:
                    throw new Exception($"Unexpected HTTP response: {statusCode}");
            }
        }
    }
}
