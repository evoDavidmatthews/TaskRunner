using System.Reflection;
using static TaskManager.Repositories.Filters.MethodInfoFilter;

namespace TaskManager.Extensions
{
    internal static class TypeInfoExtensions
    {
        internal static IEnumerable<MethodInfo> GetPublicMethods(this IEnumerable<TypeInfo> typeInfos)
        {
            return typeInfos.SelectMany(
                type => type.DeclaredMethods.Where(
                    DeclaredMethodIsPublicAndHasEntryPointAttribute)
                );
        }
    }
}