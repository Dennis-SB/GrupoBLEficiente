namespace BackEnd.Models
{
    public class NationalIdTypeModel
    {
        public int IdType { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; } = null;
    }
}