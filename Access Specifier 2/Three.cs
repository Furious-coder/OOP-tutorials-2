using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Specifier_2
{
    public class Three:Access_Specifiers.One
    {
       static void Main(string[] args)
        {
            Three three = new Three();
            three.three();
            three.five();
            three.two();
        }
    }
  
}
