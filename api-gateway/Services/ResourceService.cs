using api_gateway.DTOs.Resources;
using api_gateway.Microservices.Interfaces;
using api_gateway.Services.Interfaces;

namespace api_gateway.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IResourceMicroservice _resourceMicroservice;

        public ResourceService(IResourceMicroservice resourceMicroservice)
        {
            _resourceMicroservice = resourceMicroservice;
        }

        public async Task<List<SubjectResourceDto>> GetAllSubjectResources()
        {
            return await _resourceMicroservice.GetAllSubjectResources();
        }

        public async Task<List<ResourceDto>> GetSubjectResourceById(int id)
        {
            return await _resourceMicroservice.GetSubjectResourceById(id);
        }
    }
}