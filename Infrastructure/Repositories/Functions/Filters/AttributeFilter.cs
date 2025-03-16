using System.Reflection;

namespace Infrastructure.Repositories.Functions.Filters
{
    class AttributeFilter
    {
        private static string EntryPointAttribute = "EntryPointAttribute";
        public static bool Criteria(CustomAttributeData ca) => ca.AttributeType.Name == EntryPointAttribute;
    }
}
