using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Min_Character
    {
         static void EvenPoss(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(arr[i]+" ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character");
            char[] arr = new char[5];
            Min_Char(arr);


            Console.WriteLine("Even Position ");
            EvenPoss(arr);
            Console.WriteLine();

            OddSum();
            Console.WriteLine();
        }

        static void OddSum()
        {
            Console.WriteLine("Enter Number for array");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum+=arr[i];
                }
            }
            Console.WriteLine($"Sum = {sum}");
        }
        static void Min_Char(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToChar(Console.ReadLine());
            }
            char min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Minimum Char is {min}");
        }
    }
}
