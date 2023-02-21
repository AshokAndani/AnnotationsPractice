using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsPractice
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class TestCaseAttribute : Attribute
    {
        public object[] Parameters;
        public TestCaseAttribute(params object[] parameters)
        {
            this.Parameters = parameters;
        }
    }
}
