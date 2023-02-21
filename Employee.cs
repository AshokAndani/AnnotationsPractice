using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsPractice
{
    public class Employee
    {
        [Test]
        public void DoSomething()
        {
            Console.WriteLine("I got called");
        }
        [Test]
        public void sjdbfjbsdf()
        {
            Console.WriteLine("sdbfhjdf method called");
        }
        [Test]
        public void PickMe2()
        {
            Console.WriteLine("PickMe2 method called");
        }
        [TestCase("Hey", "Hi")]
        [TestCase("Hello", "How Are you")]
        public void PickMe(string a, string b)
        {
            Console.WriteLine("2 string parameterized method called {0}: {1}", a, b);
        }
        [TestCase("Hey")]
        public void PickMe3(string name)
        {
            Console.WriteLine("PickMe3 with TestCase called" + name);
        }
    }
}
