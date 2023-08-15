namespace DotnetWebAPI.Models
{
    public class ExperienceDTO
    {
        public int exp_id { get; set; }
        public string? Title { get; set; }
        public string? Company { get; set; }
        public string? Description { get; set; } = string.Empty;

    }
}
