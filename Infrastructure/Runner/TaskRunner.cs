namespace TaskManager.Runner
{
    using TaskManager.Interfaces;
    using TaskManager.Repositories;

    internal class TaskRunner(TasksRepository tasksRepository) : ITaskRunner
    {
        private readonly TasksRepository _tasksRepository = tasksRepository;

        public void Run(Guid id)
        {
            Models.Task? function = _tasksRepository.Functions.FirstOrDefault(f => f.Id == id);
            if (function == null)
            {
                Console.WriteLine($"no function found by id {id}");
                return;
            }

            Console.WriteLine($"invoking {function!.Name} in seperate thread");
            System.Threading.Tasks.Task t = System.Threading.Tasks.Task.Run(() =>
            {
                function.Action.Invoke([]);
            });
            Console.WriteLine($"succesfully invoked on task id {t.Id}");
        }
    }
}
