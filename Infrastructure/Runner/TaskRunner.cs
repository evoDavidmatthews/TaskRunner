using TaskManager.Repositories.Functions;

namespace TaskManager.Runner
{
    internal static class TaskRunner
    {
        internal static void Run(Guid id)
        {
            Models.Task? function = TasksRepository.Instance.Functions.FirstOrDefault(f => f.Id == id);
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
