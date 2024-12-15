using api_gateway.DTOs.Resources;

namespace api_gateway.Microservices.Interfaces
{
    public interface IResourceMicroservice
    {
        public Task<List<SubjectResourceDto>> GetAllSubjectResources();
        public Task<List<ResourceDto>> GetSubjectResourceById(int id);
    }
}