namespace TaskRunner.Models
{
    internal class Task
    {
        internal string Name { get; set; } = string.Empty;
        internal string Description { get; set; } = string.Empty;
        internal Guid Id { get; set; }

        // Implicit conversion from tuple to Function
        public static implicit operator Task((string? name, string description, Guid id) tuple)
        {
            return new Task
            {
                Name = tuple.name ?? string.Empty, // Handle nullability
                Description = tuple.description,
                Id = tuple.id
            };
        }

        // Implicit conversion from Function to tuple
        public static implicit operator (string? name, string description, Guid id)(Task func)
        {
            return (func.Name, func.Description, func.Id);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
