using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Sorting_Arr
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] arr = str.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    string temp;
                    if (arr[i].Length > arr[j].Length)
                    {
                        temp =arr[i];
                       arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    else if (arr[i].Length == arr[j].Length)
                    {
                      int result= arr[i].CompareTo(arr[j]);

                        if(result == -1)
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        } 
                    }

                }
            }
            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
