using System.Reflection;

namespace TaskManager.Repositories.Functions.Filters
{
    static class AttributeFilter
    {
        private static string EntryPointAttribute = "EntryPointAttribute";
        public static bool HasEntryPointAttribute(CustomAttributeData ca) => ca.AttributeType.Name == EntryPointAttribute;
    }
}
