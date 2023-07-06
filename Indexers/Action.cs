using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Action
    {
        public static void Main(string[] args)
        {
            Test t = new Test("Ishan", 23);
            Console.WriteLine(t[1]);
            Console.WriteLine(t[2]);
            t[1] = "Laptop";
            t[2] = 18;
            Console.WriteLine(t[1]);
            Console.WriteLine(t[2]);
        }
    }
}
