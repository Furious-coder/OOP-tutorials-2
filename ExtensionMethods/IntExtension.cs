using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal static class IntExtension
    {
        static long Method(this Int32 i)
        {
            if (i == 0 || i == 1 || i == 2)
            {
                return i;
            }
            else
            {
                return i*Method(i-1);
            }
           
        }
        static void Main(string[] args)
        {
            int i = 3;
           long result = i.Method();
            Console.WriteLine(result);
            
        }
    }
}
