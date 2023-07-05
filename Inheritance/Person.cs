using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

    public class Student : Person
    {
        public string Class { get; set; }
        public string Marks { get; set; }
        public string Grade { get; set; }
        public string Fees { get; set; }

    }

    public class Post: Person
    {
        public string Designation { get; set; }
        public int Salary { get; set; }

    }

    public class Tstaff : Post
    {
        public string Subject { get; set; }
        public string Qualification { get; set; }

    }

    public class NTstaff : Post
    {
        public string Dname { get; set; }
        public string Mgrld { get; set; }
    }
    public class Access : Post
    {
        public static void Main(string[] args)
        {
            NTstaff nt = new NTstaff();
            nt.Name = "Ishan";
            nt.Salary = 254400;
            nt.Address = "KTM";
            nt.Mgrld = "esrv";
            nt.Designation = "Developer";
            nt.Dname = "IT";
            nt.Phone = "8666";
            nt.Id = 2;
            Console.WriteLine(nt.Name);
        }
    }
}
