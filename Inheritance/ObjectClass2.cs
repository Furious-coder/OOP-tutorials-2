using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ObjectClass2:ObjectClass1
    {
        public static void Main(String[] args)
        {
            ObjectClass2 obj= new ObjectClass2();
           Console.WriteLine(obj.method());
        }
    }
}
