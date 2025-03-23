using System.Reflection;

namespace TaskManager.Repositories.Filters
{
    class TypeFilter
    {
        public static bool TypeInfoIsPublic(TypeInfo t) => t.IsPublic;
    }
}
