namespace TaskManager.Factories
{
    using TaskManager.Repositories.Functions;
    internal static class TaskRepositoryFactory
    {
        private static readonly Lazy<TasksRepository> _instance =
            new Lazy<TasksRepository>(
                () => new TasksRepository(new AssemblyRepository())
        );

        public static TasksRepository Instantiate() => _instance.Value;
    }
}
