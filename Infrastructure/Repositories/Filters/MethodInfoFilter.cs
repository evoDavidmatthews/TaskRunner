using System.Reflection;

namespace TaskManager.Repositories.Filters
{
    static class MethodInfoFilter
    {
        public static bool DeclaredMethodIsPublicAndHasEntryPointAttribute(MethodInfo m) => m.IsPublic && m.CustomAttributes.Any(AttributeFilter.HasEntryPointAttribute);
    }
}
