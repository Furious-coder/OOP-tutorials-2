using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    class StaticConstructor
    {
        public StaticConstructor() 
        {
            Console.WriteLine("This will execute at last"); //non-static constructor -- needs to be called from Main -- executed at first
        }  
        static StaticConstructor()
        {
            Console.WriteLine("Static constructor called"); //static constructor -- does not need any calls
        }
        

        public static void Main()
        {
            Console.WriteLine("Main method called");
            StaticConstructor c = new StaticConstructor(); //non-static constructor is called
        }
    }
}
