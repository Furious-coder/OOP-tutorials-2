using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class One
    {
        public static void Main(string[] args)
        {
            int[] arr = { 22, 34, 12, 3, 4, 5, 33, 245, 533, 44, 52, 66 };
            var brr = from i in arr orderby i select i;
            foreach ( int a in brr ) 
            {
                Console.Write(a + " ");
            }
        }
    }
}
