using System.Reflection;

namespace TaskManager.Interfaces
{
    internal interface IAssemblyRepository
    {
        IEnumerable<Assembly> GetAssemblies();
    }
}