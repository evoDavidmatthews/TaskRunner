namespace TaskManager.Models
{
    public record TaskDto(Guid Id, string Name, string Description)
    {
        public override string ToString()
        {
            return this.Name;
        }
    };
}
