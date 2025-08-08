namespace Portfolio.Models
{
    public class Project
    {
        public required string Title { get; set; }
        public string FrontImage { get; set; } =null!;
        public string Description { get; set; } = null!;
        public string Content { get; set; } = null!;
        public List<string> Tecnologies { get; set; } = [];

    }
}
