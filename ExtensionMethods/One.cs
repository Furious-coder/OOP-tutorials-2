using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class One
    {
        public void Method1()
        {
            Console.WriteLine("One called");

        }
        public void Method2()
        {
            Console.WriteLine("Two called");

        }

        public static void Main(string[] args)
        {
            One o = new One();
        }
    }
}
