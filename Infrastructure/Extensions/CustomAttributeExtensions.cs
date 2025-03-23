using System.Reflection;

namespace TaskManager.Extensions
{
    internal static class CustomAttributeExtensions
    {
        internal static string GetDescription(this List<CustomAttributeTypedArgument> ConstructorArguments)
        {
            return ConstructorArguments.FirstOrDefault()
            .Value?.ToString() ?? "no description";
        }
    }
}