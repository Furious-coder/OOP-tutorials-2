using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ArrList
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(20);
            Console.WriteLine(al.Capacity);
            al.Add(50);al.Add(60);al.Add(90);

            foreach(object o in al)
            {
                Console.Write(o+"   ");
               
            }
            Console.WriteLine();
            al.Insert(4,60);

            foreach (object o in al)
            {
                Console.Write(o + "   ");
                
            }
            Console.WriteLine();
            al.RemoveAt(1);

            foreach (object o in al)
            {
                Console.Write(o + "   ");

            }
            Console.WriteLine();

        }
    }
}
