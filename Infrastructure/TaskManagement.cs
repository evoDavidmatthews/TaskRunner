namespace TaskManager
{
    using System.Data.Common;
    using TaskManager.Factories;
    using TaskManager.Models;
    using TaskManager.Repositories.Functions;
    using TaskManager.Runner;


    /// <summary>
    /// Facade to abstract all the complexity of the task management
    /// </summary>
    public class TaskManagement
    {
        /// <summary>
        /// This method will return you the tasks it is able to resolve at runtime.<br/>
        /// <br/>
        /// It is important to note that the loading of all the functions is only done on the first call of this function.<br/>
        /// The tasks will be held in the memory of a singleton repository.<br/>
        /// The Second call will only retrieve tasks from the cached list.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<TaskDto> GetTasks()
        {
            TasksRepository taskRepository = TaskRepositoryFactory.Instantiate();
            return taskRepository.Functions.Select(Func => new TaskDto(Func.Id, Func.Name ?? "", Func.Description));
        }

        /// <summary>
        /// This function will instruct the back end to run the task you have retrieved.<br/>
        /// <br/>
        /// If you are wondering where to get the TaskDto object from. Please call the function <b>TaskManagment.GetTasks</b><br/>
        /// for a list of tasks that are runnable.
        /// </summary>
        /// <param name="taskDto"></param>
        public static void RunTask(TaskDto taskDto)
        {
            TaskRunner.Run(taskDto.Id);
        }

        /// <summary>
        /// This function will instruct the back end to run the task you have retrieved.<br/>
        /// <br/>
        /// If you are wondering where to get the Guid id from. Please call the function <b>TaskManagment.GetTasks</b><br/>
        /// for a list of tasks that are runnable. The Guid will be a property of the returnd TaskDto
        /// </summary>
        /// <param name="taskDto"></param>
        public static void RunTask(Guid id)
        {
            TaskRunner.Run(id);
        }
    }
}
