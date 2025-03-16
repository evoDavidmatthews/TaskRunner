namespace Infrastructure.Models
{
    public class FunctionDto
    {
        public Guid Id { get; set; }
        public string? Name { get; init; }
        public string Description { get; set; }
        public List<ArgumentDto> Arguments { get; set; }
    }

}
