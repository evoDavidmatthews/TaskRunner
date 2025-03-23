namespace TaskManager.Models
{
    internal class Task
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string Description { get; set; }
        public Action<object[]> Action { get; set; } = (args) => { };
    }
}
