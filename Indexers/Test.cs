using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Test
    {
        int age;
        string name;

        public Test(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return name;
                else if(index==2)
                    return age;
                return null;
            }
            set
            {
                if (index == 1)
                    name = (string)value;
                else if (index==2)
                    age = (int)value;
                
            }
        }
    }
}
