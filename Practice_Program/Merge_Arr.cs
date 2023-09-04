using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Merge_Arr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Array");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter 2nd Array");
            int[] arr2 = new int[5];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());

            }
            MergeArrays(arr,arr2);

        }

        static void MergeArrays(int[] arr, int[] arr2)
        {
            int length = arr.Length + arr2.Length;

            int[] result = new int[length];

            int i = 0, j = 0, k=0;

            while (i < length)
            {
                    while (j < arr.Length)
                    {
                        for (int index = 0; index < length; index++)
                        {
                            if (result[index] != arr[j])
                            {
                                result[i] = arr[j];
                                i++; j++;
                            }
                        }
                        
                    }
                        for (int index = 0; index < length; index++)
                        {
                            if (result[index] != arr2[k])
                            {
                                result[i] = arr2[k];
                                i++; k++;
                            }
                   
                        }
            }

            foreach (var item in result)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }

    class Move_Zero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array");
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            ZeroToEnd(arr);
        }
        static void ZeroToEnd(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == 0)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
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
