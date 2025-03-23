namespace TaskManager
{
    using TaskManager.Repositories.Functions;
    using TaskManager.Runner;

    public static class TaskManagement
    {
        public static IEnumerable<(string? name, string description, Guid id)> GetTasks()
        {
            TasksRepository taskRepository = TasksRepository.Instance;
            return taskRepository.Functions.Select(Func => (Func.Name, Func.Description, Func.Id));
        }

        public static void RunTask(Guid id)
        {
            TaskRunner.Run(id);
        }
    }
}
