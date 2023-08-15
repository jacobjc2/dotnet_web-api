namespace DotnetWebAPI.Models
{
    public class Experience
    {
        public int exp_id { get; set; }
        public string? Title { get; set; }
        public string? Company { get; set; }
        public long Start_date { get; set; }
        public long End_date { get; set; }
        public string? Description { get; set; } = string.Empty;

    }
}
