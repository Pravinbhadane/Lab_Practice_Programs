using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class String_Pattern
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string[] arr = s.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(arr[j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
