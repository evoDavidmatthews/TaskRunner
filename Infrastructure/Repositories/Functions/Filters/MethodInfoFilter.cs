using System.Reflection;

namespace TaskManager.Repositories.Functions.Filters
{
    static class MethodInfoFilter
    {
        public static bool DeclaredMethodIsPublicAndHasEntryPointAttribute(MethodInfo m) => m.IsPublic && m.CustomAttributes.Any(AttributeFilter.HasEntryPointAttribute);
    }
}
