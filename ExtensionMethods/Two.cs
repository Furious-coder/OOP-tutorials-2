using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal static class Two
    {
        static void Method3(this One o)
        {
            Console.WriteLine("Three called");
        }
        public static void Main(string[] args)
        {
            One o = new One();
            o.Method1();
            o.Method2();
            o.Method3();
        }
    }
}
