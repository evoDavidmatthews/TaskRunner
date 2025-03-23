using System.Collections.Generic;
using System.Reflection;
using static TaskManager.Repositories.Functions.Filters.TypeFilter;

namespace TaskManager.Extensions
{
    internal static class AssemblyExtensions
    {
        private static string currentType = "";
        internal static List<TypeInfo> GetPublicTypes(this IEnumerable<Assembly> assemblies)
        {
            List<TypeInfo> types = new List<TypeInfo>();
            foreach (var assembly in assemblies)
            {
                try
                {
                    foreach (var type in assembly.DefinedTypes)
                    {
                        currentType = type.Assembly.GetName().Name ?? "";
                        if (TypeInfoIsPublic(type))
                        {
                            types.Add(type);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine($"unable to load type {currentType}");
                }
            }
            return types;
        }
    }
}