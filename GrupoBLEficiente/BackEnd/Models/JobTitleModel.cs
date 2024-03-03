namespace BackEnd.Models
{
    public class JobTitleModel
    {
        public int IdJobTitle { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; } = null;
    }
}