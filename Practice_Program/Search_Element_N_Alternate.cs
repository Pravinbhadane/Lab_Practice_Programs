using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Search_Element_N_Alternate
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Element to search");
            int number =  Convert.ToInt32(Console.ReadLine());

            FindElement(arr, number);
            Console.WriteLine();

            Alternate_Element(arr);
        }

        static void FindElement(int[] arr, int number)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    Console.WriteLine($"Present at index{i} = {arr[i]}");
                    break;
                }
            }
            Console.WriteLine("Element Not Present");
        }
        static void Alternate_Element(int[] arr)
        {
            for(int i = 0;i < arr.Length;i=i+2)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
