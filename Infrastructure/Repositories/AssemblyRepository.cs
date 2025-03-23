using Newtonsoft.Json;
using System.Reflection;
using TaskManager.Interfaces;
using TaskManager.Models;


namespace TaskManager.Repositories
{
    internal class AssemblyRepository : IAssemblyRepository
    {
        public IEnumerable<Assembly> GetAssemblies()
        {
            string jsonConfig = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\TaskManagement.Json");
            Config config = JsonConvert.DeserializeObject<Config>(jsonConfig) ?? new();
            string location = config.ExtensionsPath;
            if (!Directory.Exists(location)) Directory.CreateDirectory(location);

            List<string> directories = Directory.GetDirectories(location).ToList();
            directories.Add(location);
            foreach (string directory in directories)
            {
                string[] dllFiles = Directory.GetFiles(directory, "startup.dll");
                foreach (var fileName in dllFiles)
                {
                    string name = fileName.Split("\\")[fileName.Split("\\").Length - 1];

                    string assemblyPath = Path.Combine(directory, name);

                    if (!AppDomain.CurrentDomain.GetAssemblies().Any(a => a.GetName().Name == name.Replace(".dll", "")))
                    {
                        yield return Assembly.LoadFrom(assemblyPath);
                    }

                }
            }
        }
    }

}
