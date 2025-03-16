using System.Reflection;

namespace Infrastructure.Repositories.Functions.Filters
{
    class TypeFilter
    {
        public static bool Criteria(TypeInfo t) => t.IsPublic;
    }
}
