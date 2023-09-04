using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{

    public class Employee
    {
        int eid;
        string ename;

        public Employee(int eid, string ename)
        {
            this.eid = eid;
            this.ename = ename;
        }

        public override string ToString()
        {
            return $"{eid}  {ename}";
        }
    }
    public class Department
    {
        int did;
        string dname;
        Employee emp;

        public Department(int did, string dname, Employee emp)
        {
            this .did = did;
            this .dname = dname;
            this .emp = emp;
        }
        public override string ToString()
        {
            return did + " " + dname + " " + emp;
        }

        static void Main(string[] args)
        {
            Department[] dept = new Department[3];

            dept[0] = new Department(101, "HR", new Employee(1, "Pravin"));
            dept[1] = new Department(101, "HR", new Employee(2, "Pawan"));
            dept[2] = new Department(101, "HR", new Employee(3, "kartik"));

            foreach (var item in dept)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<Department> list = new List<Department>();

            list.Add(new Department(101, "HR", new Employee(1, "Pravin")));
            list.Add(new Department(101, "HR", new Employee(2, "Pawan")));
            list.Add( new Department(101, "HR", new Employee(3, "kartik")));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }


}
