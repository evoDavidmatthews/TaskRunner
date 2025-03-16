using System.Reflection;

namespace Infrastructure.Extensions
{
    internal static class MethodInfoExtensions
    {

        internal static Action<object[]> CreateAction(this MethodInfo methodInfo, params object[] parameters)
        {
            // If the method is non-static, create an instance of the class
            object? instance = methodInfo.IsStatic ? null : Activator.CreateInstance(methodInfo.DeclaringType);


            Action<object[]> actionDelegate = (object[] args) =>
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
    }
}