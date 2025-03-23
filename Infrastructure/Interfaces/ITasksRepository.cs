namespace TaskManager.Interfaces
{
    internal interface ITasksRepository
    {
        List<Models.Task> Functions { get; set; }
    }
}