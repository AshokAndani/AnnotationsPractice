using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsPractice
{
    internal class AttributeExtractor
    {
        public static void ExtractTestAttribute()
        {
            var assembly = Assembly.GetExecutingAssembly();
            foreach (var type in assembly.GetTypes())
            {


                foreach (var method in type.GetMethods())
                {
                    foreach (var attribute in method.GetCustomAttributes<TestCaseAttribute>())
                    {
                        var instance = Activator.CreateInstance(type);
                        method.Invoke(instance, attribute.Parameters);
                    }
                }

            }


        }
        public static void ExtractTestCaseAttribute()
        {
            var type = typeof(Employee);

            List<MethodInfo> methods = new List<MethodInfo>();

            foreach (var method in type.GetMethods())
            {
                var attributes = method.GetCustomAttributes();
                foreach (var attribute in attributes)
                {

                    if (attribute is TestAttribute)
                    {
                        methods.Add(method);
                    }
                }
            }
            var instance = Activator.CreateInstance(type);
            foreach (var method in methods)
            {
                method.Invoke(instance, null);
            }
        }
    }
}
