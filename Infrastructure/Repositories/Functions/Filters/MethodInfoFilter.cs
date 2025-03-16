using System.Reflection;

namespace Infrastructure.Repositories.Functions.Filters
{
    class MethodInfoFilter
    {
        public static bool Criteria(MethodInfo m) => m.IsPublic && m.CustomAttributes.Any(AttributeFilter.Criteria);
    }
}
