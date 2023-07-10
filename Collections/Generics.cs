using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Generics : IComparable<Generics>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Generics other)
        {
            if(this.ID>other.ID)
                return 1;
            else if(this.ID < other.ID) return -1; else return 0;
        }
    }

    public class Action
    {
        public static void Main(string[] args)
        {
            Generics g1 = new Generics {ID=22, Name="IShan", Age=23 };
            Generics g2 = new Generics { ID = 2, Name = "Nishan", Age = 28 };
            Generics g3 = new Generics { ID = 5, Name = "hishan", Age = 28 };
            List<Generics> Gen = new List<Generics>() { g1, g2, g3 };
            Gen.Sort();

            foreach (Generics gen in Gen)
            {
                Console.WriteLine(gen.ID+" "+gen.Name+" "+gen.Age);

            }
        }

        
    }
}
