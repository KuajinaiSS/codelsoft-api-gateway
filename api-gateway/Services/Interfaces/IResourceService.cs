using api_gateway.DTOs.Resources;

namespace api_gateway.Services.Interfaces
{
    public interface IResourceService
    {
        public Task<List<SubjectResourceDto>> GetAllSubjectResources();
        public Task<List<ResourceDto>> GetSubjectResourceById(int id);
    }
}