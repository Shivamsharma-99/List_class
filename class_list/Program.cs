using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students stu1 = new Students()
            {
                name = "shiva",
                age = 21,
            }; 
            Students stu2 = new Students()
            {
                name = "piyus",
                age = 22,
            };
            List<Students> mystudent = new List<Students>();
            mystudent.Add(stu1);
            mystudent.Add(stu2);
            foreach (Students x in mystudent)
            {
                Console.WriteLine("Name is {0} and age is {1}", x.name, x.age);
            }
            Console.ReadLine();
        }
    }
}
