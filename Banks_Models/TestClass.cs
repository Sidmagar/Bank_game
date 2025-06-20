using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks_Models
{
    public class TestClass
    {
        private TestClass()
        {
            Console.WriteLine("In private Constructor");

        }
        public TestClass(string name)
        {
            Console.WriteLine($"In public constructor {name}");
        }
    }




}
