using System.Reflection;
using TaskManager.Extensions;
using TaskManager.Models;


namespace TaskManager.Repositories.Functions
{

    /// <summary>
    /// the complexity is for ensuring that the assemblies and tasks only loaded into memory once
    /// </summary>
    internal class TasksRepository
    {
        #region SingleTonContruction

        private static readonly Lazy<TasksRepository> _instance =
            new Lazy<TasksRepository>(
                () => new TasksRepository(new AssemblyRepository())
                );

        private readonly AssemblyRepository _assemblyRepository;

        // Private constructor to prevent external instantiation
        private TasksRepository(AssemblyRepository assemblyRepository)
        {
            _assemblyRepository = assemblyRepository;
            LoadFunctionsIntoMemory();
        }

        // Public accessor for the singleton instance
        internal static TasksRepository Instance => _instance.Value;

        #endregion



        internal List<Models.Task> Functions { get; set; } = new List<Models.Task>();

        private void LoadFunctionsIntoMemory()
        {
            try
            {
                //get assemblies
                IEnumerable<Assembly> assemblies = _assemblyRepository.GetAssemblies();
                //get public classes
                List<TypeInfo> typeInfos = assemblies.GetPublicTypes();
                //get public methods with entry point attribute
                IEnumerable<MethodInfo> memeberInfos = typeInfos.GetPublicMethods();

                foreach (MethodInfo methodInfo in memeberInfos)
                {
                    try
                    {
                        CustomAttributeData? entryPointAttribute = methodInfo.GetEntryPointAttribute();
                        List<CustomAttributeTypedArgument> entryPointArgs = entryPointAttribute?.ConstructorArguments.ToList() ?? [];

                        Models.Task function = new Models.Task();
                        function.Id = Guid.NewGuid();
                        function.Name = methodInfo!.Name;
                        function.Action = methodInfo.CreateAction();
                        function.Description = entryPointArgs.GetDescription();
                        Functions.Add(function);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"could not load function {methodInfo!.Name} due to: {e.Message}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"problem loading assemblies");
            }

        }
    }
}
