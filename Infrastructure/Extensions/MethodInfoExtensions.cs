using System.Reflection;
using static TaskManager.Repositories.Functions.Filters.AttributeFilter;

namespace TaskManager.Extensions
{
    internal static class MethodInfoExtensions
    {

        internal static Action<object[]> CreateAction(this MethodInfo methodInfo, params object[] parameters)
        {
            // If the method is non-static, create an instance of the class
            object? instance = methodInfo.IsStatic ? null : Activator.CreateInstance(methodInfo.DeclaringType);


            Action<object[]> actionDelegate = (args) =>
            {
                try
                {
                    methodInfo.Invoke(instance, args);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            };

            return actionDelegate;
        }

        internal static CustomAttributeData? GetEntryPointAttribute(this MethodInfo methodInfo)
        {
            return methodInfo.CustomAttributes
                    .FirstOrDefault(HasEntryPointAttribute);
        }

    }
}