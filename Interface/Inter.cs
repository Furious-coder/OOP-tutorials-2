using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface Inter
    {
        public int Add(int x, int y);
        public int Subtract(int x, int y);
    }

    public class Task : Inter
    {
       

       public int Add(int x, int y)
        {
            return x + y;
        }

       public int Subtract(int x, int y)
        {
            return x - y;
        }

        public static void Main(string[] args)
        {
            Task task = new Task();
            Console.WriteLine(task.Subtract(1, 2));
           Console.WriteLine( task.Add(1, 2)); 
        }
    }
}
