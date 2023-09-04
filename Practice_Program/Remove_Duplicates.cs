using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Remove_Duplicates
    {
        static void Main(string[] args)
        {
            List<int> inputList = new List<int>();
            List<int> uniqueList = new List<int>();

            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            foreach (string number in numbers)
            { 
                    inputList.Add(Convert.ToInt32(number)); 
            }

            foreach (int num in inputList)
            {
                if (!uniqueList.Contains(num))
                {
                    uniqueList.Add(num);
                }
            }

            foreach (int num in uniqueList)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}
