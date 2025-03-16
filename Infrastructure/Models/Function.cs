namespace Infrastructure.Models
{
    public class Function
    {
        public Guid Id { get; set; }
        public string? Name { get; init; }
        public string Description { get; set; }
        public Action<object[]> Func { get; set; } = (object[] args) => { };
        public object[] Arguments { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
