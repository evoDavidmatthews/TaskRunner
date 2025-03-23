namespace TaskManager.Factories
{
    using System.Diagnostics.CodeAnalysis;
    using TaskManager.Runner;

    [ExcludeFromCodeCoverage]
    internal static class TaskRunnerFactory
    {
        private static readonly Lazy<TaskRunner> _instance =
            new Lazy<TaskRunner>(
                () => new TaskRunner(TaskRepositoryFactory.Instantiate())
        );

        public static TaskRunner Instantiate() => _instance.Value;
    }
}
