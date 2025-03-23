using System.Reflection;

namespace TaskManager.Repositories.Functions.Filters
{
    class TypeFilter
    {
        public static bool TypeInfoIsPublic(TypeInfo t) => t.IsPublic;
    }
}
