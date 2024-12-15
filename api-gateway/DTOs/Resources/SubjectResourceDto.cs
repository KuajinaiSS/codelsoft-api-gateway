namespace api_gateway.DTOs.Resources
{
    public class SubjectResourceDto : BaseModelDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Semester { get; set; }
    }
}