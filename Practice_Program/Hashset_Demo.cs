using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Hashset_Demo
    {
        class Student
        {
         
            public int ID { get; set; }
            public int Marks { get; set; }
        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();


            list.Add(new Student() { ID = 1,Marks=50 });
            list.Add(new Student() { ID =2 ,Marks=40 });
            list.Add(new Student() { ID = 3 , Marks=70});
            list.Add(new Student() { ID = 3 , Marks=60});
            list.Add(new Student() { ID = 1, Marks=80});
          
            HashSet<Student> set = new HashSet<Student>();

            foreach (var item in list)
            {
                set.Add(item);
            }
            foreach (Student item in set)
            {
                Console.WriteLine(item.ID+" "+item.Marks);
            }
        }
    }
}
