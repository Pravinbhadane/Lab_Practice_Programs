using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Employee_List
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Id { get; set; }

        static void Main(string[] args)
        {
            List<Employee_List> list = new List<Employee_List>();

            list.Add(new Employee_List() { Name = "Pravin", Salary= 50000, Id=1 }) ;
            list.Add(new Employee_List() { Name = "Pawan", Salary = 20000 , Id = 2 });
            list.Add(new Employee_List() { Name = "Kartik", Salary = 70000, Id= 3 });
            list.Add(new Employee_List() { Name = "Piyush", Salary = 70000, Id = 4 });
            list.Add(new Employee_List() { Name = "Rishabh", Salary = 70000, Id = 5 });


            List<string> list2 = new List<string>();

            Dictionary<double, List<string>> emp = new Dictionary<double, List<string>>();

            foreach (Employee_List item in list)
            {
                if (emp.ContainsKey(item.Salary))
                { 
                list2 = emp[item.Salary];
                    list2.Add(item.Name);
                    }
                else
                {
                    list2 = new List<String>();
                    list2.Add(item.Name);                   
                }
                if(!emp.ContainsKey(item.Salary))
                emp.Add(item.Salary, list2);
               
            }

            foreach(KeyValuePair<double,List<string>> item in emp)
            {
                List<String> li = item.Value;

                Console.Write(item.Key+" ");
                foreach(String str in li)
                {
                    Console.Write(  str+" ");
                }
                Console.WriteLine(  );

            }

            Console.WriteLine();
            CheckSalary(list);
            Console.WriteLine();
            IncreaseSalary(list);
           
        }
        

        static void CheckSalary(List<Employee_List> list)
        {
            Console.WriteLine(" Employee whose Salary is greater than 25k");
            foreach (Employee_List item in list)
            {
                if (item.Salary > 25000)
                    Console.WriteLine(item.Name + " " + item.Salary + " " + item.Id);
            }
        }

        static void IncreaseSalary(List<Employee_List> list)
        {
            Console.WriteLine(" Employee whose Salary is less than 25k increased by 10%");
            foreach (Employee_List item in list)
            {
                if (item.Salary < 25000)
                {
                    item.Salary = (item.Salary + item.Salary * 0.10);
                    
                }
                Console.WriteLine();
                foreach (Employee_List i in list)
                {
                    Console.WriteLine(i.Name + " " + i.Salary + " " + i.Id);
                }
            }
        }

        

    }
}
