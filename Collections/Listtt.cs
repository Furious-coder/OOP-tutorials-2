using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Listtt
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            foreach (int i in list)
            {
                Console.Write(i+"   ");
            }
            Console.WriteLine();

            list.Insert(2, 7);
            foreach (int i in list)
            {
                Console.Write(i + "   ");
            }
            Console.WriteLine();

        }
    }
}
