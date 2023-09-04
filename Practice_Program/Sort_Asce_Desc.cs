using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    public class Sort_Asce_Desc
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int half = arr.Length / 2;
            int length = arr.Length;

            SortInAsce(arr, half, length);
            SortInDesce(arr, half);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] SortInDesce(int[] arr, int half)
        {
            for (int i = 0; i < half; i++)
            {
                int temp;
                for (int j = i + 1; j < half; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        static int[] SortInAsce(int[] arr, int half, int length)
        {
            for (int i = half; i < length; i++)
            {
                int temp;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
