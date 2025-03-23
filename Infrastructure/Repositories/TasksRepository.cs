namespace TaskManager.Repositories
{

    using System.Reflection;
    using TaskManager.Extensions;
    using TaskManager.Interfaces;

    /// <summary>
    /// the complexity is for ensuring that the assemblies and tasks only loaded into memory once
    /// </summary>
    internal class TasksRepository : ITasksRepository
    {
        private readonly AssemblyRepository _assemblyRepository;

        // Private constructor to prevent external instantiation
        internal TasksRepository(AssemblyRepository assemblyRepository)
        {
            _assemblyRepository = assemblyRepository;
            LoadFunctionsIntoMemory();
        }

        public List<Models.Task> Functions { get; set; } = new List<Models.Task>();

        private void LoadFunctionsIntoMemory()
        {
            try
            {
                IEnumerable<Assembly> assemblies = _assemblyRepository.GetAssemblies();
                List<TypeInfo> typeInfos = assemblies.GetPublicTypes();
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
